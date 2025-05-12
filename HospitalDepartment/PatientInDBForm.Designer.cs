namespace HospitalDepartment
{
    partial class PatientInDBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInDBForm));
            this.label1 = new System.Windows.Forms.Label();
            this.patientInDBBackButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(113, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пациент есть в БД?";
            // 
            // patientInDBBackButton
            // 
            this.patientInDBBackButton.BackColor = System.Drawing.Color.PeachPuff;
            this.patientInDBBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientInDBBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientInDBBackButton.Location = new System.Drawing.Point(13, 290);
            this.patientInDBBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.patientInDBBackButton.Name = "patientInDBBackButton";
            this.patientInDBBackButton.Size = new System.Drawing.Size(172, 59);
            this.patientInDBBackButton.TabIndex = 20;
            this.patientInDBBackButton.Text = "Назад";
            this.patientInDBBackButton.UseVisualStyleBackColor = false;
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesButton.Location = new System.Drawing.Point(22, 142);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(213, 69);
            this.yesButton.TabIndex = 21;
            this.yesButton.Text = "Да";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noButton.Location = new System.Drawing.Point(261, 142);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(217, 69);
            this.noButton.TabIndex = 22;
            this.noButton.Text = "Нет";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // PatientInDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(508, 362);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.patientInDBBackButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientInDBForm";
            this.Text = "PatientInDBForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patientInDBBackButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}