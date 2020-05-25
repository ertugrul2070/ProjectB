namespace UI
{
    partial class Reserveerscherm5Betalen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserveerscherm5Betalen));
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.black_panel = new System.Windows.Forms.Panel();
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.FormLoad = new System.Windows.Forms.Panel();
            this.jaarBox = new System.Windows.Forms.ComboBox();
            this.maandBox = new System.Windows.Forms.ComboBox();
            this.dagBox = new System.Windows.Forms.ComboBox();
            this.Creditcard = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.Valid = new System.Windows.Forms.Label();
            this.CVC = new System.Windows.Forms.Label();
            this.Passnumber = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.red_bovenkant.SuspendLayout();
            this.FormLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(1, 1);
            this.red_bovenkant.Margin = new System.Windows.Forms.Padding(2);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(828, 54);
            this.red_bovenkant.TabIndex = 13;
            // 
            // black_panel
            // 
            this.black_panel.BackColor = System.Drawing.Color.Black;
            this.black_panel.Location = new System.Drawing.Point(0, 40);
            this.black_panel.Margin = new System.Windows.Forms.Padding(2);
            this.black_panel.Name = "black_panel";
            this.black_panel.Size = new System.Drawing.Size(806, 14);
            this.black_panel.TabIndex = 3;
            // 
            // Red_onderkant
            // 
            this.Red_onderkant.BackColor = System.Drawing.Color.DarkRed;
            this.Red_onderkant.Location = new System.Drawing.Point(1, 417);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(801, 32);
            this.Red_onderkant.TabIndex = 15;
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.FormLoad.Controls.Add(this.jaarBox);
            this.FormLoad.Controls.Add(this.maandBox);
            this.FormLoad.Controls.Add(this.dagBox);
            this.FormLoad.Controls.Add(this.Creditcard);
            this.FormLoad.Controls.Add(this.Information);
            this.FormLoad.Controls.Add(this.Valid);
            this.FormLoad.Controls.Add(this.CVC);
            this.FormLoad.Controls.Add(this.Passnumber);
            this.FormLoad.Controls.Add(this.Next);
            this.FormLoad.Controls.Add(this.Back);
            this.FormLoad.Controls.Add(this.SurnameField);
            this.FormLoad.Controls.Add(this.NameField);
            this.FormLoad.Location = new System.Drawing.Point(223, 60);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(360, 334);
            this.FormLoad.TabIndex = 16;
            // 
            // jaarBox
            // 
            this.jaarBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jaarBox.FormattingEnabled = true;
            this.jaarBox.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.jaarBox.Location = new System.Drawing.Point(289, 191);
            this.jaarBox.Name = "jaarBox";
            this.jaarBox.Size = new System.Drawing.Size(48, 21);
            this.jaarBox.TabIndex = 26;
            // 
            // maandBox
            // 
            this.maandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maandBox.FormattingEnabled = true;
            this.maandBox.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maart",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Augustus",
            "September",
            "Oktober",
            "November",
            "December"});
            this.maandBox.Location = new System.Drawing.Point(211, 191);
            this.maandBox.Name = "maandBox";
            this.maandBox.Size = new System.Drawing.Size(72, 21);
            this.maandBox.TabIndex = 25;
            // 
            // dagBox
            // 
            this.dagBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dagBox.FormattingEnabled = true;
            this.dagBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dagBox.Location = new System.Drawing.Point(157, 191);
            this.dagBox.Name = "dagBox";
            this.dagBox.Size = new System.Drawing.Size(48, 21);
            this.dagBox.TabIndex = 24;
            // 
            // Creditcard
            // 
            this.Creditcard.Location = new System.Drawing.Point(154, 47);
            this.Creditcard.Name = "Creditcard";
            this.Creditcard.Size = new System.Drawing.Size(88, 21);
            this.Creditcard.TabIndex = 22;
            this.Creditcard.Text = "Creditcard";
            // 
            // Information
            // 
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(154, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(88, 21);
            this.Information.TabIndex = 18;
            this.Information.Text = "Betalen";
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(57, 194);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(68, 21);
            this.Valid.TabIndex = 12;
            this.Valid.Text = "Geldig tot:";
            // 
            // CVC
            // 
            this.CVC.Location = new System.Drawing.Point(57, 138);
            this.CVC.Name = "CVC";
            this.CVC.Size = new System.Drawing.Size(79, 21);
            this.CVC.TabIndex = 11;
            this.CVC.Text = "CVV:";
            // 
            // Passnumber
            // 
            this.Passnumber.Location = new System.Drawing.Point(57, 87);
            this.Passnumber.Name = "Passnumber";
            this.Passnumber.Size = new System.Drawing.Size(79, 21);
            this.Passnumber.TabIndex = 10;
            this.Passnumber.Text = "Pasnummer:";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(91)))));
            this.Next.Location = new System.Drawing.Point(219, 259);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(118, 37);
            this.Next.TabIndex = 9;
            this.Next.Text = "Verder";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(18, 259);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 37);
            this.Back.TabIndex = 8;
            this.Back.Text = "Terug";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SurnameField
            // 
            this.SurnameField.Location = new System.Drawing.Point(157, 84);
            this.SurnameField.MaxLength = 19;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(180, 20);
            this.SurnameField.TabIndex = 2;
            this.SurnameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameField_KeyPress);
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(157, 135);
            this.NameField.MaxLength = 3;
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(72, 20);
            this.NameField.TabIndex = 1;
            // 
            // pbMovie
            // 
            this.pbMovie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMovie.InitialImage")));
            this.pbMovie.Location = new System.Drawing.Point(49, 72);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(117, 166);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovie.TabIndex = 18;
            this.pbMovie.TabStop = false;
            // 
            // Reserveerscherm5Betalen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMovie);
            this.Controls.Add(this.FormLoad);
            this.Controls.Add(this.Red_onderkant);
            this.Controls.Add(this.red_bovenkant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reserveerscherm5Betalen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popcorn Plaza";
            this.red_bovenkant.ResumeLayout(false);
            this.FormLoad.ResumeLayout(false);
            this.FormLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Label Creditcard;
        private System.Windows.Forms.Label CVC;
        private System.Windows.Forms.ComboBox dagBox;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.ComboBox jaarBox;
        private System.Windows.Forms.ComboBox maandBox;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Passnumber;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.Label Valid;

        #endregion
    }
}