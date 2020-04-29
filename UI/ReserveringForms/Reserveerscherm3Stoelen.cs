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
            Reserveerscherm4Snacks nextForm = new Reserveerscherm4Snacks();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
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
        
        ComboBox addCB(int i)
        {
            List<string> dataUrl = new List<string>();


            
            ComboBox l = new ComboBox();
            l.Name = "DD" + i.ToString();
            l.Margin = new Padding(6);
            l.Height = 21;
            l.Width = 40;
            l.DropDownStyle = ComboBoxStyle.DropDownList;
            l.DataSource = dataUrl;


            return l;
        }

        private void Reserveerscherm3Stoelen_Load(object sender, EventArgs e)
        {

           
            


            int acb = Program._ReservationSession.CurrentReservation.ticketDictionary.Count;

            for (int i = acb; i > 0; i--)
            {
                ComboBox l = addCB(i);
                DD_loop.Controls.Add(l);
            }              
               
          
        }

       
    }
}
