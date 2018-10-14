namespace liga
{
    partial class urediEkipo
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.trenerTextbox = new System.Windows.Forms.TextBox();
            this.letoTextbox = new System.Windows.Forms.TextBox();
            this.mestoTextbox = new System.Windows.Forms.TextBox();
            this.imeTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(207, 146);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(251, 23);
            this.dodajButton.TabIndex = 17;
            this.dodajButton.Text = "Shrani";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // trenerTextbox
            // 
            this.trenerTextbox.Location = new System.Drawing.Point(324, 109);
            this.trenerTextbox.Name = "trenerTextbox";
            this.trenerTextbox.Size = new System.Drawing.Size(134, 20);
            this.trenerTextbox.TabIndex = 16;
            // 
            // letoTextbox
            // 
            this.letoTextbox.Location = new System.Drawing.Point(324, 82);
            this.letoTextbox.Name = "letoTextbox";
            this.letoTextbox.Size = new System.Drawing.Size(134, 20);
            this.letoTextbox.TabIndex = 15;
            // 
            // mestoTextbox
            // 
            this.mestoTextbox.Location = new System.Drawing.Point(324, 52);
            this.mestoTextbox.Name = "mestoTextbox";
            this.mestoTextbox.Size = new System.Drawing.Size(134, 20);
            this.mestoTextbox.TabIndex = 14;
            // 
            // imeTextbox
            // 
            this.imeTextbox.Location = new System.Drawing.Point(324, 27);
            this.imeTextbox.Name = "imeTextbox";
            this.imeTextbox.Size = new System.Drawing.Size(134, 20);
            this.imeTextbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Leto ustanovitve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trener:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // urediEkipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 206);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.trenerTextbox);
            this.Controls.Add(this.letoTextbox);
            this.Controls.Add(this.mestoTextbox);
            this.Controls.Add(this.imeTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "urediEkipo";
            this.Text = "urediEkipo";
            this.Load += new System.EventHandler(this.urediEkipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.TextBox trenerTextbox;
        private System.Windows.Forms.TextBox letoTextbox;
        private System.Windows.Forms.TextBox mestoTextbox;
        private System.Windows.Forms.TextBox imeTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}