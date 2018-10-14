namespace liga
{
    partial class Login
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
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.gesloTextbox = new System.Windows.Forms.TextBox();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uporabniško ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geslo:";
            // 
            // userTextbox
            // 
            this.userTextbox.Location = new System.Drawing.Point(130, 30);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(155, 20);
            this.userTextbox.TabIndex = 2;
            // 
            // gesloTextbox
            // 
            this.gesloTextbox.Location = new System.Drawing.Point(130, 60);
            this.gesloTextbox.Name = "gesloTextbox";
            this.gesloTextbox.Size = new System.Drawing.Size(155, 20);
            this.gesloTextbox.TabIndex = 3;
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(28, 95);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(257, 23);
            this.prijavaButton.TabIndex = 4;
            this.prijavaButton.Text = "Prijavi se!";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click_1);
            // 
            // registracijaButton
            // 
            this.registracijaButton.Location = new System.Drawing.Point(28, 125);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(257, 23);
            this.registracijaButton.TabIndex = 5;
            this.registracijaButton.Text = "Registriraj se!";
            this.registracijaButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 166);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.gesloTextbox);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.TextBox gesloTextbox;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Button registracijaButton;
    }
}