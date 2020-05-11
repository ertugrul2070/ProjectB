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
        public Dictionary<string, double> snackDict = new Dictionary<string, double>();

        public Reserveerscherm4Snacks()
        {
            InitializeComponent();
            UpdateTotaal();
            FillSnackDict();
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
            // stuur de snacklijst door naar reservation administration

            Reserveerscherm1Gegevens nextForm = new Reserveerscherm1Gegevens();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            snacks.Clear();

            Reserveerscherm3Stoelen nextForm = new Reserveerscherm3Stoelen();
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

        private void FillSnackDict()
        {
            snackDict.Add("Popcorn Zoet Klein", 3.5);
            snackDict.Add("Popcorn Zout Klein", 3.5);
            snackDict.Add("Popcorn Mix Klein", 3.5);
            snackDict.Add("Popcorn Zoet Middel", 4.5);
            snackDict.Add("Popcorn Zout Middel", 4.5);
            snackDict.Add("Popcorn Mix Middel", 4.5);
            snackDict.Add("Popcorn Zoet Groot", 5.5);
            snackDict.Add("Popcorn Zout Groot", 5.5);
            snackDict.Add("Popcorn Mix Groot", 5.5);
            snackDict.Add("Cola", 3.5);
            snackDict.Add("Fanta", 3.5);
            snackDict.Add("Water", 2.5);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int snacksAmount = snacks.Count - 1;
            string snackToRemove = snacks[snacksAmount];

            snacks.RemoveAt(snacksAmount);

            double removedSnackPrice;

            if (snackDict.TryGetValue(snackToRemove, out removedSnackPrice))
            {
                totaal -= removedSnackPrice;
            }

            UpdateTotaal();
            UpdateBon();
        }
    }
}
