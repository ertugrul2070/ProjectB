﻿using System;
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
    public partial class Reserveerscherm7Tijden : Form
    {

        public List<string> cinemaList = new List<string>();
        public List<DateTime> dateLis = new List<DateTime>();


        public Reserveerscherm7Tijden()
        {
            InitializeComponent();
            fillBoxes();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            Reserveerscherm3Stoelen nextForm = new Reserveerscherm3Stoelen();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void fillBoxes()
        {
            //Vul de combobexes met juiste plekken en tijden voor de gekozen film
        }
    }
}