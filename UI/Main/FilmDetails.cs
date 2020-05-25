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
    public partial class FilmDetails : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();

        public string chosenName;
        public string chosenPic;
        public string chosenId;
        public FilmDetails(string filmName,string filmPic, string filmId)
        {
            
            this.chosenName = filmName;
            this.chosenPic = filmPic;
            this.chosenId = filmId;
            InitializeComponent();
        }

        private void FilmDetails_Load(object sender, EventArgs e)
        {
            label1.Text = chosenName;
            pictureBox1.ImageLocation = chosenPic;

            dbc.cnn.Open();

            string getMovieDesc = "SELECT * FROM mydb.movies WHERE name = (SELECT name FROM mydb.movies WHERE idmovies = " + chosenId + ")";
            MySqlCommand command = new MySqlCommand(getMovieDesc, dbc.cnn);

            MySqlDataReader dataReader = command.ExecuteReader();
            List<string> dataList = new List<string>();
            while (dataReader.Read())
            {
                string name = dataReader.GetString("description");
                string link = dataReader.GetString("trailer");
                dataList.Add(name);
                dataList.Add(link);
            }
            label2.Text = dataList[0];
            //YTplayer.Movie = chosenLink;
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"300\" height=\"200\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            this.webBrowser2.DocumentText = string.Format(embed, dataList[1]);
            /* XmlDocument doc = new XmlDocument();
             doc.Load("Films.xml");
             foreach (XmlNode node in doc.DocumentElement)
             {
                 string name = node.Attributes[0].InnerText;
                 foreach (XmlNode child in node.ChildNodes[2])
                 {
                     if (name == chosenName)
                     {
                         label2.Text = child.InnerText;
                     }
                 }
             }*/

            
            

            //label2.Text = getMoviesQuery;

        }

        private void nButton_Click(object sender, EventArgs e)
        {
            Reserveerscherm7Tijden nextForm = new Reserveerscherm7Tijden();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
