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
    public partial class Reserveerscherm6Bevestiging : Form
    {
        public Reserveerscherm6Bevestiging()
        {
            InitializeComponent();
            InitializeLabels();
        }

 

        private void Reserveerscherm6Bevestiging_Load(object sender, EventArgs e)
        {

        }

        

        private void Next_Click(object sender, EventArgs e)
        {
            Program._ReservationSession.CurrentReservation.ReservationToDatabase();
            this.Close();
        }

        private void InitializeLabels()
        {
            var rand = new Random();
            int zaal = rand.Next(1, 11);
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;

            lblFilm.Text = Program._ReservationSession.CurrentReservation.movie;
            lblTijd.Text = Program._ReservationSession.CurrentReservation.time;
            lblZaal.Text = $"Zaal {Program._ReservationSession.CurrentReservation.zaal}";
            lblStoelen.Text = String.Join(", ", Program._ReservationSession.CurrentReservation.Seats.Values.ToArray());
            lblExtra.Text = String.Join(",\n",Program._ReservationSession.CurrentReservation.chosenSnacks.ToArray());
        }

        private void pbMovie_Click(object sender, EventArgs e)
        {
            
        }

        private void Thanks_Click(object sender, EventArgs e)
        {

        }
    }
}
