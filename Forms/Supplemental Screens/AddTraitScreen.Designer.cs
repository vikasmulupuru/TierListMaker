﻿namespace TierListMaker
{
    partial class AddTraitScreen
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
            this.CancelAddTraitButton = new System.Windows.Forms.Button();
            this.OKAddTraitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelAddTraitButton
            // 
            this.CancelAddTraitButton.Location = new System.Drawing.Point(93, 130);
            this.CancelAddTraitButton.Name = "CancelAddTraitButton";
            this.CancelAddTraitButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddTraitButton.TabIndex = 0;
            this.CancelAddTraitButton.Text = "Cancel";
            this.CancelAddTraitButton.UseVisualStyleBackColor = true;
            this.CancelAddTraitButton.Click += new System.EventHandler(this.CancelAddTraitButton_Click);
            // 
            // OKAddTraitButton
            // 
            this.OKAddTraitButton.Location = new System.Drawing.Point(12, 129);
            this.OKAddTraitButton.Name = "OKAddTraitButton";
            this.OKAddTraitButton.Size = new System.Drawing.Size(75, 23);
            this.OKAddTraitButton.TabIndex = 1;
            this.OKAddTraitButton.Text = "OK";
            this.OKAddTraitButton.UseVisualStyleBackColor = true;
            this.OKAddTraitButton.Click += new System.EventHandler(this.OKAddTraitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert New Trait Below:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddTraitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 165);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKAddTraitButton);
            this.Controls.Add(this.CancelAddTraitButton);
            this.Name = "AddTraitScreen";
            this.Text = "Add Trait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddTraitButton;
        private System.Windows.Forms.Button OKAddTraitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
