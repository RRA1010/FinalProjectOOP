using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Patient
    {
        private string firstName;
        private string lastName;
        private string middleName;

        private string sex;
        private DateTime birthDate;

        //here be properties yarr
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value;}
        }

        public Patient (
            string firstname, 
            string middlename, 
            string lastname,
            string sex,
            DateTime birthday
            )
        {
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
            Sex = sex;
            BirthDate = birthday;
        }

        public void patientRegister() 
        {

        }
    }
    public abstract class Vaccination
    {
        /*vaccine name or vaccine brand? much more difficult to think
        how to implement dateadministered
        administeredby Doctor or Nurse, remove na lang category?? kasi addtl.feature
        */
        //shorthand
        public string VaccineName { get; set; }
        public DateTime DateAdministered { get; set; }

        public string AdministeredBy { get; set; }

        public abstract void RecordVaccination();
    }
    /*
    reminder: CONSTRUCTORS are used to initialize objects, hence CONSTRUCTOS are diff w/ Encapsulation
    */
    //16 class per vaccine?
    public class VaccineType : Vaccination
    {
        public VaccineType(string vaccineName, DateTime dateAdministered, string administor) 
        {
            VaccineName = vaccineName;
            DateAdministered = dateAdministered;
            AdministeredBy = administor;

        }
        public override void RecordVaccination()
        {
            
        }
    }


    /* Vaccine List available as per DOH Immunization Program
     * Vaccines                         Disease
     * =======================================================
     * BCG                              Tuberculosis
     * Hepa B                           Hepatitis B
     * OPV(Oral Polio                   Polio
     * IPV(inactivated so injection?    Polio
     * PENTA DPT - HepB, Hib            Diphtheria
     *                                  Tetanus
     *                                  Pertussis
     *                                  Hepatitis B
     *                                  Haemophilus influenzae
     * PCV                              Pneumonia
     * PPV                              Pneumonia
     * MMR                              Measles - Mumps - Rubella
     * MR                               Measles - Rubella
     * Rotavirus                        Rotavirus
     * JE                               Jap. Encephalitis
     * Td                               Tetanus Diphtheria
     * HPV                              Human Papilloma Virus
     * Influenza                        Influenza
     * COVID?                           Covid
     * 
     * == not in DOH file
     * Chickenpox                       Varicella/Chickenpox
     * 
     */

    public abstract class Billing
    {

        public decimal VaccinePrice { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }

        public abstract string calculatePayment(decimal vaccineCost, decimal payment);
    }

    public class Member : Billing
    {
        public override string calculatePayment(decimal vaccineCost, decimal payment) 
        {
            decimal discount = 0.20m;
            decimal totalBill = (discount * vaccineCost) - payment;
            return Convert.ToString(totalBill);
            
        }
    }
    public class NonMember : Billing
    {
        public override string calculatePayment(decimal vaccineCost, decimal payment)
        {
            decimal totalBill = vaccineCost - payment;
            return Convert.ToString(totalBill);
            

        }
    }

}
