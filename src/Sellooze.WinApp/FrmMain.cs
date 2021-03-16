using Selloze.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sellooze.WinApp
{
    public partial class FrmMain : Form
    {
        public Selloze.ConsoleBotEngine.Engine Engine { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var sellozeEngineParameters = new SellozeEngineParameters();
            sellozeEngineParameters.Symbols.Add("ethereum");
            sellozeEngineParameters.RSI_PERIOD = 3;
            sellozeEngineParameters.RSI_OVERBOUGHT = 70;
            sellozeEngineParameters.RSI_OVERSOLD = 30;

            backgroundWorker1.RunWorkerAsync(sellozeEngineParameters);
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);

            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void Engine_RaiseReceivedEvent(SellozeProgressDto progress)
        {
            int p = 0;
            backgroundWorker1.ReportProgress(p, progress);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var progress = (SellozeProgressDto)e.UserState;

            switch (progress.Operation)
            {
                case "log":
                    lstEvents.Items.Add(progress.Log);
                    lstEvents.SelectedItem = lstEvents.Items[lstEvents.Items.Count - 1];
                    break;
                case "actualrsi":
                    lblActualRSI.Text = progress.ActualRSI.ToString();
                    break;

                case "closecount":
                    lblCloseCount.Text = progress.CloseCount.ToString();
                    break;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            Engine = new Selloze.ConsoleBotEngine.Engine();
            Engine.RaiseReceivedEvent += Engine_RaiseReceivedEvent;

            var parameters = (SellozeEngineParameters)e.Argument;

            Engine.SellozeEngineParameters = parameters;
            Engine.Run().Wait();
        }
    }
}
