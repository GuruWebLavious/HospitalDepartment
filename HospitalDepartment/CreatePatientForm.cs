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
            PatientWorkForm patientWorkForm = new PatientWorkForm(this);
            this.Hide();
            patientWorkForm.Show();
        }
    }
}
