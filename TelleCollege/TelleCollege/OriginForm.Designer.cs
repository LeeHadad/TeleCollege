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
            this._tabLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.maximizeButton1 = new CustomControls_TelleCollege.MaximizeButton();
            this._closeButton = new CustomControls_TelleCollege.CloseButton();
            this.minimizeButton1 = new CustomControls_TelleCollege.MinimizeButton();
            this.topBar2 = new CustomControls_TelleCollege.TopBar();
            this._outlineButton2 = new System.Windows.Forms.Button();
            this._leadsColumnLayout = new System.Windows.Forms.TableLayoutPanel();
            this._sortLeadIndex = new System.Windows.Forms.Button();
            this._sortLeadsName = new System.Windows.Forms.Button();
            this._sortLeadsId = new System.Windows.Forms.Button();
            this._sortLeadsBirth = new System.Windows.Forms.Button();
            this._sortLeadsPhone = new System.Windows.Forms.Button();
            this._sortleadsEmail = new System.Windows.Forms.Button();
            this._sortLeadsInsert = new System.Windows.Forms.Button();
            this._leadsListView = new System.Windows.Forms.ListView();
            this._index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._personalId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._emailAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._insertionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._leadsPanel = new System.Windows.Forms.Panel();
            this._opportunitiesPanel = new System.Windows.Forms.Panel();
            this._opportunitiesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._opportunitiesColumnLayout = new System.Windows.Forms.TableLayoutPanel();
            this._sortOpportunityStatus = new System.Windows.Forms.Button();
            this._sortOpportunityIndex = new System.Windows.Forms.Button();
            this._sortOpportunityName = new System.Windows.Forms.Button();
            this._sortOpportunityId = new System.Windows.Forms.Button();
            this._sortOpportunityBirth = new System.Windows.Forms.Button();
            this._sortOpportunityPhone = new System.Windows.Forms.Button();
            this._sortOpportunityEmail = new System.Windows.Forms.Button();
            this._sortOpportunityInsert = new System.Windows.Forms.Button();
            this._tabLayoutPanel.SuspendLayout();
            this._leadsColumnLayout.SuspendLayout();
            this._leadsPanel.SuspendLayout();
            this._opportunitiesPanel.SuspendLayout();
            this._opportunitiesColumnLayout.SuspendLayout();
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
            this._welcomeLabel.Location = new System.Drawing.Point(597, 14);
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
            // _tabLayoutPanel
            // 
            this._tabLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabLayoutPanel.ColumnCount = 2;
            this._tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tabLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tabLayoutPanel.Controls.Add(this._LeadsButton, 0, 0);
            this._tabLayoutPanel.Controls.Add(this._OpportunityButton, 1, 0);
            this._tabLayoutPanel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabLayoutPanel.Location = new System.Drawing.Point(14, 57);
            this._tabLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._tabLayoutPanel.Name = "_tabLayoutPanel";
            this._tabLayoutPanel.RowCount = 1;
            this._tabLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tabLayoutPanel.Size = new System.Drawing.Size(1340, 39);
            this._tabLayoutPanel.TabIndex = 17;
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
            this.maximizeButton1.Click += new System.EventHandler(this.maximizeButton1_Click);
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
            this.minimizeButton1.Click += new System.EventHandler(this.minimizeButton1_Click);
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
            // _leadsColumnLayout
            // 
            this._leadsColumnLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._leadsColumnLayout.ColumnCount = 7;
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.52632F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.47369F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 437F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._leadsColumnLayout.Controls.Add(this._sortLeadIndex, 0, 0);
            this._leadsColumnLayout.Controls.Add(this._sortLeadsName, 1, 0);
            this._leadsColumnLayout.Controls.Add(this._sortLeadsId, 2, 0);
            this._leadsColumnLayout.Controls.Add(this._sortLeadsBirth, 3, 0);
            this._leadsColumnLayout.Controls.Add(this._sortLeadsPhone, 4, 0);
            this._leadsColumnLayout.Controls.Add(this._sortleadsEmail, 5, 0);
            this._leadsColumnLayout.Controls.Add(this._sortLeadsInsert, 6, 0);
            this._leadsColumnLayout.Location = new System.Drawing.Point(5, 96);
            this._leadsColumnLayout.Margin = new System.Windows.Forms.Padding(0);
            this._leadsColumnLayout.Name = "_leadsColumnLayout";
            this._leadsColumnLayout.RowCount = 1;
            this._leadsColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._leadsColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._leadsColumnLayout.Size = new System.Drawing.Size(1359, 32);
            this._leadsColumnLayout.TabIndex = 25;
            // 
            // _sortLeadIndex
            // 
            this._sortLeadIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortLeadIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortLeadIndex.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortLeadIndex.Location = new System.Drawing.Point(0, 0);
            this._sortLeadIndex.Margin = new System.Windows.Forms.Padding(0);
            this._sortLeadIndex.Name = "_sortLeadIndex";
            this._sortLeadIndex.Size = new System.Drawing.Size(77, 32);
            this._sortLeadIndex.TabIndex = 0;
            this._sortLeadIndex.Text = "  #   v";
            this._sortLeadIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._sortLeadIndex.UseVisualStyleBackColor = true;
            // 
            // _sortLeadsName
            // 
            this._sortLeadsName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortLeadsName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortLeadsName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortLeadsName.Location = new System.Drawing.Point(77, 0);
            this._sortLeadsName.Margin = new System.Windows.Forms.Padding(0);
            this._sortLeadsName.Name = "_sortLeadsName";
            this._sortLeadsName.Size = new System.Drawing.Size(301, 32);
            this._sortLeadsName.TabIndex = 1;
            this._sortLeadsName.Text = "Full Name";
            this._sortLeadsName.UseVisualStyleBackColor = true;
            // 
            // _sortLeadsId
            // 
            this._sortLeadsId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortLeadsId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortLeadsId.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortLeadsId.Location = new System.Drawing.Point(378, 0);
            this._sortLeadsId.Margin = new System.Windows.Forms.Padding(0);
            this._sortLeadsId.Name = "_sortLeadsId";
            this._sortLeadsId.Size = new System.Drawing.Size(124, 32);
            this._sortLeadsId.TabIndex = 2;
            this._sortLeadsId.Text = "Id";
            this._sortLeadsId.UseVisualStyleBackColor = true;
            // 
            // _sortLeadsBirth
            // 
            this._sortLeadsBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortLeadsBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortLeadsBirth.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortLeadsBirth.Location = new System.Drawing.Point(502, 0);
            this._sortLeadsBirth.Margin = new System.Windows.Forms.Padding(0);
            this._sortLeadsBirth.Name = "_sortLeadsBirth";
            this._sortLeadsBirth.Size = new System.Drawing.Size(123, 32);
            this._sortLeadsBirth.TabIndex = 3;
            this._sortLeadsBirth.Text = "Birth Date";
            this._sortLeadsBirth.UseVisualStyleBackColor = true;
            // 
            // _sortLeadsPhone
            // 
            this._sortLeadsPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortLeadsPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortLeadsPhone.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortLeadsPhone.Location = new System.Drawing.Point(625, 0);
            this._sortLeadsPhone.Margin = new System.Windows.Forms.Padding(0);
            this._sortLeadsPhone.Name = "_sortLeadsPhone";
            this._sortLeadsPhone.Size = new System.Drawing.Size(171, 32);
            this._sortLeadsPhone.TabIndex = 4;
            this._sortLeadsPhone.Text = "Phone Number";
            this._sortLeadsPhone.UseVisualStyleBackColor = true;
            // 
            // _sortleadsEmail
            // 
            this._sortleadsEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortleadsEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortleadsEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortleadsEmail.Location = new System.Drawing.Point(796, 0);
            this._sortleadsEmail.Margin = new System.Windows.Forms.Padding(0);
            this._sortleadsEmail.Name = "_sortleadsEmail";
            this._sortleadsEmail.Size = new System.Drawing.Size(437, 32);
            this._sortleadsEmail.TabIndex = 5;
            this._sortleadsEmail.Text = "Email Address";
            this._sortleadsEmail.UseVisualStyleBackColor = true;
            // 
            // _sortLeadsInsert
            // 
            this._sortLeadsInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortLeadsInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortLeadsInsert.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortLeadsInsert.Location = new System.Drawing.Point(1233, 0);
            this._sortLeadsInsert.Margin = new System.Windows.Forms.Padding(0);
            this._sortLeadsInsert.Name = "_sortLeadsInsert";
            this._sortLeadsInsert.Size = new System.Drawing.Size(126, 32);
            this._sortLeadsInsert.TabIndex = 6;
            this._sortLeadsInsert.Text = "Insertion Date";
            this._sortLeadsInsert.UseVisualStyleBackColor = true;
            // 
            // _leadsListView
            // 
            this._leadsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._leadsListView.AutoArrange = false;
            this._leadsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._leadsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._leadsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._index,
            this._name,
            this._personalId,
            this._birthDate,
            this._phoneNumber,
            this._emailAddress,
            this._insertionDate});
            this._leadsListView.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._leadsListView.ForeColor = System.Drawing.Color.AliceBlue;
            this._leadsListView.FullRowSelect = true;
            this._leadsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._leadsListView.LabelWrap = false;
            this._leadsListView.Location = new System.Drawing.Point(-1, 0);
            this._leadsListView.MultiSelect = false;
            this._leadsListView.Name = "_leadsListView";
            this._leadsListView.ShowGroups = false;
            this._leadsListView.Size = new System.Drawing.Size(1397, 646);
            this._leadsListView.TabIndex = 26;
            this._leadsListView.TabStop = false;
            this._leadsListView.TileSize = new System.Drawing.Size(100, 50);
            this._leadsListView.UseCompatibleStateImageBehavior = false;
            this._leadsListView.View = System.Windows.Forms.View.Details;
            // 
            // _index
            // 
            this._index.Text = "#";
            this._index.Width = 78;
            // 
            // _name
            // 
            this._name.Text = "Name";
            this._name.Width = 303;
            // 
            // _personalId
            // 
            this._personalId.Text = "Id";
            this._personalId.Width = 122;
            // 
            // _birthDate
            // 
            this._birthDate.Text = "Birth Date";
            this._birthDate.Width = 123;
            // 
            // _phoneNumber
            // 
            this._phoneNumber.Text = "Phone Number";
            this._phoneNumber.Width = 172;
            // 
            // _emailAddress
            // 
            this._emailAddress.Text = "Email";
            this._emailAddress.Width = 437;
            // 
            // _insertionDate
            // 
            this._insertionDate.Text = "Date Added";
            this._insertionDate.Width = 401;
            // 
            // _leadsPanel
            // 
            this._leadsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._leadsPanel.Controls.Add(this._leadsListView);
            this._leadsPanel.Location = new System.Drawing.Point(5, 131);
            this._leadsPanel.Name = "_leadsPanel";
            this._leadsPanel.Size = new System.Drawing.Size(1359, 625);
            this._leadsPanel.TabIndex = 27;
            // 
            // _opportunitiesPanel
            // 
            this._opportunitiesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._opportunitiesPanel.Controls.Add(this._opportunitiesListView);
            this._opportunitiesPanel.Location = new System.Drawing.Point(5, 131);
            this._opportunitiesPanel.Name = "_opportunitiesPanel";
            this._opportunitiesPanel.Size = new System.Drawing.Size(1359, 625);
            this._opportunitiesPanel.TabIndex = 28;
            this._opportunitiesPanel.Visible = false;
            // 
            // _opportunitiesListView
            // 
            this._opportunitiesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._opportunitiesListView.AutoArrange = false;
            this._opportunitiesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._opportunitiesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._opportunitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7});
            this._opportunitiesListView.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._opportunitiesListView.ForeColor = System.Drawing.Color.AliceBlue;
            this._opportunitiesListView.FullRowSelect = true;
            this._opportunitiesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._opportunitiesListView.LabelWrap = false;
            this._opportunitiesListView.Location = new System.Drawing.Point(-1, 0);
            this._opportunitiesListView.MultiSelect = false;
            this._opportunitiesListView.Name = "_opportunitiesListView";
            this._opportunitiesListView.ShowGroups = false;
            this._opportunitiesListView.Size = new System.Drawing.Size(1397, 646);
            this._opportunitiesListView.TabIndex = 26;
            this._opportunitiesListView.TabStop = false;
            this._opportunitiesListView.TileSize = new System.Drawing.Size(100, 50);
            this._opportunitiesListView.UseCompatibleStateImageBehavior = false;
            this._opportunitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 267;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birth Date";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone Number";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.Width = 350;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Status";
            this.columnHeader8.Width = 133;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date Added";
            this.columnHeader7.Width = 401;
            // 
            // _opportunitiesColumnLayout
            // 
            this._opportunitiesColumnLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._opportunitiesColumnLayout.ColumnCount = 8;
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.52632F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.47369F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this._opportunitiesColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityStatus, 6, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityIndex, 0, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityName, 1, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityId, 2, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityBirth, 3, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityPhone, 4, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityEmail, 5, 0);
            this._opportunitiesColumnLayout.Controls.Add(this._sortOpportunityInsert, 7, 0);
            this._opportunitiesColumnLayout.Location = new System.Drawing.Point(5, 96);
            this._opportunitiesColumnLayout.Margin = new System.Windows.Forms.Padding(0);
            this._opportunitiesColumnLayout.Name = "_opportunitiesColumnLayout";
            this._opportunitiesColumnLayout.RowCount = 1;
            this._opportunitiesColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._opportunitiesColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._opportunitiesColumnLayout.Size = new System.Drawing.Size(1359, 32);
            this._opportunitiesColumnLayout.TabIndex = 29;
            // 
            // _sortOpportunityStatus
            // 
            this._sortOpportunityStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityStatus.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityStatus.Location = new System.Drawing.Point(1109, 0);
            this._sortOpportunityStatus.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityStatus.Name = "_sortOpportunityStatus";
            this._sortOpportunityStatus.Size = new System.Drawing.Size(132, 32);
            this._sortOpportunityStatus.TabIndex = 27;
            this._sortOpportunityStatus.Text = "Status";
            this._sortOpportunityStatus.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityIndex
            // 
            this._sortOpportunityIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityIndex.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityIndex.Location = new System.Drawing.Point(0, 0);
            this._sortOpportunityIndex.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityIndex.Name = "_sortOpportunityIndex";
            this._sortOpportunityIndex.Size = new System.Drawing.Size(69, 32);
            this._sortOpportunityIndex.TabIndex = 0;
            this._sortOpportunityIndex.Text = "  #   v";
            this._sortOpportunityIndex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._sortOpportunityIndex.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityName
            // 
            this._sortOpportunityName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityName.Location = new System.Drawing.Point(69, 0);
            this._sortOpportunityName.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityName.Name = "_sortOpportunityName";
            this._sortOpportunityName.Size = new System.Drawing.Size(269, 32);
            this._sortOpportunityName.TabIndex = 1;
            this._sortOpportunityName.Text = "Full Name";
            this._sortOpportunityName.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityId
            // 
            this._sortOpportunityId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityId.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityId.Location = new System.Drawing.Point(338, 0);
            this._sortOpportunityId.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityId.Name = "_sortOpportunityId";
            this._sortOpportunityId.Size = new System.Drawing.Size(123, 32);
            this._sortOpportunityId.TabIndex = 2;
            this._sortOpportunityId.Text = "Id";
            this._sortOpportunityId.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityBirth
            // 
            this._sortOpportunityBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityBirth.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityBirth.Location = new System.Drawing.Point(461, 0);
            this._sortOpportunityBirth.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityBirth.Name = "_sortOpportunityBirth";
            this._sortOpportunityBirth.Size = new System.Drawing.Size(128, 32);
            this._sortOpportunityBirth.TabIndex = 3;
            this._sortOpportunityBirth.Text = "Birth Date";
            this._sortOpportunityBirth.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityPhone
            // 
            this._sortOpportunityPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityPhone.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityPhone.Location = new System.Drawing.Point(589, 0);
            this._sortOpportunityPhone.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityPhone.Name = "_sortOpportunityPhone";
            this._sortOpportunityPhone.Size = new System.Drawing.Size(170, 32);
            this._sortOpportunityPhone.TabIndex = 4;
            this._sortOpportunityPhone.Text = "Phone Number";
            this._sortOpportunityPhone.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityEmail
            // 
            this._sortOpportunityEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityEmail.Location = new System.Drawing.Point(759, 0);
            this._sortOpportunityEmail.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityEmail.Name = "_sortOpportunityEmail";
            this._sortOpportunityEmail.Size = new System.Drawing.Size(350, 32);
            this._sortOpportunityEmail.TabIndex = 5;
            this._sortOpportunityEmail.Text = "Email Address";
            this._sortOpportunityEmail.UseVisualStyleBackColor = true;
            // 
            // _sortOpportunityInsert
            // 
            this._sortOpportunityInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sortOpportunityInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._sortOpportunityInsert.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sortOpportunityInsert.Location = new System.Drawing.Point(1241, 0);
            this._sortOpportunityInsert.Margin = new System.Windows.Forms.Padding(0);
            this._sortOpportunityInsert.Name = "_sortOpportunityInsert";
            this._sortOpportunityInsert.Size = new System.Drawing.Size(118, 32);
            this._sortOpportunityInsert.TabIndex = 6;
            this._sortOpportunityInsert.Text = "Insertion Date";
            this._sortOpportunityInsert.UseVisualStyleBackColor = true;
            // 
            // OriginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this._opportunitiesColumnLayout);
            this.Controls.Add(this._opportunitiesPanel);
            this.Controls.Add(this._welcomeLabel);
            this.Controls.Add(this._leadsPanel);
            this.Controls.Add(this._leadsColumnLayout);
            this.Controls.Add(this._outlineButton2);
            this.Controls.Add(this.maximizeButton1);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this.minimizeButton1);
            this.Controls.Add(this.topBar2);
            this.Controls.Add(this._tabLayoutPanel);
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
            this._tabLayoutPanel.ResumeLayout(false);
            this._leadsColumnLayout.ResumeLayout(false);
            this._leadsPanel.ResumeLayout(false);
            this._opportunitiesPanel.ResumeLayout(false);
            this._opportunitiesColumnLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _welcomeLabel;
        private System.Windows.Forms.Button _LeadsButton;
        private System.Windows.Forms.Button _OpportunityButton;
        private System.Windows.Forms.Button _outline1;
        private System.Windows.Forms.Button _focusVessel;
        private System.Windows.Forms.TableLayoutPanel _tabLayoutPanel;
        private CustomControls_TelleCollege.CloseButton _closeButton;
        private CustomControls_TelleCollege.MinimizeButton minimizeButton1;
        private CustomControls_TelleCollege.TopBar topBar2;
        private CustomControls_TelleCollege.MaximizeButton maximizeButton1;
        private Button _outlineButton2;
        private TableLayoutPanel _leadsColumnLayout;
        private Button _sortLeadIndex;
        private Button _sortLeadsName;
        private Button _sortLeadsId;
        private Button _sortLeadsBirth;
        private Button _sortLeadsPhone;
        private Button _sortleadsEmail;
        private Button _sortLeadsInsert;
        private ListView _leadsListView;
        private ColumnHeader _index;
        private ColumnHeader _name;
        private ColumnHeader _personalId;
        private ColumnHeader _birthDate;
        private ColumnHeader _phoneNumber;
        private ColumnHeader _emailAddress;
        private ColumnHeader _insertionDate;
        private Panel _leadsPanel;
        private Panel _opportunitiesPanel;
        private ListView _opportunitiesListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TableLayoutPanel _opportunitiesColumnLayout;
        private Button _sortOpportunityIndex;
        private Button _sortOpportunityName;
        private Button _sortOpportunityId;
        private Button _sortOpportunityBirth;
        private Button _sortOpportunityPhone;
        private Button _sortOpportunityEmail;
        private Button _sortOpportunityInsert;
        private ColumnHeader columnHeader8;
        private Button _sortOpportunityStatus;
    }
}

