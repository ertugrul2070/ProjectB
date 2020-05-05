using System;
using System.IO;
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
    public partial class Reserveerscherm3Stoelen : Form
    {
        public Reserveerscherm3Stoelen()
        {
            InitializeComponent();
        }

        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int abc = Program._ReservationSession.CurrentReservation.ticketDictionary.Count;
            bool check = true;

            int [] cbarray = { CB1.SelectedIndex, CB2.SelectedIndex, CB3.SelectedIndex, CB4.SelectedIndex, CB5.SelectedIndex, CB6.SelectedIndex };


            for (int i = 0; i < abc; i++)
            {
                if (cbarray[i] > -1)
                {
                    check = check && true;

                }

                else
                {
                    check = check && false;
                }
            }

            if (check)
            {

                string[] CB = { CB1.Text, CB2.Text, CB3.Text, CB4.Text, CB5.Text, CB6.Text };

                if (CB.Length != CB.Distinct().Count())
                {
                    MessageBox.Show("U heeft dubbele stoelen gekozen. Kies opnieuw.");
                }


                else
                {
                    Reserveerscherm4Snacks nextForm = new Reserveerscherm4Snacks();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }

            }

            else
            {
                MessageBox.Show("Kies voor elke ticket een stoel.");
            }

            
            
        }

        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Schermtekst_Click(object sender, EventArgs e)
        {

        }

        private void S1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
       

        private void Reserveerscherm3Stoelen_Load(object sender, EventArgs e)
        {
            
            int acb = Program._ReservationSession.CurrentReservation.ticketDictionary.Count;

            switch (acb)
            {
                case 1:
                    CB1.Visible = true;
                    break;

                case 2:
                    CB1.Visible = true;
                    CB2.Visible = true;
                    break;
                case 3:
                    CB1.Visible = true;
                    CB2.Visible = true;
                    CB3.Visible = true;
                    break;
                case 4:
                    CB1.Visible = true;
                    CB2.Visible = true;
                    CB3.Visible = true;
                    CB4.Visible = true;
                    break;
                case 5:
                    CB1.Visible = true;
                    CB2.Visible = true;
                    CB3.Visible = true;
                    CB4.Visible = true;
                    CB5.Visible = true;
                    break;

                default:
                    CB1.Visible = true;
                    CB2.Visible = true;
                    CB3.Visible = true;
                    CB4.Visible = true;
                    CB5.Visible = true;
                    CB6.Visible = true;
                    break;
            }
               
          
        }

       
    }
}
