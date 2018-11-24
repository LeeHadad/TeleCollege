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
    public partial class OriginForm : Form
    {
        private string _id;
        LoginForm _loginForm;
        public OriginForm()
        {
            InitializeComponent();

        }
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id=value;
            }
        }
        private void OriginForm_Shown(object sender, EventArgs e)
        {
            this._loginForm = new TelleCollege.LoginForm();
            _loginForm.ShowDialog(this);//'this' parameter makes this form the login's owner for future use.
        }

    }
}
