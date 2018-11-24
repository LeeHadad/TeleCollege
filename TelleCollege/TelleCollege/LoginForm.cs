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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* Origin form will be enabled only after a valid id number has been entered,
             * thus calling this function only when the forms is closed by pressing the window's close button.*/
            if (this.Owner.Enabled == false)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
