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
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.Postcode = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.FormLoad = new System.Windows.Forms.Panel();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PhonenumberField = new System.Windows.Forms.TextBox();
            this.CityField = new System.Windows.Forms.TextBox();
            this.PostcodeField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.GenderField = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.red_bovenkant.SuspendLayout();
            this.FormLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(-1, 0);
            this.red_bovenkant.Margin = new System.Windows.Forms.Padding(2);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(801, 54);
            this.red_bovenkant.TabIndex = 7;
            // 
            // black_panel
            // 
            this.black_panel.BackColor = System.Drawing.Color.Black;
            this.black_panel.Location = new System.Drawing.Point(0, 40);
            this.black_panel.Margin = new System.Windows.Forms.Padding(2);
            this.black_panel.Name = "black_panel";
            this.black_panel.Size = new System.Drawing.Size(801, 14);
            this.black_panel.TabIndex = 3;
            // 
            // Red_onderkant
            // 
            this.Red_onderkant.BackColor = System.Drawing.Color.DarkRed;
            this.Red_onderkant.Location = new System.Drawing.Point(-1, 416);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(801, 32);
            this.Red_onderkant.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.Back.Location = new System.Drawing.Point(18, 247);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 37);
            this.Back.TabIndex = 8;
            this.Back.Text = "Terug";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (254)))), ((int) (((byte) (91)))));
            this.Next.Location = new System.Drawing.Point(219, 247);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(118, 37);
            this.Next.TabIndex = 9;
            this.Next.Text = "Verder";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(77, 48);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 21);
            this.Gender.TabIndex = 10;
            this.Gender.Text = "Gelsacht:";
            this.Gender.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(87, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(38, 21);
            this.UserName.TabIndex = 11;
            this.UserName.Text = "Naam:";
            this.UserName.Click += new System.EventHandler(this.Naam_Click);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(57, 98);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(68, 21);
            this.Surname.TabIndex = 12;
            this.Surname.Text = "Achternaam:";
            this.Surname.Click += new System.EventHandler(this.label2_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(87, 123);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(38, 21);
            this.address.TabIndex = 13;
            this.address.Text = "Adres:";
            this.address.Click += new System.EventHandler(this.label3_Click);
            // 
            // Postcode
            // 
            this.Postcode.Location = new System.Drawing.Point(71, 148);
            this.Postcode.Name = "Postcode";
            this.Postcode.Size = new System.Drawing.Size(65, 21);
            this.Postcode.TabIndex = 14;
            this.Postcode.Text = "Postcode:";
            this.Postcode.Click += new System.EventHandler(this.label4_Click);
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(94, 173);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(42, 21);
            this.City.TabIndex = 15;
            this.City.Text = "Stad:";
            this.City.Click += new System.EventHandler(this.Stad_Click);
            // 
            // Phonenumber
            // 
            this.Phonenumber.Location = new System.Drawing.Point(32, 196);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(93, 21);
            this.Phonenumber.TabIndex = 16;
            this.Phonenumber.Text = "Telefoonnummer:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(87, 217);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 21);
            this.Email.TabIndex = 17;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.label7_Click);
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(154, 8);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(73, 21);
            this.Information.TabIndex = 18;
            this.Information.Text = "Gegevens";
            this.Information.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (246)))), ((int) (((byte) (242)))), ((int) (((byte) (90)))));
            this.FormLoad.Controls.Add(this.EmailField);
            this.FormLoad.Controls.Add(this.PhonenumberField);
            this.FormLoad.Controls.Add(this.CityField);
            this.FormLoad.Controls.Add(this.PostcodeField);
            this.FormLoad.Controls.Add(this.AddressField);
            this.FormLoad.Controls.Add(this.SurnameField);
            this.FormLoad.Controls.Add(this.NameField);
            this.FormLoad.Controls.Add(this.GenderField);
            this.FormLoad.Controls.Add(this.btnRegister);
            this.FormLoad.Controls.Add(this.btnLogin);
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
            this.FormLoad.Location = new System.Drawing.Point(214, 59);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(360, 334);
            this.FormLoad.TabIndex = 8;
            this.FormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(157, 218);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(100, 20);
            this.EmailField.TabIndex = 28;
            // 
            // PhonenumberField
            // 
            this.PhonenumberField.Location = new System.Drawing.Point(157, 193);
            this.PhonenumberField.Name = "PhonenumberField";
            this.PhonenumberField.Size = new System.Drawing.Size(100, 20);
            this.PhonenumberField.TabIndex = 27;
            // 
            // CityField
            // 
            this.CityField.Location = new System.Drawing.Point(157, 170);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(100, 20);
            this.CityField.TabIndex = 26;
            // 
            // PostcodeField
            // 
            this.PostcodeField.Location = new System.Drawing.Point(157, 145);
            this.PostcodeField.Name = "PostcodeField";
            this.PostcodeField.Size = new System.Drawing.Size(100, 20);
            this.PostcodeField.TabIndex = 25;
            // 
            // AddressField
            // 
            this.AddressField.Location = new System.Drawing.Point(157, 121);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(100, 20);
            this.AddressField.TabIndex = 24;
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(157, 95);
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(100, 20);
            this.SurnameField.TabIndex = 23;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(157, 70);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(100, 20);
            this.NameField.TabIndex = 22;
            // 
            // GenderField
            // 
            this.GenderField.Location = new System.Drawing.Point(157, 45);
            this.GenderField.Name = "GenderField";
            this.GenderField.Size = new System.Drawing.Size(100, 20);
            this.GenderField.TabIndex = 21;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (254)))), ((int) (((byte) (91)))));
            this.btnRegister.Location = new System.Drawing.Point(18, 290);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 37);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Registreer";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (254)))), ((int) (((byte) (91)))));
            this.btnLogin.Location = new System.Drawing.Point(219, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 37);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Reserveerscherm1Gegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormLoad);
            this.Controls.Add(this.red_bovenkant);
            this.Controls.Add(this.Red_onderkant);
            this.Name = "Reserveerscherm1Gegevens";
            this.Text = "Reserveerscherm1Gegevens";
            this.Load += new System.EventHandler(this.Reserveerscherm1Gegevens_Load);
            this.red_bovenkant.ResumeLayout(false);
            this.FormLoad.ResumeLayout(false);
            this.FormLoad.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label address;
        public System.Windows.Forms.TextBox AddressField;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label City;
        public System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.Label Email;
        public System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Gender;
        public System.Windows.Forms.TextBox GenderField;
        private System.Windows.Forms.Label Information;
        public System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Phonenumber;
        public System.Windows.Forms.TextBox PhonenumberField;
        private System.Windows.Forms.Label Postcode;
        public System.Windows.Forms.TextBox PostcodeField;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.Label Surname;
        public System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.Label UserName;

        #endregion
    }
}