using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelleCollege
{
    public partial class loadingScreenForm : Form
    {
        private int _milliseconds_left = 300;
        public loadingScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                --_milliseconds_left;
                if (this._milliseconds_left <= 0)
                {
                    fadeTimer.Stop();
                    this.Close();
                }
            }
        }

        private void loadingScreemForm_Shown(object sender, EventArgs e)
        {
            fadeTimer.Start();
        }
    }
}
