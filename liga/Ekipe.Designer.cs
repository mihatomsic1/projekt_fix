namespace liga
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
            this.izpisiButton = new System.Windows.Forms.Button();
            this.urediButton = new System.Windows.Forms.Button();
            this.nazajButton = new System.Windows.Forms.Button();
            this.osveziButton = new System.Windows.Forms.Button();
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
            // izpisiButton
            // 
            this.izpisiButton.Location = new System.Drawing.Point(185, 97);
            this.izpisiButton.Name = "izpisiButton";
            this.izpisiButton.Size = new System.Drawing.Size(115, 23);
            this.izpisiButton.TabIndex = 4;
            this.izpisiButton.Text = "Izpisi ekipo";
            this.izpisiButton.UseVisualStyleBackColor = true;
            this.izpisiButton.Click += new System.EventHandler(this.izpisiButton_Click);
            // 
            // urediButton
            // 
            this.urediButton.Location = new System.Drawing.Point(185, 133);
            this.urediButton.Name = "urediButton";
            this.urediButton.Size = new System.Drawing.Size(115, 23);
            this.urediButton.TabIndex = 5;
            this.urediButton.Text = "Posodobi";
            this.urediButton.UseVisualStyleBackColor = true;
            this.urediButton.Click += new System.EventHandler(this.urediButton_Click);
            // 
            // nazajButton
            // 
            this.nazajButton.Location = new System.Drawing.Point(30, 97);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(121, 23);
            this.nazajButton.TabIndex = 6;
            this.nazajButton.Text = "Nazaj";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.Click += new System.EventHandler(this.nazajButton_Click);
            // 
            // osveziButton
            // 
            this.osveziButton.Location = new System.Drawing.Point(30, 68);
            this.osveziButton.Name = "osveziButton";
            this.osveziButton.Size = new System.Drawing.Size(121, 23);
            this.osveziButton.TabIndex = 7;
            this.osveziButton.Text = "Osvezi seznam";
            this.osveziButton.UseVisualStyleBackColor = true;
            this.osveziButton.Click += new System.EventHandler(this.osveziButton_Click);
            // 
            // Ekipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 177);
            this.Controls.Add(this.osveziButton);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.urediButton);
            this.Controls.Add(this.izpisiButton);
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
        private System.Windows.Forms.Button izpisiButton;
        private System.Windows.Forms.Button urediButton;
        private System.Windows.Forms.Button nazajButton;
        private System.Windows.Forms.Button osveziButton;
    }
}