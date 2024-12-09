using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP
{
    public partial class MainForm : Form
    {
        public string userAccount;
        public MainForm(string user)
        {
            userAccount = user;
            InitializeComponent();



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentUserTextbox.Text = userAccount;
            //MainForm mainform = new MainForm();
            dateTimeLabel.Text = DateTime.Now.ToLongDateString();
            dateTimeLabel2.Text = DateTime.Now.ToShortTimeString();

            List<Patient> list = new List<Patient>();


            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Last Name";
            dataGridView1.Columns[2].Name = "Middle Name";
            dataGridView1.Columns[3].Name = "Sex";
            dataGridView1.Columns[4].Name = "Birth Date";
            dataGridView1.Columns[5].Name = "Vaccine Name";
            dataGridView1.Columns[6].Name = "Date Administered";
            dataGridView1.Columns[7].Name = "Administerd By";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void patientInfoButton_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm(this);
            patientForm.ShowDialog();
        }

        private void vaccinationButton_Click(object sender, EventArgs e)
        {
            VaccinationForm vaccinationForm = new VaccinationForm(this);
            vaccinationForm.ShowDialog();
        }

        private void billingButton_Click(object sender, EventArgs e)
        {
            BillingForm newBillForm = new BillingForm();
            newBillForm.ShowDialog();
        }
    }
}
