﻿namespace liga
{
    partial class tekmovanja
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nazajButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 134);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretekle tekme:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nazajButton
            // 
            this.nazajButton.Location = new System.Drawing.Point(30, 191);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(75, 23);
            this.nazajButton.TabIndex = 7;
            this.nazajButton.Text = "Nazaj";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.Click += new System.EventHandler(this.nazajButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(129, 191);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 8;
            this.dodajButton.Text = "Dodaj tekmo";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // tekmovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 243);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "tekmovanja";
            this.Text = "TEKME";
            this.Load += new System.EventHandler(this.tekmovanja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nazajButton;
        private System.Windows.Forms.Button dodajButton;
    }
}