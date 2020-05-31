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
    public partial class AdminMain : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        List<string> CountGenres = new List<string>();
        List<string> CountGenders = new List<string>();
        public AdminMain()
        {
            InitializeComponent();
            for (int i = 1; i < 7; i++)
            {
                string selectQuery = "SELECT COUNT(genre_idgenre) FROM mydb.movies WHERE genre_idgenre = " + i;
                try
                {
                    dbc.cnn.Open();


                    MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string genreName = dataReader.GetString("COUNT(genre_idgenre)");
                        CountGenres.Add(genreName);
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

            pieChart1.Titles.Add("Film Genres");

            pieChart1.Series["Pie1"].Points.AddXY("Science Fiction", CountGenres[0]);
            pieChart1.Series["Pie1"].Points.AddXY("Adventure", CountGenres[1]);
            pieChart1.Series["Pie1"].Points.AddXY("Horror", CountGenres[2]);
            pieChart1.Series["Pie1"].Points.AddXY("Comedy", CountGenres[3]);
            pieChart1.Series["Pie1"].Points.AddXY("Fantasy", CountGenres[4]);
            pieChart1.Series["Pie1"].Points.AddXY("Romance", CountGenres[5]);

            var genders = new List<string> { "Man", "Vrouw", "Anders" , "Wil ik niet zeggen"};
            for (int i = 0; i < 4; i++)
            {
                string selectQuery = "SELECT COUNT(idUsers) FROM mydb.customers WHERE gender = '" + genders[i] +"'";
                try
                {
                    dbc.cnn.Open();


                    MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                    MySqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string gender = dataReader.GetString("COUNT(idUsers)");
                        CountGenders.Add(gender);
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
            int cGen = 0;
            pieChart2.Titles.Add("Gebruiker geslacht");
            foreach (string gender in genders)
            {
                pieChart2.Series["Pie2"].Points.AddXY(gender, CountGenders[cGen]);
                cGen++;
            }
            

        }

        private void PaneelBtn_Click(object sender, EventArgs e)
        {
            selectPanel.Height = PaneelBtn.Height - 25;
            selectPanel.Top = PaneelBtn.Top + 11;
        }

        private void GebruikersBtn_Click(object sender, EventArgs e)
        {
            selectPanel.Height = GebruikersBtn.Height - 25;
            selectPanel.Top = GebruikersBtn.Top + 11;
        }

        private void FilmsBtn_Click(object sender, EventArgs e)
        {
            selectPanel.Height = FilmsBtn.Height - 25;
            selectPanel.Top = FilmsBtn.Top + 11;
        }

        private void SnacksBtn_Click(object sender, EventArgs e)
        {
            selectPanel.Height = SnacksBtn.Height - 25;
            selectPanel.Top = SnacksBtn.Top + 15;
        }
    }
}
