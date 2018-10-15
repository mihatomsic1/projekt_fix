namespace liga
{
    partial class dodajEkipo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imeTextbox = new System.Windows.Forms.TextBox();
            this.mestoTextbox = new System.Windows.Forms.TextBox();
            this.letoTextbox = new System.Windows.Forms.TextBox();
            this.trenerTextbox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trener:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leto ustanovitve:";
            // 
            // imeTextbox
            // 
            this.imeTextbox.Location = new System.Drawing.Point(157, 23);
            this.imeTextbox.Name = "imeTextbox";
            this.imeTextbox.Size = new System.Drawing.Size(134, 20);
            this.imeTextbox.TabIndex = 4;
            // 
            // mestoTextbox
            // 
            this.mestoTextbox.Location = new System.Drawing.Point(157, 48);
            this.mestoTextbox.Name = "mestoTextbox";
            this.mestoTextbox.Size = new System.Drawing.Size(134, 20);
            this.mestoTextbox.TabIndex = 5;
            // 
            // letoTextbox
            // 
            this.letoTextbox.Location = new System.Drawing.Point(157, 78);
            this.letoTextbox.Name = "letoTextbox";
            this.letoTextbox.Size = new System.Drawing.Size(134, 20);
            this.letoTextbox.TabIndex = 6;
            // 
            // trenerTextbox
            // 
            this.trenerTextbox.Location = new System.Drawing.Point(157, 105);
            this.trenerTextbox.Name = "trenerTextbox";
            this.trenerTextbox.Size = new System.Drawing.Size(134, 20);
            this.trenerTextbox.TabIndex = 7;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(40, 142);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(251, 23);
            this.dodajButton.TabIndex = 8;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nazaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajEkipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.trenerTextbox);
            this.Controls.Add(this.letoTextbox);
            this.Controls.Add(this.mestoTextbox);
            this.Controls.Add(this.imeTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dodajEkipo";
            this.Text = "Dodaj ekipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imeTextbox;
        private System.Windows.Forms.TextBox mestoTextbox;
        private System.Windows.Forms.TextBox letoTextbox;
        private System.Windows.Forms.TextBox trenerTextbox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button button1;
    }
}