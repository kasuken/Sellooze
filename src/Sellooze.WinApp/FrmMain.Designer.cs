
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.btnStop = new System.Windows.Forms.Button();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(840, 694);
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
            this.tableLayoutPanel1.SetRowSpan(this.lstEvents, 8);
            this.lstEvents.Size = new System.Drawing.Size(486, 655);
            this.lstEvents.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 11);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 676);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "RSI";
            // 
            // txtRsiPeriod
            // 
            this.txtRsiPeriod.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiPeriod.Location = new System.Drawing.Point(691, 82);
            this.txtRsiPeriod.Name = "txtRsiPeriod";
            this.txtRsiPeriod.Size = new System.Drawing.Size(100, 39);
            this.txtRsiPeriod.TabIndex = 7;
            this.txtRsiPeriod.Text = "14";
            this.txtRsiPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.lblCloseCountTitle.Size = new System.Drawing.Size(137, 32);
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
            // txtRsiOverbought
            // 
            this.txtRsiOverbought.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiOverbought.Location = new System.Drawing.Point(691, 127);
            this.txtRsiOverbought.Name = "txtRsiOverbought";
            this.txtRsiOverbought.Size = new System.Drawing.Size(100, 39);
            this.txtRsiOverbought.TabIndex = 10;
            this.txtRsiOverbought.Text = "70";
            this.txtRsiOverbought.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRsiOversold
            // 
            this.txtRsiOversold.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRsiOversold.Location = new System.Drawing.Point(691, 172);
            this.txtRsiOversold.Name = "txtRsiOversold";
            this.txtRsiOversold.Size = new System.Drawing.Size(98, 39);
            this.txtRsiOversold.TabIndex = 11;
            this.txtRsiOversold.Text = "30";
            this.txtRsiOversold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(495, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "RSI Period";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(495, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "RSI Overbought";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(495, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
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
            this.cboEngine.Location = new System.Drawing.Point(691, 217);
            this.cboEngine.Name = "cboEngine";
            this.cboEngine.Size = new System.Drawing.Size(121, 40);
            this.cboEngine.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(495, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bot Engine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(495, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Trade Quantity";
            // 
            // txtTradeQuantity
            // 
            this.txtTradeQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTradeQuantity.Location = new System.Drawing.Point(691, 263);
            this.txtTradeQuantity.Name = "txtTradeQuantity";
            this.txtTradeQuantity.Size = new System.Drawing.Size(100, 39);
            this.txtTradeQuantity.TabIndex = 20;
            this.txtTradeQuantity.Text = "0.0005";
            this.txtTradeQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(921, 694);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(12, 705);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(16, 15);
            this.lblDeviceId.TabIndex = 7;
            this.lblDeviceId.Text = "...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnStart);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
    }
}

