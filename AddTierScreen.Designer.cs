namespace TierListMaker
{
    partial class AddTierScreen
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
            this.promptToTypeTierName = new System.Windows.Forms.Label();
            this.CancelAddTierButton = new System.Windows.Forms.Button();
            this.OKAddTierButton = new System.Windows.Forms.Button();
            this.addTierTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // promptToTypeTierName
            // 
            this.promptToTypeTierName.AutoSize = true;
            this.promptToTypeTierName.Location = new System.Drawing.Point(22, 59);
            this.promptToTypeTierName.Name = "promptToTypeTierName";
            this.promptToTypeTierName.Size = new System.Drawing.Size(143, 13);
            this.promptToTypeTierName.TabIndex = 1;
            this.promptToTypeTierName.Text = "Type Name of Tier List Here:";
            // 
            // CancelAddTierButton
            // 
            this.CancelAddTierButton.Location = new System.Drawing.Point(119, 145);
            this.CancelAddTierButton.Name = "CancelAddTierButton";
            this.CancelAddTierButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddTierButton.TabIndex = 2;
            this.CancelAddTierButton.Text = "Cancel";
            this.CancelAddTierButton.UseVisualStyleBackColor = true;
            this.CancelAddTierButton.Click += new System.EventHandler(this.CancelAddTierButton_Click);
            // 
            // OKAddTierButton
            // 
            this.OKAddTierButton.Location = new System.Drawing.Point(25, 145);
            this.OKAddTierButton.Name = "OKAddTierButton";
            this.OKAddTierButton.Size = new System.Drawing.Size(75, 23);
            this.OKAddTierButton.TabIndex = 3;
            this.OKAddTierButton.Text = "OK";
            this.OKAddTierButton.UseVisualStyleBackColor = true;
            this.OKAddTierButton.Click += new System.EventHandler(this.OKAddTierButton_Click);
            // 
            // addTierTextbox
            // 
            this.addTierTextbox.Location = new System.Drawing.Point(25, 88);
            this.addTierTextbox.Name = "addTierTextbox";
            this.addTierTextbox.Size = new System.Drawing.Size(100, 20);
            this.addTierTextbox.TabIndex = 0;
            this.addTierTextbox.TextChanged += new System.EventHandler(this.addTierTextbox_TextChanged);
            // 
            // AddTierScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 253);
            this.Controls.Add(this.OKAddTierButton);
            this.Controls.Add(this.CancelAddTierButton);
            this.Controls.Add(this.promptToTypeTierName);
            this.Controls.Add(this.addTierTextbox);
            this.Name = "AddTierScreen";
            this.Text = "Add Tier";
            this.Load += new System.EventHandler(this.AddTierScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label promptToTypeTierName;
        private System.Windows.Forms.Button CancelAddTierButton;
        private System.Windows.Forms.Button OKAddTierButton;
        private System.Windows.Forms.TextBox addTierTextbox;
    }
}