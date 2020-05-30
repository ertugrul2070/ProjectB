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
            this.Actueel_Tekst = new System.Windows.Forms.Label();
            this.Films_Knop = new System.Windows.Forms.Button();
            this.PopcornPlaza_Tekst = new System.Windows.Forms.Label();
            this.Verwacht_Tekst = new System.Windows.Forms.Label();
            this.PopcornPlaza_Logo = new System.Windows.Forms.PictureBox();
            this.Zwarte_Balk = new System.Windows.Forms.PictureBox();
            this.Rode_Balk = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelActueel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelVerwacht = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchFilm = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.GenreFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PopcornPlaza_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zwarte_Balk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rode_Balk)).BeginInit();
            this.SuspendLayout();
            // 
            // Actueel_Tekst
            // 
            this.Actueel_Tekst.AutoSize = true;
            this.Actueel_Tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actueel_Tekst.Location = new System.Drawing.Point(12, 77);
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
            this.Films_Knop.Text = "Home";
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
            this.Verwacht_Tekst.Location = new System.Drawing.Point(8, 354);
            this.Verwacht_Tekst.Name = "Verwacht_Tekst";
            this.Verwacht_Tekst.Size = new System.Drawing.Size(102, 25);
            this.Verwacht_Tekst.TabIndex = 10;
            this.Verwacht_Tekst.Text = "Verwacht";
            // 
            // PopcornPlaza_Logo
            // 
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
            this.Zwarte_Balk.Size = new System.Drawing.Size(837, 24);
            this.Zwarte_Balk.TabIndex = 3;
            this.Zwarte_Balk.TabStop = false;
            // 
            // Rode_Balk
            // 
            this.Rode_Balk.BackColor = System.Drawing.SystemColors.Desktop;
            this.Rode_Balk.Location = new System.Drawing.Point(0, 0);
            this.Rode_Balk.Name = "Rode_Balk";
            this.Rode_Balk.Size = new System.Drawing.Size(837, 50);
            this.Rode_Balk.TabIndex = 2;
            this.Rode_Balk.TabStop = false;
            // 
            // flowLayoutPanelActueel
            // 
            this.flowLayoutPanelActueel.AutoScroll = true;
            this.flowLayoutPanelActueel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanelActueel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanelActueel.Location = new System.Drawing.Point(13, 105);
            this.flowLayoutPanelActueel.Name = "flowLayoutPanelActueel";
            this.flowLayoutPanelActueel.Size = new System.Drawing.Size(806, 224);
            this.flowLayoutPanelActueel.TabIndex = 11;
            // 
            // flowLayoutPanelVerwacht
            // 
            this.flowLayoutPanelVerwacht.AutoScroll = true;
            this.flowLayoutPanelVerwacht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanelVerwacht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanelVerwacht.Location = new System.Drawing.Point(12, 382);
            this.flowLayoutPanelVerwacht.Name = "flowLayoutPanelVerwacht";
            this.flowLayoutPanelVerwacht.Size = new System.Drawing.Size(807, 224);
            this.flowLayoutPanelVerwacht.TabIndex = 12;
            // 
            // SearchFilm
            // 
            this.SearchFilm.BackColor = System.Drawing.SystemColors.Desktop;
            this.SearchFilm.Location = new System.Drawing.Point(92, 37);
            this.SearchFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchFilm.Name = "SearchFilm";
            this.SearchFilm.Size = new System.Drawing.Size(112, 20);
            this.SearchFilm.TabIndex = 13;
            this.SearchFilm.Visible = false;
            // 
            // flowLayoutPanelSearch
            // 
            this.flowLayoutPanelSearch.AutoScroll = true;
            this.flowLayoutPanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelSearch.Location = new System.Drawing.Point(92, 66);
            this.flowLayoutPanelSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelSearch.Name = "flowLayoutPanelSearch";
            this.flowLayoutPanelSearch.Size = new System.Drawing.Size(139, 178);
            this.flowLayoutPanelSearch.TabIndex = 14;
            this.flowLayoutPanelSearch.Visible = false;
            // 
            // GenreFilter
            // 
            this.GenreFilter.AccessibleName = "";
            this.GenreFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreFilter.FormattingEnabled = true;
            this.GenreFilter.Items.AddRange(new object[] {
            "alle",
            "yes",
            "Adventure",
            "Horror",
            "Comedy",
            "Fantasy",
            "Romance"});
            this.GenreFilter.Location = new System.Drawing.Point(727, 77);
            this.GenreFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenreFilter.Name = "GenreFilter";
            this.GenreFilter.Size = new System.Drawing.Size(92, 23);
            this.GenreFilter.TabIndex = 15;
            this.GenreFilter.Text = "Genre";
            this.GenreFilter.SelectedIndexChanged += new System.EventHandler(this.Homepage_Load);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 618);
            this.Controls.Add(this.GenreFilter);
            this.Controls.Add(this.flowLayoutPanelSearch);
            this.Controls.Add(this.SearchFilm);
            this.Controls.Add(this.flowLayoutPanelVerwacht);
            this.Controls.Add(this.flowLayoutPanelActueel);
            this.Controls.Add(this.Verwacht_Tekst);
            this.Controls.Add(this.PopcornPlaza_Tekst);
            this.Controls.Add(this.PopcornPlaza_Logo);
            this.Controls.Add(this.Films_Knop);
            this.Controls.Add(this.Zwarte_Balk);
            this.Controls.Add(this.Rode_Balk);
            this.Controls.Add(this.Actueel_Tekst);
            this.Name = "Homepage";
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

        private System.Windows.Forms.TextBox SearchFilm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearch;
        private System.Windows.Forms.ComboBox GenreFilter;
    }
}