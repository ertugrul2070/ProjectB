﻿namespace UI
{
    partial class Reserveerscherm4Snacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserveerscherm4Snacks));
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.black_panel = new System.Windows.Forms.Panel();
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.Receipt1 = new System.Windows.Forms.Panel();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.rtbTotaal = new System.Windows.Forms.RichTextBox();
            this.rtbBon = new System.Windows.Forms.RichTextBox();
            this.Receipt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FormLoad = new System.Windows.Forms.Panel();
            this.Toevoegen6 = new System.Windows.Forms.Button();
            this.Toevoegen5 = new System.Windows.Forms.Button();
            this.Toevoegen4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Drink1 = new System.Windows.Forms.Label();
            this.Drinks = new System.Windows.Forms.Label();
            this.Toevoegen3 = new System.Windows.Forms.Button();
            this.Toevoegen2 = new System.Windows.Forms.Button();
            this.Toevoegen1 = new System.Windows.Forms.Button();
            this.Soort3 = new System.Windows.Forms.ComboBox();
            this.Soort2 = new System.Windows.Forms.ComboBox();
            this.Soort1 = new System.Windows.Forms.ComboBox();
            this.Popcorn3 = new System.Windows.Forms.Label();
            this.Popcorn2 = new System.Windows.Forms.Label();
            this.Popcorn1 = new System.Windows.Forms.Label();
            this.Popcorn = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.red_bovenkant.SuspendLayout();
            this.Receipt1.SuspendLayout();
            this.FormLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(0, 1);
            this.red_bovenkant.Margin = new System.Windows.Forms.Padding(2);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(828, 54);
            this.red_bovenkant.TabIndex = 12;
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
            this.Red_onderkant.Location = new System.Drawing.Point(0, 420);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(801, 32);
            this.Red_onderkant.TabIndex = 14;
            // 
            // Receipt1
            // 
            this.Receipt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.Receipt1.Controls.Add(this.btnDeleteItem);
            this.Receipt1.Controls.Add(this.rtbTotaal);
            this.Receipt1.Controls.Add(this.rtbBon);
            this.Receipt1.Controls.Add(this.Receipt);
            this.Receipt1.Controls.Add(this.button1);
            this.Receipt1.Location = new System.Drawing.Point(566, 69);
            this.Receipt1.Name = "Receipt1";
            this.Receipt1.Size = new System.Drawing.Size(207, 334);
            this.Receipt1.TabIndex = 15;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 304);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(204, 27);
            this.btnDeleteItem.TabIndex = 36;
            this.btnDeleteItem.Text = "Verwijder laatste item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // rtbTotaal
            // 
            this.rtbTotaal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.rtbTotaal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTotaal.Location = new System.Drawing.Point(4, 262);
            this.rtbTotaal.Name = "rtbTotaal";
            this.rtbTotaal.Size = new System.Drawing.Size(200, 36);
            this.rtbTotaal.TabIndex = 20;
            this.rtbTotaal.Text = "";
            // 
            // rtbBon
            // 
            this.rtbBon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.rtbBon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbBon.Location = new System.Drawing.Point(4, 29);
            this.rtbBon.Name = "rtbBon";
            this.rtbBon.Size = new System.Drawing.Size(200, 227);
            this.rtbBon.TabIndex = 19;
            this.rtbBon.Text = "";
            // 
            // Receipt
            // 
            this.Receipt.Location = new System.Drawing.Point(95, 8);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(88, 21);
            this.Receipt.TabIndex = 18;
            this.Receipt.Text = "Bon";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(91)))));
            this.button1.Location = new System.Drawing.Point(221, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Verder";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.FormLoad.Controls.Add(this.Toevoegen6);
            this.FormLoad.Controls.Add(this.Toevoegen5);
            this.FormLoad.Controls.Add(this.Toevoegen4);
            this.FormLoad.Controls.Add(this.label2);
            this.FormLoad.Controls.Add(this.label1);
            this.FormLoad.Controls.Add(this.Drink1);
            this.FormLoad.Controls.Add(this.Drinks);
            this.FormLoad.Controls.Add(this.Toevoegen3);
            this.FormLoad.Controls.Add(this.Toevoegen2);
            this.FormLoad.Controls.Add(this.Toevoegen1);
            this.FormLoad.Controls.Add(this.Soort3);
            this.FormLoad.Controls.Add(this.Soort2);
            this.FormLoad.Controls.Add(this.Soort1);
            this.FormLoad.Controls.Add(this.Popcorn3);
            this.FormLoad.Controls.Add(this.Popcorn2);
            this.FormLoad.Controls.Add(this.Popcorn1);
            this.FormLoad.Controls.Add(this.Popcorn);
            this.FormLoad.Controls.Add(this.Information);
            this.FormLoad.Controls.Add(this.Next);
            this.FormLoad.Controls.Add(this.Back);
            this.FormLoad.Location = new System.Drawing.Point(170, 69);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(360, 334);
            this.FormLoad.TabIndex = 16;
            this.FormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLoad_Paint);
            // 
            // Toevoegen6
            // 
            this.Toevoegen6.Location = new System.Drawing.Point(221, 248);
            this.Toevoegen6.Name = "Toevoegen6";
            this.Toevoegen6.Size = new System.Drawing.Size(75, 21);
            this.Toevoegen6.TabIndex = 35;
            this.Toevoegen6.Text = "Toevoegen";
            this.Toevoegen6.UseVisualStyleBackColor = true;
            this.Toevoegen6.Click += new System.EventHandler(this.Toevoegen6_Click);
            // 
            // Toevoegen5
            // 
            this.Toevoegen5.Location = new System.Drawing.Point(221, 221);
            this.Toevoegen5.Name = "Toevoegen5";
            this.Toevoegen5.Size = new System.Drawing.Size(75, 21);
            this.Toevoegen5.TabIndex = 34;
            this.Toevoegen5.Text = "Toevoegen";
            this.Toevoegen5.UseVisualStyleBackColor = true;
            this.Toevoegen5.Click += new System.EventHandler(this.Toevoegen5_Click);
            // 
            // Toevoegen4
            // 
            this.Toevoegen4.Location = new System.Drawing.Point(221, 191);
            this.Toevoegen4.Name = "Toevoegen4";
            this.Toevoegen4.Size = new System.Drawing.Size(75, 21);
            this.Toevoegen4.TabIndex = 33;
            this.Toevoegen4.Text = "Toevoegen";
            this.Toevoegen4.UseVisualStyleBackColor = true;
            this.Toevoegen4.Click += new System.EventHandler(this.Toevoegen4_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Water:   €2,50";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fanta:   €3,50";
            // 
            // Drink1
            // 
            this.Drink1.Location = new System.Drawing.Point(48, 195);
            this.Drink1.Name = "Drink1";
            this.Drink1.Size = new System.Drawing.Size(88, 21);
            this.Drink1.TabIndex = 30;
            this.Drink1.Text = "Cola:   €3,50";
            // 
            // Drinks
            // 
            this.Drinks.Location = new System.Drawing.Point(154, 169);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(88, 21);
            this.Drinks.TabIndex = 29;
            this.Drinks.Text = "Drinken";
            // 
            // Toevoegen3
            // 
            this.Toevoegen3.Location = new System.Drawing.Point(221, 129);
            this.Toevoegen3.Name = "Toevoegen3";
            this.Toevoegen3.Size = new System.Drawing.Size(75, 21);
            this.Toevoegen3.TabIndex = 28;
            this.Toevoegen3.Text = "Toevoegen";
            this.Toevoegen3.UseVisualStyleBackColor = true;
            this.Toevoegen3.Click += new System.EventHandler(this.Toevoegen3_Click);
            // 
            // Toevoegen2
            // 
            this.Toevoegen2.Location = new System.Drawing.Point(221, 96);
            this.Toevoegen2.Name = "Toevoegen2";
            this.Toevoegen2.Size = new System.Drawing.Size(75, 21);
            this.Toevoegen2.TabIndex = 27;
            this.Toevoegen2.Text = "Toevoegen";
            this.Toevoegen2.UseVisualStyleBackColor = true;
            this.Toevoegen2.Click += new System.EventHandler(this.Toevoegen2_Click);
            // 
            // Toevoegen1
            // 
            this.Toevoegen1.Location = new System.Drawing.Point(221, 65);
            this.Toevoegen1.Name = "Toevoegen1";
            this.Toevoegen1.Size = new System.Drawing.Size(75, 21);
            this.Toevoegen1.TabIndex = 26;
            this.Toevoegen1.Text = "Toevoegen";
            this.Toevoegen1.UseVisualStyleBackColor = true;
            this.Toevoegen1.Click += new System.EventHandler(this.Toevoegen1_Click);
            // 
            // Soort3
            // 
            this.Soort3.FormattingEnabled = true;
            this.Soort3.Items.AddRange(new object[] {
            "Zoet",
            "Zout",
            "Mix"});
            this.Soort3.Location = new System.Drawing.Point(142, 129);
            this.Soort3.Name = "Soort3";
            this.Soort3.Size = new System.Drawing.Size(63, 21);
            this.Soort3.TabIndex = 25;
            this.Soort3.Text = "Soort";
            // 
            // Soort2
            // 
            this.Soort2.FormattingEnabled = true;
            this.Soort2.Items.AddRange(new object[] {
            "Zoet",
            "Zout",
            "Mix"});
            this.Soort2.Location = new System.Drawing.Point(142, 96);
            this.Soort2.Name = "Soort2";
            this.Soort2.Size = new System.Drawing.Size(63, 21);
            this.Soort2.TabIndex = 24;
            this.Soort2.Text = "Soort";
            // 
            // Soort1
            // 
            this.Soort1.FormattingEnabled = true;
            this.Soort1.Items.AddRange(new object[] {
            "Zoet",
            "Zout",
            "Mix"});
            this.Soort1.Location = new System.Drawing.Point(142, 65);
            this.Soort1.Name = "Soort1";
            this.Soort1.Size = new System.Drawing.Size(63, 21);
            this.Soort1.TabIndex = 23;
            this.Soort1.Text = "Soort";
            this.Soort1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Popcorn3
            // 
            this.Popcorn3.Location = new System.Drawing.Point(48, 132);
            this.Popcorn3.Name = "Popcorn3";
            this.Popcorn3.Size = new System.Drawing.Size(88, 21);
            this.Popcorn3.TabIndex = 22;
            this.Popcorn3.Text = "Groot:   €5,50";
            // 
            // Popcorn2
            // 
            this.Popcorn2.Location = new System.Drawing.Point(48, 99);
            this.Popcorn2.Name = "Popcorn2";
            this.Popcorn2.Size = new System.Drawing.Size(88, 21);
            this.Popcorn2.TabIndex = 21;
            this.Popcorn2.Text = "Medium:   €4,50";
            // 
            // Popcorn1
            // 
            this.Popcorn1.Location = new System.Drawing.Point(48, 68);
            this.Popcorn1.Name = "Popcorn1";
            this.Popcorn1.Size = new System.Drawing.Size(88, 21);
            this.Popcorn1.TabIndex = 20;
            this.Popcorn1.Text = "Klein:   €3,50";
            this.Popcorn1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Popcorn
            // 
            this.Popcorn.Location = new System.Drawing.Point(154, 29);
            this.Popcorn.Name = "Popcorn";
            this.Popcorn.Size = new System.Drawing.Size(88, 21);
            this.Popcorn.TabIndex = 19;
            this.Popcorn.Text = "Popcorn";
            this.Popcorn.Click += new System.EventHandler(this.label1_Click);
            // 
            // Information
            // 
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(154, 8);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(66, 21);
            this.Information.TabIndex = 18;
            this.Information.Text = "Snacks";
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(91)))));
            this.Next.Location = new System.Drawing.Point(221, 294);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(118, 37);
            this.Next.TabIndex = 9;
            this.Next.Text = "Verder";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(18, 294);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(118, 37);
            this.Back.TabIndex = 8;
            this.Back.Text = "Terug";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pbMovie
            // 
            this.pbMovie.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMovie.InitialImage")));
            this.pbMovie.Location = new System.Drawing.Point(21, 69);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(117, 166);
            this.pbMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMovie.TabIndex = 17;
            this.pbMovie.TabStop = false;
            // 
            // Reserveerscherm4Snacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMovie);
            this.Controls.Add(this.FormLoad);
            this.Controls.Add(this.Receipt1);
            this.Controls.Add(this.Red_onderkant);
            this.Controls.Add(this.red_bovenkant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reserveerscherm4Snacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popcorn Plaza";
            this.red_bovenkant.ResumeLayout(false);
            this.Receipt1.ResumeLayout(false);
            this.FormLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Drink1;
        private System.Windows.Forms.Label Drinks;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Label Popcorn;
        private System.Windows.Forms.Label Popcorn1;
        private System.Windows.Forms.Label Popcorn2;
        private System.Windows.Forms.Label Popcorn3;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Panel Receipt1;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.RichTextBox rtbBon;
        private System.Windows.Forms.RichTextBox rtbTotaal;
        private System.Windows.Forms.ComboBox Soort1;
        private System.Windows.Forms.ComboBox Soort2;
        private System.Windows.Forms.ComboBox Soort3;
        private System.Windows.Forms.Button Toevoegen1;
        private System.Windows.Forms.Button Toevoegen2;
        private System.Windows.Forms.Button Toevoegen3;
        private System.Windows.Forms.Button Toevoegen4;
        private System.Windows.Forms.Button Toevoegen5;
        private System.Windows.Forms.Button Toevoegen6;

        #endregion
    }
}