namespace UI
{
    partial class Reserveerschem2Tickets
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
            this.FormLoad = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.Button();
            this.Price3 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.Price1 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.Senior = new System.Windows.Forms.Label();
            this.Child = new System.Windows.Forms.Label();
            this.Normal = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.NormalField = new System.Windows.Forms.TextBox();
            this.ChildField = new System.Windows.Forms.TextBox();
            this.BoomerField = new System.Windows.Forms.TextBox();
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.black_panel = new System.Windows.Forms.Panel();
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.FormLoad.SuspendLayout();
            this.red_bovenkant.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLoad
            // 
            this.FormLoad.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (246)))), ((int) (((byte) (242)))), ((int) (((byte) (90)))));
            this.FormLoad.Controls.Add(this.Next);
            this.FormLoad.Controls.Add(this.Price3);
            this.FormLoad.Controls.Add(this.Price2);
            this.FormLoad.Controls.Add(this.Price1);
            this.FormLoad.Controls.Add(this.Information);
            this.FormLoad.Controls.Add(this.Senior);
            this.FormLoad.Controls.Add(this.Child);
            this.FormLoad.Controls.Add(this.Normal);
            this.FormLoad.Controls.Add(this.Back);
            this.FormLoad.Controls.Add(this.NormalField);
            this.FormLoad.Controls.Add(this.ChildField);
            this.FormLoad.Controls.Add(this.BoomerField);
            this.FormLoad.Location = new System.Drawing.Point(211, 58);
            this.FormLoad.Name = "FormLoad";
            this.FormLoad.Size = new System.Drawing.Size(360, 334);
            this.FormLoad.TabIndex = 9;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (253)))), ((int) (((byte) (254)))), ((int) (((byte) (91)))));
            this.Next.Location = new System.Drawing.Point(209, 259);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(118, 37);
            this.Next.TabIndex = 22;
            this.Next.Text = "Verder";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Price3
            // 
            this.Price3.Location = new System.Drawing.Point(154, 193);
            this.Price3.Name = "Price3";
            this.Price3.Size = new System.Drawing.Size(44, 21);
            this.Price3.TabIndex = 21;
            this.Price3.Text = "€8,-";
            // 
            // Price2
            // 
            this.Price2.Location = new System.Drawing.Point(154, 138);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(44, 21);
            this.Price2.TabIndex = 20;
            this.Price2.Text = "€6,-";
            // 
            // Price1
            // 
            this.Price1.Location = new System.Drawing.Point(154, 83);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(44, 21);
            this.Price1.TabIndex = 19;
            this.Price1.Text = "€12,-";
            this.Price1.Click += new System.EventHandler(this.Price1_Click);
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(154, 8);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(88, 21);
            this.Information.TabIndex = 18;
            this.Information.Text = "Tickets";
            // 
            // Senior
            // 
            this.Senior.Location = new System.Drawing.Point(57, 194);
            this.Senior.Name = "Senior";
            this.Senior.Size = new System.Drawing.Size(68, 21);
            this.Senior.TabIndex = 12;
            this.Senior.Text = "60+:";
            // 
            // Child
            // 
            this.Child.Location = new System.Drawing.Point(57, 138);
            this.Child.Name = "Child";
            this.Child.Size = new System.Drawing.Size(79, 21);
            this.Child.TabIndex = 11;
            this.Child.Text = "Kind (0-12):";
            // 
            // Normal
            // 
            this.Normal.Location = new System.Drawing.Point(57, 87);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(79, 21);
            this.Normal.TabIndex = 10;
            this.Normal.Text = "Normaal (12+):";
            this.Normal.Click += new System.EventHandler(this.Gender_Click);
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
            // NormalField
            // 
            this.NormalField.Location = new System.Drawing.Point(231, 84);
            this.NormalField.Name = "NormalField";
            this.NormalField.Size = new System.Drawing.Size(96, 20);
            this.NormalField.TabIndex = 2;
            // 
            // ChildField
            // 
            this.ChildField.Location = new System.Drawing.Point(231, 135);
            this.ChildField.Name = "ChildField";
            this.ChildField.Size = new System.Drawing.Size(96, 20);
            this.ChildField.TabIndex = 1;
            // 
            // BoomerField
            // 
            this.BoomerField.Location = new System.Drawing.Point(231, 194);
            this.BoomerField.Name = "BoomerField";
            this.BoomerField.Size = new System.Drawing.Size(96, 20);
            this.BoomerField.TabIndex = 0;
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(-1, -1);
            this.red_bovenkant.Margin = new System.Windows.Forms.Padding(2);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(803, 54);
            this.red_bovenkant.TabIndex = 10;
            // 
            // black_panel
            // 
            this.black_panel.BackColor = System.Drawing.Color.Black;
            this.black_panel.Location = new System.Drawing.Point(0, 40);
            this.black_panel.Margin = new System.Windows.Forms.Padding(2);
            this.black_panel.Name = "black_panel";
            this.black_panel.Size = new System.Drawing.Size(803, 14);
            this.black_panel.TabIndex = 3;
            // 
            // Red_onderkant
            // 
            this.Red_onderkant.BackColor = System.Drawing.Color.DarkRed;
            this.Red_onderkant.Location = new System.Drawing.Point(1, 417);
            this.Red_onderkant.Margin = new System.Windows.Forms.Padding(2);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(801, 32);
            this.Red_onderkant.TabIndex = 11;
            // 
            // Reserveerschem2Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Red_onderkant);
            this.Controls.Add(this.red_bovenkant);
            this.Controls.Add(this.FormLoad);
            this.Name = "Reserveerschem2Tickets";
            this.Text = "Form1";
            this.FormLoad.ResumeLayout(false);
            this.FormLoad.PerformLayout();
            this.red_bovenkant.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.TextBox BoomerField;
        private System.Windows.Forms.Label Child;
        private System.Windows.Forms.TextBox ChildField;
        private System.Windows.Forms.Panel FormLoad;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label Normal;
        private System.Windows.Forms.TextBox NormalField;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Label Price2;
        private System.Windows.Forms.Label Price3;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.Label Senior;

        #endregion
    }
}