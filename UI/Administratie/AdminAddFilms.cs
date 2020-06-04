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

namespace UI.Administratie
{
    public partial class AdminAddFilms : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        public AdminAddFilms()
        {
            InitializeComponent();

            string selectQuery = "SELECT * FROM mydb.genre";
            try
            {
                dbc.cnn.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);
                List<string> genreName = new List<string>();
                List<int> genreId = new List<int>();
                MySqlDataReader dataReader = command.ExecuteReader();
                int custCount = 0;
                while (dataReader.Read())
                {
                    string gName = dataReader.GetString("genreName");
                    string gId = dataReader.GetString("idgenre");
                    genreName.Add(gName);
                    genreId.Add(Convert.ToInt32(gId));
                    custCount++;
                }

                for(int i = 0; i < custCount; i++)
                {
                    genreBox.Items.Add(genreName[i]);
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

            string selectQueryy = "SELECT * FROM mydb.time";
            try
            {
                dbc.cnn.Open();

                MySqlCommand command = new MySqlCommand(selectQueryy, dbc.cnn);
                List<string> time = new List<string>();
                List<int> timeId = new List<int>();
                MySqlDataReader dataReader = command.ExecuteReader();
                int x = 0;
                while (dataReader.Read())
                {
                    string t = dataReader.GetString("time");
                    string tId = dataReader.GetString("idtime");
                    time.Add(t);
                    timeId.Add(Convert.ToInt32(tId));
                    x++;
                }

                for (int i = 0; i < x; i++)
                {
                    tijdBox.Items.Add(time[i]);
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
        }

        private void GebruikersBtn_Click(object sender, EventArgs e)
        {
            string name = NameField.Text;
            string genre = getIdValue("genre", "genreName",genreBox.SelectedItem.ToString(), "idgenre"); 
            string time = getIdValue("time", "time", tijdBox.SelectedItem.ToString(), "idtime");
            string cover = coverField.Text;
            string trailer = trailerField.Text;
            string date = releaseDTP.Value.ToString("yyyy-MM-dd");
            string pegi = pegiBox.SelectedItem.ToString();
            string description = descRTB.Text;

            if (!movieExists())
            {
                try
                {
                    dbc.cnn.Open();

                    string queryy = "INSERT INTO `mydb`.`movies` (`name`, `description`, `cover`, `genre_idgenre`, `trailer`, `releaseDate`, `pegi`)"+
                        " VALUES ('" + name + "', '" + description + "', '" + cover + "', '" + genre + "', '" + trailer + "', '" + date + "', '"
                        + pegi + "');";

                    MySqlCommand command = new MySqlCommand(queryy, dbc.cnn);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Film toegevoegd.");
                    }
                    else
                    {
                        MessageBox.Show("Er is iets fout gegaan. Probeer opnieuw.");
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

                string movieId = getIdValue("movies", "name", NameField.Text, "idmovies");

                MessageBox.Show(tijdBox.SelectedItem.ToString());
                MessageBox.Show(time.ToString());


                try
                {
                    dbc.cnn.Open();

                    string query = "INSERT INTO `mydb`.`movie_time` (`movie_idmovie`, `time_idtime`, `date`)" +
                        " VALUES ('" + GetMoviesID() + "', '" + time + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "');";

                    MySqlCommand command = new MySqlCommand(query, dbc.cnn);

                    if (!(command.ExecuteNonQuery() == 1))
                    {
                        MessageBox.Show("Er is iets fout gegaan. Probeer opnieuw.");
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

                exitAfterSave();
            } 
            else
            {
                MessageBox.Show("Deze film bestaat al");
            }
        }

        private bool movieExists()
        {
            bool ex = false;

            try
            {
                dbc.cnn.Open();

                string query = "SELECT name FROM mydb.movies;";

                MySqlCommand command = new MySqlCommand(query, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (NameField.Text == dataReader.GetString("name"))
                    {
                        ex = true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }
            return ex;
        }

        private string getIdValue(string table, string compareRow, string compareInput, string output)
        {
            string value = "";
            try
            {
                dbc.cnn.Open();

                string query = "SELECT * FROM mydb." + table + " WHERE "+ compareRow + " = '"+compareInput+"';";
                
                MySqlCommand command = new MySqlCommand(query, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    value = dataReader.GetString("id"+table);
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
            return value;

        }

        private int GetMoviesID()
        {
            string query = $"SELECT MAX(idmovies) as id FROM mydb.movies;";
            MySqlCommand command = new MySqlCommand(query, dbc.cnn);
            MySqlDataReader dataReader = command.ExecuteReader();

            int id = 0;

            while (dataReader.Read())
            {
                id = (int)dataReader.GetInt32("id");
            }

            dataReader.Close();
            return id;
        }

        private void exitAfterSave()
        {
            AdminMain nextForm = new AdminMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
