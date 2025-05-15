namespace HospitalDepartment
{
    partial class PatientWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientWorkForm));
            this.patientWorkBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.surnameCreatePatientBox = new System.Windows.Forms.TextBox();
            this.nameCreatePatientBox = new System.Windows.Forms.TextBox();
            this.patronymicCreatePatientBox = new System.Windows.Forms.TextBox();
            this.genderCreatePatientBox = new System.Windows.Forms.TextBox();
            this.ageCreatePatientBox = new System.Windows.Forms.TextBox();
            this.diagnosisCreatePatientBox = new System.Windows.Forms.TextBox();
            this.treatmentStatusCreatePatientBox = new System.Windows.Forms.TextBox();
            this.idDoctorCreatePatientBox = new System.Windows.Forms.TextBox();
            this.makeAnAppointmentButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.idPatientCreatePatientBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // patientWorkBackButton
            // 
            this.patientWorkBackButton.BackColor = System.Drawing.Color.PeachPuff;
            this.patientWorkBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientWorkBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientWorkBackButton.Location = new System.Drawing.Point(13, 546);
            this.patientWorkBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.patientWorkBackButton.Name = "patientWorkBackButton";
            this.patientWorkBackButton.Size = new System.Drawing.Size(172, 59);
            this.patientWorkBackButton.TabIndex = 22;
            this.patientWorkBackButton.Text = "На главную";
            this.patientWorkBackButton.UseVisualStyleBackColor = false;
            this.patientWorkBackButton.Click += new System.EventHandler(this.patientWorkBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(216, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Данные пациента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(68, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(96, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(96, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(63, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(76, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(76, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Диагноз";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(64, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "ID Врача";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(8, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Статус лечения";
            // 
            // surnameCreatePatientBox
            // 
            this.surnameCreatePatientBox.Enabled = false;
            this.surnameCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameCreatePatientBox.Location = new System.Drawing.Point(182, 122);
            this.surnameCreatePatientBox.Name = "surnameCreatePatientBox";
            this.surnameCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.surnameCreatePatientBox.TabIndex = 34;
            // 
            // nameCreatePatientBox
            // 
            this.nameCreatePatientBox.Enabled = false;
            this.nameCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCreatePatientBox.Location = new System.Drawing.Point(182, 158);
            this.nameCreatePatientBox.Name = "nameCreatePatientBox";
            this.nameCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.nameCreatePatientBox.TabIndex = 35;
            // 
            // patronymicCreatePatientBox
            // 
            this.patronymicCreatePatientBox.Enabled = false;
            this.patronymicCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicCreatePatientBox.Location = new System.Drawing.Point(182, 194);
            this.patronymicCreatePatientBox.Name = "patronymicCreatePatientBox";
            this.patronymicCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.patronymicCreatePatientBox.TabIndex = 36;
            // 
            // genderCreatePatientBox
            // 
            this.genderCreatePatientBox.Enabled = false;
            this.genderCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderCreatePatientBox.Location = new System.Drawing.Point(182, 245);
            this.genderCreatePatientBox.Name = "genderCreatePatientBox";
            this.genderCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.genderCreatePatientBox.TabIndex = 37;
            // 
            // ageCreatePatientBox
            // 
            this.ageCreatePatientBox.Enabled = false;
            this.ageCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageCreatePatientBox.Location = new System.Drawing.Point(182, 287);
            this.ageCreatePatientBox.Name = "ageCreatePatientBox";
            this.ageCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.ageCreatePatientBox.TabIndex = 38;
            // 
            // diagnosisCreatePatientBox
            // 
            this.diagnosisCreatePatientBox.Enabled = false;
            this.diagnosisCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosisCreatePatientBox.Location = new System.Drawing.Point(182, 328);
            this.diagnosisCreatePatientBox.Name = "diagnosisCreatePatientBox";
            this.diagnosisCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.diagnosisCreatePatientBox.TabIndex = 39;
            // 
            // treatmentStatusCreatePatientBox
            // 
            this.treatmentStatusCreatePatientBox.Enabled = false;
            this.treatmentStatusCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treatmentStatusCreatePatientBox.Location = new System.Drawing.Point(182, 371);
            this.treatmentStatusCreatePatientBox.Name = "treatmentStatusCreatePatientBox";
            this.treatmentStatusCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.treatmentStatusCreatePatientBox.TabIndex = 40;
            // 
            // idDoctorCreatePatientBox
            // 
            this.idDoctorCreatePatientBox.Enabled = false;
            this.idDoctorCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDoctorCreatePatientBox.Location = new System.Drawing.Point(182, 414);
            this.idDoctorCreatePatientBox.Name = "idDoctorCreatePatientBox";
            this.idDoctorCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.idDoctorCreatePatientBox.TabIndex = 41;
            // 
            // makeAnAppointmentButton
            // 
            this.makeAnAppointmentButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeAnAppointmentButton.Location = new System.Drawing.Point(248, 459);
            this.makeAnAppointmentButton.Name = "makeAnAppointmentButton";
            this.makeAnAppointmentButton.Size = new System.Drawing.Size(217, 69);
            this.makeAnAppointmentButton.TabIndex = 42;
            this.makeAnAppointmentButton.Text = "Назначить приём";
            this.makeAnAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePatientButton.Location = new System.Drawing.Point(544, 536);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(171, 69);
            this.deletePatientButton.TabIndex = 43;
            this.deletePatientButton.Text = "Удалить пациента";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updatePatientButton.Location = new System.Drawing.Point(544, 229);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(171, 69);
            this.updatePatientButton.TabIndex = 44;
            this.updatePatientButton.Text = "Изменить данные";
            this.updatePatientButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(96, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "ID";
            // 
            // idPatientCreatePatientBox
            // 
            this.idPatientCreatePatientBox.Enabled = false;
            this.idPatientCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idPatientCreatePatientBox.Location = new System.Drawing.Point(182, 65);
            this.idPatientCreatePatientBox.Name = "idPatientCreatePatientBox";
            this.idPatientCreatePatientBox.Size = new System.Drawing.Size(346, 30);
            this.idPatientCreatePatientBox.TabIndex = 46;
            // 
            // PatientWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(727, 618);
            this.Controls.Add(this.idPatientCreatePatientBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.updatePatientButton);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.makeAnAppointmentButton);
            this.Controls.Add(this.idDoctorCreatePatientBox);
            this.Controls.Add(this.treatmentStatusCreatePatientBox);
            this.Controls.Add(this.diagnosisCreatePatientBox);
            this.Controls.Add(this.ageCreatePatientBox);
            this.Controls.Add(this.genderCreatePatientBox);
            this.Controls.Add(this.patronymicCreatePatientBox);
            this.Controls.Add(this.nameCreatePatientBox);
            this.Controls.Add(this.surnameCreatePatientBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientWorkBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientWorkForm";
            this.Text = "PatientWorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patientWorkBackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox surnameCreatePatientBox;
        private System.Windows.Forms.TextBox nameCreatePatientBox;
        private System.Windows.Forms.TextBox patronymicCreatePatientBox;
        private System.Windows.Forms.TextBox genderCreatePatientBox;
        private System.Windows.Forms.TextBox ageCreatePatientBox;
        private System.Windows.Forms.TextBox diagnosisCreatePatientBox;
        private System.Windows.Forms.TextBox treatmentStatusCreatePatientBox;
        private System.Windows.Forms.TextBox idDoctorCreatePatientBox;
        private System.Windows.Forms.Button makeAnAppointmentButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox idPatientCreatePatientBox;
    }
}