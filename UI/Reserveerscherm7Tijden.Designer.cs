namespace UI
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
            this.Cinema = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Cinema1 = new System.Windows.Forms.CheckBox();
            this.Cinema2 = new System.Windows.Forms.CheckBox();
            this.Cinema3 = new System.Windows.Forms.CheckBox();
            this.Date1 = new System.Windows.Forms.CheckBox();
            this.Date2 = new System.Windows.Forms.CheckBox();
            this.Date3 = new System.Windows.Forms.CheckBox();
            this.Time1 = new System.Windows.Forms.CheckBox();
            this.Time2 = new System.Windows.Forms.CheckBox();
            this.Time3 = new System.Windows.Forms.CheckBox();
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
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.FormLoad.Controls.Add(this.Time3);
            this.FormLoad.Controls.Add(this.Time2);
            this.FormLoad.Controls.Add(this.Time1);
            this.FormLoad.Controls.Add(this.Date3);
            this.FormLoad.Controls.Add(this.Date2);
            this.FormLoad.Controls.Add(this.Date1);
            this.FormLoad.Controls.Add(this.Cinema3);
            this.FormLoad.Controls.Add(this.Cinema2);
            this.FormLoad.Controls.Add(this.Cinema1);
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
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(91)))));
            this.Next.Location = new System.Drawing.Point(219, 259);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(118, 37);
            this.Next.TabIndex = 9;
            this.Next.Text = "Verder";
            this.Next.UseVisualStyleBackColor = false;
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
            // 
            // Cinema1
            // 
            this.Cinema1.AutoSize = true;
            this.Cinema1.Location = new System.Drawing.Point(46, 116);
            this.Cinema1.Name = "Cinema1";
            this.Cinema1.Size = new System.Drawing.Size(75, 17);
            this.Cinema1.TabIndex = 23;
            this.Cinema1.Text = "Rotterdam";
            this.Cinema1.UseVisualStyleBackColor = true;
            this.Cinema1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cinema2
            // 
            this.Cinema2.AutoSize = true;
            this.Cinema2.Location = new System.Drawing.Point(46, 151);
            this.Cinema2.Name = "Cinema2";
            this.Cinema2.Size = new System.Drawing.Size(75, 17);
            this.Cinema2.TabIndex = 24;
            this.Cinema2.Text = "Den Haag";
            this.Cinema2.UseVisualStyleBackColor = true;
            // 
            // Cinema3
            // 
            this.Cinema3.AutoSize = true;
            this.Cinema3.Location = new System.Drawing.Point(46, 189);
            this.Cinema3.Name = "Cinema3";
            this.Cinema3.Size = new System.Drawing.Size(78, 17);
            this.Cinema3.TabIndex = 25;
            this.Cinema3.Text = "Amsterdam";
            this.Cinema3.UseVisualStyleBackColor = true;
            // 
            // Date1
            // 
            this.Date1.AutoSize = true;
            this.Date1.Location = new System.Drawing.Point(146, 116);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(63, 17);
            this.Date1.TabIndex = 26;
            this.Date1.Text = "Datum1";
            this.Date1.UseVisualStyleBackColor = true;
            // 
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Location = new System.Drawing.Point(146, 151);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(63, 17);
            this.Date2.TabIndex = 27;
            this.Date2.Text = "Datum2";
            this.Date2.UseVisualStyleBackColor = true;
            // 
            // Date3
            // 
            this.Date3.AutoSize = true;
            this.Date3.Location = new System.Drawing.Point(146, 190);
            this.Date3.Name = "Date3";
            this.Date3.Size = new System.Drawing.Size(63, 17);
            this.Date3.TabIndex = 28;
            this.Date3.Text = "Datum3";
            this.Date3.UseVisualStyleBackColor = true;
            // 
            // Time1
            // 
            this.Time1.AutoSize = true;
            this.Time1.Location = new System.Drawing.Point(251, 116);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(49, 17);
            this.Time1.TabIndex = 29;
            this.Time1.Text = "Tijd1";
            this.Time1.UseVisualStyleBackColor = true;
            this.Time1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Time2
            // 
            this.Time2.AutoSize = true;
            this.Time2.Location = new System.Drawing.Point(251, 151);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(49, 17);
            this.Time2.TabIndex = 30;
            this.Time2.Text = "Tijd2";
            this.Time2.UseVisualStyleBackColor = true;
            // 
            // Time3
            // 
            this.Time3.AutoSize = true;
            this.Time3.Location = new System.Drawing.Point(251, 189);
            this.Time3.Name = "Time3";
            this.Time3.Size = new System.Drawing.Size(49, 17);
            this.Time3.TabIndex = 31;
            this.Time3.Text = "Tijd3";
            this.Time3.UseVisualStyleBackColor = true;
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
            this.Text = "Reserveerscherm7Tijden";
            this.red_bovenkant.ResumeLayout(false);
            this.FormLoad.ResumeLayout(false);
            this.FormLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Cinema;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.CheckBox Cinema1;
        private System.Windows.Forms.CheckBox Cinema2;
        private System.Windows.Forms.CheckBox Date3;
        private System.Windows.Forms.CheckBox Date2;
        private System.Windows.Forms.CheckBox Date1;
        private System.Windows.Forms.CheckBox Cinema3;
        private System.Windows.Forms.CheckBox Time1;
        private System.Windows.Forms.CheckBox Time3;
        private System.Windows.Forms.CheckBox Time2;
    }
}