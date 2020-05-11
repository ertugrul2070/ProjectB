﻿namespace UI
{
    partial class Reserveerscherm7Tijden
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
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.black_panel = new System.Windows.Forms.Panel();
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.FormLoad = new System.Windows.Forms.Panel();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.Cinema = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.red_bovenkant.SuspendLayout();
            this.FormLoad.SuspendLayout();
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
            this.red_bovenkant.TabIndex = 14;
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
            this.Red_onderkant.Location = new System.Drawing.Point(1, 420);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(801, 32);
            this.Red_onderkant.TabIndex = 16;
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (246)))), ((int) (((byte) (242)))), ((int) (((byte) (90)))));
            this.FormLoad.Controls.Add(this.cbTime);
            this.FormLoad.Controls.Add(this.cbDate);
            this.FormLoad.Controls.Add(this.cbCity);
            this.FormLoad.Controls.Add(this.Cinema);
            this.FormLoad.Controls.Add(this.Information);
            this.FormLoad.Controls.Add(this.Time);
            this.FormLoad.Controls.Add(this.Date);
            this.FormLoad.Controls.Add(this.Next);
            this.FormLoad.Controls.Add(this.Back);
            this.FormLoad.Location = new System.Drawing.Point(220, 58);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(360, 334);
            this.FormLoad.TabIndex = 17;
            this.FormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLoad_Paint);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {"14:45", "16:00", "17:35", "19:00", "21:30", "23:15"});
            this.cbTime.Location = new System.Drawing.Point(251, 104);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(85, 21);
            this.cbTime.TabIndex = 25;
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {"13/08/2020", "15/08/2020", "19/08/2020", "25/08/2020", "01/09/2020"});
            this.cbDate.Location = new System.Drawing.Point(148, 104);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(85, 21);
            this.cbDate.TabIndex = 24;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {"Rotterdam", "Amsterdam", "Den Haag", "Leiden", "Groningen"});
            this.cbCity.Location = new System.Drawing.Point(46, 104);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(85, 21);
            this.cbCity.TabIndex = 23;
            // 
            // Cinema
            // 
            this.Cinema.Location = new System.Drawing.Point(43, 79);
            this.Cinema.Name = "Cinema";
            this.Cinema.Size = new System.Drawing.Size(88, 21);
            this.Cinema.TabIndex = 22;
            this.Cinema.Text = "Bioscoop:";
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(154, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(88, 21);
            this.Information.TabIndex = 18;
            this.Information.Text = "Reserveren";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(248, 79);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(79, 21);
            this.Time.TabIndex = 11;
            this.Time.Text = "Tijd:";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(154, 79);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(79, 21);
            this.Date.TabIndex = 10;
            this.Date.Text = "Datum:";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (254)))), ((int) (((byte) (91)))));
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
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.Back.Location = new System.Drawing.Point(18, 259);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 37);
            this.Back.TabIndex = 8;
            this.Back.Text = "Terug";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Reserveerscherm7Tijden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormLoad);
            this.Controls.Add(this.Red_onderkant);
            this.Controls.Add(this.red_bovenkant);
            this.Name = "Reserveerscherm7Tijden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserveerscherm7Tijden";
            this.red_bovenkant.ResumeLayout(false);
            this.FormLoad.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label Cinema;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.Label Time;

        #endregion
    }
}