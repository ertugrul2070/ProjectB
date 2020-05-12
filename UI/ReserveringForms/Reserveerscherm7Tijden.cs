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
    public partial class Reserveerscherm7Tijden : Form
    {

        public Reserveerscherm7Tijden()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (cbCity.SelectedIndex > -1 && cbDate.SelectedIndex > -1 && cbTime.SelectedIndex > -1)
            {
                Program._ReservationSession.CurrentReservation.AddPlaceDateTime(cbCity.Text, cbDate.Text, cbTime.Text);

                Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Zorg aub dat u alles geselecteerd heeft.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
