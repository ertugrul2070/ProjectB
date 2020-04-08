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
                List<string> dataUrl = new List<string>();
                foreach (XmlNode child in node.ChildNodes)
                {
                    dataUrl.Add(child.InnerText);
                }
                PictureBox l = addlabel(afilm, name, dataUrl);
                flowLayoutPanelActueel.Controls.Add(l);
                l.DoubleClick += new System.EventHandler(this.labelDoubleClick);
                afilm = afilm + 1;
            }
        }
        public static string chosenName = "";
        public static string chosenPic = "";

        private void labelDoubleClick(object sender, EventArgs e)
        {
            PictureBox currentlabel = (PictureBox)sender;

            chosenName = currentlabel.Text;
            chosenPic = currentlabel.ImageLocation;

            FilmDetails frm2 = new FilmDetails();
            frm2.Show();

        }

        PictureBox addlabel(int i, string name, List<string> dataUrl)
        {

            PictureBox l = new PictureBox();
            l.Name = "pBox" + i.ToString();
            l.Text = name;
            l.BackColor = Color.Green;
            l.ImageLocation = dataUrl[1];
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

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Actueel_1_Tekst_Click(object sender, EventArgs e)
        {

        }
    }
}
