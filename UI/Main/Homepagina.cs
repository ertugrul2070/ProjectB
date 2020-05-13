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

        public void Homepage_Load(object sender, EventArgs e)
        {
            var today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            flowLayoutPanelActueel.Controls.Clear();
            flowLayoutPanelVerwacht.Controls.Clear();
            Order_Films(flowLayoutPanelActueel, x => x < today);
            Order_Films(flowLayoutPanelVerwacht, x => x > today);          
        }
        public void Order_Films(FlowLayoutPanel label, Func<DateTime, bool> f)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Films.xml");
            int afilm = 0;
            foreach (XmlNode node in doc.DocumentElement)
            {
                string naam = node.Attributes[0].InnerText;
                List<string> dataUrl = new List<string>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    dataUrl.Add(child.InnerText);
                }
                var mDate = Convert.ToDateTime(dataUrl[3]);
                bool comp = false;
                if (label == flowLayoutPanelSearch)
                {
                    comp = naam.Contains(SearchFilm.Text.ToUpper());
                }
                Console.WriteLine("HAHA bongalonga");
                Console.WriteLine(dataUrl[5]);
                bool GenreFilt = ((string)GenreFilter.SelectedItem == dataUrl[5]);
                if (GenreFilter.SelectedItem == null ||(string)GenreFilter.SelectedItem == "Alle")
                {
                    GenreFilt = true;
                }
                if (f(mDate) &&  GenreFilt || comp)
                { 
                    PictureBox l = addlabel(afilm, naam, dataUrl);
                    label.Controls.Add(l);
                    l.DoubleClick += new System.EventHandler(this.labelDoubleClick);
                }
                if (label.Controls.Count > 5)
                {
                    label.AutoScroll = true;
                }
            }
        }
        public void labelDoubleClick(object sender, EventArgs e)
           {
            string chosenName = "";
            string chosenPic = "";
            string chosenLink = "";
            PictureBox currentlabel = (PictureBox)sender;

            chosenName = currentlabel.Text;
            chosenPic = currentlabel.ImageLocation;
            chosenLink = currentlabel.Name;

            FilmDetails frm2 = new FilmDetails(chosenName,chosenPic,chosenLink);
            frm2.Show();

        }

        public PictureBox addlabel(int i, string name, List<string> dataUrl)
        {

            PictureBox l = new PictureBox();
            l.Name = dataUrl[4];
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

        public void SearchFilm_KeyDown(object sender, KeyEventArgs e)
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
        }        
    }
}