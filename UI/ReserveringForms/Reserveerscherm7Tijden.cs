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
                string selectQuery = $"SELECT time FROM mydb.time WHERE idtime = (SELECT time_idtime FROM mydb.movie_time WHERE movie_idmovie = '1')";
                MySqlCommand command = new MySqlCommand(selectQuery, dbcr.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string cinema = dataReader.GetString("time");

                    cbTime.Items.Add(cinema.Remove(cinema.Length - 3));
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

            cbDate.Value = DateTime.Today;
            cbDate.MinDate = DateTime.Today;
            cbDate.MaxDate = DateTime.Today.AddDays(7);
        }

        void Fillcombo()
        {
            
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
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }


        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Reserveerscherm7Tijden_Load(object sender, EventArgs e)
        {

        }
    }
}
