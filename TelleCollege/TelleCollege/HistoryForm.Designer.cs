namespace TelleCollege
{
    partial class HistoryForm
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
            this._removeHistoryButton = new System.Windows.Forms.Button();
            this._addHistoryButton = new System.Windows.Forms.Button();
            this._historyPanel = new System.Windows.Forms.Panel();
            this._historyListView = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this._closeButton = new CustomControls_TelleCollege.CloseButton();
            this.topBar2 = new CustomControls_TelleCollege.TopBar();
            this._outlineButton2 = new System.Windows.Forms.Button();
            this._leadsColumnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._historyPanel.SuspendLayout();
            this._leadsColumnLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // _outline1
            // 
            this._outline1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._outline1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._outline1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._outline1.Enabled = false;
            this._outline1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._outline1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._outline1.Location = new System.Drawing.Point(3, 1);
            this._outline1.Name = "_outline1";
            this._outline1.Size = new System.Drawing.Size(1016, 639);
            this._outline1.TabIndex = 4;
            this._outline1.UseVisualStyleBackColor = false;
            // 
            // _removeHistoryButton
            // 
            this._removeHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._removeHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeHistoryButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._removeHistoryButton.ForeColor = System.Drawing.Color.SkyBlue;
            this._removeHistoryButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this._removeHistoryButton.Location = new System.Drawing.Point(992, 612);
            this._removeHistoryButton.Name = "_removeHistoryButton";
            this._removeHistoryButton.Size = new System.Drawing.Size(26, 26);
            this._removeHistoryButton.TabIndex = 40;
            this._removeHistoryButton.Text = "-";
            this._removeHistoryButton.UseVisualStyleBackColor = true;
            this._removeHistoryButton.Click += new System.EventHandler(this._removeHistoryButton_Click);
            // 
            // _addHistoryButton
            // 
            this._addHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._addHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addHistoryButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addHistoryButton.ForeColor = System.Drawing.Color.SkyBlue;
            this._addHistoryButton.Location = new System.Drawing.Point(967, 612);
            this._addHistoryButton.Name = "_addHistoryButton";
            this._addHistoryButton.Size = new System.Drawing.Size(26, 26);
            this._addHistoryButton.TabIndex = 39;
            this._addHistoryButton.Text = "+";
            this._addHistoryButton.UseVisualStyleBackColor = true;
            this._addHistoryButton.Click += new System.EventHandler(this._addHistoryButton_Click);
            // 
            // _historyPanel
            // 
            this._historyPanel.Controls.Add(this._historyListView);
            this._historyPanel.Location = new System.Drawing.Point(4, 67);
            this._historyPanel.Name = "_historyPanel";
            this._historyPanel.Size = new System.Drawing.Size(1012, 540);
            this._historyPanel.TabIndex = 42;
            // 
            // _historyListView
            // 
            this._historyListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this._historyListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._historyListView.AutoArrange = false;
            this._historyListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._historyListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this._historyListView.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._historyListView.ForeColor = System.Drawing.Color.AliceBlue;
            this._historyListView.FullRowSelect = true;
            this._historyListView.GridLines = true;
            this._historyListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._historyListView.HideSelection = false;
            this._historyListView.Location = new System.Drawing.Point(-1, 0);
            this._historyListView.MultiSelect = false;
            this._historyListView.Name = "_historyListView";
            this._historyListView.ShowGroups = false;
            this._historyListView.Size = new System.Drawing.Size(1050, 558);
            this._historyListView.TabIndex = 26;
            this._historyListView.TabStop = false;
            this._historyListView.TileSize = new System.Drawing.Size(1000, 50);
            this._historyListView.UseCompatibleStateImageBehavior = false;
            this._historyListView.View = System.Windows.Forms.View.Details;
            this._historyListView.DoubleClick += new System.EventHandler(this._historyListView_DoubleClick);
            // 
            // Index
            // 
            this.Index.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 111;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 531;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(4, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1009, 1);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this._closeButton.FlatAppearance.BorderSize = 0;
            this._closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._closeButton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._closeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this._closeButton.Location = new System.Drawing.Point(992, 3);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(21, 23);
            this._closeButton.TabIndex = 27;
            this._closeButton.TerminateOnClick = false;
            this._closeButton.UseVisualStyleBackColor = false;
            // 
            // topBar2
            // 
            this.topBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.topBar2.Location = new System.Drawing.Point(4, 6);
            this.topBar2.Name = "topBar2";
            this.topBar2.Size = new System.Drawing.Size(982, 16);
            this.topBar2.TabIndex = 28;
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
            this._outlineButton2.Location = new System.Drawing.Point(4, 34);
            this._outlineButton2.Name = "_outlineButton2";
            this._outlineButton2.Size = new System.Drawing.Size(1012, 3);
            this._outlineButton2.TabIndex = 27;
            this._outlineButton2.UseVisualStyleBackColor = true;
            // 
            // _leadsColumnLayout
            // 
            this._leadsColumnLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._leadsColumnLayout.ColumnCount = 5;
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.15873F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 533F));
            this._leadsColumnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._leadsColumnLayout.Controls.Add(this.button6, 4, 0);
            this._leadsColumnLayout.Controls.Add(this.button5, 3, 0);
            this._leadsColumnLayout.Controls.Add(this.button4, 2, 0);
            this._leadsColumnLayout.Controls.Add(this.button3, 1, 0);
            this._leadsColumnLayout.Controls.Add(this.button2, 0, 0);
            this._leadsColumnLayout.Location = new System.Drawing.Point(4, 38);
            this._leadsColumnLayout.Margin = new System.Windows.Forms.Padding(0);
            this._leadsColumnLayout.Name = "_leadsColumnLayout";
            this._leadsColumnLayout.RowCount = 1;
            this._leadsColumnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._leadsColumnLayout.Size = new System.Drawing.Size(1015, 32);
            this._leadsColumnLayout.TabIndex = 43;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.Location = new System.Drawing.Point(481, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(534, 32);
            this.button6.TabIndex = 48;
            this.button6.Text = "  Note";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Location = new System.Drawing.Point(365, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 32);
            this.button5.TabIndex = 47;
            this.button5.Text = "Date";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Location = new System.Drawing.Point(255, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 32);
            this.button4.TabIndex = 46;
            this.button4.Text = "Rep. Id";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(50, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 32);
            this.button3.TabIndex = 45;
            this.button3.Text = "Representative Name";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 32);
            this.button2.TabIndex = 44;
            this.button2.Text = "  # v";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1021, 644);
            this.Controls.Add(this._leadsColumnLayout);
            this.Controls.Add(this._outlineButton2);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topBar2);
            this.Controls.Add(this._historyPanel);
            this.Controls.Add(this._removeHistoryButton);
            this.Controls.Add(this._addHistoryButton);
            this.Controls.Add(this._outline1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryForm";
            this._historyPanel.ResumeLayout(false);
            this._leadsColumnLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _outline1;
        private System.Windows.Forms.Button _removeHistoryButton;
        private System.Windows.Forms.Button _addHistoryButton;
        private System.Windows.Forms.Panel _historyPanel;
        private System.Windows.Forms.ListView _historyListView;
        private System.Windows.Forms.Button button1;
        private CustomControls_TelleCollege.CloseButton _closeButton;
        private CustomControls_TelleCollege.TopBar topBar2;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button _outlineButton2;
        private System.Windows.Forms.TableLayoutPanel _leadsColumnLayout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}