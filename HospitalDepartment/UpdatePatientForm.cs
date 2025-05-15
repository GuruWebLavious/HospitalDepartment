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
using System.Xml.Linq;

namespace HospitalDepartment
{
    public partial class UpdatePatientForm : Form
    {
        private Form patientWorkForm;
        private Patient _patient;
        public UpdatePatientForm(Form patientWorkForm, Patient patient)
        {
            InitializeComponent();
            this.patientWorkForm = patientWorkForm;
            this._patient = patient;

            idChangeDataPatientBox.Text = _patient.Id.ToString();
            surnameChangeDataPatientBox.Text = _patient.Surname;
            nameChangeDataPatientBox.Text = _patient.Name;
            patronymicChangeDataPatientBox.Text = _patient.Patronymic;
            genderChangeDataPatientBox.Text = _patient.Gender;
            ageChangeDataPatientBox.Text = _patient.Age.ToString();
            diagnosisChangeDataPatientBox.Text = _patient.Diagnosis;
            treatment_statusChangeDataPatientBox.Text = _patient.Status;
            idDoctorChangeDataPatientBox.Text = _patient.doctor_patient == 0 ? "" : Convert.ToString(_patient.doctor_patient);
        }

        private void UpdatePatientForm_Load(object sender, EventArgs e)
        {

        }

        private void changePatientDataBackButton_Click(object sender, EventArgs e)
        {
            patientWorkForm.Show();
            this.Close();
        }

        private void changePatientDataButton_Click(object sender, EventArgs e)
        {
            int? doctorId = null;
            string doctorIdText = idDoctorChangeDataPatientBox.Text.Trim();
            if (!string.IsNullOrEmpty(doctorIdText) && int.TryParse(doctorIdText, out int parsedDoctorId))
            {
                doctorId = parsedDoctorId;
            }
            string[] columns = { "surname", "name", "patronymic", "gender", "age", "diagnosis", "treatment_status", "doctor_id" };

            object[] values = {
                surnameChangeDataPatientBox.Text,
                nameChangeDataPatientBox.Text,
                patronymicChangeDataPatientBox.Text,
                genderChangeDataPatientBox.Text,
                Convert.ToInt32(ageChangeDataPatientBox.Text),
                diagnosisChangeDataPatientBox.Text,
                treatment_statusChangeDataPatientBox.Text,
                doctorId ?? (object)DBNull.Value 
            };
            try
            {
                DBWorkSQL.Update("patient", "id", _patient.Id, columns, values);

                MessageBox.Show("Данные пациента успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _patient.Surname = surnameChangeDataPatientBox.Text;
                _patient.Name = nameChangeDataPatientBox.Text;
                _patient.Patronymic = patronymicChangeDataPatientBox.Text;
                _patient.Gender = genderChangeDataPatientBox.Text;
                _patient.Age = Convert.ToInt32(ageChangeDataPatientBox.Text);
                _patient.Diagnosis = diagnosisChangeDataPatientBox.Text;
                _patient.Status = treatment_statusChangeDataPatientBox.Text;
                if (int.TryParse(idDoctorChangeDataPatientBox.Text, out int doctorID))
                {
                    _patient.doctor_patient = doctorID;
                }
                else
                {
                    _patient.doctor_patient = 0; 
                }

                PatientWorkForm patientWorkForm = new PatientWorkForm(_patient);
                patientWorkForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
