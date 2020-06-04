using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Engine.ViewModels;
namespace UI
{
    public partial class Reserveerscherm3Stoelen : Form
    {
        DatabaseConnection dbcr = Program.dbc;
        public int Amount = 0;
        public List<string> seats = new List<string>();
        string greyPersonIcon = "https://i.imgur.com/8gjqlK3.png";
        string greenPersonIcon = "https://i.imgur.com/G5KLPoO.png";
        string redPersonIcon = "https://i.imgur.com/F2olJZ5.png";
        List<string> takenSeats = new List<string>();

        public Reserveerscherm3Stoelen()
        {
            InitializeComponent();
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;
            
        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Program._ReservationSession.CurrentReservation.TicketAmount == Amount)
            {
                Program._ReservationSession.CurrentReservation.AddSeats(seats);
                Reserveerscherm4Snacks nextForm = new Reserveerscherm4Snacks();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show($"U heeft {Amount} stoelen gekozen, u moet er {Program._ReservationSession.CurrentReservation.TicketAmount} kiezen");
            }
        }

        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Schermtekst_Click(object sender, EventArgs e)
        {

        }

        private void S1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
       

        private void Reserveerscherm3Stoelen_Load(object sender, EventArgs e)
        {
            label18.Text = "";
            label19.Text = "";
            int normal = 0, elder = 0, child = 0;
            double normalD = 0.0, elderD = 0.0, childD = 0.0;
            foreach( KeyValuePair<string, double> kvp in Program._ReservationSession.CurrentReservation.ticketDictionary )
            {
                if(kvp.Value == 12.00)
                {
                    normal++;
                    normalD+= 12.0;
                }
                else if (kvp.Value == 8.00)
                {
                    elder++;
                    elderD += 8.00;

                }
                else if (kvp.Value == 6.00)
                {
                    child++;
                    childD += 6.00;
                }

            }
            if(normal > 0)
            {
                label18.Text += $"Normaal:\n";
                label19.Text += $"{normalD}\n";
            }
            if (child > 0)
            {
                label18.Text += $"Kind:\n";
                label19.Text += $"{child}\n";
            }
            if (elder > 0)
            {
                label18.Text += $"Ouder:\n";
                label19.Text += $"{elder}\n";
            }
            label22.Text = Program._ReservationSession.CurrentReservation.date;
            label24.Text = Program._ReservationSession.CurrentReservation.time;
            label25.Text = $"Totaal aantal tickets: {Program._ReservationSession.CurrentReservation.TicketAmount}";


            try
            {
                dbcr.cnn.Open();
                string selectQuery = $"SELECT * FROM mydb.seat WHERE idseat IN (SELECT seats_idseats FROM mydb.cinemahall WHERE movie_time_idmovie_time = (SELECT idmovie_time FROM mydb.movie_time WHERE movie_idmovie = '{Program._ReservationSession.CurrentReservation.MovieId}' AND date = '{Program._ReservationSession.CurrentReservation.date}'))";
                MySqlCommand command = new MySqlCommand(selectQuery, dbcr.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.Read())
                {
                    string seat = dataReader.GetString("seat");
                    takenSeats.Add(seat);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbcr.cnn.Close();
            }
            var pics = new PictureBox[] { A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, E1, E2, E3, E4, E5, E6, E7, E8, E9, E10 };
            Dictionary<PictureBox, string> dictionary = new Dictionary<PictureBox, string>();
            foreach (PictureBox c in pics)
            {
                c.ImageLocation = greyPersonIcon;
                foreach(string s in takenSeats)
                {
                    if(c.Name == s)
                    {
                        c.ImageLocation = redPersonIcon;
                    }
                }
            }
            
            for (int i = 0; i < pics.Length; i++)
            {
                if(i < 10)
                {
                    dictionary.Add(pics[i], ("A" + (i + 1)));
                }
                else if(i < 20)
                {
                    dictionary.Add(pics[i], ("B" + (i + 1)));
                }
                else if (i < 30)
                {
                    dictionary.Add(pics[i], ("C" + (i + 1)));
                }
                else if (i < 40)
                {
                    dictionary.Add(pics[i], ("D" + (i + 1)));
                }
                else if (i < 50)
                {
                    dictionary.Add(pics[i], ("E" + (i + 1)));
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            PictureBox pic = (PictureBox)sender;
            if (pic.ImageLocation != redPersonIcon)
            {


                if (pic.ImageLocation == greenPersonIcon)
                {
                    pic.ImageLocation = greyPersonIcon;
                    seats.Remove(pic.Name);
                    Amount--;
                }
                else if (Amount >= Program._ReservationSession.CurrentReservation.TicketAmount)
                {
                    MessageBox.Show($"U heeft al {Program._ReservationSession.CurrentReservation.TicketAmount} stoelen geselecteerd.");
                }
                else
                {
                    pic.ImageLocation = greenPersonIcon;
                    seats.Add(pic.Name);
                    Amount++;
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
