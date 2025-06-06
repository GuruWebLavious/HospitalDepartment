﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDepartment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutForm = new AboutUsForm(this);
            this.Hide();
            aboutForm.Show();
        }

        private void acceptThePatientButton_Click(object sender, EventArgs e)
        {
            PatientInDBForm patientInDBForm = new PatientInDBForm(this);
            this.Hide();
            patientInDBForm.Show();
        }

        private void exportDataButton_Click(object sender, EventArgs e)
        {
            ExportDataForm exportDataForm = new ExportDataForm(this);
            this.Hide();
            exportDataForm.Show();
        }
    }
}
