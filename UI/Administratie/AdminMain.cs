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
using MySqlX.XDevAPI.Relational;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI.Administratie
{
    public partial class AdminMain : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        
        
        public AdminMain()
        {
            InitializeComponent();

            PaneelBtn_Click(null, new EventArgs());

        }
        bool c1exists = false;
        bool c2exists = false;
        private void PaneelBtn_Click(object sender, EventArgs e)
        {
            
            selectPanel.Height = PaneelBtn.Height - 25;
            selectPanel.Top = PaneelBtn.Top + 11;

            pieChart1.Visible = true;
            panelPanel.Visible = true;
            pieChart2.Visible = true;
            containerPanele.Controls.Clear();
            containerPanele.Height = 224;
            containerPanele.Width = 539;
            containerPanele.Top = 225;
            containerPanele.Left = 206;

            //Load data for chart 1
            List<string> CountGenres = new List<string>();
            var genres = new List<string> { "Science Fiction", "Adventure", "Horror", "Comedy", "Fantasy", "Romance" };
            
            if (pieChart2.Series["Pie2"].Points.Count() > 0)
            {
                c1exists = true;
            }   
            else
            {

                for (int i = 1; i < 7; i++)
            {

                string selectQueryyyy = "SELECT COUNT(genre_idgenre) FROM mydb.movies WHERE genre_idgenre = " + i;
                try
                {
                    dbc.cnn.Open();
                    
                    MySqlCommand command = new MySqlCommand(selectQueryyyy, dbc.cnn);

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
            
            
            FillChart("Genres", "Pie1",CountGenres, genres, pieChart1, c1exists);
            }


            //Load data for chart 2
            var genders = new List<string> { "Man", "Vrouw", "Anders", "Wil ik niet zeggen" };
            List<string> CountGenders = new List<string>();
            if (pieChart2.Series["Pie2"].Points.Count() > 0)
            {
                c2exists = true;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    string selectQueryy = "SELECT COUNT(idUsers) FROM mydb.customers WHERE gender = '" + genders[i] + "'";
                    try
                    {
                        dbc.cnn.Open();

                        MySqlCommand command = new MySqlCommand(selectQueryy, dbc.cnn);
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
                FillChart("Geslacht", "Pie2", CountGenders, genders, pieChart2, c2exists);
            }

            //Listview Reservations
            ListView CLW = CreateListView(3, 3, containerPanele.Height, containerPanele.Width);
            CLW.Clear();
            panelPanel.Controls.Add(CLW);

            string selectQuery = "SELECT customers.firstName, customers.lastName, movies.name, movie_time.date, time.time FROM mydb.reservation_zaal " +
            "INNER JOIN mydb.reservations ON mydb.reservation_zaal.reservering_idreservering = mydb.reservations.idreservations " +
            "INNER JOIN mydb.customers ON mydb.reservations.customer_idcustomer = mydb.customers.idUsers " +
            "INNER JOIN mydb.cinemahall ON mydb.reservation_zaal.cinemahall_idcinemahall = mydb.cinemahall.idCinemahall " +
            "INNER JOIN mydb.movie_time ON mydb.cinemahall.movie_time_idmovie_time = mydb.movie_time.idmovie_time " +
            "INNER JOIN mydb.movies ON mydb.movie_time.movie_idmovie = mydb.movies.idmovies " +
            "INNER JOIN mydb.time ON mydb.movie_time.time_idtime = mydb.time.idtime";

            List<string> pFirstName = new List<string>();
            List<string> pLastName = new List<string>();
            List<string> pName = new List<string>();
            List<string> pDate = new List<string>();
            List<string> time = new List<string>();
            try
            {
                dbc.cnn.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                int custCount = 0;
                while (dataReader.Read())
                {
                    string fn = dataReader.GetString("firstName");
                    string ln = dataReader.GetString("lastName");
                    string nm = dataReader.GetString("name");
                    DateTime dt = Convert.ToDateTime(dataReader.GetString("date"));
                    string tm = dataReader.GetString("time");
                    pFirstName.Add(fn);
                    pLastName.Add(ln);
                    pName.Add(nm);
                    pDate.Add(dt.ToString("yyyy-MM-dd"));
                    time.Add(tm);
                    custCount++;
                }

                CLW.Columns.Add("Naam", 200);
                CLW.Columns.Add("AchterNaam", 200);
                CLW.Columns.Add("FilmNaam", 200);
                CLW.Columns.Add("Datum", 200);
                CLW.Columns.Add("Reserveer Tijd", 200);

                for (int i = 0; i < custCount; i++)
                {
                    ListViewItem item = new ListViewItem(pFirstName[i]);
                    item.SubItems.Add(pLastName[i]);
                    item.SubItems.Add(pName[i]);
                    item.SubItems.Add(pDate[i]);
                    item.SubItems.Add(time[i]);
                    CLW.Items.Add(item);
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
            
            selectPanel.Height = GebruikersBtn.Height - 25;
            selectPanel.Top = GebruikersBtn.Top + 11;

            pieChart1.Visible = false;
            panelPanel.Visible = false;
            pieChart2.Visible = false;
            containerPanele.Controls.Clear();
            containerPanele.Height = 537;
            containerPanele.Width = 539;
            containerPanele.Top = 11;
            containerPanele.Left = 206;


            ListView CLW = CreateListView(3, 3, containerPanele.Height, containerPanele.Width);

            CLW.Clear();
            containerPanele.Controls.Add(CLW);

            string selectQuery = "SELECT * FROM mydb.customers";

            List<string> cName = new List<string>();
            List<string> cLast = new List<string>();
            List<string> cGender = new List<string>();
            List<string> cEmail = new List<string>();
            try
            {
                dbc.cnn.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);
                
                MySqlDataReader dataReader = command.ExecuteReader();
                int custCount = 0;
                while (dataReader.Read())
                {
                    string custName = dataReader.GetString("firstName");
                    string custLastName = dataReader.GetString("lastName");
                    string gender = dataReader.GetString("gender");
                    string email = dataReader.GetString("email");
                    cName.Add(custName);
                    cLast.Add(custLastName);
                    cGender.Add(gender);
                    cEmail.Add(email); 
                    custCount++;
                }

                CLW.Columns.Add("Naam", 200);
                CLW.Columns.Add("Achternaam", 200);
                CLW.Columns.Add("Geslacht", 200);
                CLW.Columns.Add("Email", 200);

                for (int i = 0; i < custCount; i++)
                {   
                    ListViewItem item = new ListViewItem(cName[i]);
                    item.SubItems.Add(cLast[i]);
                    item.SubItems.Add(cGender[i]);
                    item.SubItems.Add(cEmail[i]);
                    CLW.Items.Add(item);
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

        private void FilmsBtn_Click(object sender, EventArgs e)
        {   
            selectPanel.Height = FilmsBtn.Height - 25;
            selectPanel.Top = FilmsBtn.Top + 11;
            pieChart1.Visible = false;
            panelPanel.Visible = false;
            pieChart2.Visible = false;
            containerPanele.Controls.Clear();
            containerPanele.Height = 537;
            containerPanele.Width = 539;
            containerPanele.Top = 11;
            containerPanele.Left = 206;
            ListView CLW = CreateListView(3, 3, containerPanele.Height, containerPanele.Width);
            containerPanele.Controls.Add(CLW);

            string selectQuery = "SELECT * FROM mydb.movies INNER JOIN mydb.Genre ON mydb.movies.genre_idgenre=mydb.Genre.idgenre;";

            List<string> mName = new List<string>();
            List<string> mReleaseDate = new List<string>();
            List<string> mPegi = new List<string>();
            List<string> mGenre = new List<string>();
            try
            {
                dbc.cnn.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                int custCount = 0;
                while (dataReader.Read())
                {
                    string movName = dataReader.GetString("name");
                    DateTime movReleaseDate = Convert.ToDateTime(dataReader.GetString("releaseDate"));
                    string movPegi = dataReader.GetString("pegi");
                    string movGenre = dataReader.GetString("genreName");
                    mName.Add(movName);
                    mReleaseDate.Add(movReleaseDate.ToString("yyyy-MM-dd"));
                    mPegi.Add(movPegi);
                    mGenre.Add(movGenre);
                    custCount++;
                }

                CLW.Columns.Add("Naam", 200);
                CLW.Columns.Add("Uitgebracht op", 200);
                CLW.Columns.Add("Pegi", 200);
                CLW.Columns.Add("Genre", 200);

                for (int i = 0; i < custCount; i++)
                {
                    ListViewItem item = new ListViewItem(mName[i]);
                    item.SubItems.Add(mReleaseDate[i]);
                    item.SubItems.Add(mPegi[i] + " +");
                    item.SubItems.Add(mGenre[i]);
                    CLW.Items.Add(item);
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

        private void SnacksBtn_Click(object sender, EventArgs e)
        {
            selectPanel.Height = SnacksBtn.Height - 25;
            selectPanel.Top = SnacksBtn.Top + 15;
            pieChart1.Visible = false;
            panelPanel.Visible = false;
            pieChart2.Visible = false;
            containerPanele.Controls.Clear();
            containerPanele.Height = 537;
            containerPanele.Width = 539;
            containerPanele.Top = 11;
            containerPanele.Left = 206;
            ListView CLW = CreateListView(3, 3, containerPanele.Height, containerPanele.Width);
            containerPanele.Controls.Add(CLW);

            string selectQuery = "SELECT * FROM mydb.snackcatelogus";

            List<string> sName = new List<string>();
            List<string> sPrice = new List<string>();
            List<string> sType = new List<string>();
            try
            {
                dbc.cnn.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                int custCount = 0;
                while (dataReader.Read())
                {
                    string snacName = dataReader.GetString("name");
                    string snacPrice = dataReader.GetString("prijs");
                    string snacType = dataReader.GetString("type");
                    sName.Add(snacName);
                    sPrice.Add(snacPrice);
                    sType.Add(snacType);
                    custCount++;

                }

                CLW.Columns.Add("Naam", 200);
                CLW.Columns.Add("Prijs", 200);
                CLW.Columns.Add("Type", 200);

                for (int i = 0; i < custCount; i++)
                {
                    ListViewItem item = new ListViewItem(sName[i]);
                    item.SubItems.Add(sPrice[i]);
                    item.SubItems.Add(sType[i]);
                    CLW.Items.Add(item);
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

            ListView CreateListView(int top, int left, int Height, int Width)
        {
            ListView lv1 = new ListView();

            lv1.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            lv1.Location = new Point(top, left);
            lv1.Name = "custData";
            lv1.Size = new Size(Width - 20, Height - 20);
            lv1.View = View.Details;
            lv1.FullRowSelect = true;
            lv1.BackColor = Color.FromArgb(46, 45, 41);
            lv1.BorderStyle = BorderStyle.None;
            lv1.ForeColor = Color.White;

            return lv1;
        }

        Panel CreatePanel(int height, int width, int left, int top, string name)
        {
            Panel pnl = new Panel();

            pnl.Name = name;
            pnl.Size = new Size(height, width);
            pnl.Location = new Point(top, left);
            pnl.BackColor = Color.FromArgb(46, 45, 41);

            return pnl;
        }

        private void FillChart(string Chartnaam, string serieName,  List<string> value, List<string> title, Chart var, bool exists)
        {
   
            if (!exists)
                {   
                    var.Titles.Add(Chartnaam);
                int cGen = 0;
                foreach (string val in value)
                {
                    var.Series[serieName].Points.AddXY(title[cGen], val);
                    cGen++;
                }
            }
            else
            {
                var.Series[serieName].Points.AddXY("", "");
            }
        }

        private void LoguitBtn_Click(object sender, EventArgs e)
        {
            Overzicht nextForm = new Overzicht();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void addMovie_Click(object sender, EventArgs e)
        {

            AdminAddFilms nextForm = new AdminAddFilms();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
