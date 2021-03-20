namespace Sellooze.WinApp
{
    using DeviceId;
    using DeviceId.Encoders;
    using DeviceId.Formatters;
    using Sellooze.Models;
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

        #endregion

        #region constructors

        public FrmMain()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            btnStart.EnabledChanged += (obj, args) => btnStop.Enabled = !btnStart.Enabled;
        }

        #endregion

        #region properties

        public Sellooze.BotEngine.Engine Engine { get; set; }

        #endregion

        #region private methods [Form]

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var sellozeEngineParameters = new SelloozeEngineParameters();
            sellozeEngineParameters.Symbols.Add("ethereum");

            sellozeEngineParameters.RSI_PERIOD = Convert.ToInt32(txtRsiPeriod.Text);
            sellozeEngineParameters.RSI_OVERBOUGHT = Convert.ToInt32(txtRsiOverbought.Text);
            sellozeEngineParameters.RSI_OVERSOLD = Convert.ToInt32(txtRsiOversold.Text);
            sellozeEngineParameters.TRADE_QUANTITY = Convert.ToDouble(txtTradeQuantity.Text);

            switch (cboEngine.SelectedItem.ToString())
            {
                case "RSI":
                    sellozeEngineParameters.Engine = BotEngineEnum.RSI;
                    break;
                default:
                    sellozeEngineParameters.Engine = BotEngineEnum.OTHER;
                    break;
            }
            
            LogToListbox("Sellooze started...");

            backgroundWorker.RunWorkerAsync(sellozeEngineParameters);

            btnStart.Enabled = false;
            txtRsiPeriod.Enabled = false;
            txtRsiOverbought.Enabled = false;
            txtRsiOversold.Enabled = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this._cts.Cancel();
        }

        private void LogToListbox(string content)
        {
            lstEvents.SuspendLayout();
            int index = lstEvents.Items.Add(content);
            lstEvents.SetSelected(index, true);
            lstEvents.ResumeLayout();
        }

        #endregion

        #region private methods [BackgroundWorker]

        private void InitializeBackgroundWorker()
        {
            // set background worker
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);

            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            // set cancellation token
            this.ResetCancellationToken();
        }

        private void ResetCancellationToken()
        {
            _cts = new CancellationTokenSource();

            _cancellationToken = _cts.Token;
            _cancellationToken.Register(this.backgroundWorker.CancelAsync);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            Engine = new Sellooze.BotEngine.Engine();
            Engine.RaiseReceivedEvent += (progress) => backgroundWorker.ReportProgress(0, progress);

            var parameters = (SelloozeEngineParameters)e.Argument;

            Engine.SellozeEngineParameters = parameters;

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
            var progress = (SelloozeProgressDto)e.UserState;

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
                case "boughtLog":
                    lblBought.Text = progress.Bought.ToString();
                    break;
                case "soldLog":
                    lblSold.Text = progress.Sold.ToString();
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string deviceId = new DeviceIdBuilder()
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .UseFormatter(new HashDeviceIdFormatter(() => SHA256.Create(), new Base64UrlByteArrayEncoder()))
                .ToString();

            lblDeviceId.Text = deviceId;
        }
    }
}
