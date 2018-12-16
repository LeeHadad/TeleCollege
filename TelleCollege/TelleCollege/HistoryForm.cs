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

    public partial class HistoryForm : Form
    {
        private encapsulateCustomer _clone;
        public HistoryForm(encapsulateCustomer clone)
        {
            InitializeComponent();
            ListViewItem item;
            for (int i = 0; i < clone.customer.history_amount; i++)
            {
                item = new ListViewItem((_historyListView.Items.Count + 1).ToString());

                item.SubItems.Add(clone.customer.history[i].representativeName);
                item.SubItems.Add(clone.customer.history[i].representativeId);
                item.SubItems.Add(clone.customer.history[i].date.day.ToString() + "/" + clone.customer.history[i].date.month.ToString() + "/" + clone.customer.history[i].date.year.ToString());
                item.SubItems.Add(clone.customer.history[i].Note);
                _historyListView.Items.Add(item);
            }
            _clone = clone;
        }

        private void _addHistoryButton_Click(object sender, EventArgs e)
        {
            if (_historyListView.Items.Count == 30)
                MessageBox.Show("A customer can only have 30 history records!", "", MessageBoxButtons.OK);
            else
            {
                OriginForm org = this.Owner.Owner as OriginForm;
                if (org == null)
                    org = this.Owner.Owner.Owner as OriginForm;
                Date dt = new Date();
                dt.day = DateTime.Today.Day;
                dt.month = DateTime.Today.Month;
                dt.year = DateTime.Today.Year;
                string[] encapsulateNote = new string[1] { "" };
                (new HistoryInfoForm(1, org.RepName, org.Id, dt, encapsulateNote)).ShowDialog();

                if (encapsulateNote[0] != "")
                {
                    _clone.customer.history[_historyListView.Items.Count].Note = encapsulateNote[0] + '\n';

                    _clone.customer.history[_historyListView.Items.Count].representativeName = org.RepName;
                    _clone.customer.history[_historyListView.Items.Count].representativeId = org.Id;
                    dt.day = DateTime.Today.Day;
                    dt.month = DateTime.Today.Month;
                    dt.year = DateTime.Today.Year;
                    _clone.customer.history[_historyListView.Items.Count].date = dt;
                    _clone.customer.history_amount++;
                    if (cppLinkage.updateDatabase(_clone.customer.id, _clone.customer, (int)Actions.action.no_change, (int)Actions.action.no_change, (int)Actions.action.added))
                    {
                        ListViewItem item = new ListViewItem((_historyListView.Items.Count + 1).ToString());

                        item.SubItems.Add(_clone.customer.history[_historyListView.Items.Count].representativeName);
                        item.SubItems.Add(_clone.customer.history[_historyListView.Items.Count].representativeId);

                        item.SubItems.Add(_clone.customer.history[_historyListView.Items.Count].date.day.ToString() + "/" + _clone.customer.history[_historyListView.Items.Count].date.month.ToString() + "/" + _clone.customer.history[_historyListView.Items.Count].date.year.ToString());
                        item.SubItems.Add(_clone.customer.history[_historyListView.Items.Count].Note);
                        _historyListView.Items.Add(item);
                    }

                    _clone.editHistory = (int)Actions.action.edited;
                }
            }
        }

        private void _historyListView_DoubleClick(object sender, EventArgs e)
        {
            int index = _historyListView.Items.IndexOf(_historyListView.FocusedItem);
            string[] encapsulateNote = new string[1] { _clone.customer.history[index].Note.Substring(0, _clone.customer.history[index].Note.Length - 1) };

            (new HistoryInfoForm(0, _clone.customer.history[index].representativeName, _clone.customer.history[index].representativeId, _clone.customer.history[index].date, encapsulateNote)).ShowDialog();
            if (encapsulateNote[0] != _clone.customer.history[index].Note)
            {
                _clone.customer.history[index].Note = encapsulateNote[0] + "\n";
                if (cppLinkage.updateDatabase(_clone.customer.id, _clone.customer, (int)Actions.action.no_change, (int)Actions.action.no_change, (int)Actions.action.edited, index))
                {
                    _clone.customer.history[index].Note = encapsulateNote[0];
                    _historyListView.FocusedItem.SubItems[4].Text = _clone.customer.history[index].Note;
                }

            }
        }

        private void _removeHistoryButton_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Are you sure you want to remove this history record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (prompt == DialogResult.Yes)
            {
                int index = _historyListView.Items.IndexOf(_historyListView.FocusedItem);
                if (cppLinkage.updateDatabase(_clone.customer.id, _clone.customer, (int)Actions.action.no_change, (int)Actions.action.no_change, (int)Actions.action.deleted, index))
                {
                    Date dt = new Date();
                    _clone.customer.history[index].Note = "";
                    _clone.customer.history[index].representativeName = "";
                    _clone.customer.history[index].representativeId = "";
                    _clone.customer.history[index].date = dt;
                    _clone.customer.history_amount--;
                    _historyListView.Items.RemoveAt(index);
                }
            }
        }
    }
}
