﻿namespace UI
{
    partial class Registreerscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registreerscherm));
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.black_panel = new System.Windows.Forms.Panel();
            this.FormLoad = new System.Windows.Forms.Panel();
            this.btnrRegister = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.FormLoad.SuspendLayout();
            this.red_bovenkant.SuspendLayout();
            this.SuspendLayout();
            // 
            // Red_onderkant
            // 
            this.Red_onderkant.BackColor = System.Drawing.Color.DarkRed;
            this.Red_onderkant.Location = new System.Drawing.Point(0, 312);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(441, 32);
            this.Red_onderkant.TabIndex = 10;
            // 
            // black_panel
            // 
            this.black_panel.BackColor = System.Drawing.Color.Black;
            this.black_panel.Location = new System.Drawing.Point(0, 40);
            this.black_panel.Margin = new System.Windows.Forms.Padding(2);
            this.black_panel.Name = "black_panel";
            this.black_panel.Size = new System.Drawing.Size(441, 14);
            this.black_panel.TabIndex = 3;
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(242)))), ((int)(((byte)(90)))));
            this.FormLoad.Controls.Add(this.btnrRegister);
            this.FormLoad.Controls.Add(this.txtPassword2);
            this.FormLoad.Controls.Add(this.txtPassword);
            this.FormLoad.Controls.Add(this.label2);
            this.FormLoad.Controls.Add(this.label1);
            this.FormLoad.Controls.Add(this.Information);
            this.FormLoad.Location = new System.Drawing.Point(79, 61);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(266, 246);
            this.FormLoad.TabIndex = 12;
            // 
            // btnrRegister
            // 
            this.btnrRegister.Location = new System.Drawing.Point(18, 199);
            this.btnrRegister.Name = "btnrRegister";
            this.btnrRegister.Size = new System.Drawing.Size(215, 23);
            this.btnrRegister.TabIndex = 24;
            this.btnrRegister.Text = "Registreer";
            this.btnrRegister.UseVisualStyleBackColor = true;
            this.btnrRegister.Click += new System.EventHandler(this.btnrRegister_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(18, 145);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(215, 20);
            this.txtPassword2.TabIndex = 23;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(18, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(215, 20);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Voer wachtwoord in:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Voer wachtwoord nogmaals in:";
            // 
            // Information
            // 
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(41, 12);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(161, 25);
            this.Information.TabIndex = 19;
            this.Information.Text = "Kies een wachtwoord";
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(0, 0);
            this.red_bovenkant.Margin = new System.Windows.Forms.Padding(2);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(441, 56);
            this.red_bovenkant.TabIndex = 11;
            // 
            // Registreerscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 344);
            this.Controls.Add(this.Red_onderkant);
            this.Controls.Add(this.FormLoad);
            this.Controls.Add(this.red_bovenkant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registreerscherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popcorn Plaza";
            this.FormLoad.ResumeLayout(false);
            this.FormLoad.PerformLayout();
            this.red_bovenkant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Button btnrRegister;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;

        #endregion
    }
}