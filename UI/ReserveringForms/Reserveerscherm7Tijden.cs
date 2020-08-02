using Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using MySql.Data.MySqlClient;


namespace UI
{

    public partial class Reserveerscherm7Tijden : Form
    {
        DatabaseConnection dbcr = Program.dbc;
        public Reserveerscherm7Tijden()
        {
            InitializeComponent();
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;

            
            try
            {
                dbcr.cnn.Open();
                string selectQuery = $"SELECT date FROM mydb.movie_time WHERE movie_idmovie = '{Program._ReservationSession.CurrentReservation.MovieId}'";
                MySqlCommand command = new MySqlCommand(selectQuery, dbcr.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                List<string> date = new List<string>();
                while (dataReader.Read())
                {
                    DateTime cinema = dataReader.GetDateTime("date");
                    if(DateTime.Now < cinema)
                    {
                        date.Add(cinema.ToString("yyyy-MM-dd"));
                    }
                }
                date = date.Distinct().ToList();
                foreach (string t in date)
                {
                    cbDate.Items.Add(t);
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
        
        }


        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Next_Click(object sender, EventArgs e)
        {
            if (cbTime.SelectedIndex > -1)
            {
                Program._ReservationSession.CurrentReservation.AddPlaceDateTime(cbDate.Text, cbTime.Text);

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
            FilmDetails nextForm = new FilmDetails();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reserveerscherm7Tijden_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTime.Items.Clear();
            cbTime.Text = "";
            try
            {
                dbcr.cnn.Open();
                string selectQuery = $"SELECT time FROM mydb.time WHERE idtime IN (SELECT time_idtime FROM mydb.movie_time WHERE movie_idmovie = '{Program._ReservationSession.CurrentReservation.MovieId}' AND date = '{cbDate.Text}')";
                MySqlCommand command = new MySqlCommand(selectQuery, dbcr.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                List<string> time = new List<string>();
                while (dataReader.Read())
                {
                    string cinema = dataReader.GetString("time");
                    time.Add(cinema);
                }
                foreach (string t in time)
                {
                    cbTime.Items.Add(t.Remove(t.Length - 3));
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
        }

        private void cbDate_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
