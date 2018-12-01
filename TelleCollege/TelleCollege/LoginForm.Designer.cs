namespace TelleCollege
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this._loginButton = new System.Windows.Forms.Button();
            this._errorLabel = new System.Windows.Forms.Label();
            this._focusVessel = new System.Windows.Forms.Button();
            this._idLabel = new System.Windows.Forms.Label();
            this._idTextBox = new System.Windows.Forms.TextBox();
            this._closeButton = new CustomControls_TelleCollege.CloseButton();
            this._errorPictureBox = new System.Windows.Forms.PictureBox();
            this._outlineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._errorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _loginButton
            // 
            this._loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this._loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this._loginButton.Location = new System.Drawing.Point(40, 125);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(437, 38);
            this._loginButton.TabIndex = 0;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = false;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // _errorLabel
            // 
            this._errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._errorLabel.AutoSize = true;
            this._errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._errorLabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this._errorLabel.Location = new System.Drawing.Point(193, 98);
            this._errorLabel.Name = "_errorLabel";
            this._errorLabel.Size = new System.Drawing.Size(145, 18);
            this._errorLabel.TabIndex = 4;
            this._errorLabel.Text = "Please Enter Your ID";
            this._errorLabel.Visible = false;
            // 
            // _focusVessel
            // 
            this._focusVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._focusVessel.Font = new System.Drawing.Font("Century Gothic", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._focusVessel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._focusVessel.Location = new System.Drawing.Point(6, 12);
            this._focusVessel.Name = "_focusVessel";
            this._focusVessel.Size = new System.Drawing.Size(27, 26);
            this._focusVessel.TabIndex = 13;
            this._focusVessel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._focusVessel.UseVisualStyleBackColor = true;
            // 
            // _idLabel
            // 
            this._idLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._idLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._idLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this._idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._idLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this._idLabel.Location = new System.Drawing.Point(220, 34);
            this._idLabel.Name = "_idLabel";
            this._idLabel.Size = new System.Drawing.Size(78, 22);
            this._idLabel.TabIndex = 8;
            this._idLabel.Text = "User ID";
            // 
            // _idTextBox
            // 
            this._idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._idTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._idTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this._idTextBox.Location = new System.Drawing.Point(40, 65);
            this._idTextBox.MaxLength = 9;
            this._idTextBox.Name = "_idTextBox";
            this._idTextBox.Size = new System.Drawing.Size(437, 30);
            this._idTextBox.TabIndex = 7;
            this._idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._closeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._closeButton.Location = new System.Drawing.Point(495, 2);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(21, 23);
            this._closeButton.TabIndex = 10;
            this._closeButton.UseVisualStyleBackColor = false;
            // 
            // _errorPictureBox
            // 
            this._errorPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._errorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_errorPictureBox.Image")));
            this._errorPictureBox.Location = new System.Drawing.Point(172, 96);
            this._errorPictureBox.Name = "_errorPictureBox";
            this._errorPictureBox.Size = new System.Drawing.Size(21, 18);
            this._errorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._errorPictureBox.TabIndex = 9;
            this._errorPictureBox.TabStop = false;
            this._errorPictureBox.Visible = false;
            // 
            // _outlineButton
            // 
            this._outlineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outlineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._outlineButton.Enabled = false;
            this._outlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._outlineButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._outlineButton.Location = new System.Drawing.Point(0, 0);
            this._outlineButton.Name = "_outlineButton";
            this._outlineButton.Size = new System.Drawing.Size(517, 177);
            this._outlineButton.TabIndex = 14;
            this._outlineButton.UseVisualStyleBackColor = false;
            this._outlineButton.Click += new System.EventHandler(this._outlineButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this._loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(517, 181);
            this.Controls.Add(this._idLabel);
            this.Controls.Add(this._errorLabel);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._errorPictureBox);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._idTextBox);
            this.Controls.Add(this._outlineButton);
            this.Controls.Add(this._focusVessel);
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._errorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.Label _errorLabel;
        private System.Windows.Forms.Button _focusVessel;
        private System.Windows.Forms.Label _idLabel;
        private System.Windows.Forms.TextBox _idTextBox;
        private CustomControls_TelleCollege.CloseButton _closeButton;
        private System.Windows.Forms.PictureBox _errorPictureBox;
        private System.Windows.Forms.Button _outlineButton;
    }
}