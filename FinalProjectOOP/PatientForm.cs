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
    public partial class PatientForm : Form
    {
        MainForm returnMainForm;
        public PatientForm(MainForm theMainForm)
        {
            InitializeComponent();
            this.returnMainForm = theMainForm;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient(firstNameTextbox.Text, midNameTextbox.Text, 
                lastNameTextbox.Text, sexComboBox.Text,birthdateTimePicker.Value);

            

            returnMainForm.dataGridView1.Rows.Add(
                newPatient.FirstName,
                newPatient.LastName,
                newPatient.MiddleName,
                newPatient.Sex,
                newPatient.BirthDate
                );
            //error -- fixed need to add initialize columns forst
            
            //tester
            //MessageBox.Show(newPatient.BirthDate.ToShortDateString());

            
        }
    }
}
