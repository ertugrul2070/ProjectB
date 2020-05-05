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
    public partial class Reserveerschem2Tickets : Form
    {
        public Reserveerschem2Tickets()
        {
            InitializeComponent();
        }

        private void City_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Price1_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            addTickets();

            if (Convert.ToInt32(NormalField.Text) < 0 || Convert.ToInt32(ChildField.Text) < 0 || Convert.ToInt32(BoomerField.Text) < 0)
            {
                MessageBox.Show("Kies aub tussen 1 en 6 tickets.");

               
            }
            
            

            else
            {
                Reserveerscherm7Tijden nextForm = new Reserveerscherm7Tijden();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }

 
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerscherm1Gegevens nextForm = new Reserveerscherm1Gegevens();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void addTickets()
        {

            if (Int32.TryParse(NormalField.Text, out int x))
            {
                for (int i = 1; i <= x; i++)
                {
                    FormattableString IDstring = $"Normal{i}";
                    string IDS = IDstring.ToString();
                    Program._ReservationSession.CurrentReservation.AddTickets(IDS, 12.0);
                }
            }
            if (Int32.TryParse(ChildField.Text, out int y))
            {
                for (int i = 1; i <= y; i++)
                {
                    FormattableString IDstring = $"Child{i}";
                    string IDS = IDstring.ToString();
                    Program._ReservationSession.CurrentReservation.AddTickets(IDS, 6.0);
                }
            }
            if (Int32.TryParse(BoomerField.Text, out int z))
            {
                for (int i = 1; i <= z; i++)
                {
                    FormattableString IDstring = $"Boomer{i}";
                    string IDS = IDstring.ToString();
                    Program._ReservationSession.CurrentReservation.AddTickets(IDS, 8.0);
                }
            }

        }

        private void Information_Click(object sender, EventArgs e)
        {

        }
    }
}
