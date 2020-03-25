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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchInput.Text != null)
            {
                searchResult.Items.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("Films.xml");

                foreach(XmlNode node in doc.DocumentElement)
                {
                    string name = node.Attributes[0].InnerText;
                    if (name == searchInput.Text)
                    {
                        foreach(XmlNode child in node.ChildNodes)
                        {
                            searchResult.Items.Add(child.InnerText);
                        }
                    }
                }
            } 
            else
            {
                MessageBox.Show("Invalid Input");
                searchInput.Text = string.Empty;
                searchInput.Focus();
            }
        }
    }
}
