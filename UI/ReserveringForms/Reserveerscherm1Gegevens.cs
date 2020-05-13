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
            char[] chars = PostcodeField.Text.ToCharArray();


            if (genderBox.Text == "" || NameField.Text == "" || SurnameField.Text == "" || AddressField.Text == "" || PostcodeField.Text == "" || CityField.Text == "" || PhonenumberField.Text == "" || EmailField.Text == "")
            {
                MessageBox.Show("Vul alle velden in AUB");
            }


            

            else if ((chars[0] < '0' || chars[0] > '9') || (chars[1] < '0' || chars[1] > '9') || (chars[2] < '0' || chars[2] > '9') || (chars[3] < '0' || chars[3] > '9') ||
            (chars[4] < 'A' || chars[4] > 'Z') || (chars[5] < 'A' || chars[5] > 'Z') || PostcodeField.Text.Length < 6)
                {
                    MessageBox.Show("Postcode is onjuist.");
                }

            else
            {
                Program._ReservationSession.CurrentReservation.AddCustomer(EmailField.Text, genderBox.Text, NameField.Text, SurnameField.Text,
               AddressField.Text, PostcodeField.Text, CityField.Text, Int32.Parse(PhonenumberField.Text));
                Reserveerschem2Tickets nextForm = new Reserveerschem2Tickets();
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

                string selectQuery = "SELECT * FROM `mydb`.`customers`";
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
            string gender = genderBox.Text;
            string inputAddress = AddressField.Text;
            string zipcode = PostcodeField.Text;
            string city = CityField.Text;
            string phonenumber = PhonenumberField.Text;

            if (!CheckIfUserExists(userEmail))
            {
                PasswordScreen();

                try
                {
                    dbc.cnn.Open();

                    string query = "INSERT INTO `mydb`.`customers` (`firstName`, `lastName`, `gender`, `adress`, `zipCode`, `city`, `phoneNumber`, `email`, `password`) VALUES ('"+ firstName + "', '"+ lastName + "', '"+ gender + "', '"+ inputAddress + "', '"+ zipcode + "', '"+ city + "', '"+ phonenumber +"', '" + userEmail + "', '"+ _password +"');";

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

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}