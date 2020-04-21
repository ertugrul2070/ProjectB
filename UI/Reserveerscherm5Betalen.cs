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
    public partial class Reserveerscherm5Betalen : Form
    {
        public Reserveerscherm5Betalen()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Reserveerscherm7Tijden nextForm = new Reserveerscherm7Tijden();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
