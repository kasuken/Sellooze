
using System.ComponentModel;

namespace Sellooze.WinApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRsiPeriod = new System.Windows.Forms.TextBox();
            this.lblEventsTitle = new System.Windows.Forms.Label();
            this.lblActualRSITitle = new System.Windows.Forms.Label();
            this.lblCloseCountTitle = new System.Windows.Forms.Label();
            this.lblActualRSI = new Sellooze.WinApp.Controls.BlinkingLabel();
            this.lblCloseCount = new Sellooze.WinApp.Controls.BlinkingLabel();
            this.txtRsiOverbought = new System.Windows.Forms.TextBox();
            this.txtRsiOversold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEngine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTradeQuantity = new System.Windows.Forms.TextBox();
            this.lblBought = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(960, 925);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 20;
            this.lstEvents.Location = new System.Drawing.Point(3, 24);
            this.lstEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEvents.Name = "lstEvents";
            this.tableLayoutPanel1.SetRowSpan(this.lstEvents, 9);
            this.lstEvents.Size = new System.Drawing.Size(556, 872);
            this.lstEvents.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtRsiPeriod, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstEvents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEventsTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblActualRSITitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCloseCountTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblActualRSI, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCloseCount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRsiOverbought, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtRsiOversold, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cboEngine, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTradeQuantity, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBought, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblSold, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 901);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(565, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 41);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 900);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "RSI";
            // 
            // txtRsiPeriod
            // 
            this.txtRsiPeriod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiPeriod.Location = new System.Drawing.Point(790, 106);
            this.txtRsiPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRsiPeriod.Name = "txtRsiPeriod";
            this.txtRsiPeriod.Size = new System.Drawing.Size(114, 47);
            this.txtRsiPeriod.TabIndex = 7;
            this.txtRsiPeriod.Text = "14";
            this.txtRsiPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEventsTitle
            // 
            this.lblEventsTitle.AutoSize = true;
            this.lblEventsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblEventsTitle.Name = "lblEventsTitle";
            this.lblEventsTitle.Size = new System.Drawing.Size(51, 20);
            this.lblEventsTitle.TabIndex = 5;
            this.lblEventsTitle.Text = "Events";
            // 
            // lblActualRSITitle
            // 
            this.lblActualRSITitle.AutoSize = true;
            this.lblActualRSITitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualRSITitle.Location = new System.Drawing.Point(565, 20);
            this.lblActualRSITitle.Name = "lblActualRSITitle";
            this.lblActualRSITitle.Size = new System.Drawing.Size(150, 41);
            this.lblActualRSITitle.TabIndex = 6;
            this.lblActualRSITitle.Text = "Actual RSI";
            // 
            // lblCloseCountTitle
            // 
            this.lblCloseCountTitle.AutoSize = true;
            this.lblCloseCountTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCloseCountTitle.Location = new System.Drawing.Point(565, 61);
            this.lblCloseCountTitle.Name = "lblCloseCountTitle";
            this.lblCloseCountTitle.Size = new System.Drawing.Size(172, 41);
            this.lblCloseCountTitle.TabIndex = 7;
            this.lblCloseCountTitle.Text = "CloseCount";
            // 
            // lblActualRSI
            // 
            this.lblActualRSI.AccentColor = System.Drawing.Color.LightYellow;
            this.lblActualRSI.AutoSize = true;
            this.lblActualRSI.BackColor = System.Drawing.SystemColors.Control;
            this.lblActualRSI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActualRSI.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualRSI.Location = new System.Drawing.Point(790, 20);
            this.lblActualRSI.Name = "lblActualRSI";
            this.lblActualRSI.Size = new System.Drawing.Size(332, 41);
            this.lblActualRSI.TabIndex = 8;
            this.lblActualRSI.Text = "0.0";
            // 
            // lblCloseCount
            // 
            this.lblCloseCount.AccentColor = System.Drawing.Color.LightYellow;
            this.lblCloseCount.AutoSize = true;
            this.lblCloseCount.BackColor = System.Drawing.SystemColors.Control;
            this.lblCloseCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCloseCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCloseCount.Location = new System.Drawing.Point(790, 61);
            this.lblCloseCount.Name = "lblCloseCount";
            this.lblCloseCount.Size = new System.Drawing.Size(332, 41);
            this.lblCloseCount.TabIndex = 9;
            this.lblCloseCount.Text = "0";
            // 
            // txtRsiOverbought
            // 
            this.txtRsiOverbought.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiOverbought.Location = new System.Drawing.Point(790, 161);
            this.txtRsiOverbought.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRsiOverbought.Name = "txtRsiOverbought";
            this.txtRsiOverbought.Size = new System.Drawing.Size(114, 47);
            this.txtRsiOverbought.TabIndex = 10;
            this.txtRsiOverbought.Text = "70";
            this.txtRsiOverbought.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRsiOversold
            // 
            this.txtRsiOversold.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiOversold.Location = new System.Drawing.Point(790, 243);
            this.txtRsiOversold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRsiOversold.Name = "txtRsiOversold";
            this.txtRsiOversold.Size = new System.Drawing.Size(111, 47);
            this.txtRsiOversold.TabIndex = 11;
            this.txtRsiOversold.Text = "30";
            this.txtRsiOversold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(565, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 41);
            this.label2.TabIndex = 14;
            this.label2.Text = "RSI Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(565, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 82);
            this.label3.TabIndex = 15;
            this.label3.Text = "RSI Overbought";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(565, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 41);
            this.label4.TabIndex = 16;
            this.label4.Text = "RSI Oversold";
            // 
            // cboEngine
            // 
            this.cboEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEngine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEngine.FormattingEnabled = true;
            this.cboEngine.Items.AddRange(new object[] {
            "RSI",
            "Other"});
            this.cboEngine.Location = new System.Drawing.Point(790, 298);
            this.cboEngine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEngine.Name = "cboEngine";
            this.cboEngine.Size = new System.Drawing.Size(138, 49);
            this.cboEngine.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(565, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 41);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bot Engine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(565, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 41);
            this.label6.TabIndex = 19;
            this.label6.Text = "Trade Quantity";
            // 
            // txtTradeQuantity
            // 
            this.txtTradeQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTradeQuantity.Location = new System.Drawing.Point(790, 355);
            this.txtTradeQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTradeQuantity.Name = "txtTradeQuantity";
            this.txtTradeQuantity.Size = new System.Drawing.Size(114, 47);
            this.txtTradeQuantity.TabIndex = 20;
            this.txtTradeQuantity.Text = "0.0005";
            this.txtTradeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBought
            // 
            this.lblBought.AutoSize = true;
            this.lblBought.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblBought.Location = new System.Drawing.Point(790, 406);
            this.lblBought.Name = "lblBought";
            this.lblBought.Size = new System.Drawing.Size(98, 54);
            this.lblBought.TabIndex = 21;
            this.lblBought.Text = "0.00";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSold.ForeColor = System.Drawing.Color.Red;
            this.lblSold.Location = new System.Drawing.Point(790, 460);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(98, 54);
            this.lblSold.TabIndex = 22;
            this.lblSold.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(565, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 41);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bought";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(1053, 925);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 31);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(14, 940);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(18, 20);
            this.lblDeviceId.TabIndex = 7;
            this.lblDeviceId.Text = "...";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1152, 972);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selloze";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstEvents;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEventsTitle;
        private System.Windows.Forms.Label lblActualRSITitle;
        private System.Windows.Forms.Label lblCloseCountTitle;
        private Controls.BlinkingLabel lblActualRSI;
        private Controls.BlinkingLabel lblCloseCount;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtRsiPeriod;
        private System.Windows.Forms.TextBox txtRsiOverbought;
        private System.Windows.Forms.TextBox txtRsiOversold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEngine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTradeQuantity;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Label lblBought;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

