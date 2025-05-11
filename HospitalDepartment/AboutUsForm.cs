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
    public partial class AboutUsForm : Form
    {
        private Form mainForm;
        public AboutUsForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void aboutUsBackButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
