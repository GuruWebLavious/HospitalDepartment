namespace HospitalDepartment
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeButton
            // 
            this.welcomeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.welcomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcomeButton.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeButton.Location = new System.Drawing.Point(62, 213);
            this.welcomeButton.Name = "welcomeButton";
            this.welcomeButton.Size = new System.Drawing.Size(294, 47);
            this.welcomeButton.TabIndex = 2;
            this.welcomeButton.Text = "Добро пожаловать!";
            this.welcomeButton.UseVisualStyleBackColor = true;
            this.welcomeButton.Click += new System.EventHandler(this.welcomeButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 306);
            this.Controls.Add(this.welcomeButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button welcomeButton;
    }
}