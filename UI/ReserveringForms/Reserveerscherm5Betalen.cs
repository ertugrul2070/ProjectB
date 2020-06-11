using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Reserveerscherm5Betalen : Form
    {
        public Reserveerscherm5Betalen()
        {
            InitializeComponent();
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;

        }

        private void Next_Click(object sender, EventArgs e)
        {

            char[] chars = NameField.Text.ToCharArray();

            if (SurnameField.Text == "" || NameField.Text == "" || dagBox.Text == "" || maandBox.Text == "" || jaarBox.Text == "")
            {
                MessageBox.Show("Vul alle velden in AUB.");
            }

            else if (SurnameField.Text.Length < 13 || SurnameField.Text.Length > 19)
            {
                MessageBox.Show("Uw pasnummer moet tussen de 13 en 19 tekens zijn.");
            }
            else if (NameField.Text.Length != 3 || (chars[0] < '0' || chars[0] > '9') || (chars[1] < '0' || chars[1] > '9') || (chars[2] < '0' || chars[2] > '9'))
            {
                MessageBox.Show("Uw CVV nummer moet 3 cijfers hebben.");
            }


            else
            {
                Program._ReservationSession.CurrentReservation.ReservationToDatabase();

                Reserveerscherm6Bevestiging nextForm = new Reserveerscherm6Bevestiging();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }

        }

        private void SurnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enkel nummers 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void jaarBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerscherm4Snacks nextForm = new Reserveerscherm4Snacks();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
