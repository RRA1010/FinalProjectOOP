using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP
{
    public partial class VaccinationForm : Form
    {
        MainForm returnMainForm;

        public VaccinationForm(MainForm mainForm)
        {
            InitializeComponent();
            this.returnMainForm = mainForm;
        }

        private void vaccination_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            VaccineType vaccinationInfo = new VaccineType(vaccineTypeComboBox.Text,vaccineDateTimePicker.Value,administerComboBox.Text);

            returnMainForm.dataGridView1.Rows.Add(
                vaccinationInfo.VaccineName,vaccinationInfo.DateAdministered, vaccinationInfo.AdministeredBy);

            //TEST
            MessageBox.Show(vaccinationInfo.VaccineName,
                vaccinationInfo.AdministeredBy);
        }
    }
}
