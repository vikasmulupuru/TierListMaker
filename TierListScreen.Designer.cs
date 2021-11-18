namespace TierListMaker
{
    partial class TierListScreen
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
            this.components = new System.ComponentModel.Container();
            this.tiersDropdownComboBox = new System.Windows.Forms.ComboBox();
            this.tierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showItemsButton = new System.Windows.Forms.Button();
            this.itemsDisplayListBox = new System.Windows.Forms.ListBox();
            this.newTierButton = new System.Windows.Forms.Button();
            this.newTraitButton = new System.Windows.Forms.Button();
            this.newItembutton = new System.Windows.Forms.Button();
            this.tierListScreenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tierListScreenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tierListScreenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tierListScreenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tiersDropdownComboBox
            // 
            this.tiersDropdownComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiersDropdownComboBox.FormattingEnabled = true;
            this.tiersDropdownComboBox.Location = new System.Drawing.Point(38, 71);
            this.tiersDropdownComboBox.Name = "tiersDropdownComboBox";
            this.tiersDropdownComboBox.Size = new System.Drawing.Size(121, 21);
            this.tiersDropdownComboBox.TabIndex = 0;
            this.tiersDropdownComboBox.SelectedIndexChanged += new System.EventHandler(this.tiersDropdownComboBox_SelectedIndexChanged);
            // 
            // tierBindingSource
            // 
            this.tierBindingSource.DataSource = typeof(TierListMaker.Tier);
            // 
            // showItemsButton
            // 
            this.showItemsButton.Location = new System.Drawing.Point(192, 100);
            this.showItemsButton.Name = "showItemsButton";
            this.showItemsButton.Size = new System.Drawing.Size(75, 23);
            this.showItemsButton.TabIndex = 1;
            this.showItemsButton.Text = ">>";
            this.showItemsButton.UseVisualStyleBackColor = true;
            this.showItemsButton.Click += new System.EventHandler(this.showItemsButton_Click);
            // 
            // itemsDisplayListBox
            // 
            this.itemsDisplayListBox.FormattingEnabled = true;
            this.itemsDisplayListBox.Location = new System.Drawing.Point(301, 59);
            this.itemsDisplayListBox.Name = "itemsDisplayListBox";
            this.itemsDisplayListBox.Size = new System.Drawing.Size(171, 160);
            this.itemsDisplayListBox.TabIndex = 2;
            // 
            // newTierButton
            // 
            this.newTierButton.Location = new System.Drawing.Point(59, 248);
            this.newTierButton.Name = "newTierButton";
            this.newTierButton.Size = new System.Drawing.Size(110, 23);
            this.newTierButton.TabIndex = 3;
            this.newTierButton.Text = "Create New Tier";
            this.newTierButton.UseVisualStyleBackColor = true;
            this.newTierButton.Click += new System.EventHandler(this.newTierButton_Click);
            // 
            // newTraitButton
            // 
            this.newTraitButton.Location = new System.Drawing.Point(318, 248);
            this.newTraitButton.Name = "newTraitButton";
            this.newTraitButton.Size = new System.Drawing.Size(105, 23);
            this.newTraitButton.TabIndex = 5;
            this.newTraitButton.Text = "Create New Trait";
            this.newTraitButton.UseVisualStyleBackColor = true;
            this.newTraitButton.Click += new System.EventHandler(this.newTraitButton_Click);
            // 
            // newItembutton
            // 
            this.newItembutton.Location = new System.Drawing.Point(192, 248);
            this.newItembutton.Name = "newItembutton";
            this.newItembutton.Size = new System.Drawing.Size(102, 23);
            this.newItembutton.TabIndex = 6;
            this.newItembutton.Text = "Create New Item";
            this.newItembutton.UseVisualStyleBackColor = true;
            this.newItembutton.Click += new System.EventHandler(this.newItembutton_Click);
            // 
            // tierListScreenBindingSource
            // 
            this.tierListScreenBindingSource.DataSource = typeof(TierListMaker.TierListScreen);
            // 
            // tierListScreenBindingSource1
            // 
            this.tierListScreenBindingSource1.DataSource = typeof(TierListMaker.TierListScreen);
            // 
            // TierListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(498, 330);
            this.Controls.Add(this.newItembutton);
            this.Controls.Add(this.newTraitButton);
            this.Controls.Add(this.newTierButton);
            this.Controls.Add(this.itemsDisplayListBox);
            this.Controls.Add(this.showItemsButton);
            this.Controls.Add(this.tiersDropdownComboBox);
            this.IsMdiContainer = true;
            this.Name = "TierListScreen";
            this.Text = "Tier List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tierListScreenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tierListScreenBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tiersDropdownComboBox;
        private System.Windows.Forms.Button showItemsButton;
        private System.Windows.Forms.ListBox itemsDisplayListBox;
        private System.Windows.Forms.Button newTierButton;
        private System.Windows.Forms.Button newTraitButton;
        private System.Windows.Forms.Button newItembutton;
        private System.Windows.Forms.BindingSource tierBindingSource;
        private System.Windows.Forms.BindingSource tierListScreenBindingSource;
        private System.Windows.Forms.BindingSource tierListScreenBindingSource1;
    }
}

