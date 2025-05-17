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
    public partial class ExportDataForm : Form
    {
        private Form mainForm;
        public ExportDataForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ExportDataForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExportBackButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxExport.Text == "")
                {
                    MessageBox.Show("Пожалуйста, выберите формат экспорта (Excel или HTML).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ExportExcelradioButton.Checked)
                {
                    if (comboBoxExport.Text== "Пациенты")
                    {
                        DBWorkSQL.ExportToExcel("patient");
                    }
                    if (comboBoxExport.Text == "Врачи")
                    {
                        DBWorkSQL.ExportToExcel("doctor");
                    }
                    if (comboBoxExport.Text == "Встречи")
                    {
                        DBWorkSQL.ExportToExcel("appointment");
                    }
                    
                }
                else if (ExportHTMLradioButton.Checked)
                {
                    if (comboBoxExport.Text == "Пациенты")
                    {
                        DBWorkSQL.ExportToHTML("patient");
                    }
                    if (comboBoxExport.Text == "Врачи")
                    {
                        DBWorkSQL.ExportToHTML("doctor");
                    }
                    if (comboBoxExport.Text == "Встречи")
                    {
                        DBWorkSQL.ExportToHTML("appointment");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите формат экспорта (Excel или HTML).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
