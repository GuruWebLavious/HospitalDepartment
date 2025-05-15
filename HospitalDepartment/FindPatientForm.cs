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
    public partial class FindPatientForm : Form
    {
        private Form patientInDBForm;
        private int currentPage = 0;
        private int pageSize = 10;
        public FindPatientForm(Form patientInDBForm)
        {
            InitializeComponent();
            this.patientInDBForm = patientInDBForm;
        }

        private void FindPatientForm_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateNavigationButtons();
        }
        public void LoadData()
        {
            try
            {
                List<List<string>> list_list = DBWorkSQL.Select_n_k("patient", pageSize, currentPage);

                dataGridViewPatient.Rows.Clear();
                dataGridViewPatient.Columns.Clear();

                foreach (string ss in list_list[0])
                {
                    dataGridViewPatient.Columns.Add(ss, ss);
                }

                bool skip1 = false;
                foreach (List<string> list in list_list)
                {
                    if (skip1)
                    {
                        string[] v = new string[list.Count];
                        int k = 0;
                        foreach (string ss in list)
                        {
                            v[k] = ss;
                            k++;
                        }
                        dataGridViewPatient.Rows.Add(v);
                    }
                    skip1 = true;
                }

                dataGridViewPatient.AutoResizeColumns();
                dataGridViewPatient.AutoResizeRows();
                dataGridViewPatient.Width = dataGridViewPatient.RowHeadersWidth
                    + dataGridViewPatient.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 24;
                dataGridViewPatient.Height = Math.Min(dataGridViewPatient.ColumnHeadersHeight
                    + dataGridViewPatient.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 32, 400);
                dataGridViewPatient.Refresh();

                if (dataGridViewPatient.Left + dataGridViewPatient.Width + 32 > Width)
                    Width += dataGridViewPatient.Left + dataGridViewPatient.Width + 32 - Width;
                if (dataGridViewPatient.Top + dataGridViewPatient.Height + 64 > Height)
                    Height += dataGridViewPatient.Top + dataGridViewPatient.Height + 64 - Height;

                curPagePatient.Text = (currentPage + 1).ToString();
            }
            catch (Exception ex) { MessageBox.Show("Error!\n" + ex.Message); }
        }
        private void UpdateNavigationButtons()
        {

            PreviousPagePatient.LinkVisited = (currentPage == 0);

            int totalRows = DBWorkSQL.GetTotalRows("patient");
            int totalPages = (int)Math.Ceiling((double)totalRows / pageSize);

            // Отключаем кнопку "Следующая страница", если текущая страница == последняя
            NextPagePatient.LinkVisited = (currentPage >= totalPages - 1);

            PreviousPagePatient.Enabled = currentPage > 0;
            NextPagePatient.Enabled = currentPage < totalPages - 1;
        }

        private void findPatientBackButton_Click(object sender, EventArgs e)
        {
            patientInDBForm.Show();
            this.Close();
        }

        private void PreviousPagePatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadData();
                UpdateNavigationButtons();
            }
        }

        private void NextPagePatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int totalRows = DBWorkSQL.GetTotalRows("patient");
            int totalPages = (int)Math.Ceiling((double)totalRows / pageSize);

            if (currentPage < totalPages - 1)
            {
                currentPage++; 
                LoadData();    
                UpdateNavigationButtons(); 
            }
        }

        private void choosePatientButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите пациента из таблицы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewPatient.SelectedRows[0];

            // Извлекаем данные из ячеек
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string surname = selectedRow.Cells["surname"].Value?.ToString();
            string name = selectedRow.Cells["name"].Value?.ToString();
            string patronymic = selectedRow.Cells["patronymic"].Value?.ToString();
            string gender = selectedRow.Cells["gender"].Value?.ToString();
            int age = Convert.ToInt32(selectedRow.Cells["age"].Value);
            string diagnosis = selectedRow.Cells["diagnosis"].Value?.ToString();
            string status = selectedRow.Cells["treatment_status"].Value?.ToString();
            int doctorId = Convert.ToInt32(selectedRow.Cells["doctor_id"].Value);

            Patient selectedPatient = new Patient(id, surname, name, patronymic, gender, age, diagnosis, status, doctorId);

            PatientWorkForm patientForm = new PatientWorkForm(selectedPatient);
            patientForm.Show();
            this.Hide(); 
        }
    }
}
