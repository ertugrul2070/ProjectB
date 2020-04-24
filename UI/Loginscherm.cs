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

        DatabaseConnection connection = new DatabaseConnection();

        public Loginscherm(Form callingForm)
        {
            mainform = callingForm as Reserveerscherm1Gegevens;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SendUserData();

            string inputtedEmail = txtEmail.Text;
            string inputtedPassword = txtPassword.Text;

            try
            {     
                connection.cnn.Open();

                string command = "SELECT COUNT(*) as account FROM `customers`.`custromers` WHERE email = '@email' AND password = '@password';";

                MySqlCommand com = new MySqlCommand(command, connection.cnn);
                com.Parameters.AddWithValue("@email", inputtedEmail);
                com.Parameters.AddWithValue("@password", inputtedPassword);

                MySqlDataReader dataReader = com.ExecuteReader();

                while(dataReader.Read())
                {

                    int komtvoor = dataReader.GetInt32("account");

                    if (dataReader.GetInt16(0) == 1)
                    {
                        DialogResult = DialogResult.OK;
                        SendUserData();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login is incorrect");
                    }

                }
                dataReader.Close();
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

        public void SendUserData()
        {
            connection.cnn.Open();

            string command = "SELECT * FROM `customers`.`custromers` WHERE email = '@email' AND password = '@password'; ";
            
            MySqlCommand com = new MySqlCommand(command, connection.cnn);
            com.Parameters.AddWithValue("@email", txtEmail.Text.ToString());
            com.Parameters.AddWithValue("@password", txtPassword.Text.ToString());

            MySqlDataReader dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                this.mainform.firstName = dataReader.GetString("firstName");
                this.mainform.lastName = dataReader.GetString("lastName");
                this.mainform.gender = dataReader.GetString("gender");
                this.mainform.inputAddress = dataReader.GetString("adress");
                this.mainform.zipcode = dataReader.GetString("zipCode");
                this.mainform.city = dataReader.GetString("city");
                this.mainform.phonenumber = dataReader.GetString("phoneNumber");

                string naam = dataReader.GetString("password");
            }

            connection.cnn.Close();
        }
    }
}
