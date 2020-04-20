using System;
using System.Windows.Forms;
using Engine.ViewModels;

namespace UI
{
    public partial class Reserveerscherm1Gegevens : Form
    {
        private ReservationSession _personSession;
        
        public Reserveerscherm1Gegevens()
        {
            InitializeComponent();
            
            _personSession = new ReservationSession();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Naam_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Stad_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void GenderField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentPerson.gender = GenderField.Text;
            
        }

        private void AddressField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentPerson.streetAdress = AddressField.Text;
        }

        private void PhonenumberField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentPerson.phoneNumber = int.Parse(PhonenumberField.Text);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentPerson.city = CityField.Text;
        }

        private void SurnameField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentPerson.surname = SurnameField.Text;
        }

        private void PostcodeField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentPerson.postcode = PostcodeField.Text;
        }

        private void CityField_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {
            _personSession.CurrentCustommer.email = EmailField.Text;

        }

        private void Reserveerscherm1Gegevens_Load(object sender, EventArgs e)
        {

        }
    }
}