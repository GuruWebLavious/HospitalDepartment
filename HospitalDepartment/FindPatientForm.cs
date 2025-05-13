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
        public FindPatientForm(Form patientInDBForm)
        {
            InitializeComponent();
            this.patientInDBForm = patientInDBForm;
        }

        private void FindPatientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
