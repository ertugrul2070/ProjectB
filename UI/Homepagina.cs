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

namespace UI
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
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
                PictureBox l = addlabel(afilm, name, dataUrl);
                var mDate = Convert.ToDateTime(dataUrl[3]);
                if (mDate < today)
                {
                    flowLayoutPanelActueel.Controls.Add(l);
                }
                else
                {
                    flowLayoutPanelVerwacht.Controls.Add(l);
                }
                l.DoubleClick += new System.EventHandler(this.labelDoubleClick);
                afilm = afilm + 1;
                
                if (flowLayoutPanelActueel.Controls.Count > 5)
                {
                    flowLayoutPanelActueel.AutoScroll = true;
                }
                if (flowLayoutPanelVerwacht.Controls.Count > 5)
                {
                    flowLayoutPanelVerwacht.AutoScroll = true;
                }
            }
        }
        public static string chosenName = "";
        public static string chosenPic = "";

        private void labelDoubleClick(object sender, EventArgs e)
        {
            PictureBox currentlabel = (PictureBox)sender;

            chosenName = currentlabel.Text;
            chosenPic = currentlabel.ImageLocation;

            FilmDetails frm2 = new FilmDetails(chosenName,chosenPic);
            frm2.Show();

        }

        PictureBox addlabel(int i, string name, List<string> dataUrl)
        {

            PictureBox l = new PictureBox();
            l.Name = "pBox" + i.ToString();
            l.Text = name;
            l.BackColor = Color.Green;
            l.ImageLocation = dataUrl[1];
            //l.Width = 135;
            //l.Height = 191;
            l.Size = new System.Drawing.Size(110, 150);
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

        private void SearchFilm_KeyDown(object sender, KeyEventArgs e)
        {
            flowLayoutPanelSearch.Controls.Clear();
            flowLayoutPanelSearch.Visible = false;
            string nameFilm = SearchFilm.Text;
            if (e.KeyCode == Keys.Enter && SearchFilm.Text != "")
            {
                nameFilm = char.ToUpper(nameFilm[0]) + nameFilm.Substring(1);
                Search_Film(nameFilm);
            }
        }

        private void Search_Film(string nameFilm)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Films.xml");
            int afilm = 0;
            foreach (XmlNode node in doc.DocumentElement)
            {
                string naam = node.Attributes[0].InnerText;
                if (naam.Contains(nameFilm))
                {
                    List<string> dataUrl = new List<string>();
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        dataUrl.Add(child.InnerText);
                    }
                    PictureBox l = addlabel(afilm, naam, dataUrl);
                    flowLayoutPanelSearch.Controls.Add(l);
                    l.DoubleClick += new System.EventHandler(this.labelDoubleClick);
                }
            }
            if (flowLayoutPanelSearch.Controls.Count < 1 || nameFilm == "")
            {
                flowLayoutPanelSearch.Controls.Clear();
            } else
            {
                flowLayoutPanelSearch.Visible = true;
            }
        }
    }
}