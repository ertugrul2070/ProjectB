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
        public FilmDetails()
        {
            InitializeComponent();
        }

        private void FilmDetails_Load(object sender, EventArgs e)
        {
            label1.Text = Overzicht.chosenName;
            pictureBox1.ImageLocation = Overzicht.chosenPic;
            XmlDocument doc = new XmlDocument();
            doc.Load("Films.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].InnerText;
                foreach (XmlNode child in node.ChildNodes[2])
                {
                    if (name == Overzicht.chosenName)
                    {
                        label2.Text = child.InnerText;
                    }
                }
            }
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            Form3 nextForm = new Form3();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
