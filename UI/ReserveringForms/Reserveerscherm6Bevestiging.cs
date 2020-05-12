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
            
            this.Close();
        }

        private void InitializeLabels()
        {
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;

            lblFilm.Text = Program._ReservationSession.CurrentReservation.movie;
            lblTijd.Text = Program._ReservationSession.CurrentReservation.time;
            lblPlaats.Text = Program._ReservationSession.CurrentReservation.location;

        }
    }
}
