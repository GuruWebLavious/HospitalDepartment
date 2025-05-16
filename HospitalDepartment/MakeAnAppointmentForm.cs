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
    public partial class MakeAnAppointmentForm : Form
    {
        private Form patientWorkForm;
        private Patient _patient;
        public MakeAnAppointmentForm(Form patientWorkForm, Patient patient)
        {
            InitializeComponent();
            this.patientWorkForm = patientWorkForm;
            _patient = patient;
        }

        private void MakeAnAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void AppointmentBackButton_Click(object sender, EventArgs e)
        {
            patientWorkForm.Show();
            this.Close();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {

            string doctorIdText = idDoctorBox.Text.Trim();
            string startTimeText = startDateBox.Text.Trim();
            string endTimeText = endDateBox.Text.Trim();

            if (string.IsNullOrEmpty(doctorIdText) ||
                string.IsNullOrEmpty(startTimeText) ||
                string.IsNullOrEmpty(endTimeText))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(doctorIdText, out int doctorId))
            {
                MessageBox.Show("Неверный формат ID врача.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParseExact(startTimeText, "yyyy-MM-dd HH:mm", null,
                    System.Globalization.DateTimeStyles.None, out DateTime start))
            {
                MessageBox.Show("Неверный формат времени начала. Используйте 'yyyy-MM-dd HH:mm'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParseExact(endTimeText, "yyyy-MM-dd HH:mm", null,
                    System.Globalization.DateTimeStyles.None, out DateTime end))
            {
                MessageBox.Show("Неверный формат времени окончания. Используйте 'yyyy-MM-dd HH:mm'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            start = new DateTime(start.Year, start.Month, start.Day, start.Hour, start.Minute, 0);
            end = new DateTime(end.Year, end.Month, end.Day, end.Hour, end.Minute, 0);

            Doctor selectedDoctor = DBWorkSQL.GetDoctorById(doctorId);
            if (selectedDoctor == null)
            {
                MessageBox.Show("Врач с таким ID не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = DBWorkSQL.AddMeeting(_patient.Id, doctorId, start, end);

            if (success)
            {
                MessageBox.Show("Встреча успешно назначена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                patientWorkForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось назначить встречу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
