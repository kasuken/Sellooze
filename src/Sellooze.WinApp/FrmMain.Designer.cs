
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
            this.lblEventsTitle = new System.Windows.Forms.Label();
            this.lblActualRSITitle = new System.Windows.Forms.Label();
            this.lblCloseCountTitle = new System.Windows.Forms.Label();
            this.lblActualRSI = new Sellooze.WinApp.Controls.BlinkingLabel();
            this.lblCloseCount = new Sellooze.WinApp.Controls.BlinkingLabel();
            this.btnStop = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.SetRowSpan(this.lstEvents, 4);
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
            this.tableLayoutPanel1.Controls.Add(this.lstEvents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEventsTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblActualRSITitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCloseCountTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblActualRSI, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCloseCount, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 676);
            this.tableLayoutPanel1.TabIndex = 5;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selloze";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

