
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblEventsTitle = new System.Windows.Forms.Label();
            this.lblActualRSITitle = new System.Windows.Forms.Label();
            this.lblCloseCountTitle = new System.Windows.Forms.Label();
            this.lblActualRSI = new Sellooze.WinApp.Controls.BlinkingLabel();
            this.lblCloseCount = new Sellooze.WinApp.Controls.BlinkingLabel();
            this.lblRsiPeriod = new System.Windows.Forms.Label();
            this.lblRsiOverbought = new System.Windows.Forms.Label();
            this.lblRsiOversold = new System.Windows.Forms.Label();
            this.cboEngine = new System.Windows.Forms.ComboBox();
            this.lblBotEngine = new System.Windows.Forms.Label();
            this.lblTradeQuantity = new System.Windows.Forms.Label();
            this.txtTradeQuantity = new System.Windows.Forms.TextBox();
            this.txtRsiPeriod = new System.Windows.Forms.NumericUpDown();
            this.txtRsiOverbought = new System.Windows.Forms.NumericUpDown();
            this.txtRsiOversold = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblDeviceInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.droTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRsiPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRsiOverbought)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRsiOversold)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(840, 668);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(3, 18);
            this.lstEvents.Name = "lstEvents";
            this.tableLayoutPanel.SetRowSpan(this.lstEvents, 8);
            this.lstEvents.Size = new System.Drawing.Size(486, 629);
            this.lstEvents.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.lstEvents, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblEventsTitle, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblActualRSITitle, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCloseCountTitle, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblActualRSI, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCloseCount, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.lblRsiPeriod, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblRsiOverbought, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblRsiOversold, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.cboEngine, 2, 7);
            this.tableLayoutPanel.Controls.Add(this.lblBotEngine, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lblTradeQuantity, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.txtTradeQuantity, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.txtRsiPeriod, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.txtRsiOverbought, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.txtRsiOversold, 2, 6);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(984, 650);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // lblEventsTitle
            // 
            this.lblEventsTitle.AutoSize = true;
            this.lblEventsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblEventsTitle.Name = "lblEventsTitle";
            this.lblEventsTitle.Size = new System.Drawing.Size(41, 15);
            this.lblEventsTitle.TabIndex = 5;
            this.lblEventsTitle.Text = "Events";
            // 
            // lblActualRSITitle
            // 
            this.lblActualRSITitle.AutoSize = true;
            this.lblActualRSITitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualRSITitle.Location = new System.Drawing.Point(495, 15);
            this.lblActualRSITitle.Name = "lblActualRSITitle";
            this.lblActualRSITitle.Size = new System.Drawing.Size(120, 32);
            this.lblActualRSITitle.TabIndex = 6;
            this.lblActualRSITitle.Text = "Actual RSI";
            // 
            // lblCloseCountTitle
            // 
            this.lblCloseCountTitle.AutoSize = true;
            this.lblCloseCountTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCloseCountTitle.Location = new System.Drawing.Point(495, 47);
            this.lblCloseCountTitle.Name = "lblCloseCountTitle";
            this.lblCloseCountTitle.Size = new System.Drawing.Size(144, 32);
            this.lblCloseCountTitle.TabIndex = 7;
            this.lblCloseCountTitle.Text = "Close Count";
            // 
            // lblActualRSI
            // 
            this.lblActualRSI.AccentColor = System.Drawing.Color.LightYellow;
            this.lblActualRSI.AutoSize = true;
            this.lblActualRSI.BackColor = System.Drawing.SystemColors.Control;
            this.lblActualRSI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActualRSI.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualRSI.Location = new System.Drawing.Point(691, 15);
            this.lblActualRSI.Name = "lblActualRSI";
            this.lblActualRSI.Size = new System.Drawing.Size(290, 32);
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
            this.lblCloseCount.Location = new System.Drawing.Point(691, 47);
            this.lblCloseCount.Name = "lblCloseCount";
            this.lblCloseCount.Size = new System.Drawing.Size(290, 32);
            this.lblCloseCount.TabIndex = 9;
            this.lblCloseCount.Text = "0";
            // 
            // lblRsiPeriod
            // 
            this.lblRsiPeriod.AutoSize = true;
            this.lblRsiPeriod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRsiPeriod.Location = new System.Drawing.Point(495, 279);
            this.lblRsiPeriod.Name = "lblRsiPeriod";
            this.lblRsiPeriod.Size = new System.Drawing.Size(121, 32);
            this.lblRsiPeriod.TabIndex = 14;
            this.lblRsiPeriod.Text = "RSI Period";
            // 
            // lblRsiOverbought
            // 
            this.lblRsiOverbought.AutoSize = true;
            this.lblRsiOverbought.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRsiOverbought.Location = new System.Drawing.Point(495, 324);
            this.lblRsiOverbought.Name = "lblRsiOverbought";
            this.lblRsiOverbought.Size = new System.Drawing.Size(183, 32);
            this.lblRsiOverbought.TabIndex = 15;
            this.lblRsiOverbought.Text = "RSI Overbought";
            // 
            // lblRsiOversold
            // 
            this.lblRsiOversold.AutoSize = true;
            this.lblRsiOversold.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRsiOversold.Location = new System.Drawing.Point(495, 369);
            this.lblRsiOversold.Name = "lblRsiOversold";
            this.lblRsiOversold.Size = new System.Drawing.Size(149, 32);
            this.lblRsiOversold.TabIndex = 16;
            this.lblRsiOversold.Text = "RSI Oversold";
            // 
            // cboEngine
            // 
            this.cboEngine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEngine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEngine.FormattingEnabled = true;
            this.cboEngine.Items.AddRange(new object[] {
            "RSI",
            "Other"});
            this.cboEngine.Location = new System.Drawing.Point(691, 417);
            this.cboEngine.Name = "cboEngine";
            this.cboEngine.Size = new System.Drawing.Size(290, 40);
            this.cboEngine.TabIndex = 17;
            // 
            // lblBotEngine
            // 
            this.lblBotEngine.AutoSize = true;
            this.lblBotEngine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBotEngine.Location = new System.Drawing.Point(495, 414);
            this.lblBotEngine.Name = "lblBotEngine";
            this.lblBotEngine.Size = new System.Drawing.Size(130, 32);
            this.lblBotEngine.TabIndex = 18;
            this.lblBotEngine.Text = "Bot Engine";
            // 
            // lblTradeQuantity
            // 
            this.lblTradeQuantity.AutoSize = true;
            this.lblTradeQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTradeQuantity.Location = new System.Drawing.Point(495, 460);
            this.lblTradeQuantity.Name = "lblTradeQuantity";
            this.lblTradeQuantity.Size = new System.Drawing.Size(171, 32);
            this.lblTradeQuantity.TabIndex = 19;
            this.lblTradeQuantity.Text = "Trade Quantity";
            // 
            // txtTradeQuantity
            // 
            this.txtTradeQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTradeQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTradeQuantity.Location = new System.Drawing.Point(691, 463);
            this.txtTradeQuantity.Name = "txtTradeQuantity";
            this.txtTradeQuantity.Size = new System.Drawing.Size(290, 39);
            this.txtTradeQuantity.TabIndex = 20;
            this.txtTradeQuantity.Text = "0.0005";
            this.txtTradeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRsiPeriod
            // 
            this.txtRsiPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRsiPeriod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiPeriod.Location = new System.Drawing.Point(691, 282);
            this.txtRsiPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRsiPeriod.Name = "txtRsiPeriod";
            this.txtRsiPeriod.Size = new System.Drawing.Size(290, 39);
            this.txtRsiPeriod.TabIndex = 21;
            this.txtRsiPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRsiPeriod.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // txtRsiOverbought
            // 
            this.txtRsiOverbought.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRsiOverbought.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiOverbought.Location = new System.Drawing.Point(691, 327);
            this.txtRsiOverbought.Name = "txtRsiOverbought";
            this.txtRsiOverbought.Size = new System.Drawing.Size(290, 39);
            this.txtRsiOverbought.TabIndex = 22;
            this.txtRsiOverbought.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRsiOverbought.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // txtRsiOversold
            // 
            this.txtRsiOversold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRsiOversold.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiOversold.Location = new System.Drawing.Point(691, 372);
            this.txtRsiOversold.Name = "txtRsiOversold";
            this.txtRsiOversold.Size = new System.Drawing.Size(290, 39);
            this.txtRsiOversold.TabIndex = 23;
            this.txtRsiOversold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRsiOversold.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(921, 668);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDeviceInfo,
            this.droTools});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip_ItemClicked);
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(16, 17);
            this.lblDeviceInfo.Text = "...";
            // 
            // droTools
            // 
            this.droTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.droTools.Image = ((System.Drawing.Image)(resources.GetObject("droTools.Image")));
            this.droTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.droTools.Name = "droTools";
            this.droTools.ShowDropDownArrow = false;
            this.droTools.Size = new System.Drawing.Size(20, 20);
            this.droTools.ToolTipText = "Copy";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selloze";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRsiPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRsiOverbought)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRsiOversold)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstEvents;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblEventsTitle;
        private System.Windows.Forms.Label lblActualRSITitle;
        private System.Windows.Forms.Label lblCloseCountTitle;
        private Controls.BlinkingLabel lblActualRSI;
        private Controls.BlinkingLabel lblCloseCount;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblRsiPeriod;
        private System.Windows.Forms.Label lblRsiOverbought;
        private System.Windows.Forms.Label lblRsiOversold;
        private System.Windows.Forms.ComboBox cboEngine;
        private System.Windows.Forms.Label lblBotEngine;
        private System.Windows.Forms.Label lblTradeQuantity;
        private System.Windows.Forms.TextBox txtTradeQuantity;
        private System.Windows.Forms.NumericUpDown txtRsiPeriod;
        private System.Windows.Forms.NumericUpDown txtRsiOverbought;
        private System.Windows.Forms.NumericUpDown txtRsiOversold;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblDeviceInfo;
        private System.Windows.Forms.ToolStripDropDownButton droTools;
    }
}

