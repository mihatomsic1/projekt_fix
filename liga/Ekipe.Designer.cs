﻿namespace liga
{
    partial class Ekipe
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.izbrisiButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.izpisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(185, 30);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(115, 23);
            this.dodajButton.TabIndex = 1;
            this.dodajButton.Text = "Dodaj ekipo";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // izbrisiButton
            // 
            this.izbrisiButton.Location = new System.Drawing.Point(185, 68);
            this.izbrisiButton.Name = "izbrisiButton";
            this.izbrisiButton.Size = new System.Drawing.Size(115, 23);
            this.izbrisiButton.TabIndex = 2;
            this.izbrisiButton.Text = "Izbrisi ekipo";
            this.izbrisiButton.UseVisualStyleBackColor = true;
            this.izbrisiButton.Click += new System.EventHandler(this.izbrisiButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(185, 108);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Posodobi ekipo";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // izpisiButton
            // 
            this.izpisiButton.Location = new System.Drawing.Point(185, 147);
            this.izpisiButton.Name = "izpisiButton";
            this.izpisiButton.Size = new System.Drawing.Size(115, 23);
            this.izpisiButton.TabIndex = 4;
            this.izpisiButton.Text = "Izpisi ekipo";
            this.izpisiButton.UseVisualStyleBackColor = true;
            // 
            // Ekipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 207);
            this.Controls.Add(this.izpisiButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.izbrisiButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Ekipe";
            this.Text = "Ekipe";
            this.Load += new System.EventHandler(this.Ekipe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button izbrisiButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button izpisiButton;
    }
}