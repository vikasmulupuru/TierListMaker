﻿namespace TierListMaker
{
    partial class AddItemScreen
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CancelAddItemButton = new System.Windows.Forms.Button();
            this.OKAddItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Tier to Add Item To:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // CancelAddItemButton
            // 
            this.CancelAddItemButton.Location = new System.Drawing.Point(148, 144);
            this.CancelAddItemButton.Name = "CancelAddItemButton";
            this.CancelAddItemButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddItemButton.TabIndex = 4;
            this.CancelAddItemButton.Text = "Cancel";
            this.CancelAddItemButton.UseVisualStyleBackColor = true;
            this.CancelAddItemButton.Click += new System.EventHandler(this.CancelAddItemButton_Click);
            // 
            // OKAddItemButton
            // 
            this.OKAddItemButton.Location = new System.Drawing.Point(50, 144);
            this.OKAddItemButton.Name = "OKAddItemButton";
            this.OKAddItemButton.Size = new System.Drawing.Size(75, 23);
            this.OKAddItemButton.TabIndex = 5;
            this.OKAddItemButton.Text = "OK";
            this.OKAddItemButton.UseVisualStyleBackColor = true;
            this.OKAddItemButton.Click += new System.EventHandler(this.OKAddItemButton_Click);
            // 
            // AddItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 209);
            this.Controls.Add(this.OKAddItemButton);
            this.Controls.Add(this.CancelAddItemButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddItemScreen";
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CancelAddItemButton;
        private System.Windows.Forms.Button OKAddItemButton;
    }
}