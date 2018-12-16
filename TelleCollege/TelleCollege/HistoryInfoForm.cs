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
    public partial class HistoryInfoForm : Form
    {
        private string[] _note;
        public HistoryInfoForm(int addOrUpdate,string repName,string repId,Date dt,string[] note)
        {
            InitializeComponent();
            if (addOrUpdate == 1)
                _okButton.Text = "Add";
            _note = note;
            this._noteTextBox.Text = _note[0];
            this._repNameTextBox.Text = repName;
            this._repIdTextBox.Text = repId;
            this._datePicker.Value = new DateTime(dt.year, dt.month, dt.day);
        }

        private void _firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this._characterAmountLabel.Text = this._noteTextBox.Text.Length.ToString() ;
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt;
            if (_okButton.Text == "Add")
                prompt = MessageBox.Show("Are you sure you want to add this Note?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            else
                prompt = MessageBox.Show("Are you sure you want to apply these changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (prompt == DialogResult.Yes)
            {
                this._note[0] = _noteTextBox.Text;
                this.Close();
            }
        }
    }
}
