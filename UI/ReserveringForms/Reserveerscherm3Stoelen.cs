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
        public Dictionary<string, string> seats = new Dictionary<string, string>();
        string greyPersonIcon = "https://i.imgur.com/8gjqlK3.png";
        string greenPersonIcon = "https://i.imgur.com/G5KLPoO.png";
        string redPersonIcon = "https://i.imgur.com/ts4EBwu.png";

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
            Program._ReservationSession.CurrentReservation.AddSeats(seats);
            Reserveerscherm4Snacks nextForm = new Reserveerscherm4Snacks();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
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
            /*try
            {
                dbcr.cnn.Open();
                string selectQuery = $"SELECT * FROM mydb.seats WHERE idseats = (SELECT seats_idseats FROM mydb.cinemahall WHERE movie_time_idmovie_time = (SELECT idmovie_time FROM mydb.movie_time WHERE movie_idmovie = '{Program._ReservationSession.CurrentReservation.MovieId}'))";
                MySqlCommand command = new MySqlCommand(selectQuery, dbcr.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string row = dataReader.GetString("row");
                    string number = dataReader.GetString("number");
                    MessageBox.Show(row + number);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbcr.cnn.Close();
            }*/
            var pics = new PictureBox[] { A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, E1, E2, E3, E4, E5, E6, E7, E8, E9, E10 };
            Dictionary<PictureBox, string> dictionary = new Dictionary<PictureBox, string>();
            foreach (PictureBox c in pics)
            {
                c.ImageLocation = greyPersonIcon;
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
                seats.Add(pic.Name, pic.Name);
                Amount++;
            }
        }
    }
}
