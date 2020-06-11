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
        public string email;
        public bool loggedIn = false;

        public Reserveerscherm1Gegevens()
        {
            InitializeComponent();
            pbMovie.ImageLocation = Program._ReservationSession.CurrentReservation.dataUrl;

        }
        private void Reserveerscherm1Gegevens_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reserveerscherm4Snacks nextForm = new Reserveerscherm4Snacks();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();

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
            
        }

        private void genderBox_TextChanged(object sender, EventArgs e)
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
            System.Text.RegularExpressions.Regex theEmailPattern = new System.Text.RegularExpressions.Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");

            char[] chars = PostcodeField.Text.ToCharArray();


            if (genderBox.Text == "" || NameField.Text == "" || SurnameField.Text == "" || AddressField.Text == "" || PostcodeField.Text == "" || CityField.Text == "" || PhonenumberField.Text == "" || EmailField.Text == "")
            {
                MessageBox.Show("Vul alle velden in AUB.");
            }

            else if (!theEmailPattern.IsMatch(EmailField.Text))
            {
                    MessageBox.Show("Email is onjuist.");
            }

            else if (!isPostcodeValid(chars))
            {
                MessageBox.Show("Postcode is onjuist.");
            }
            else if (!loggedIn && userExists())
            {
                MessageBox.Show("Er bestaat al een gebruiker met dit emailadres. Probeer in te loggen om verder te gaan.");
            }
            else if (!loggedIn && !userExists())
            {
                RegisterUser(EmailField.Text);
            }

            else
            {
                Program._ReservationSession.CurrentReservation.AddCustomer(EmailField.Text, genderBox.Text, NameField.Text, SurnameField.Text,
               AddressField.Text, PostcodeField.Text, CityField.Text, Int32.Parse(PhonenumberField.Text));
                Reserveerscherm5Betalen nextForm = new Reserveerscherm5Betalen();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
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
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userEmail = EmailField.Text;

            if (genderBox.Text != "" && NameField.Text != "" && SurnameField.Text != "" && AddressField.Text != "" && PostcodeField.Text != "" && CityField.Text != "" && PhonenumberField.Text != "" && EmailField.Text != "")
            {
                if (!userExists())
                {
                    if (isPostcodeValid(PostcodeField.Text.ToCharArray()))
                    {
                        PasswordScreen();
                        RegisterUser(userEmail);
                    }
                    else
                    {
                        MessageBox.Show("Postcode is onjuist.");
                    }
                }
                else
                {
                    MessageBox.Show("Er bestaat al een account met dit emailadres, log in om door te gaan.");
                }
            }
            else
            {
                MessageBox.Show("Vul alle velden in AUB.");
            }
        }

        private void RegisterUser(string userEmail)
        {
            // Alle variabelen uit fields halen
            string firstName = NameField.Text;
            string lastName = SurnameField.Text;
            string gender = genderBox.Text;
            string inputAddress = AddressField.Text;
            string zipcode = PostcodeField.Text;
            string city = CityField.Text;
            string phonenumber = PhonenumberField.Text;

            string query;
            try
            {
                dbc.cnn.Open();

                if (_password == null)
                {
                    query = "INSERT INTO `mydb`.`customers` (`firstName`, `lastName`, `gender`, `adress`, `zipCode`, `city`, `phoneNumber`, `email`) VALUES ('" + firstName + "', '" + lastName + "', '" + gender + "', '" + inputAddress + "', '" + zipcode + "', '" + city + "', '" + phonenumber + "', '" + userEmail + "');";
                }
                else
                {
                    query = "INSERT INTO `mydb`.`customers` (`firstName`, `lastName`, `gender`, `adress`, `zipCode`, `city`, `phoneNumber`, `email`, `password`) VALUES ('" + firstName + "', '" + lastName + "', '" + gender + "', '" + inputAddress + "', '" + zipcode + "', '" + city + "', '" + phonenumber + "', '" + userEmail + "', '" + _password + "');";
                }

                MySqlCommand command = new MySqlCommand(query, dbc.cnn);

                if (command.ExecuteNonQuery() == 1)
                {
                    if (_password != null)
                    {
                        MessageBox.Show("Gebruiker toegevoegd.");
                        loggedIn = true;
                    }
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan. Probeer opnieuw.");
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

        public void PasswordScreen()
        {
            Registreerscherm rgt = new Registreerscherm(this);
            rgt.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginscherm lgn = new Loginscherm(this);
            lgn.ShowDialog();
            loggedIn = lgn.loggedIn;

            if (lgn.loggedIn)
            {
                autoFill();
            }

        }

        private void autoFill()
        {
            NameField.Text = firstName;
            SurnameField.Text = lastName;
            genderBox.Text = gender;
            AddressField.Text = inputAddress;
            PostcodeField.Text = zipcode;
            CityField.Text = city;
            PhonenumberField.Text = phonenumber;
            EmailField.Text = email;
        }

        private bool isPostcodeValid(char[] chars)
        {
            if ((chars[0] < '0' || chars[0] > '9') || (chars[1] < '0' || chars[1] > '9') || (chars[2] < '0' || chars[2] > '9') || (chars[3] < '0' || chars[3] > '9') ||
            (chars[4] < 'A' || chars[4] > 'Z') || (chars[5] < 'A' || chars[5] > 'Z') || PostcodeField.Text.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool userExists()
        {
            bool ex = false;

            try
            {
                dbc.cnn.Open();

                string query = "SELECT * FROM mydb.customers;";

                MySqlCommand command = new MySqlCommand(query, dbc.cnn);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var ordinal = dataReader.GetOrdinal("password");

                    if (EmailField.Text == dataReader.GetString("email") && !dataReader.IsDBNull(ordinal))
                    {
                        ex = true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                dbc.cnn.Close();
            }
            return ex;
        }
    }
}