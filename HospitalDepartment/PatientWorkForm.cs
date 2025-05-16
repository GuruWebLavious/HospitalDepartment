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
            idDoctorCreatePatientBox.Text = _patient.doctor_patient == 0 ? "" : Convert.ToString(_patient.doctor_patient);
        }
        private void patientWorkBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить пациента {_patient.Surname} {_patient.Name}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DBWorkSQL.Delete("patient", "id", _patient.Id);

                    MessageBox.Show("Пациент успешно удалён из базы данных.", "Удаление выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainForm mainform = new MainForm();
                    mainform.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении пациента: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            UpdatePatientForm updatePatientForm = new UpdatePatientForm(this, _patient);
            updatePatientForm.Show();
            this.Hide();
        }

        private void makeAnAppointmentButton_Click(object sender, EventArgs e)
        {
            MakeAnAppointmentForm makeAnAppointmentForm = new MakeAnAppointmentForm(this, _patient);
            makeAnAppointmentForm.Show();
            this.Hide();
        }
    }
}
