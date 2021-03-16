
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblActualRSI = new System.Windows.Forms.Label();
            this.lblCloseCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(921, 694);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(65, 86);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(573, 304);
            this.lstEvents.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, 458);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // lblActualRSI
            // 
            this.lblActualRSI.AutoSize = true;
            this.lblActualRSI.Location = new System.Drawing.Point(713, 125);
            this.lblActualRSI.Name = "lblActualRSI";
            this.lblActualRSI.Size = new System.Drawing.Size(13, 15);
            this.lblActualRSI.TabIndex = 3;
            this.lblActualRSI.Text = "0";
            // 
            // lblCloseCount
            // 
            this.lblCloseCount.AutoSize = true;
            this.lblCloseCount.ForeColor = System.Drawing.Color.Red;
            this.lblCloseCount.Location = new System.Drawing.Point(687, 191);
            this.lblCloseCount.Name = "lblCloseCount";
            this.lblCloseCount.Size = new System.Drawing.Size(13, 15);
            this.lblCloseCount.TabIndex = 4;
            this.lblCloseCount.Text = "0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblCloseCount);
            this.Controls.Add(this.lblActualRSI);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selloze";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstEvents;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblActualRSI;
        private System.Windows.Forms.Label lblCloseCount;
    }
}

