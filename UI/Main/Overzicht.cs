﻿using System;
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

        public Overzicht()
        {
            InitializeComponent();
        }

        private void Overzicht_Load(object sender, EventArgs e)
        {
            /*XmlDocument doc = new XmlDocument();
            doc.Load("Films.xml");
            int afilm = 0;
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].InnerText;
                var today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                List<string> dataUrl = new List<string>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    dataUrl.Add(child.InnerText);
                    
                }
                var mDate = Convert.ToDateTime(dataUrl[3]);
                if (mDate > today) { 
                PictureBox l = addlabel(afilm, name, dataUrl);
                filmPanel1.Controls.Add(l);
                l.DoubleClick += new System.EventHandler(this.labelDoubleClick);
                afilm = afilm + 1;
                }
            }*/




            

            try
            {
                dbc.cnn.Open();

                string getMoviesQuery = "SELECT * FROM mydb.movies";
                MySqlCommand command = new MySqlCommand(getMoviesQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();
                List<string> str = new List<string>();

                while (dataReader.Read())
                {
                    string name = dataReader.GetString("name");
                    string cover = dataReader.GetString("cover");
                    PictureBox l = addlabel(name, cover);
                    filmPanel1.Controls.Add(l);
                    l.DoubleClick += new System.EventHandler(this.labelDoubleClick);
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
        public static string chosenLink = "";
        
        private void labelDoubleClick(object sender, EventArgs e)
        {
            PictureBox currentlabel = (PictureBox)sender;
            chosenName = currentlabel.Text;
            chosenPic = currentlabel.ImageLocation;
            chosenLink = currentlabel.Name;

            Program._ReservationSession.CurrentReservation.movie = chosenName;
            Program._ReservationSession.CurrentReservation.dataUrl = chosenPic;

            FilmDetails frm2 = new FilmDetails(chosenName,chosenPic, chosenLink);
            frm2.Show();
        }

        PictureBox addlabel(string name, string cover)
        {

            PictureBox l = new PictureBox();
            l.Name = "https://www.youtube.com/embed/BIhNsAtPbPI";
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
    }
}
