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
    public partial class Overzicht : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        public int Soon_movies = 0;

        public Overzicht()
        {
            InitializeComponent();
        }

        private void Overzicht_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.cnn.Open();

                string getMoviesQuery = "SELECT * FROM mydb.movies";
                MySqlCommand command = new MySqlCommand(getMoviesQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    
                    string name = dataReader.GetString("name");
                    string cover = dataReader.GetString("cover");

                    int id = Convert.ToInt32(dataReader.GetString("idmovies"));
                    DateTime date = dataReader.GetDateTime("releaseDate");
                    DateTime today = DateTime.Today;

                    if (Soon_movies == 0)
                    {
                        if (date > today.AddMonths(-1) && date < today)
                        {
                            PictureBox l = addlabel(name, cover, id);
                            filmPanel1.Controls.Add(l);
                            l.Click += new System.EventHandler(this.labelClick);
                        }
                    } else
                    {
                        if (date > today)
                        {
                            PictureBox l = addlabel(name, cover, id);
                            filmPanel1.Controls.Add(l);
                            l.Click += new System.EventHandler(this.labelClick);
                        }
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
            Binn_lb.Click += new EventHandler(BinnenkortLB_Click);
            Nu_lb.Click += new EventHandler(NuLB_Click);
        }

        void BinnenkortLB_Click(object sender, EventArgs e)
        {
            Nu_lb.BackColor = Color.Transparent;
            Nu_lb.ForeColor = Color.Black;

            Soon_movies = 1;
            filmPanel1.Controls.Clear();
            Overzicht_Load(sender, e);

            Binn_lb.BackColor = Color.Red;
            Binn_lb.ForeColor = Color.White;
           
        }
        void NuLB_Click(object sender, EventArgs e)
        {

            Binn_lb.BackColor = Color.Transparent;
            Binn_lb.ForeColor = Color.Black;

            Soon_movies = 0;
            filmPanel1.Controls.Clear();
            Overzicht_Load(sender, e);

            Nu_lb.BackColor = Color.Red;
            Nu_lb.ForeColor = Color.White;
        }

        public static string chosenName = "";
        public static string chosenPic = "";
        public static string chosenId = "";
        
        private void labelClick(object sender, EventArgs e)
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
            l.Margin = new Padding(13);

            return l;
        }

        private void Films_Knop_Click(object sender, EventArgs e)
        {
            Homepage nextForm = new Homepage();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void filmPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PopcornPlaza_Logo_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void filmPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
