using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.ViewModels;
using MySql.Data.MySqlClient;

namespace UI
{

    public partial class Reserveerschem2Tickets : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();

        public Reserveerschem2Tickets()
        {
            InitializeComponent();
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;
            
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
            List<string> dataList = new List<string>();
            try
            {
                dbc.cnn.Open();
                string selectQuery = "SELECT * FROM mydb.movies WHERE name = (SELECT name FROM mydb.movies WHERE idmovies = " + Program._ReservationSession.CurrentReservation.MovieId + ")";
                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                

                while (dataReader.Read())
                {
                    string pegi = dataReader.GetString("pegi");
                    dataList.Add(pegi);
                }
                dbc.cnn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }
            int takenseats = 0;
            try
            {
                dbc.cnn.Open();
                string selectQuery = $"SELECT * FROM mydb.seat WHERE idseat IN (SELECT seats_idseats FROM mydb.cinemahall WHERE movie_time_idmovie_time = (SELECT idmovie_time FROM mydb.movie_time WHERE movie_idmovie = '{Program._ReservationSession.CurrentReservation.MovieId}' AND date = '{Program._ReservationSession.CurrentReservation.date}' AND time_idtime = (SELECT idtime FROM mydb.time WHERE time = '{Program._ReservationSession.CurrentReservation.time}')))";
                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string seat = dataReader.GetString("seat");
                    takenseats++;
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }

            addTickets();

            System.Text.RegularExpressions.Regex regularExpression = new System.Text.RegularExpressions.Regex(@"^[0-6]$");


            if (NormalField.Text == "" && ChildField.Text == "" && BoomerField.Text == "")
            {
                MessageBox.Show("Vul uw aantal tickets in AUB.");
                NormalField.Text = "0";
                ChildField.Text = "0";
                BoomerField.Text = "0";
            }

            else if (NormalField.Text == "" || ChildField.Text == "" || BoomerField.Text == "")
            {
                NormalField.Text = "0";
                ChildField.Text = "0";
                BoomerField.Text = "0";
            }


            else if (!regularExpression.IsMatch(NormalField.Text) || !regularExpression.IsMatch(ChildField.Text) || !regularExpression.IsMatch(BoomerField.Text))
            {
                MessageBox.Show("Kies tussen 1 en 6 tickets.");
            }

            else if((Convert.ToInt32(NormalField.Text) + Convert.ToInt32(ChildField.Text) + Convert.ToInt32(BoomerField.Text)) > 6 ||
                (Convert.ToInt32(NormalField.Text) + Convert.ToInt32(ChildField.Text) + Convert.ToInt32(BoomerField.Text)) < 1)
            {
                MessageBox.Show("Kies tussen 1 en 6 tickets.");
            }


            else if (ChildField.Text != "0" && Convert.ToInt32(dataList[0]) > 12)
            {
                MessageBox.Show("Deze film is niet geschikt voor kinderen.");
            }

            else if((takenseats + Program._ReservationSession.CurrentReservation.TicketAmount) >= 50)
            {
                MessageBox.Show($"Er zijn geen genoeg plekken. Voor deze film zijn er nog {50 - takenseats} over.");
            }

           

            else
            {
                Reserveerscherm3Stoelen nextForm = new Reserveerscherm3Stoelen();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }

           



        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerscherm7Tijden nextForm = new Reserveerscherm7Tijden();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void addTickets()
        {
            Program._ReservationSession.CurrentReservation.ticketDictionary = new Dictionary<string, double>();
            Program._ReservationSession.CurrentReservation.TicketAmount = 0;
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

        private void NormalField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ChildField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BoomerField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }
    }
}
