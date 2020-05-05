using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Reserveerscherm4Snacks : Form
    {
        public Reserveerscherm4Snacks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            Reserveerscherm5Betalen nextForm = new Reserveerscherm5Betalen();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerscherm3Stoelen nextForm = new Reserveerscherm3Stoelen();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
