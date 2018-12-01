using System.Windows.Forms;

namespace TelleCollege
{
    partial class OriginForm
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
            this._welcomeLabel = new System.Windows.Forms.Label();
            this._LeadsButton = new System.Windows.Forms.Button();
            this._OpportunityButton = new System.Windows.Forms.Button();
            this._outline1 = new System.Windows.Forms.Button();
            this._focusVessel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maximizeButton1 = new CustomControls_TelleCollege.MaximizeButton();
            this._closeButton = new CustomControls_TelleCollege.CloseButton();
            this.minimizeButton1 = new CustomControls_TelleCollege.MinimizeButton();
            this.topBar2 = new CustomControls_TelleCollege.TopBar();
            this._outlineButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _welcomeLabel
            // 
            this._welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._welcomeLabel.AutoSize = true;
            this._welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._welcomeLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this._welcomeLabel.Location = new System.Drawing.Point(597, 17);
            this._welcomeLabel.Name = "_welcomeLabel";
            this._welcomeLabel.Size = new System.Drawing.Size(179, 30);
            this._welcomeLabel.TabIndex = 0;
            this._welcomeLabel.Text = "Logged in as: ";
            this._welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _LeadsButton
            // 
            this._LeadsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._LeadsButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this._LeadsButton.FlatAppearance.BorderSize = 0;
            this._LeadsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this._LeadsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this._LeadsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._LeadsButton.Font = new System.Drawing.Font("Century Gothic", 13F);
            this._LeadsButton.ForeColor = System.Drawing.Color.AliceBlue;
            this._LeadsButton.Location = new System.Drawing.Point(0, 0);
            this._LeadsButton.Margin = new System.Windows.Forms.Padding(0);
            this._LeadsButton.Name = "_LeadsButton";
            this._LeadsButton.Size = new System.Drawing.Size(670, 36);
            this._LeadsButton.TabIndex = 1;
            this._LeadsButton.Text = "Leads";
            this._LeadsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._LeadsButton.UseVisualStyleBackColor = false;
            this._LeadsButton.Click += new System.EventHandler(this._LeadsButton_Click);
            // 
            // _OpportunityButton
            // 
            this._OpportunityButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._OpportunityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._OpportunityButton.FlatAppearance.BorderSize = 0;
            this._OpportunityButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this._OpportunityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(240)))));
            this._OpportunityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._OpportunityButton.Font = new System.Drawing.Font("Century Gothic", 13F);
            this._OpportunityButton.ForeColor = System.Drawing.Color.AliceBlue;
            this._OpportunityButton.Location = new System.Drawing.Point(670, 0);
            this._OpportunityButton.Margin = new System.Windows.Forms.Padding(0);
            this._OpportunityButton.Name = "_OpportunityButton";
            this._OpportunityButton.Size = new System.Drawing.Size(670, 36);
            this._OpportunityButton.TabIndex = 2;
            this._OpportunityButton.Text = "Opportunities";
            this._OpportunityButton.UseVisualStyleBackColor = false;
            this._OpportunityButton.Click += new System.EventHandler(this._OpportunityButton_Click);
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
            this._outline1.Location = new System.Drawing.Point(4, 4);
            this._outline1.Name = "_outline1";
            this._outline1.Size = new System.Drawing.Size(1361, 760);
            this._outline1.TabIndex = 3;
            this._outline1.UseVisualStyleBackColor = false;
            // 
            // _focusVessel
            // 
            this._focusVessel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._focusVessel.Font = new System.Drawing.Font("Century Gothic", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._focusVessel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._focusVessel.Location = new System.Drawing.Point(13, 13);
            this._focusVessel.Name = "_focusVessel";
            this._focusVessel.Size = new System.Drawing.Size(27, 26);
            this._focusVessel.TabIndex = 12;
            this._focusVessel.Text = "__";
            this._focusVessel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._focusVessel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._LeadsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._OpportunityButton, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1340, 39);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // maximizeButton1
            // 
            this.maximizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.maximizeButton1.FlatAppearance.BorderSize = 0;
            this.maximizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeButton1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.maximizeButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.maximizeButton1.Location = new System.Drawing.Point(1317, 6);
            this.maximizeButton1.Name = "maximizeButton1";
            this.maximizeButton1.Size = new System.Drawing.Size(21, 23);
            this.maximizeButton1.TabIndex = 21;
            this.maximizeButton1.UseVisualStyleBackColor = false;
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._closeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._closeButton.Location = new System.Drawing.Point(1343, 6);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(21, 23);
            this._closeButton.TabIndex = 10;
            this._closeButton.UseVisualStyleBackColor = false;
            // 
            // minimizeButton1
            // 
            this.minimizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.minimizeButton1.FlatAppearance.BorderSize = 0;
            this.minimizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton1.Font = new System.Drawing.Font("Century Gothic", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeButton1.Location = new System.Drawing.Point(1293, 7);
            this.minimizeButton1.Name = "minimizeButton1";
            this.minimizeButton1.Size = new System.Drawing.Size(21, 23);
            this.minimizeButton1.TabIndex = 18;
            this.minimizeButton1.UseVisualStyleBackColor = false;
            // 
            // topBar2
            // 
            this.topBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.topBar2.Location = new System.Drawing.Point(5, 9);
            this.topBar2.Name = "topBar2";
            this.topBar2.Size = new System.Drawing.Size(1288, 16);
            this.topBar2.TabIndex = 20;
            // 
            // _outlineButton2
            // 
            this._outlineButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._outlineButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._outlineButton2.Enabled = false;
            this._outlineButton2.FlatAppearance.BorderSize = 3;
            this._outlineButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._outlineButton2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._outlineButton2.Location = new System.Drawing.Point(5, 93);
            this._outlineButton2.Name = "_outlineButton2";
            this._outlineButton2.Size = new System.Drawing.Size(1359, 3);
            this._outlineButton2.TabIndex = 22;
            this._outlineButton2.UseVisualStyleBackColor = true;
            // 
            // OriginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this._outlineButton2);
            this.Controls.Add(this.maximizeButton1);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.topBar2);
            this.Controls.Add(this._welcomeLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._outline1);
            this.Controls.Add(this._focusVessel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Enabled = false;
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.Name = "OriginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelleCollege";
            this.Shown += new System.EventHandler(this.OriginForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _welcomeLabel;
        private System.Windows.Forms.Button _LeadsButton;
        private System.Windows.Forms.Button _OpportunityButton;
        private System.Windows.Forms.Button _outline1;
        private System.Windows.Forms.Button _focusVessel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls_TelleCollege.CloseButton _closeButton;
        private CustomControls_TelleCollege.MinimizeButton minimizeButton1;
        private CustomControls_TelleCollege.TopBar topBar2;
        private CustomControls_TelleCollege.MaximizeButton maximizeButton1;
        private Button _outlineButton2;
    }
}

