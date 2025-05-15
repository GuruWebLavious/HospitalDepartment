using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalDepartment
{
    public partial class PatientWorkForm : Form
    {
        private Form createPatientForm;
        private Patient _patient;
        public PatientWorkForm(Form createPatientForm)
        {
            InitializeComponent();
            this.createPatientForm = createPatientForm;
        }
        public PatientWorkForm(Patient patient) : base()
        {
            InitializeComponent();
            _patient = patient;

            idPatientCreatePatientBox.Text = _patient.Id.ToString();
            surnameCreatePatientBox.Text = _patient.Surname;
            nameCreatePatientBox.Text = _patient.Name;
            patronymicCreatePatientBox.Text = _patient.Patronymic;
            genderCreatePatientBox.Text = _patient.Gender;
            ageCreatePatientBox.Text = _patient.Age.ToString();
            diagnosisCreatePatientBox.Text = _patient.Diagnosis;
            treatmentStatusCreatePatientBox.Text = _patient.Status;
            idDoctorCreatePatientBox.Text = _patient.doctor_patient.ToString();
        }
        private void patientWorkBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
