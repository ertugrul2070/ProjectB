namespace UI
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.Actueel_Tekst = new System.Windows.Forms.Label();
            this.Films_Knop = new System.Windows.Forms.Button();
            this.PopcornPlaza_Tekst = new System.Windows.Forms.Label();
            this.Verwacht_Tekst = new System.Windows.Forms.Label();
            this.PopcornPlaza_Logo = new System.Windows.Forms.PictureBox();
            this.Zwarte_Balk = new System.Windows.Forms.PictureBox();
            this.Rode_Balk = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelActueel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelVerwacht = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PopcornPlaza_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zwarte_Balk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rode_Balk)).BeginInit();
            this.SuspendLayout();
            // 
            // Actueel_Tekst
            // 
            this.Actueel_Tekst.AutoSize = true;
            this.Actueel_Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actueel_Tekst.Location = new System.Drawing.Point(7, 63);
            this.Actueel_Tekst.Name = "Actueel_Tekst";
            this.Actueel_Tekst.Size = new System.Drawing.Size(85, 25);
            this.Actueel_Tekst.TabIndex = 1;
            this.Actueel_Tekst.Text = "Actueel";
            this.Actueel_Tekst.Click += new System.EventHandler(this.label1_Click);
            // 
            // Films_Knop
            // 
            this.Films_Knop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Films_Knop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Films_Knop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Films_Knop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Films_Knop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Films_Knop.ForeColor = System.Drawing.SystemColors.Window;
            this.Films_Knop.Location = new System.Drawing.Point(12, 37);
            this.Films_Knop.Name = "Films_Knop";
            this.Films_Knop.Size = new System.Drawing.Size(75, 23);
            this.Films_Knop.TabIndex = 4;
            this.Films_Knop.Text = "Startpagina";
            this.Films_Knop.UseVisualStyleBackColor = false;
            this.Films_Knop.Click += new System.EventHandler(this.Films_Knop_Click);
            // 
            // PopcornPlaza_Tekst
            // 
            this.PopcornPlaza_Tekst.AutoSize = true;
            this.PopcornPlaza_Tekst.BackColor = System.Drawing.SystemColors.Desktop;
            this.PopcornPlaza_Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopcornPlaza_Tekst.Location = new System.Drawing.Point(68, 9);
            this.PopcornPlaza_Tekst.Name = "PopcornPlaza_Tekst";
            this.PopcornPlaza_Tekst.Size = new System.Drawing.Size(124, 20);
            this.PopcornPlaza_Tekst.TabIndex = 9;
            this.PopcornPlaza_Tekst.Text = "Popcorn Plaza";
            this.PopcornPlaza_Tekst.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Verwacht_Tekst
            // 
            this.Verwacht_Tekst.AutoSize = true;
            this.Verwacht_Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verwacht_Tekst.Location = new System.Drawing.Point(1, 339);
            this.Verwacht_Tekst.Name = "Verwacht_Tekst";
            this.Verwacht_Tekst.Size = new System.Drawing.Size(102, 25);
            this.Verwacht_Tekst.TabIndex = 10;
            this.Verwacht_Tekst.Text = "Verwacht";
            // 
            // PopcornPlaza_Logo
            // 
            this.PopcornPlaza_Logo.BackColor = System.Drawing.SystemColors.WindowText;
            this.PopcornPlaza_Logo.ImageLocation = "https://i.imgur.com/OPnRgAV.png";
            this.PopcornPlaza_Logo.Location = new System.Drawing.Point(12, 0);
            this.PopcornPlaza_Logo.Name = "PopcornPlaza_Logo";
            this.PopcornPlaza_Logo.Size = new System.Drawing.Size(41, 39);
            this.PopcornPlaza_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PopcornPlaza_Logo.TabIndex = 8;
            this.PopcornPlaza_Logo.TabStop = false;
            // 
            // Zwarte_Balk
            // 
            this.Zwarte_Balk.BackColor = System.Drawing.SystemColors.MenuText;
            this.Zwarte_Balk.Location = new System.Drawing.Point(0, 36);
            this.Zwarte_Balk.Name = "Zwarte_Balk";
            this.Zwarte_Balk.Size = new System.Drawing.Size(800, 24);
            this.Zwarte_Balk.TabIndex = 3;
            this.Zwarte_Balk.TabStop = false;
            // 
            // Rode_Balk
            // 
            this.Rode_Balk.BackColor = System.Drawing.SystemColors.Desktop;
            this.Rode_Balk.Location = new System.Drawing.Point(0, 0);
            this.Rode_Balk.Name = "Rode_Balk";
            this.Rode_Balk.Size = new System.Drawing.Size(800, 50);
            this.Rode_Balk.TabIndex = 2;
            this.Rode_Balk.TabStop = false;
            // 
            // flowLayoutPanelActueel
            // 
            this.flowLayoutPanelActueel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanelActueel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanelActueel.Location = new System.Drawing.Point(13, 105);
            this.flowLayoutPanelActueel.Name = "flowLayoutPanelActueel";
            this.flowLayoutPanelActueel.Size = new System.Drawing.Size(787, 161);
            this.flowLayoutPanelActueel.TabIndex = 11;
            // 
            // flowLayoutPanelVerwacht
            // 
            this.flowLayoutPanelVerwacht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanelVerwacht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanelVerwacht.Location = new System.Drawing.Point(12, 382);
            this.flowLayoutPanelVerwacht.Name = "flowLayoutPanelVerwacht";
            this.flowLayoutPanelVerwacht.Size = new System.Drawing.Size(787, 161);
            this.flowLayoutPanelVerwacht.TabIndex = 12;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 618);
            this.Controls.Add(this.flowLayoutPanelVerwacht);
            this.Controls.Add(this.flowLayoutPanelActueel);
            this.Controls.Add(this.Verwacht_Tekst);
            this.Controls.Add(this.PopcornPlaza_Tekst);
            this.Controls.Add(this.PopcornPlaza_Logo);
            this.Controls.Add(this.Films_Knop);
            this.Controls.Add(this.Zwarte_Balk);
            this.Controls.Add(this.Rode_Balk);
            this.Controls.Add(this.Actueel_Tekst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popcorn Plaza";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopcornPlaza_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zwarte_Balk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rode_Balk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Actueel_Tekst;
        private System.Windows.Forms.Button Films_Knop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActueel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVerwacht;
        private System.Windows.Forms.PictureBox PopcornPlaza_Logo;
        private System.Windows.Forms.Label PopcornPlaza_Tekst;
        private System.Windows.Forms.PictureBox Rode_Balk;
        private System.Windows.Forms.Label Verwacht_Tekst;
        private System.Windows.Forms.PictureBox Zwarte_Balk;

        #endregion
    }
}