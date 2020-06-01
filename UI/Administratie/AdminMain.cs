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
        List<string> CountGenres = new List<string>();
        List<string> CountGenders = new List<string>();
        public AdminMain()
        {
            InitializeComponent();

            PaneelBtn_Click(null, new EventArgs());

        }

        private void PaneelBtn_Click(object sender, EventArgs e)
        {
            
            selectPanel.Height = PaneelBtn.Height - 25;
            selectPanel.Top = PaneelBtn.Top + 11;

            containerPanel.Controls.Clear();

            Panel p1 = CreatePanel(268, 218, 3, 3, "panelPie1");
            Panel p2 = CreatePanel(268, 218, 3, 277, "panelPie2");

            containerPanel.Controls.Add(p1);
            containerPanel.Controls.Add(p2);

            //Load data for chart 1
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
            var genres = new List<string> { "Science Fiction", "Adventure", "Horror", "Comedy", "Fantasy", "Romance" };
            Chart c1 = CreateChart(262, 207, 3, 3, "pieChart1", "Pie1", CountGenres, genres);
            c1.Parent = p1;

            //Load data for chart 2
            var genders = new List<string> { "Man", "Vrouw", "Anders", "Wil ik niet zeggen" };
            for (int i = 0; i < 4; i++)
            {
                string selectQuery = "SELECT COUNT(idUsers) FROM mydb.customers WHERE gender = '" + genders[i] + "'";
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
            Chart c2 = CreateChart(262, 207, 3, 3, "pieChart2", "Pie2", CountGenders, genders);
            c2.Parent = p2;
            c2.Show();
        }

        private void GebruikersBtn_Click(object sender, EventArgs e)
        {
            
            selectPanel.Height = GebruikersBtn.Height - 25;
            selectPanel.Top = GebruikersBtn.Top + 11;
            panelPie1.Visible = false;
            panelPie2.Visible = false;
            panelChart.Visible = false;
            containerPanel.Controls.Clear();
            ListView CLW = CreateListView(containerPanel.Height, containerPanel.Width);
            CLW.Clear();
            containerPanel.Controls.Add(CLW);

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
            panelPie1.Visible = false;
            panelPie2.Visible = false;
            panelChart.Visible = false;
            containerPanel.Controls.Clear();
            ListView CLW = CreateListView(containerPanel.Height, containerPanel.Width);
            containerPanel.Controls.Add(CLW);

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
                    string movReleaseDate = dataReader.GetString("releaseDate");
                    string movPegi = dataReader.GetString("pegi");
                    string movGenre = dataReader.GetString("genreName");
                    mName.Add(movName);
                    mReleaseDate.Add(movReleaseDate);
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
            panelPie1.Visible = false;
            panelChart.Visible = false;
            panelPie2.Visible = false;
            containerPanel.Controls.Clear();
            ListView CLW = CreateListView(containerPanel.Height, containerPanel.Width);
            containerPanel.Controls.Add(CLW);

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

            ListView CreateListView(int Height, int Width)
        {
            ListView lv1 = new ListView();

            lv1.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            lv1.Location = new Point(3, 3);
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

        Chart CreateChart(int height, int width, int left, int top, string name, string serieName,  List<string> value, List<string> title)
        {
            Chart chrt = new Chart();

            chrt.Name = name;
            chrt.Titles.Add("aaaaaaaaaaaaaaaaaaaa");
            chrt.Size = new Size(height, width);
            chrt.Location = new Point(top, left);
            chrt.Series.Add(serieName);
            chrt.Series[serieName].ChartType = SeriesChartType.Pie;
            chrt.Series[serieName].SetDefault(true);
            chrt.Series[serieName].Enabled = true;
            chrt.Visible = true;

            int cGen = 0;
            foreach (string val in value)
            {
                chrt.Series[serieName].Points.AddXY(title[cGen], val);
                cGen++;
            }
            

            return chrt;
        }
    }
}
