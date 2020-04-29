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
        public List<string> snacks = new List<string>();
        public double totaal;

        public Reserveerscherm4Snacks()
        {
            InitializeComponent();
            UpdateTotaal();
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
            snacks.Clear();

            Reserveerscherm5Betalen nextForm = new Reserveerscherm5Betalen();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Toevoegen1_Click(object sender, EventArgs e)
        {
            if (Soort1.SelectedIndex > -1)
            {
                string snack = "Popcorn " + Soort1.Text + " Klein";
                AddSnackToList(snack);
                totaal += 3.5;
                UpdateTotaal();
                UpdateBon();
            }
            else
            {
                MessageBox.Show("Kies een smaak");
            }
        }

        private void Toevoegen2_Click(object sender, EventArgs e)
        {
            if (Soort2.SelectedIndex > -1)
            {
                string snack = "Popcorn " + Soort3.Text + " Middel";
                AddSnackToList(snack);
                totaal += 4.5;
                UpdateTotaal();
                UpdateBon();
            }
            else
            {
                MessageBox.Show("Kies een smaak");
            }
        }

        private void Toevoegen3_Click(object sender, EventArgs e)
        {
            if (Soort3.SelectedIndex > -1)
            {
                string snack = "Popcorn " + Soort3.Text + " Groot";
                AddSnackToList(snack);
                totaal += 5.5;
                UpdateTotaal();
                UpdateBon();
            }
            else
            {
                MessageBox.Show("Kies een smaak");
            }
        }

        private void Toevoegen4_Click(object sender, EventArgs e)
        {
            AddSnackToList("Cola");
            totaal += 3.5;
            UpdateTotaal();
            UpdateBon();
        }

        private void Toevoegen5_Click(object sender, EventArgs e)
        {
            AddSnackToList("Fanta");
            totaal += 3.5;
            UpdateTotaal();
            UpdateBon();
        }

        private void Toevoegen6_Click(object sender, EventArgs e)
        {
            AddSnackToList("Water");
            totaal += 2.5;
            UpdateTotaal();
            UpdateBon();
        }

        private void AddSnackToList(string snack)
        {
            snacks.Add(snack);
        }

        private void UpdateTotaal()
        {
            rtbTotaal.Text = "TOTAAL : €" + totaal.ToString("0.##");
        }

        private void UpdateBon()
        {
            rtbBon.Lines = snacks.ToArray();
        }
    }
}
