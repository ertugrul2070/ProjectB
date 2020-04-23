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
    public partial class FilmDetails : Form
    {
        public string chosenName;
        public string chosenPic;
        public string chosenTrailer;
        public FilmDetails(string filmName,string filmPic)
        {
            
            this.chosenName = filmName;
            this.chosenPic = filmPic;
            InitializeComponent();
        }

        private void FilmDetails_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>"+
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>"+
                        "</head><body>" +
                        "<iframe width=\"300\" height=\"200\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/CpzbJ7OdXcA?start=192";
            this.webBrowser1.DocumentText = string.Format(embed, url);
            label1.Text = chosenName;
            pictureBox1.ImageLocation = chosenPic;
            XmlDocument doc = new XmlDocument();
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
            }
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            Reserveerscherm1Gegevens nextForm = new Reserveerscherm1Gegevens();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
