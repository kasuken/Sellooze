namespace Sellooze.WinApp
{
    using DeviceId;
    using DeviceId.Encoders;
    using DeviceId.Formatters;
    using Selloze.Models;
    using System;
    using System.ComponentModel;
    using System.Security.Cryptography;
    using System.Threading;
    using System.Windows.Forms;

    public partial class FrmMain : Form
    {
        #region private members

        private CancellationTokenSource _cts;

        private CancellationToken _cancellationToken;

        private string _deviceId;

        #endregion

        #region constructors

        public FrmMain()
        {
            this.InitializeComponent();
            this.InitializeBackgroundWorker();

            this.btnStart.EnabledChanged += (obj, args) =>
            {
                this.btnStop.Enabled = !this.btnStart.Enabled;

                this.txtRsiPeriod.Enabled = this.btnStart.Enabled;
                this.txtRsiOverbought.Enabled = this.btnStart.Enabled;
                this.txtRsiOversold.Enabled = this.btnStart.Enabled;
            };

            this.cboEngine.SelectedIndex = 0;
        }

        #endregion

        #region properties

        public Selloze.ConsoleBotEngine.Engine Engine { get; set; }

        #endregion

        #region private methods [Form]
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this._deviceId = new DeviceIdBuilder()
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .UseFormatter(new HashDeviceIdFormatter(() => SHA256.Create(), new Base64UrlByteArrayEncoder()))
                .ToString();

            this.lblDeviceInfo.Text = $"Device ID: {this._deviceId}";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var sellozeEngineParameters = new SellozeEngineParameters();
            sellozeEngineParameters.Symbols.Add("ethereum");

            sellozeEngineParameters.RSI_PERIOD = Convert.ToInt32(txtRsiPeriod.Value);
            sellozeEngineParameters.RSI_OVERBOUGHT = Convert.ToInt32(txtRsiOverbought.Value);
            sellozeEngineParameters.RSI_OVERSOLD = Convert.ToInt32(txtRsiOversold.Value);
            sellozeEngineParameters.TRADE_QUANTITY = Convert.ToDouble(txtTradeQuantity.Text);

            switch (cboEngine.SelectedItem.ToString())
            {
                case "RSI":
                    sellozeEngineParameters.Engine = BotEngine.RSI;
                    break;
                default:
                    sellozeEngineParameters.Engine = BotEngine.OTHER;
                    break;
            }

            this.LogToListbox("Sellooze started...");

            this.backgroundWorker.RunWorkerAsync(sellozeEngineParameters);

            this.btnStart.Enabled = false;            
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this._cts.Cancel();
        }

        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.droTools)
            {
                Clipboard.SetText(this._deviceId);
                System.Media.SystemSounds.Asterisk.Play(); // this could not works, due to Windows settings - use System.Media.SoundPlayer if required
            }
        }

        private void LogToListbox(string content)
        {
            this.lstEvents.SuspendLayout();
            int index = lstEvents.Items.Add(content);
            this.lstEvents.SetSelected(index, true);
            this.lstEvents.ResumeLayout();
        }

        #endregion

        #region private methods [BackgroundWorker]

        private void InitializeBackgroundWorker()
        {
            // set background worker
            this.backgroundWorker.DoWork += this.BackgroundWorker_DoWork;

            this.backgroundWorker.ProgressChanged += this.BackgroundWorker_ProgressChanged;
            this.backgroundWorker.RunWorkerCompleted += this.BackgroundWorker_RunWorkerCompleted;
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;

            // set cancellation token
            this.ResetCancellationToken();
        }

        private void ResetCancellationToken()
        {
            this._cts = new CancellationTokenSource();

            this._cancellationToken = this._cts.Token;
            this._cancellationToken.Register(this.backgroundWorker.CancelAsync);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            this.Engine = new Selloze.ConsoleBotEngine.Engine();
            this.Engine.RaiseReceivedEvent += (progress) => this.backgroundWorker.ReportProgress(0, progress);

            var parameters = (SellozeEngineParameters)e.Argument;

            this.Engine.SellozeEngineParameters = parameters;

            try
            {
                Engine.Run().Wait(_cancellationToken);
            }
            catch (OperationCanceledException oce)
            {
                // nop - logging?
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var progress = (SellozeProgressDto)e.UserState;

            switch (progress.Operation)
            {
                case "log":
                    LogToListbox(progress.Log);
                    break;

                case "actualrsi":
                    lblActualRSI.Text = progress.ActualRSI.ToString();
                    break;

                case "closecount":
                    lblCloseCount.Text = progress.CloseCount.ToString();
                    break;
            }
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;

            LogToListbox("Sellooze stopped");

            this.ResetCancellationToken();
        }


        #endregion       
    }
}
