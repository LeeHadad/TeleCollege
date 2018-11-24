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
            this.label1 = new System.Windows.Forms.Label();
            this._LeadsButton = new System.Windows.Forms.Button();
            this._OpportunityButton = new System.Windows.Forms.Button();
            this._IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _LeadsButton
            // 
            this._LeadsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LeadsButton.Location = new System.Drawing.Point(20, 133);
            this._LeadsButton.Name = "_LeadsButton";
            this._LeadsButton.Size = new System.Drawing.Size(313, 116);
            this._LeadsButton.TabIndex = 1;
            this._LeadsButton.Text = "LEADS";
            this._LeadsButton.UseVisualStyleBackColor = true;
            // 
            // _OpportunityButton
            // 
            this._OpportunityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._OpportunityButton.Location = new System.Drawing.Point(349, 133);
            this._OpportunityButton.Name = "_OpportunityButton";
            this._OpportunityButton.Size = new System.Drawing.Size(313, 116);
            this._OpportunityButton.TabIndex = 2;
            this._OpportunityButton.Text = "OPPORTUNITIES";
            this._OpportunityButton.UseVisualStyleBackColor = true;
            // 
            // _IdLabel
            // 
            this._IdLabel.AutoSize = true;
            this._IdLabel.Enabled = false;
            this._IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this._IdLabel.Location = new System.Drawing.Point(266, 56);
            this._IdLabel.Name = "_IdLabel";
            this._IdLabel.Size = new System.Drawing.Size(23, 36);
            this._IdLabel.TabIndex = 3;
            this._IdLabel.Text = " ";
            this._IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OriginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 275);
            this.Controls.Add(this._IdLabel);
            this.Controls.Add(this._OpportunityButton);
            this.Controls.Add(this._LeadsButton);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.MaximizeBox = false;
            this.Name = "OriginForm";
            this.Text = "TelleCollege";
            this.Shown += new System.EventHandler(this.OriginForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _LeadsButton;
        private System.Windows.Forms.Button _OpportunityButton;
        private System.Windows.Forms.Label _IdLabel;



    }
}

