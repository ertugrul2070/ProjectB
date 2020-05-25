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
        public int Amount = 0;
        string greyPersonIcon = "https://i.imgur.com/8gjqlK3.png";
        string greenPersonIcon = "https://i.imgur.com/7QQILej.png";
        string redPersonIcon = "https://i.imgur.com/ts4EBwu.png";
        public Reserveerscherm3Stoelen()
        {
            InitializeComponent();
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;
            
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
        
       

        private void Reserveerscherm3Stoelen_Load(object sender, EventArgs e)
        {
            PictureBox[] pics = {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, 
                pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18,
                pictureBox19,pictureBox20,pictureBox21,pictureBox22,pictureBox23,pictureBox24,pictureBox25,pictureBox26,pictureBox27,
                pictureBox28,pictureBox29,pictureBox30,pictureBox31,pictureBox32,pictureBox33,pictureBox34,pictureBox35,pictureBox36,
                pictureBox37,pictureBox38,pictureBox39,pictureBox40,pictureBox41,pictureBox42,pictureBox43,pictureBox44,pictureBox45,pictureBox46,pictureBox47,pictureBox48,pictureBox49,pictureBox50};
            foreach(PictureBox c in pics)
            {
                c.ImageLocation = greyPersonIcon;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            

            if (pic.ImageLocation == greenPersonIcon)
            {
                pic.ImageLocation = greyPersonIcon;
                Amount--;
            }
            else if (Amount >= Program._ReservationSession.CurrentReservation.TicketAmount)
            {
                MessageBox.Show($"U heeft al {Program._ReservationSession.CurrentReservation.TicketAmount} besteld ");
            }
            else
            {
                pic.ImageLocation = greenPersonIcon;
                Amount++;
            }
        }
    }
}
