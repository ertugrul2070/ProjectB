using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Engine.ViewModels;
using MySql.Data.MySqlClient;

namespace UI
{
    public partial class Homepage : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        public Homepage()
        {
            InitializeComponent();
        }

        public void Homepage_Load(object sender, EventArgs e)
        {
            var today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            try
            { 

                flowLayoutPanelActueel.Controls.Clear();
                flowLayoutPanelVerwacht.Controls.Clear();
                dbc.cnn.Open();

                string getMoviesQuery = "SELECT * FROM mydb.movies";
                MySqlCommand command = new MySqlCommand(getMoviesQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                List<string> str = new List<string>();
                
                while (dataReader.Read())
                {
                    string name = dataReader.GetString("name");
                    string cover = dataReader.GetString("cover");
                    int id = Convert.ToInt32(dataReader.GetString("idmovies"));
                    DateTime released = dataReader.GetDateTime("releaseDate");
                    int genreid = dataReader.GetInt32("genre_idgenre");
                    PictureBox l = addlabel(name, cover, id);
                    if (genreCheck(genreid) || GenreFilter.SelectedIndex == 0 || GenreFilter.SelectedItem == null)
                    {
                        if (today >= released)
                        {
                            flowLayoutPanelActueel.Controls.Add(l);
                        }
                        else
                        {
                            flowLayoutPanelVerwacht.Controls.Add(l);
                        }
                        l.Click += new System.EventHandler(this.labelClick);
                    }
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
        public static string chosenName = "";
        public static string chosenPic = "";
        public static string chosenId = "";
        public void labelClick(object sender, EventArgs e)
           {
            PictureBox currentlabel = (PictureBox)sender;

            chosenName = currentlabel.Text;
            chosenPic = currentlabel.ImageLocation;
            chosenId = currentlabel.Name;
            Program._ReservationSession.CurrentReservation.AddMovie(chosenName, chosenPic, chosenId);
            
            FilmDetails frm2 = new FilmDetails();
            frm2.Show();

        }

        PictureBox addlabel(string name, string cover, int id)
        {

            PictureBox l = new PictureBox();
            l.Name = id.ToString();
            l.Text = name;
            l.BackColor = Color.Green;
            l.ImageLocation = cover;
            l.Width = 135;
            l.Height = 191;
            l.SizeMode = PictureBoxSizeMode.Zoom;
            //l.Location = new Point(start, end);
            l.Margin = new Padding(13);

            return l;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Films_Knop_Click(object sender, EventArgs e)
        {
            Overzicht nextForm = new Overzicht();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public bool genreCheck(int genre)
        {
            if (genre == GenreFilter.SelectedIndex)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public void SearchFilm_KeyDown(object sender, KeyEventArgs e)
        {
            flowLayoutPanelSearch.Controls.Clear();
            flowLayoutPanelSearch.Visible = false;
            if (e.KeyCode == Keys.Enter && SearchFilm.Text != "")
            {              
                Order_Films(flowLayoutPanelSearch, x => false);
                if(flowLayoutPanelSearch.Controls.Count > 0)
                {
                    flowLayoutPanelSearch.Visible = true;
                }
                else
                {
                    flowLayoutPanelSearch.Visible = false;
                }
            }
        }*/        
    }
}