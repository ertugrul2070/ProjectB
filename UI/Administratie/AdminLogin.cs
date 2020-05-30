using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine.ViewModels;
using MySql.Data.MySqlClient;

namespace UI.Administratie
{
    public partial class AdminLogin : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        private string AdminMail;
        private string AdminPassword;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.cnn.Open();

                string getMoviesQuery = "SELECT * FROM mydb.customers WHERE admin = 1";
                MySqlCommand command = new MySqlCommand(getMoviesQuery, dbc.cnn);
            
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string email = dataReader.GetString("email");
                    string password = dataReader.GetString("password");

                    AdminMail = email;
                    AdminPassword = password;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (adminEmailTB.Text == AdminMail && AdminPasswordTB.Text == AdminPassword)
            {
                AdminMain nextForm = new AdminMain();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            } else
            {
                errorMessage.Visible = true;
            }
        }
    }
}
