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
    public partial class Reserveerschem2Tickets : Form
    {
        public Reserveerschem2Tickets()
        {
            InitializeComponent();
        }

        private void City_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Price1_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            Reserveerscherm7Tijden nextForm = new Reserveerscherm7Tijden();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerscherm1Gegevens nextForm = new Reserveerscherm1Gegevens();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
