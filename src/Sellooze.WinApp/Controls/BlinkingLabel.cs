using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sellooze.WinApp.Controls
{
    public class BlinkingLabel : Label
    {
        private Color _currentColor;

        public BlinkingLabel()
        {
            this.AccentColor = Color.LightYellow;
            this.TextChanged += BlinkingLabel_TextChanged;
        }

        public Color AccentColor { get; set; }

        private void BlinkingLabel_TextChanged(object sender, EventArgs e)
        {
            if (sender == null || DesignMode)
            {
                return;
            }

            this._currentColor = this.BackColor;

            this.BackColor = this.AccentColor;

            var timer = new Timer();
            timer.Interval = 1000;

            timer.Tick += (obj, arg) =>
            {
                this.BackColor = this._currentColor;
                timer.Stop();
            };

            timer.Start();
        }
    }
}
