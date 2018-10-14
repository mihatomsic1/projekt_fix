namespace liga
{
    partial class Form1
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
            this.ekipeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.igralciButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekipeButton
            // 
            this.ekipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ekipeButton.Location = new System.Drawing.Point(65, 60);
            this.ekipeButton.Name = "ekipeButton";
            this.ekipeButton.Size = new System.Drawing.Size(208, 60);
            this.ekipeButton.TabIndex = 0;
            this.ekipeButton.Text = "EKIPE";
            this.ekipeButton.UseVisualStyleBackColor = true;
            this.ekipeButton.Click += new System.EventHandler(this.ekipeButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(355, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "EKIPE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(355, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "EKIPE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // igralciButton
            // 
            this.igralciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.igralciButton.Location = new System.Drawing.Point(65, 144);
            this.igralciButton.Name = "igralciButton";
            this.igralciButton.Size = new System.Drawing.Size(208, 60);
            this.igralciButton.TabIndex = 4;
            this.igralciButton.Text = "IGRALCI";
            this.igralciButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 317);
            this.Controls.Add(this.igralciButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ekipeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekipeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button igralciButton;
    }
}

