namespace Sellooze.WinApp
{
    using Selloze.Models;
    using System;
    using System.ComponentModel;
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

        public Selloze.ConsoleBotEngine.Engine Engine { get; set; }

        #endregion

        #region private methods [Form]

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var sellozeEngineParameters = new SellozeEngineParameters();
            sellozeEngineParameters.Symbols.Add("ethereum");
            sellozeEngineParameters.RSI_PERIOD = 3;
            sellozeEngineParameters.RSI_OVERBOUGHT = 70;
            sellozeEngineParameters.RSI_OVERSOLD = 30;

            LogToListbox("Sellooze started...");

            backgroundWorker1.RunWorkerAsync(sellozeEngineParameters);

            btnStart.Enabled = false;
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
            backgroundWorker1.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);

            backgroundWorker1.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            // set cancellation token
            this.ResetCancellationToken();
        }

        private void ResetCancellationToken()
        {
            _cts = new CancellationTokenSource();

            _cancellationToken = _cts.Token;
            _cancellationToken.Register(this.backgroundWorker1.CancelAsync);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            Engine = new Selloze.ConsoleBotEngine.Engine();
            Engine.RaiseReceivedEvent += (progress) => backgroundWorker1.ReportProgress(0, progress);

            //// Engine.RaiseReceivedEvent += Engine_RaiseReceivedEvent;

            var parameters = (SellozeEngineParameters)e.Argument;

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

        #region deprecated stuff

        /* DFK - substituted with inline lambda
        private void Engine_RaiseReceivedEvent(SellozeProgressDto progress)
        {
            int p = 0;
            backgroundWorker1.ReportProgress(p, progress);
        }
        */

        #endregion
    }
}
