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
    public partial class PatientWorkForm : Form
    {
        private Form createPatientForm;
        public PatientWorkForm(Form createPatientForm)
        {
            InitializeComponent();
            this.createPatientForm = createPatientForm;
        }

        private void patientWorkBackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
