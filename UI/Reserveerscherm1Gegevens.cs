using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Engine.Models;
using Engine.ViewModels;
using MySql.Data.MySqlClient;

namespace UI
{
    public partial class Reserveerscherm1Gegevens : Form
    {

        DatabaseConnection dbc = new DatabaseConnection();

        List<string> listEmails = new List<string>();
        public string _password;
        public string firstName;
        public string lastName;
        public string gender;
        public string inputAddress;
        public string zipcode;
        public string city;
        public string phonenumber;

        public Reserveerscherm1Gegevens()
        {
            InitializeComponent();
        }
        private void Reserveerscherm1Gegevens_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Naam_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Stad_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void GenderField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddressField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PhonenumberField_TextChanged(object sender, EventArgs e)
        {
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Program._ReservationSession.CurrentReservation.AddCustomer(EmailField.Text, GenderField.Text,NameField.Text,SurnameField.Text,
                AddressField.Text,PostcodeField.Text,CityField.Text, Int32.Parse(PhonenumberField.Text));
            Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void NameField_TextChanged(object sender, EventArgs e)
        {
        }

        private void SurnameField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PostcodeField_TextChanged(object sender, EventArgs e)
        {
        }

        private void CityField_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PhonenumberField_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userEmail = EmailField.Text;

            if (GenderField.Text != "" && NameField.Text != "" && SurnameField.Text != "" && AddressField.Text != "" && PostcodeField.Text != "" && CityField.Text != "" && PhonenumberField.Text != "" && EmailField.Text != "")
            {
                RegisterUser(userEmail);
            }
            else
            {
                MessageBox.Show("Vul alle velden in AUB");
            }
        }

        private bool CheckIfUserExists(string inputEmail)
        {
            try
            {
                dbc.cnn.Open();

                string selectQuery = "SELECT * FROM `customers`.`custromers`";
                MySqlCommand command = new MySqlCommand(selectQuery, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string email = dataReader.GetString("email");

                    listEmails.Add(email);
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

            bool inDatabase = false;



            foreach (string mail in listEmails)
            {
                if (mail == inputEmail)
                {
                    inDatabase = true;
                }
            }

            return inDatabase;
        }

        private void RegisterUser(string userEmail)
        {
            // Alle variabelen uit fields halen
            string firstName = NameField.Text;
            string lastName = SurnameField.Text;
            string gender = GenderField.Text;
            string inputAdress = AddressField.Text;
            string zipcode = PostcodeField.Text;
            string city = CityField.Text;
            string phonenumber = PhonenumberField.Text;

            PasswordScreen();

            if (!CheckIfUserExists(userEmail))
            {
                try
                {
                    dbc.cnn.Open();

                    string query = "INSERT INTO `customers`.`custromers` (`firstName`, `lastName`, `gender`, `adress`, `zipCode`, `city`, `phoneNumber`, `email`, `password`) VALUES ('"+ firstName + "', '"+ lastName + "', '"+ gender + "', '"+ address + "', '"+ zipcode + "', '"+ city + "', '"+ phonenumber +"', '" + userEmail + "', '"+ _password +"');";

                    MySqlCommand command = new MySqlCommand(query, dbc.cnn);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("User Added");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
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
            else
            {
                MessageBox.Show("USER ALREADY EXISTS, TRY LOGGING IN");
            }
        }

        public void PasswordScreen()
        {
            Registreerscherm rgt = new Registreerscherm(this);
            rgt.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginscherm lgn = new Loginscherm(this);
            lgn.ShowDialog();
        }
    }
}