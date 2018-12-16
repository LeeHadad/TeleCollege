using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TelleCollege
{
    public partial class OriginForm : Form
    {
        private List<Customer> customers;
        private string _id;
        private string _repName;
        private LoginForm _loginForm;
        private string _currentTab = "Leads";
        private Color _unclicked_back, _unclicked_over;
        private double _maximizeWidthRatio;
        private List<int> _originalLeadsListWidths, _originalOpportunitiesListWidths;
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
            }
        }
        public string RepName
        {
            get
            {
                return this._repName;
            }
            set
            {
                this._repName = value;
                this._welcomeLabel.Text = "Logged in as: " + this._repName + " (" + this._id + ")";
                this._welcomeLabel.Location = new System.Drawing.Point(this.Width / 2 - this._welcomeLabel.Width / 2, this._welcomeLabel.Location.Y);
            }
        }


        private void OriginForm_Shown(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size((int)(Screen.FromHandle(this.Handle).WorkingArea.Width * (this.Width / 1920.0)), (int)(Screen.FromHandle(this.Handle).WorkingArea.Height * (this.Height / 1080.0)));
            this.Location = new System.Drawing.Point(Screen.FromHandle(this.Handle).WorkingArea.Width / 2 - this.Width / 2, Screen.FromHandle(this.Handle).WorkingArea.Height / 2 - this.Height / 2);
            _maximizeWidthRatio = Screen.FromHandle(this.Handle).WorkingArea.Width / (this.Width * 1.0);
            _originalLeadsListWidths = new List<int>();
            foreach (ColumnHeader column in this._leadsListView.Columns)
            {
                _originalLeadsListWidths.Add(column.Width);

            }
            _originalOpportunitiesListWidths = new List<int>();
            foreach (ColumnHeader column in this._opportunitiesListView.Columns)
            {
                _originalOpportunitiesListWidths.Add(column.Width);

            }
            this.Visible = false;
            this._loginForm = new LoginForm();
            _loginForm.ShowDialog(this);//'this' parameter makes this form the login's owner for future use.
        }
        public void importCustomers()
        {
            customers = new List<Customer>();
            int length;
            IntPtr unmanagedArray = cppLinkage.exportCustomers(out length);
            cppLinkage.MarshalUnmananagedArray2StructList(unmanagedArray, length, out customers);
            cppLinkage.freeArray(unmanagedArray);

            int op = 1, ld = 1;
            ListViewItem item;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].status == (int)Statuses.status.Lead)
                    item = new ListViewItem(ld.ToString());
                else
                    item = new ListViewItem(op.ToString());

                item.SubItems.Add(customers[i].firstname + " " + customers[i].lastname);
                item.SubItems.Add(customers[i].id);

                if (customers[i].birthdate.day == -1)
                    item.SubItems.Add("-");
                else
                    item.SubItems.Add(customers[i].birthdate.day.ToString() + "/" + customers[i].birthdate.month.ToString() + "/" + customers[i].birthdate.year.ToString());

                item.SubItems.Add(customers[i].phone);
                item.SubItems.Add(customers[i].email);
                if (customers[i].status != (int)Statuses.status.Lead)
                    item.SubItems.Add(Statuses.statuses[customers[i].status - 1]);
                item.SubItems.Add(customers[i].inserted.day.ToString() + "/" + customers[i].inserted.month.ToString() + "/" + customers[i].inserted.year.ToString());

                if (customers[i].status == (int)Statuses.status.Lead)
                {
                    item.BackColor = System.Drawing.Color.DimGray;
                    this._leadsListView.Items.Add(item);
                    ld++;
                }
                else
                {
                    if (customers[i].status == (int)Statuses.status.In_Progress)
                        item.BackColor = System.Drawing.Color.SteelBlue;
                    else if (customers[i].status == (int)Statuses.status.On_Hold)
                        item.BackColor = System.Drawing.Color.SlateGray;
                    else if (customers[i].status == (int)Statuses.status.Irrelevant)
                        item.BackColor = System.Drawing.Color.Brown;
                    else if (customers[i].status == (int)Statuses.status.Sold)
                        item.BackColor = System.Drawing.Color.DarkSlateGray;

                    this._opportunitiesListView.Items.Add(item);
                    op++;
                }

            }


        }

        private void minimizeButton1_Click(object sender, EventArgs e)
        {
            this._focusVessel.Focus();
        }

        private void maximizeButton1_Click(object sender, EventArgs e)
        {
            this._focusVessel.Focus();

            if (this.WindowState == FormWindowState.Normal)
            {
                this._welcomeLabel.Location = new System.Drawing.Point((int)(this.Size.Width * _maximizeWidthRatio) / 2 - this._welcomeLabel.Width / 2, this._welcomeLabel.Location.Y);
                foreach (ColumnStyle column in this._leadsColumnLayout.ColumnStyles)
                {
                    column.Width = (float)(column.Width * _maximizeWidthRatio);
                }
                foreach (ColumnHeader column in this._leadsListView.Columns)
                {
                    column.Width = (int)(column.Width * _maximizeWidthRatio) + 2;
                }
                foreach (ColumnStyle column in this._opportunitiesColumnLayout.ColumnStyles)
                {
                    column.Width = (float)(column.Width * _maximizeWidthRatio);
                }
                foreach (ColumnHeader column in this._opportunitiesListView.Columns)
                {
                    column.Width = (int)(column.Width * _maximizeWidthRatio) + 2;
                }
            }
            else
            {
                this._welcomeLabel.Location = new System.Drawing.Point((int)(this.Size.Width / _maximizeWidthRatio) / 2 - this._welcomeLabel.Width / 2, this._welcomeLabel.Location.Y);
                int i = 0;
                foreach (ColumnStyle column in this._leadsColumnLayout.ColumnStyles)
                {
                    column.Width = (float)(column.Width * (1.0 / _maximizeWidthRatio));
                }
                foreach (ColumnHeader column in this._leadsListView.Columns)
                {
                    column.Width = _originalLeadsListWidths[i];
                    i++;
                }
                i = 0;
                foreach (ColumnStyle column in this._opportunitiesColumnLayout.ColumnStyles)
                {
                    column.Width = (float)(column.Width * (1.0 / _maximizeWidthRatio));
                }
                foreach (ColumnHeader column in this._opportunitiesListView.Columns)
                {
                    column.Width = _originalOpportunitiesListWidths[i];
                    i++;
                }
            }

        }

        private void OriginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Enabled)
                cppLinkage.freeGlobalList();
        }

        private void CustomerEditWindow(ListView currListView)
        {
            for (int i = 0; i < this.customers.Count; i++)
            {
                if (customers[i].id == currListView.FocusedItem.SubItems[2].Text)
                {
                    encapsulateCustomer clone = new encapsulateCustomer();
                    clone.customer = customers[i];

                    if (_currentTab == "Leads")
                    {
                        LeadInfoForm ld = new LeadInfoForm(clone, 0);
                        ld.ShowDialog(this);


                    }
                    else
                    {
                        OpportunityInfoForm op = new OpportunityInfoForm(clone, 0);
                        op.ShowDialog(this);
                    }

                    if (clone.isChanged)
                    {
                        if (customers[i].id != clone.customer.id)
                        {
                            clone.editCallLater = (int)Actions.action.edited;
                            if (_currentTab == "Opportunities")
                                clone.editHistory = (int)Actions.action.edited;
                        }


                        if (cppLinkage.updateDatabase(customers[i].id, clone.customer, (int)Actions.action.edited, clone.editCallLater, clone.editHistory))
                        {

                            if (customers[i].status == (int)Statuses.status.Lead && clone.customer.status != customers[i].status)
                            {
                                currListView.FocusedItem.Remove();
                                if (currListView.Items.Count != 0)
                                {
                                    for (int j = currListView.FocusedItem.Index; j < currListView.Items.Count; j++)
                                    {
                                        currListView.Items[j].SubItems[0].Text = (j + 1).ToString();
                                    }
                                }
                                customers[i] = clone.customer;
                                ListViewItem item = new ListViewItem((_opportunitiesListView.Items.Count + 1).ToString());

                                item.SubItems.Add(customers[i].firstname + " " + customers[i].lastname);
                                item.SubItems.Add(customers[i].id);

                                if (customers[i].birthdate.day == -1)
                                    item.SubItems.Add("-");
                                else
                                    item.SubItems.Add(customers[i].birthdate.day.ToString() + "/" + customers[i].birthdate.month.ToString() + "/" + customers[i].birthdate.year.ToString());

                                item.SubItems.Add(customers[i].phone);
                                item.SubItems.Add(customers[i].email);
                                if (customers[i].status != (int)Statuses.status.Lead)
                                    item.SubItems.Add(Statuses.statuses[customers[i].status - 1]);
                                item.SubItems.Add(customers[i].inserted.day.ToString() + "/" + customers[i].inserted.month.ToString() + "/" + customers[i].inserted.year.ToString());
                                if (customers[i].status == (int)Statuses.status.In_Progress)
                                    item.BackColor = System.Drawing.Color.SteelBlue;
                                else if (customers[i].status == (int)Statuses.status.On_Hold)
                                    item.BackColor = System.Drawing.Color.SlateGray;
                                else if (customers[i].status == (int)Statuses.status.Irrelevant)
                                    item.BackColor = System.Drawing.Color.Brown;
                                else if (customers[i].status == (int)Statuses.status.Sold)
                                    item.BackColor = System.Drawing.Color.DarkSlateGray;
                                this._opportunitiesListView.Items.Add(item);
                                item.Selected = true;
                                _opportunitiesListView.Select();
                                _opportunitiesListView.Items[_opportunitiesListView.Items.IndexOf(item)].EnsureVisible();

                            }
                            else
                            {
                                customers[i] = clone.customer;
                                currListView.FocusedItem.SubItems[1].Text = customers[i].firstname + " " + customers[i].lastname;
                                currListView.FocusedItem.SubItems[2].Text = customers[i].id;
                                if (customers[i].birthdate.day > 0)
                                    currListView.FocusedItem.SubItems[3].Text = customers[i].birthdate.day.ToString() + "/" + customers[i].birthdate.month.ToString() + "/" + customers[i].birthdate.year.ToString();
                                else
                                    currListView.FocusedItem.SubItems[3].Text = "-";
                                currListView.FocusedItem.SubItems[4].Text = customers[i].phone;
                                currListView.FocusedItem.SubItems[5].Text = customers[i].email;
                                if (_currentTab == "Opportunities")
                                {
                                    currListView.FocusedItem.SubItems[6].Text = Statuses.statuses[customers[i].status - 1];
                                    if (customers[i].status == (int)Statuses.status.In_Progress)
                                        currListView.FocusedItem.BackColor = System.Drawing.Color.SteelBlue;
                                    else if (customers[i].status == (int)Statuses.status.On_Hold)
                                        currListView.FocusedItem.BackColor = System.Drawing.Color.SlateGray;
                                    else if (customers[i].status == (int)Statuses.status.Irrelevant)
                                        currListView.FocusedItem.BackColor = System.Drawing.Color.Brown;
                                    else if (customers[i].status == (int)Statuses.status.Sold)
                                        currListView.FocusedItem.BackColor = System.Drawing.Color.DarkSlateGray;
                                }

                            }

                        }
                    }
                    else if (clone.editHistory == (int)Actions.action.edited)
                        customers[i] = clone.customer;
                    break;
                }
            }
        }
        private void removeCustomer(ListView currListView)
        {
            DialogResult prompt;
            if (_currentTab == "Leads")
                prompt = MessageBox.Show("Are you sure you want to remove this Lead?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            else
                prompt = MessageBox.Show("Are you sure you want to remove this Opportunity?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (prompt == DialogResult.Yes)
            {
                for (int i = 0; i < this.customers.Count; i++)
                {
                    if (customers[i].id == currListView.FocusedItem.SubItems[2].Text)
                    {
                        if (cppLinkage.updateDatabase(customers[i].id, customers[i], (int)Actions.action.deleted))
                        {
                            int index = currListView.FocusedItem.Index;
                            currListView.FocusedItem.Remove();
                            customers.Remove(customers[i]);
                            for (int j = index; j < currListView.Items.Count; j++)
                            {
                                currListView.Items[j].SubItems[0].Text = (j + 1).ToString();
                            }
                        }
                        break;
                    }
                }
            }
        }
        private void _customerListView_DoubleClick(object sender, EventArgs e)
        {
            CustomerEditWindow(sender as ListView);
        }

        private void _addLeadButton_Click(object sender, EventArgs e)
        {
            encapsulateCustomer temp = new encapsulateCustomer();
            temp.customer.courses = new bool[6] { false, false, false, false, false, false };
            temp.customer.history = new History[30];
            LeadInfoForm ld = new LeadInfoForm(temp, 1);

            ld.ShowDialog(this);
            if (temp.isChanged)
            {
                DateTime now = DateTime.Now;
                temp.customer.inserted.day = now.Day;
                temp.customer.inserted.month = now.Month;
                temp.customer.inserted.year = now.Year;

                if (cppLinkage.updateDatabase(temp.customer.id, temp.customer, (int)Actions.action.added))
                {
                    this.customers.Add(temp.customer);
                    ListViewItem item;

                    item = new ListViewItem((_leadsListView.Items.Count + 1).ToString());

                    item.SubItems.Add(temp.customer.firstname + " " + temp.customer.lastname);
                    item.SubItems.Add(temp.customer.id);
                    if (temp.customer.birthdate.day > 0)
                        item.SubItems.Add(temp.customer.birthdate.day.ToString() + "/" + temp.customer.birthdate.month.ToString() + "/" + temp.customer.birthdate.year.ToString());
                    else
                        item.SubItems.Add("-");
                    item.SubItems.Add(temp.customer.phone);
                    item.SubItems.Add(temp.customer.email);
                    item.SubItems.Add(temp.customer.inserted.day.ToString() + "/" + temp.customer.inserted.month.ToString() + "/" + temp.customer.inserted.year.ToString());
                    item.BackColor = System.Drawing.Color.DimGray;
                    _leadsListView.Items.Add(item);

                    _leadsListView.Focus();
                    _leadsListView.Items[_leadsListView.Items.Count - 1].Selected = true;
                    _leadsListView.Items[_leadsListView.Items.IndexOf(item)].EnsureVisible();

                }
            }
        }

        private void _customerListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((sender as ListView).FocusedItem.Bounds.Contains(e.Location))
                {
                    optionsContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentTab == "Leads")
                CustomerEditWindow(_leadsListView);
            else
                CustomerEditWindow(_opportunitiesListView);
        }

        private void _removeCustomerButton_Click(object sender, EventArgs e)
        {
            if (_currentTab == "Leads")
                removeCustomer(_leadsListView);
            else
                removeCustomer(_opportunitiesListView);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentTab == "Leads")
                removeCustomer(_leadsListView);
            else
                removeCustomer(_opportunitiesListView);
        }

        public void _LeadsButton_Click(object sender, EventArgs e)
        {
            this._focusVessel.Focus();
            if (_currentTab == "Opportunities")
            {

                this._LeadsButton.BackColor = this._LeadsButton.FlatAppearance.MouseOverBackColor = this._OpportunityButton.BackColor;
                this._OpportunityButton.BackColor = _unclicked_back;
                this._OpportunityButton.FlatAppearance.MouseOverBackColor = _unclicked_over;

                this._leadsPanel.Visible = this._leadsColumnLayout.Visible = this._addLeadButton.Visible = true;
                this._leadsListView.Select();
                this._opportunitiesPanel.Visible = this._opportunitiesColumnLayout.Visible = false;

                _currentTab = "Leads";
            }
        }
        public void _OpportunityButton_Click(object sender, EventArgs e)
        {
            this._focusVessel.Focus();
            if (_currentTab == "Leads")
            {

                this._OpportunityButton.BackColor = this._OpportunityButton.FlatAppearance.MouseOverBackColor = this._LeadsButton.BackColor;
                this._LeadsButton.BackColor = _unclicked_back;
                this._LeadsButton.FlatAppearance.MouseOverBackColor = _unclicked_over;

                this._opportunitiesPanel.Visible = this._opportunitiesColumnLayout.Visible = true;
                this._opportunitiesListView.Select();
                this._leadsPanel.Visible = this._leadsColumnLayout.Visible = this._addLeadButton.Visible = false;

                _currentTab = "Opportunities";
            }
        }
    }
}
