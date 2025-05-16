namespace HospitalDepartment
{
    partial class MakeAnAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAnAppointmentForm));
            this.AppointmentBackButton = new System.Windows.Forms.Button();
            this.endDateBox = new System.Windows.Forms.TextBox();
            this.startDateBox = new System.Windows.Forms.TextBox();
            this.idDoctorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AppointmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppointmentBackButton
            // 
            this.AppointmentBackButton.BackColor = System.Drawing.Color.PeachPuff;
            this.AppointmentBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppointmentBackButton.Location = new System.Drawing.Point(13, 345);
            this.AppointmentBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentBackButton.Name = "AppointmentBackButton";
            this.AppointmentBackButton.Size = new System.Drawing.Size(172, 59);
            this.AppointmentBackButton.TabIndex = 47;
            this.AppointmentBackButton.Text = "Назад";
            this.AppointmentBackButton.UseVisualStyleBackColor = false;
            this.AppointmentBackButton.Click += new System.EventHandler(this.AppointmentBackButton_Click);
            // 
            // endDateBox
            // 
            this.endDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateBox.Location = new System.Drawing.Point(148, 210);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(195, 30);
            this.endDateBox.TabIndex = 48;
            // 
            // startDateBox
            // 
            this.startDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateBox.Location = new System.Drawing.Point(148, 165);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(195, 30);
            this.startDateBox.TabIndex = 49;
            // 
            // idDoctorBox
            // 
            this.idDoctorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDoctorBox.Location = new System.Drawing.Point(148, 97);
            this.idDoctorBox.Name = "idDoctorBox";
            this.idDoctorBox.Size = new System.Drawing.Size(195, 30);
            this.idDoctorBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID Врача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(34, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Конец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(45, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 34);
            this.label4.TabIndex = 54;
            this.label4.Text = "Назначение встречи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(34, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 72);
            this.label5.TabIndex = 55;
            this.label5.Text = "Подсказка: формат заполнения дат\r\nдолжен быть строго в виде\r\nГГГГ-ММ-ДД ЧЧ:ММ";
            // 
            // AppointmentButton
            // 
            this.AppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppointmentButton.Location = new System.Drawing.Point(238, 345);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(166, 59);
            this.AppointmentButton.TabIndex = 56;
            this.AppointmentButton.Text = "Назначить";
            this.AppointmentButton.UseVisualStyleBackColor = true;
            this.AppointmentButton.Click += new System.EventHandler(this.AppointmentButton_Click);
            // 
            // MakeAnAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(416, 420);
            this.Controls.Add(this.AppointmentButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idDoctorBox);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.AppointmentBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeAnAppointmentForm";
            this.Text = "MakeAnAppointmentForm";
            this.Load += new System.EventHandler(this.MakeAnAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AppointmentBackButton;
        private System.Windows.Forms.TextBox endDateBox;
        private System.Windows.Forms.TextBox startDateBox;
        private System.Windows.Forms.TextBox idDoctorBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AppointmentButton;
    }
}