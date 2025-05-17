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
    }
}
