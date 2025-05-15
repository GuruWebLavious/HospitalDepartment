using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDepartment
{
    public partial class CreatePatientForm : Form
    {
        private Form patientInDBForm;
        public CreatePatientForm(Form patientInDBForm)
        {
            InitializeComponent();
            this.patientInDBForm = patientInDBForm;
        }

        private void createPatientBackButton_Click(object sender, EventArgs e)
        {
            patientInDBForm.Show();
            this.Close();   
        }

        private void createPatientButton_Click(object sender, EventArgs e)
        {
            if (surnameCreatePatientBox.Text == "" || nameCreatePatientBox.Text == "" || patronymicCreatePatientBox.Text == "" || genderCreatePatientBox.Text == "" || ageCreatePatientBox.Text == "")
            {
                MessageBox.Show("Необходимо заполнить каждое поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Patient newPatient = new Patient(surnameCreatePatientBox.Text.Trim(), nameCreatePatientBox.Text.Trim(), patronymicCreatePatientBox.Text.Trim(), genderCreatePatientBox.Text.Trim(), int.Parse(ageCreatePatientBox.Text.Trim()));

                int newID = DBWorkSQL.Insert("patient", new string[] { "surname", "name", "patronymic", "gender", "age", "diagnosis", "treatment_status", "doctor_id" },
                    new object[] { newPatient.Surname, newPatient.Name, newPatient.Patronymic, newPatient.Gender, newPatient.Age, newPatient.Diagnosis, newPatient.Status, null });

                newPatient.Id = newID;

                PatientWorkForm patientWorkForm = new PatientWorkForm(newPatient);
                patientWorkForm.Show();
                this.Hide();
            }
        }
    }
}
