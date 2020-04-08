using System.ComponentModel;

namespace UI
{
    partial class Reserveerscherm1Gegevens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.black_panel = new System.Windows.Forms.Panel();
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.FormLoad = new System.Windows.Forms.Panel();
            this.Information = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Postcode = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PhonenumberField = new System.Windows.Forms.TextBox();
            this.CityField = new System.Windows.Forms.TextBox();
            this.PostcodeField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.GenderField = new System.Windows.Forms.TextBox();
            this.red_bovenkant.SuspendLayout();
            this.FormLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(10, 0);
            this.red_bovenkant.Margin = new System.Windows.Forms.Padding(2);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(923, 62);
            this.red_bovenkant.TabIndex = 7;
            // 
            // black_panel
            // 
            this.black_panel.BackColor = System.Drawing.Color.Black;
            this.black_panel.Location = new System.Drawing.Point(0, 46);
            this.black_panel.Margin = new System.Windows.Forms.Padding(2);
            this.black_panel.Name = "black_panel";
            this.black_panel.Size = new System.Drawing.Size(923, 16);
            this.black_panel.TabIndex = 3;
            // 
            // Red_onderkant
            // 
            this.Red_onderkant.BackColor = System.Drawing.Color.DarkRed;
            this.Red_onderkant.Location = new System.Drawing.Point(-1, 480);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(934, 37);
            this.Red_onderkant.TabIndex = 6;
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (246)))), ((int) (((byte) (242)))),
                ((int) (((byte) (90)))));
            this.FormLoad.Controls.Add(this.Information);
            this.FormLoad.Controls.Add(this.Email);
            this.FormLoad.Controls.Add(this.Phonenumber);
            this.FormLoad.Controls.Add(this.City);
            this.FormLoad.Controls.Add(this.Postcode);
            this.FormLoad.Controls.Add(this.address);
            this.FormLoad.Controls.Add(this.Surname);
            this.FormLoad.Controls.Add(this.UserName);
            this.FormLoad.Controls.Add(this.Gender);
            this.FormLoad.Controls.Add(this.Next);
            this.FormLoad.Controls.Add(this.Back);
            this.FormLoad.Controls.Add(this.EmailField);
            this.FormLoad.Controls.Add(this.PhonenumberField);
            this.FormLoad.Controls.Add(this.CityField);
            this.FormLoad.Controls.Add(this.PostcodeField);
            this.FormLoad.Controls.Add(this.AddressField);
            this.FormLoad.Controls.Add(this.SurnameField);
            this.FormLoad.Controls.Add(this.NameField);
            this.FormLoad.Controls.Add(this.GenderField);
            this.FormLoad.Location = new System.Drawing.Point(237, 78);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(420, 385);
            this.FormLoad.TabIndex = 8;
            this.FormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(180, 9);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(56, 24);
            this.Information.TabIndex = 18;
            this.Information.Text = "Gegevens";
            this.Information.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(90, 258);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 24);
            this.Email.TabIndex = 17;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.label7_Click);
            // 
            // Phonenumber
            // 
            this.Phonenumber.Location = new System.Drawing.Point(37, 228);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(108, 24);
            this.Phonenumber.TabIndex = 16;
            this.Phonenumber.Text = "Telefoonnummer:";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(110, 200);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(36, 24);
            this.City.TabIndex = 15;
            this.City.Text = "Stad:";
            this.City.Click += new System.EventHandler(this.Stad_Click);
            // 
            // Postcode
            // 
            this.Postcode.Location = new System.Drawing.Point(83, 171);
            this.Postcode.Name = "Postcode";
            this.Postcode.Size = new System.Drawing.Size(63, 24);
            this.Postcode.TabIndex = 14;
            this.Postcode.Text = "Postcode:";
            this.Postcode.Click += new System.EventHandler(this.label4_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(101, 142);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(44, 24);
            this.address.TabIndex = 13;
            this.address.Text = "Adres:";
            this.address.Click += new System.EventHandler(this.label3_Click);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(66, 113);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(79, 24);
            this.Surname.TabIndex = 12;
            this.Surname.Text = "Achternaam:";
            this.Surname.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(101, 84);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(44, 24);
            this.UserName.TabIndex = 11;
            this.UserName.Text = "Naam:";
            this.UserName.Click += new System.EventHandler(this.Naam_Click);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(90, 55);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 24);
            this.Gender.TabIndex = 10;
            this.Gender.Text = "Gelsacht:";
            this.Gender.Click += new System.EventHandler(this.label1_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (254)))),
                ((int) (((byte) (91)))));
            this.Next.Location = new System.Drawing.Point(255, 299);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(138, 43);
            this.Next.TabIndex = 9;
            this.Next.Text = "Verder";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.Back.Location = new System.Drawing.Point(21, 299);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(138, 43);
            this.Back.TabIndex = 8;
            this.Back.Text = "Terug";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(170, 255);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(111, 23);
            this.EmailField.TabIndex = 7;
            this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
            // 
            // PhonenumberField
            // 
            this.PhonenumberField.Location = new System.Drawing.Point(170, 226);
            this.PhonenumberField.Name = "PhonenumberField";
            this.PhonenumberField.Size = new System.Drawing.Size(111, 23);
            this.PhonenumberField.TabIndex = 6;
            this.PhonenumberField.TextChanged += new System.EventHandler(this.PhonenumberField_TextChanged);
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(170, 197);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(111, 23);
            this.CityField.TabIndex = 5;
            this.CityField.TextChanged += new System.EventHandler(this.CityField_TextChanged);
            // 
            // PostcodeField
            // 
            this.PostcodeField.Location = new System.Drawing.Point(170, 168);
            this.PostcodeField.Name = "PostcodeField";
            this.PostcodeField.Size = new System.Drawing.Size(111, 23);
            this.PostcodeField.TabIndex = 4;
            this.PostcodeField.TextChanged += new System.EventHandler(this.PostcodeField_TextChanged);
            // 
            // AddressField
            // 
            this.AddressField.Location = new System.Drawing.Point(170, 138);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(111, 23);
            this.AddressField.TabIndex = 3;
            this.AddressField.TextChanged += new System.EventHandler(this.AddressField_TextChanged);
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(170, 110);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(111, 23);
            this.SurnameField.TabIndex = 2;
            this.SurnameField.TextChanged += new System.EventHandler(this.SurnameField_TextChanged);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(170, 81);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(111, 23);
            this.NameField.TabIndex = 1;
            this.NameField.TextChanged += new System.EventHandler(this.NameField_TextChanged);
            // 
            // GenderField
            // 
            this.GenderField.Location = new System.Drawing.Point(170, 52);
            this.GenderField.Name = "GenderField";
            this.GenderField.Size = new System.Drawing.Size(111, 23);
            this.GenderField.TabIndex = 0;
            this.GenderField.TextChanged += new System.EventHandler(this.GenderField_TextChanged);
            // 
            // Reserveerscherm1Gegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.FormLoad);
            this.Controls.Add(this.red_bovenkant);
            this.Controls.Add(this.Red_onderkant);
            this.Name = "Reserveerscherm1Gegevens";
            this.Text = "Reserveerscherm1Gegevens";
            this.red_bovenkant.ResumeLayout(false);
            this.FormLoad.ResumeLayout(false);
            this.FormLoad.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Postcode;
        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PostcodeField;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.TextBox PhonenumberField;
        private System.Windows.Forms.TextBox GenderField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel FormLoad;
    }
}