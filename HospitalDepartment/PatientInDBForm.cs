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
    public partial class PatientInDBForm : Form
    {
        private Form mainForm;
        public PatientInDBForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void patientInDBBackButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            CreatePatientForm createPatientForm = new CreatePatientForm(this);
            this.Hide();
            createPatientForm.Show();

        }
    }
}
