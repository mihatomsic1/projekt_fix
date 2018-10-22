namespace liga
{
    partial class igralci
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nazajButton = new System.Windows.Forms.Button();
            this.dodajIgralcaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izberite ekipo za prikaz igralcev:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 95);
            this.listBox1.TabIndex = 3;
            // 
            // nazajButton
            // 
            this.nazajButton.Location = new System.Drawing.Point(40, 204);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(75, 23);
            this.nazajButton.TabIndex = 7;
            this.nazajButton.Text = "Nazaj";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.Click += new System.EventHandler(this.nazajButton_Click);
            // 
            // dodajIgralcaButton
            // 
            this.dodajIgralcaButton.Location = new System.Drawing.Point(132, 204);
            this.dodajIgralcaButton.Name = "dodajIgralcaButton";
            this.dodajIgralcaButton.Size = new System.Drawing.Size(104, 23);
            this.dodajIgralcaButton.TabIndex = 8;
            this.dodajIgralcaButton.Text = "Dodaj igralca";
            this.dodajIgralcaButton.UseVisualStyleBackColor = true;
            this.dodajIgralcaButton.Click += new System.EventHandler(this.dodajIgralcaButton_Click);
            // 
            // igralci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 326);
            this.Controls.Add(this.dodajIgralcaButton);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "igralci";
            this.Text = "IGRALCI";
            this.Load += new System.EventHandler(this.igralci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button nazajButton;
        private System.Windows.Forms.Button dodajIgralcaButton;
    }
}