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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekipeButton = new System.Windows.Forms.Button();
            this.igralciButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekipeButton
            // 
            this.ekipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ekipeButton.Location = new System.Drawing.Point(65, 111);
            this.ekipeButton.Name = "ekipeButton";
            this.ekipeButton.Size = new System.Drawing.Size(208, 60);
            this.ekipeButton.TabIndex = 0;
            this.ekipeButton.Text = "EKIPE";
            this.ekipeButton.UseVisualStyleBackColor = true;
            this.ekipeButton.Click += new System.EventHandler(this.ekipeButton_Click);
            // 
            // igralciButton
            // 
            this.igralciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.igralciButton.Location = new System.Drawing.Point(65, 199);
            this.igralciButton.Name = "igralciButton";
            this.igralciButton.Size = new System.Drawing.Size(208, 60);
            this.igralciButton.TabIndex = 4;
            this.igralciButton.Text = "IGRALCI";
            this.igralciButton.UseVisualStyleBackColor = true;
            this.igralciButton.Click += new System.EventHandler(this.igralciButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "LIGA NAJJAČA";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(302, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "TEKMOVANJA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.igralciButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ekipeButton);
            this.Name = "Form1";
            this.Text = "GLAVNA STRAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekipeButton;
        private System.Windows.Forms.Button igralciButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

