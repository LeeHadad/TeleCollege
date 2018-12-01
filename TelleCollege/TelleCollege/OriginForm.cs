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
        private LoginForm _loginForm;
        private string _currentTab = "Leads";
        private Color _unclicked_back, _unclicked_over;
        public OriginForm()
        {
            //loadingScreenForm loadingScreen = new loadingScreenForm();
            //loadingScreen.ShowDialog();
            InitializeComponent();
            _unclicked_back = _OpportunityButton.BackColor;
            _unclicked_over = _OpportunityButton.FlatAppearance.MouseOverBackColor;

        }
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                this._welcomeLabel.Text = "Logged in as: " + this._id;
                this._welcomeLabel.Location = new System.Drawing.Point(this.Width / 2 - this._welcomeLabel.Width / 2, this._welcomeLabel.Location.Y);
            }
        }

        private void OriginForm_Shown(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size((int)(Screen.FromHandle(this.Handle).WorkingArea.Width * (this.Width / 1920.0)), (int)(Screen.FromHandle(this.Handle).WorkingArea.Height * (this.Height / 1080.0)));
            this.Location = new System.Drawing.Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2 - this.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Height / 2 - this.Height / 2);
            this.Visible = false;
            this._loginForm = new LoginForm();
            _loginForm.ShowDialog(this);//'this' parameter makes this form the login's owner for future use.

        }

        private void _LeadsButton_Click(object sender, EventArgs e)
        {
            if (_currentTab == "Opportunities")
            {

                this._LeadsButton.BackColor = this._LeadsButton.FlatAppearance.MouseOverBackColor = this._OpportunityButton.BackColor;
                this._OpportunityButton.BackColor = _unclicked_back;
                this._OpportunityButton.FlatAppearance.MouseOverBackColor = _unclicked_over;
                _currentTab = "Leads";

                //////do the panel switch!!!
            }
        }

        private void _OpportunityButton_Click(object sender, EventArgs e)
        {
            if (_currentTab == "Leads")
            {

                this._OpportunityButton.BackColor = this._OpportunityButton.FlatAppearance.MouseOverBackColor = this._LeadsButton.BackColor;
                this._LeadsButton.BackColor = _unclicked_back;
                this._LeadsButton.FlatAppearance.MouseOverBackColor = _unclicked_over;
                _currentTab = "Opportunities";

                //////do the panel switch!!!
            }
        }
    }
}
