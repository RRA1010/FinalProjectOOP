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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            NonMember nonMember = new NonMember();
            


            if(membershipComboBox.SelectedIndex == 0)
            {
                member.VaccinePrice = Convert.ToDecimal(vaccinePriceBox.Text);
                member.PaymentAmount = Convert.ToDecimal(paymentTextbox.Text);

                string change = member.calculatePayment(member.VaccinePrice, member.PaymentAmount);
                changeTextbox.Text = change;
            }
            else
            {

                nonMember.VaccinePrice = Convert.ToDecimal(vaccinePriceBox.Text);
                nonMember.PaymentAmount = Convert.ToDecimal(paymentTextbox.Text);

                string change = nonMember.calculatePayment(nonMember.VaccinePrice, nonMember.PaymentAmount);
                changeTextbox.Text = change;
            }
        }
    }
}
