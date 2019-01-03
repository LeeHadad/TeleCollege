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
    public partial class OpportunityInfoForm : Form
    {
        private encapsulateCustomer _clone;
        private string _originalId;
        private int _addOrUpdate;
        public OpportunityInfoForm(encapsulateCustomer clone, int addOrUpdate)
        {
            InitializeComponent();
            object[] courses = new object[Courses.coursesAmount];
            for (int i = 0; i < Courses.coursesAmount; i++)
                courses[i] = "Course " + (i + 1).ToString() + "              " + Courses.coursePrices[i].ToString() + " NIS";
            _coursesCheckedListBox.Items.AddRange(courses);

            object[] discounts = new object[Discounts.discountAmount];
            for (int i = 0; i < Discounts.discountAmount; i++)
            {
                discounts[i] = "Discount " + (i + 1).ToString();
                if (!Discounts.discountPrices[i].Contains("%"))
                {
                    if (Discounts.discountPrices[i].Length < 4)
                        discounts[i] += "             -" + Discounts.discountPrices[i] + " NIS";
                    else
                        discounts[i] += "           -" + Discounts.discountPrices[i] + " NIS";
                }
                else
                    discounts[i] += "                  -" + Discounts.discountPrices[i];
            }
         
            _discountsCheckedListBox.Items.AddRange(discounts);

            if (addOrUpdate == 1)
            {
                this._okButton.Text = "Add";
                this._birthDatePicker.Value = DateTime.Today;
                this._historyButton.Enabled = false;
            }

            if (clone.customer.status == (int)Statuses.status.Lead)
                this._statusComboBox.SelectedIndex = 0;
            else
                this._statusComboBox.SelectedIndex = clone.customer.status - 1;

            this._firstNameTextBox.Text = clone.customer.firstname;
            this._lastNameTextBox.Text = clone.customer.lastname;
            this._idTextBox.Text = clone.customer.id;
            if (clone.customer.birthdate.day != -1)
            {
                this._birthDatePicker.Value = new DateTime(clone.customer.birthdate.year, clone.customer.birthdate.month, clone.customer.birthdate.day);
            }
            else
                this._birthDatePicker.Value = DateTime.Today;
            this._phoneInitialTextBox.Text = clone.customer.phone.Split('-')[0];
            this._phoneContentTextBox.Text = clone.customer.phone.Split('-')[1];
            this._emailTextBox.Text = clone.customer.email;
            if (clone.customer.callLaterDate.day != -1 && clone.customer.callLaterDate.day != 0)
            {

                this._callLaterCheckBox.Checked = true;
                this._callLaterDatePicker.Value = new DateTime(clone.customer.callLaterDate.year, clone.customer.callLaterDate.month, clone.customer.callLaterDate.day);
                this._callLaterTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, clone.customer.callLaterTime.hour, clone.customer.callLaterTime.minutes, 0);
            }
            else
            {
                this._callLaterDatePicker.Value = DateTime.Now;
                this._callLaterTimePicker.Value = DateTime.Now;
            }
            int sum = 0;
            for (int i = 0; i < Courses.coursesAmount; i++)
            {
                this._coursesCheckedListBox.SetItemChecked(i, clone.customer.courses[i]);
                if (clone.customer.courses[i])
                    sum += Courses.coursePrices[i];
            }
            _coursesTextBox.Text = sum.ToString();
            int total_discount = 0;
            for (int i = 0; i < Discounts.discountAmount; i++)
            {
                this._discountsCheckedListBox.SetItemChecked(i, clone.customer.discounts[i]);
                if (clone.customer.discounts[i])
                {
                    if (Discounts.discountPrices[i].Contains("%"))
                        total_discount+= (sum * Int32.Parse(Discounts.discountPrices[i].Split('%')[0]) / 100);
                    else
                        total_discount += Int32.Parse(Discounts.discountPrices[i]);
                }
            }
            _discountsTextBox.Text = (total_discount).ToString();
            _totalPriceTextBox.Text = (sum-total_discount).ToString();

            this._clone = new encapsulateCustomer();
            _clone = clone;
            _originalId = _clone.customer.id;
            _addOrUpdate = addOrUpdate;
        }

        private void _callLaterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                this._callLaterDatePicker.Enabled = this._callLaterTimePicker.Enabled = true;
            else
                this._callLaterDatePicker.Enabled = this._callLaterTimePicker.Enabled = false;
        }






        private void _okButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt;
            int action;
            if (_okButton.Text == "Add")
            {
                prompt = MessageBox.Show("Are you sure you want to add this lead?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                action = (int)Actions.action.added;
            }
            else
            {
                prompt = MessageBox.Show("Are you sure you want to apply these changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                action = (int)Actions.action.edited;
            }
            if (prompt == DialogResult.Yes)
            {
                this._clone.customer.firstname = this._firstNameTextBox.Text;
                _clone.customer.lastname = this._lastNameTextBox.Text;
                _clone.customer.id = this._idTextBox.Text;
                if (_birthDatePicker.Value.CompareTo(DateTime.Today) < 0)
                {
                    _clone.customer.birthdate.day = this._birthDatePicker.Value.Day;
                    _clone.customer.birthdate.month = this._birthDatePicker.Value.Month;
                    _clone.customer.birthdate.year = this._birthDatePicker.Value.Year;
                }
                else
                {
                    _clone.customer.birthdate.day = -1;
                }
                _clone.customer.phone = this._phoneInitialTextBox.Text + "-" + this._phoneContentTextBox.Text;
                _clone.customer.email = this._emailTextBox.Text;
                if (this._callLaterCheckBox.Checked)
                {

                    if (_clone.customer.callLaterDate.day != this._callLaterDatePicker.Value.Day ||
                        _clone.customer.callLaterDate.month != this._callLaterDatePicker.Value.Month ||
                        _clone.customer.callLaterDate.year != this._callLaterDatePicker.Value.Year ||
                        _clone.customer.callLaterTime.hour != this._callLaterTimePicker.Value.Hour ||
                        _clone.customer.callLaterTime.minutes != this._callLaterTimePicker.Value.Minute)
                    {
                        if (_clone.customer.callLaterDate.day == -1)
                            _clone.editCallLater = (int)Actions.action.added;
                        else
                            _clone.editCallLater = (int)Actions.action.edited;

                        _clone.customer.callLaterDate.day = this._callLaterDatePicker.Value.Day;
                        _clone.customer.callLaterDate.month = this._callLaterDatePicker.Value.Month;
                        _clone.customer.callLaterDate.year = this._callLaterDatePicker.Value.Year;
                        _clone.customer.callLaterTime.hour = this._callLaterTimePicker.Value.Hour;
                        _clone.customer.callLaterTime.minutes = this._callLaterTimePicker.Value.Minute;
                    }
                }
                else
                {
                    if (_clone.customer.callLaterDate.day != -1)
                        _clone.editCallLater = (int)Actions.action.deleted;
                    _clone.customer.callLaterDate.day = -1;
                }
                for (int i = 0; i < Courses.coursesAmount; i++)
                {
                    _clone.customer.courses[i] = _coursesCheckedListBox.GetItemCheckState(i) == CheckState.Checked;
                    _clone.customer.discounts[i] = _discountsCheckedListBox.GetItemCheckState(i) == CheckState.Checked;
                }
                _clone.customer.status = this._statusComboBox.SelectedIndex + 1;

                int[] res = new int[6];
                cppLinkage.validateAndUpdate(res, _clone.customer, _originalId, action);

                if (res[5] == 0 && _addOrUpdate==0)
                {
                    MessageBox.Show("A customer with that id already exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                }
                else if (res[0] == 1 && res[1] == 1 && res[2] == 1 && res[3] == 1 && res[4] == 1)
                {
                    this._clone.isChanged = true;
                    this.Close();
                }
                else
                {
                    if (res[0] == 0)
                        _firstNameTextBox.ForeColor = System.Drawing.Color.Gold;
                    if (res[1] == 0)
                        _lastNameTextBox.ForeColor = System.Drawing.Color.Gold;
                    if (res[2] == 0)
                        _idTextBox.ForeColor = System.Drawing.Color.Gold;
                    if (res[3] == 0)
                    {
                        _phoneInitialTextBox.ForeColor = System.Drawing.Color.Gold;
                        _phoneContentTextBox.ForeColor = System.Drawing.Color.Gold;
                    }
                    if (res[4] == 0)
                        _emailTextBox.ForeColor = System.Drawing.Color.Gold;

                }

            }
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void _statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_clone != null)
                _clone.customer.status = this._statusComboBox.SelectedIndex + 1;
        }

        private void _coursesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < Courses.coursesAmount; i++)
            {
                if (_coursesCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                    sum += Courses.coursePrices[i];
            }
            _coursesTextBox.Text = sum.ToString();
            _totalPriceTextBox.Text = (sum - (Int32.Parse(_discountsTextBox.Text))).ToString();
        }
        private void _discountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total_discount = 0;
            for (int i = 0; i < Discounts.discountAmount; i++)
            {
                if (_discountsCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (Discounts.discountPrices[i].Contains("%"))
                        total_discount += (Int32.Parse(_coursesTextBox.Text) * Int32.Parse(Discounts.discountPrices[i].Split('%')[0]) / 100);
                    else
                        total_discount += Int32.Parse(Discounts.discountPrices[i]);
                }
            }
            _discountsTextBox.Text = (total_discount).ToString();
            _totalPriceTextBox.Text = (Int32.Parse(_coursesTextBox.Text) - total_discount).ToString();
        }

        private void _historyButton_Click(object sender, EventArgs e)
        {
            (new HistoryForm(_clone)).ShowDialog(this);
        }
        private void _enterTextBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = System.Drawing.SystemColors.Menu;
        }
    }
}
