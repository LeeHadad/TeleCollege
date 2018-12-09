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
            this.ActiveControl = _idTextBox;
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

        private void _bgPanel_Click(object sender, EventArgs e)
        {
            this._idTextBox.Enabled = false;
            this._idTextBox.Enabled = true;
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            if (this._idTextBox.Text.Length > 0)
            {
                this._errorLabel.Visible = false;
                this._errorPictureBox.Visible = false;
                (this.Owner as OriginForm).Id = this._idTextBox.Text;
                this.Owner.Enabled = true;
                this.Owner.Visible = true;
                (this.Owner as OriginForm).importCustomers();
                this.Close();
            }
            else
            {
                this._errorLabel.Visible = true;
                this._errorPictureBox.Visible = true;
            }
        }

        private void _idTextBox_Enter(object sender, EventArgs e)
        {
            this._errorLabel.Visible = false;
            this._errorPictureBox.Visible = false;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size((int)(Screen.FromHandle(this.Handle).WorkingArea.Width * (this.Width / 1920.0)), (int)(Screen.FromHandle(this.Handle).WorkingArea.Height * (this.Height / 1080.0)));
            //this.Location = new System.Drawing.Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2 - this.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Height / 2 - this.Height / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this._idTextBox.Enabled = false;
            this._idTextBox.Enabled = true;
            this._focusVessel.Focus();
        }
    }
}
