﻿namespace UI
{
    partial class Overzicht
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
            this.PopcornPlaza_Tekst = new System.Windows.Forms.Label();
            this.Films_Knop = new System.Windows.Forms.Button();
            this.Binnenkort_Tekst = new System.Windows.Forms.Label();
            this.filmPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PopcornPlaza_Logo = new System.Windows.Forms.PictureBox();
            this.Zwarte_Balk = new System.Windows.Forms.PictureBox();
            this.Rode_Balk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PopcornPlaza_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zwarte_Balk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rode_Balk)).BeginInit();
            this.SuspendLayout();
            // 
            // PopcornPlaza_Tekst
            // 
            this.PopcornPlaza_Tekst.AutoSize = true;
            this.PopcornPlaza_Tekst.BackColor = System.Drawing.SystemColors.Desktop;
            this.PopcornPlaza_Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopcornPlaza_Tekst.Location = new System.Drawing.Point(69, 9);
            this.PopcornPlaza_Tekst.Name = "PopcornPlaza_Tekst";
            this.PopcornPlaza_Tekst.Size = new System.Drawing.Size(124, 20);
            this.PopcornPlaza_Tekst.TabIndex = 10;
            this.PopcornPlaza_Tekst.Text = "Popcorn Plaza";
            // 
            // Films_Knop
            // 
            this.Films_Knop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Films_Knop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Films_Knop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Films_Knop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Films_Knop.ForeColor = System.Drawing.SystemColors.Window;
            this.Films_Knop.Location = new System.Drawing.Point(12, 35);
            this.Films_Knop.Name = "Films_Knop";
            this.Films_Knop.Size = new System.Drawing.Size(75, 23);
            this.Films_Knop.TabIndex = 12;
            this.Films_Knop.Text = "Films";
            this.Films_Knop.UseVisualStyleBackColor = false;
            this.Films_Knop.Click += new System.EventHandler(this.Films_Knop_Click);
            // 
            // Binnenkort_Tekst
            // 
            this.Binnenkort_Tekst.AutoSize = true;
            this.Binnenkort_Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binnenkort_Tekst.Location = new System.Drawing.Point(264, 332);
            this.Binnenkort_Tekst.Name = "Binnenkort_Tekst";
            this.Binnenkort_Tekst.Size = new System.Drawing.Size(294, 26);
            this.Binnenkort_Tekst.TabIndex = 14;
            this.Binnenkort_Tekst.Text = "Binnenkort in de bioscoop:";
            // 
            // filmPanel1
            // 
            this.filmPanel1.Location = new System.Drawing.Point(12, 405);
            this.filmPanel1.Name = "filmPanel1";
            this.filmPanel1.Size = new System.Drawing.Size(807, 201);
            this.filmPanel1.TabIndex = 18;
            // 
            // PopcornPlaza_Logo
            // 
            this.PopcornPlaza_Logo.Image = global::UI.Properties.Resources.output_onlinepngtools__4_1;
            this.PopcornPlaza_Logo.Location = new System.Drawing.Point(12, 0);
            this.PopcornPlaza_Logo.Name = "PopcornPlaza_Logo";
            this.PopcornPlaza_Logo.Size = new System.Drawing.Size(41, 39);
            this.PopcornPlaza_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PopcornPlaza_Logo.TabIndex = 11;
            this.PopcornPlaza_Logo.TabStop = false;
            // 
            // Zwarte_Balk
            // 
            this.Zwarte_Balk.BackColor = System.Drawing.SystemColors.MenuText;
            this.Zwarte_Balk.Location = new System.Drawing.Point(0, 33);
            this.Zwarte_Balk.Name = "Zwarte_Balk";
            this.Zwarte_Balk.Size = new System.Drawing.Size(831, 25);
            this.Zwarte_Balk.TabIndex = 4;
            this.Zwarte_Balk.TabStop = false;
            // 
            // Rode_Balk
            // 
            this.Rode_Balk.BackColor = System.Drawing.SystemColors.Desktop;
            this.Rode_Balk.Location = new System.Drawing.Point(0, 0);
            this.Rode_Balk.Name = "Rode_Balk";
            this.Rode_Balk.Size = new System.Drawing.Size(831, 50);
            this.Rode_Balk.TabIndex = 3;
            this.Rode_Balk.TabStop = false;
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(831, 618);
            this.Controls.Add(this.filmPanel1);
            this.Controls.Add(this.Binnenkort_Tekst);
            this.Controls.Add(this.Films_Knop);
            this.Controls.Add(this.PopcornPlaza_Logo);
            this.Controls.Add(this.PopcornPlaza_Tekst);
            this.Controls.Add(this.Zwarte_Balk);
            this.Controls.Add(this.Rode_Balk);
            this.Name = "Overzicht";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Overzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopcornPlaza_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zwarte_Balk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rode_Balk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Rode_Balk;
        private System.Windows.Forms.PictureBox Zwarte_Balk;
        private System.Windows.Forms.Label PopcornPlaza_Tekst;
        private System.Windows.Forms.PictureBox PopcornPlaza_Logo;
        private System.Windows.Forms.Button Films_Knop;
        private System.Windows.Forms.Label Binnenkort_Tekst;
        private System.Windows.Forms.FlowLayoutPanel filmPanel1;
    }
}