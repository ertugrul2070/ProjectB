using Engine.ViewModels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace UI
{
    public partial class Loginscherm : Form
    {
        private Reserveerscherm1Gegevens mainform = null;
        
        public bool loggedIn = false;

        DatabaseConnection connection = new DatabaseConnection();

        public Loginscherm(Form callingForm)
        {
            mainform = callingForm as Reserveerscherm1Gegevens;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputtedEmail = txtEmail.Text;
            string inputtedPassword = txtPassword.Text;

            try
            {     
                connection.cnn.Open();

                string query = "SELECT COUNT(*) as account FROM `errowdesign_popcornplaza`.`customers` WHERE email = '" + inputtedEmail +"' AND password = '"+ inputtedPassword +"';";
                MySqlCommand command = new MySqlCommand(query, connection.cnn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32("account") == 1)
                    {
                        loggedIn = true;
                        MessageBox.Show("U bent nu ingelogd!");
                    }
                    else
                    {
                        MessageBox.Show("Gebruiker niet gevonden, probeer een ander wachtwoord of registreer.");
                    }
                }
                reader.Close();

                if (loggedIn)
                {
                    SendUserData(inputtedEmail, inputtedPassword);
                    this.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.cnn.Close();
            }
        }

        public void SendUserData(string email, string password)
        {
            string query = "SELECT * FROM `errowdesign_popcornplaza`.`customers` WHERE email = '" + email + "' AND password = '" + password + "';";
            MySqlCommand command = new MySqlCommand(query, connection.cnn);

            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                this.mainform.firstName = dataReader.GetString("firstName");
                this.mainform.lastName = dataReader.GetString("lastName");
                this.mainform.gender = dataReader.GetString("gender");
                this.mainform.inputAddress = dataReader.GetString("adress");
                this.mainform.zipcode = dataReader.GetString("zipCode");
                this.mainform.city = dataReader.GetString("city");
                this.mainform.phonenumber = dataReader.GetString("phoneNumber");
                this.mainform.email = dataReader.GetString("email");
            }

            connection.cnn.Close();
        }
    }
}
