using System;
using System.Windows.Forms;
using Engine.Models;
using Engine.ViewModels;


namespace UI
{
    public partial class Reserveerscherm1Gegevens : Form
    {
        public ReservationSession _ReservationSession;
        
        public Reserveerscherm1Gegevens()
        {
            InitializeComponent();
            _ReservationSession = new ReservationSession();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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
            
        }

        private void AddressField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PhonenumberField_TextChanged(object sender, EventArgs e)
        {
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // _ReservationSession.CurrentReservation = new ReservationAdministration();
            _ReservationSession.CurrentReservation.AddCustomer(EmailField.Text, GenderField.Text,NameField.Text,SurnameField.Text,
                AddressField.Text,PostcodeField.Text,CityField.Text, Int32.Parse(PhonenumberField.Text));
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {
        }

        private void SurnameField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PostcodeField_TextChanged(object sender, EventArgs e)
        {
        }

        private void CityField_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PhonenumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}