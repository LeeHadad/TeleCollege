namespace TelleCollege
{
    partial class LeadInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._outline1 = new System.Windows.Forms.Button();
            this.closeButton1 = new CustomControls_TelleCollege.CloseButton();
            this.topBar1 = new CustomControls_TelleCollege.TopBar();
            this.label1 = new System.Windows.Forms.Label();
            this._firstNameTextBox = new System.Windows.Forms.TextBox();
            this._focusVessel = new System.Windows.Forms.Button();
            this._lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._phoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._callLaterDatePicker = new System.Windows.Forms.DateTimePicker();
            this._callLaterTimePicker = new System.Windows.Forms.DateTimePicker();
            this._callLaterCheckBox = new System.Windows.Forms.CheckBox();
            this._emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._opportunityChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _outline1
            // 
            this._outline1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outline1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._outline1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._outline1.Enabled = false;
            this._outline1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._outline1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._outline1.Location = new System.Drawing.Point(0, 0);
            this._outline1.Name = "_outline1";
            this._outline1.Size = new System.Drawing.Size(820, 244);
            this._outline1.TabIndex = 4;
            this._outline1.UseVisualStyleBackColor = false;
            this._outline1.Click += new System.EventHandler(this._enterTextBox_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.FlatAppearance.BorderSize = 0;
            this.closeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton1.Location = new System.Drawing.Point(797, 1);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(21, 23);
            this.closeButton1.TabIndex = 5;
            this.closeButton1.TerminateOnClick = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // topBar1
            // 
            this.topBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar1.Location = new System.Drawing.Point(2, 4);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(791, 16);
            this.topBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // _firstNameTextBox
            // 
            this._firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._firstNameTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._firstNameTextBox.Location = new System.Drawing.Point(24, 44);
            this._firstNameTextBox.MaxLength = 20;
            this._firstNameTextBox.Name = "_firstNameTextBox";
            this._firstNameTextBox.Size = new System.Drawing.Size(244, 28);
            this._firstNameTextBox.TabIndex = 8;
            this._firstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._firstNameTextBox.Click += new System.EventHandler(this._enterTextBox_Click);
            // 
            // _focusVessel
            // 
            this._focusVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._focusVessel.Font = new System.Drawing.Font("Century Gothic", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._focusVessel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._focusVessel.Location = new System.Drawing.Point(5, 4);
            this._focusVessel.Name = "_focusVessel";
            this._focusVessel.Size = new System.Drawing.Size(27, 26);
            this._focusVessel.TabIndex = 13;
            this._focusVessel.Text = "__";
            this._focusVessel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._focusVessel.UseVisualStyleBackColor = true;
            // 
            // _lastNameTextBox
            // 
            this._lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._lastNameTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._lastNameTextBox.Location = new System.Drawing.Point(288, 44);
            this._lastNameTextBox.MaxLength = 20;
            this._lastNameTextBox.Name = "_lastNameTextBox";
            this._lastNameTextBox.Size = new System.Drawing.Size(244, 28);
            this._lastNameTextBox.TabIndex = 15;
            this._lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._lastNameTextBox.Click += new System.EventHandler(this._enterTextBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(360, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name";
            // 
            // _idTextBox
            // 
            this._idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._idTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._idTextBox.Location = new System.Drawing.Point(552, 44);
            this._idTextBox.MaxLength = 9;
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(244, 28);
            this._idTextBox.TabIndex = 17;
            this._idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._idTextBox.Click += new System.EventHandler(this._enterTextBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(661, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id";
            // 
            // _phoneTextBox
            // 
            this._phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._phoneTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._phoneTextBox.Location = new System.Drawing.Point(288, 121);
            this._phoneTextBox.MaxLength = 11;
            this._phoneTextBox.Name = "_phoneTextBox";
            this._phoneTextBox.Size = new System.Drawing.Size(244, 28);
            this._phoneTextBox.TabIndex = 21;
            this._phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._phoneTextBox.Click += new System.EventHandler(this._enterTextBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(344, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(100, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Birth Date";
            // 
            // _birthDatePicker
            // 
            this._birthDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._birthDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._birthDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._birthDatePicker.CalendarTitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this._birthDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._birthDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._birthDatePicker.CustomFormat = "dd/MM/yyyy";
            this._birthDatePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._birthDatePicker.Location = new System.Drawing.Point(24, 122);
            this._birthDatePicker.Name = "_birthDatePicker";
            this._birthDatePicker.Size = new System.Drawing.Size(244, 26);
            this._birthDatePicker.TabIndex = 24;
            this._birthDatePicker.TabStop = false;
            this._birthDatePicker.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this._cancelButton.Location = new System.Drawing.Point(552, 144);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(244, 35);
            this._cancelButton.TabIndex = 25;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = false;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this._okButton.Location = new System.Drawing.Point(552, 193);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(244, 35);
            this._okButton.TabIndex = 26;
            this._okButton.Text = "Apply";
            this._okButton.UseVisualStyleBackColor = false;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SkyBlue;
            this.label7.Location = new System.Drawing.Point(101, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Call Later";
            // 
            // _callLaterDatePicker
            // 
            this._callLaterDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterDatePicker.CustomFormat = "";
            this._callLaterDatePicker.Enabled = false;
            this._callLaterDatePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._callLaterDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._callLaterDatePicker.Location = new System.Drawing.Point(24, 198);
            this._callLaterDatePicker.Name = "_callLaterDatePicker";
            this._callLaterDatePicker.Size = new System.Drawing.Size(151, 26);
            this._callLaterDatePicker.TabIndex = 30;
            this._callLaterDatePicker.Value = new System.DateTime(2018, 12, 12, 21, 47, 0, 0);
            // 
            // _callLaterTimePicker
            // 
            this._callLaterTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._callLaterTimePicker.CustomFormat = "HH:mm";
            this._callLaterTimePicker.Enabled = false;
            this._callLaterTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._callLaterTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._callLaterTimePicker.Location = new System.Drawing.Point(183, 198);
            this._callLaterTimePicker.Name = "_callLaterTimePicker";
            this._callLaterTimePicker.ShowUpDown = true;
            this._callLaterTimePicker.Size = new System.Drawing.Size(85, 26);
            this._callLaterTimePicker.TabIndex = 31;
            this._callLaterTimePicker.Value = new System.DateTime(2018, 12, 11, 21, 52, 0, 0);
            // 
            // _callLaterCheckBox
            // 
            this._callLaterCheckBox.AutoSize = true;
            this._callLaterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._callLaterCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this._callLaterCheckBox.FlatAppearance.BorderSize = 2;
            this._callLaterCheckBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._callLaterCheckBox.Location = new System.Drawing.Point(85, 176);
            this._callLaterCheckBox.Name = "_callLaterCheckBox";
            this._callLaterCheckBox.Size = new System.Drawing.Size(18, 17);
            this._callLaterCheckBox.TabIndex = 32;
            this._callLaterCheckBox.UseVisualStyleBackColor = true;
            this._callLaterCheckBox.CheckedChanged += new System.EventHandler(this._callLaterCheckBox_CheckedChanged);
            // 
            // _emailTextBox
            // 
            this._emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._emailTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._emailTextBox.Location = new System.Drawing.Point(288, 198);
            this._emailTextBox.MaxLength = 30;
            this._emailTextBox.Name = "_emailTextBox";
            this._emailTextBox.Size = new System.Drawing.Size(244, 28);
            this._emailTextBox.TabIndex = 48;
            this._emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._emailTextBox.Click += new System.EventHandler(this._enterTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(384, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email";
            // 
            // _opportunityChangeButton
            // 
            this._opportunityChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._opportunityChangeButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._opportunityChangeButton.ForeColor = System.Drawing.Color.SkyBlue;
            this._opportunityChangeButton.Location = new System.Drawing.Point(552, 82);
            this._opportunityChangeButton.Name = "_opportunityChangeButton";
            this._opportunityChangeButton.Size = new System.Drawing.Size(244, 49);
            this._opportunityChangeButton.TabIndex = 49;
            this._opportunityChangeButton.Text = "Opportunity";
            this._opportunityChangeButton.UseVisualStyleBackColor = true;
            this._opportunityChangeButton.Click += new System.EventHandler(this._opportunityChangeButton_Click);
            // 
            // LeadInfoForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(820, 246);
            this.Controls.Add(this._opportunityChangeButton);
            this.Controls.Add(this._emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._callLaterCheckBox);
            this.Controls.Add(this._callLaterTimePicker);
            this.Controls.Add(this._callLaterDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._birthDatePicker);
            this.Controls.Add(this._phoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this._outline1);
            this.Controls.Add(this._focusVessel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LeadInfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeadInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _outline1;
        private CustomControls_TelleCollege.CloseButton closeButton1;
        private CustomControls_TelleCollege.TopBar topBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _firstNameTextBox;
        private System.Windows.Forms.Button _focusVessel;
        private System.Windows.Forms.TextBox _lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _idTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _phoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker _birthDatePicker;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker _callLaterDatePicker;
        private System.Windows.Forms.DateTimePicker _callLaterTimePicker;
        private System.Windows.Forms.CheckBox _callLaterCheckBox;
        private System.Windows.Forms.TextBox _emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _opportunityChangeButton;
    }
}