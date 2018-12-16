namespace TelleCollege
{
    partial class HistoryInfoForm
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
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topBar1 = new CustomControls_TelleCollege.TopBar();
            this.closeButton1 = new CustomControls_TelleCollege.CloseButton();
            this._outline1 = new System.Windows.Forms.Button();
            this._datePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this._repIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._repNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._characterAmountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this._okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._okButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this._okButton.Location = new System.Drawing.Point(591, 419);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(244, 35);
            this._okButton.TabIndex = 33;
            this._okButton.Text = "Apply";
            this._okButton.UseVisualStyleBackColor = false;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this._cancelButton.Location = new System.Drawing.Point(17, 419);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(244, 35);
            this._cancelButton.TabIndex = 32;
            this._cancelButton.Text = "Discard";
            this._cancelButton.UseVisualStyleBackColor = false;
            // 
            // _noteTextBox
            // 
            this._noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._noteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._noteTextBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this._noteTextBox.Location = new System.Drawing.Point(12, 127);
            this._noteTextBox.MaxLength = 180;
            this._noteTextBox.Multiline = true;
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.Size = new System.Drawing.Size(820, 268);
            this._noteTextBox.TabIndex = 31;
            this._noteTextBox.TextChanged += new System.EventHandler(this._firstNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(396, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Note";
            // 
            // topBar1
            // 
            this.topBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar1.Location = new System.Drawing.Point(3, 5);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(812, 16);
            this.topBar1.TabIndex = 29;
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.FlatAppearance.BorderSize = 0;
            this.closeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton1.Location = new System.Drawing.Point(821, 2);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(21, 23);
            this.closeButton1.TabIndex = 28;
            this.closeButton1.TerminateOnClick = false;
            this.closeButton1.UseVisualStyleBackColor = true;
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
            this._outline1.Location = new System.Drawing.Point(1, 1);
            this._outline1.Name = "_outline1";
            this._outline1.Size = new System.Drawing.Size(843, 467);
            this._outline1.TabIndex = 27;
            this._outline1.UseVisualStyleBackColor = false;
            // 
            // _datePicker
            // 
            this._datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._datePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._datePicker.CalendarTitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this._datePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._datePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._datePicker.CustomFormat = "dd/MM/yyyy";
            this._datePicker.Enabled = false;
            this._datePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._datePicker.Location = new System.Drawing.Point(563, 51);
            this._datePicker.Name = "_datePicker";
            this._datePicker.Size = new System.Drawing.Size(244, 26);
            this._datePicker.TabIndex = 39;
            this._datePicker.TabStop = false;
            this._datePicker.Value = new System.DateTime(2018, 12, 11, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(659, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Date";
            // 
            // _repIdTextBox
            // 
            this._repIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._repIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._repIdTextBox.Enabled = false;
            this._repIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._repIdTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._repIdTextBox.Location = new System.Drawing.Point(299, 50);
            this._repIdTextBox.MaxLength = 9;
            this._repIdTextBox.Name = "_repIdTextBox";
            this._repIdTextBox.Size = new System.Drawing.Size(244, 28);
            this._repIdTextBox.TabIndex = 37;
            this._repIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(341, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Representative Id";
            // 
            // _repNameTextBox
            // 
            this._repNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._repNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._repNameTextBox.Enabled = false;
            this._repNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._repNameTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._repNameTextBox.Location = new System.Drawing.Point(35, 50);
            this._repNameTextBox.MaxLength = 20;
            this._repNameTextBox.Name = "_repNameTextBox";
            this._repNameTextBox.Size = new System.Drawing.Size(244, 28);
            this._repNameTextBox.TabIndex = 35;
            this._repNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(60, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Representative Name";
            // 
            // _characterAmountLabel
            // 
            this._characterAmountLabel.AutoSize = true;
            this._characterAmountLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._characterAmountLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this._characterAmountLabel.Location = new System.Drawing.Point(392, 399);
            this._characterAmountLabel.Name = "_characterAmountLabel";
            this._characterAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._characterAmountLabel.Size = new System.Drawing.Size(16, 17);
            this._characterAmountLabel.TabIndex = 41;
            this._characterAmountLabel.Text = "0";
            this._characterAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(419, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "/180";
            // 
            // HistoryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(847, 468);
            this.Controls.Add(this._characterAmountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._datePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._repIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._repNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._noteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this._outline1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.TextBox _noteTextBox;
        private System.Windows.Forms.Label label1;
        private CustomControls_TelleCollege.TopBar topBar1;
        private CustomControls_TelleCollege.CloseButton closeButton1;
        private System.Windows.Forms.Button _outline1;
        private System.Windows.Forms.DateTimePicker _datePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _repIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _repNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _characterAmountLabel;
        private System.Windows.Forms.Label label4;
    }
}