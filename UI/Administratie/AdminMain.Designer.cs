namespace UI.Administratie
{
    partial class AdminMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMovie = new System.Windows.Forms.Button();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.LoguitBtn = new System.Windows.Forms.Button();
            this.SnacksBtn = new System.Windows.Forms.Button();
            this.FilmsBtn = new System.Windows.Forms.Button();
            this.GebruikersBtn = new System.Windows.Forms.Button();
            this.PaneelBtn = new System.Windows.Forms.Button();
            this.pieChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.containerPanele = new System.Windows.Forms.Panel();
            this.panelPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.addMovie);
            this.panel1.Controls.Add(this.selectPanel);
            this.panel1.Controls.Add(this.LoguitBtn);
            this.panel1.Controls.Add(this.SnacksBtn);
            this.panel1.Controls.Add(this.FilmsBtn);
            this.panel1.Controls.Add(this.GebruikersBtn);
            this.panel1.Controls.Add(this.PaneelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 552);
            this.panel1.TabIndex = 0;
            // 
            // addMovie
            // 
            this.addMovie.FlatAppearance.BorderSize = 0;
            this.addMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie.Image = global::UI.Properties.Resources.plus__1_;
            this.addMovie.Location = new System.Drawing.Point(88, 144);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(109, 75);
            this.addMovie.TabIndex = 5;
            this.addMovie.Text = "Toevoegen";
            this.addMovie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(41)))));
            this.selectPanel.Location = new System.Drawing.Point(174, 11);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(10, 50);
            this.selectPanel.TabIndex = 1;
            // 
            // LoguitBtn
            // 
            this.LoguitBtn.FlatAppearance.BorderSize = 0;
            this.LoguitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoguitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoguitBtn.Image = global::UI.Properties.Resources.logout;
            this.LoguitBtn.Location = new System.Drawing.Point(0, 477);
            this.LoguitBtn.Name = "LoguitBtn";
            this.LoguitBtn.Size = new System.Drawing.Size(200, 75);
            this.LoguitBtn.TabIndex = 4;
            this.LoguitBtn.Text = "Log Uit";
            this.LoguitBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoguitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LoguitBtn.UseVisualStyleBackColor = true;
            this.LoguitBtn.Click += new System.EventHandler(this.LoguitBtn_Click);
            // 
            // SnacksBtn
            // 
            this.SnacksBtn.FlatAppearance.BorderSize = 0;
            this.SnacksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SnacksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnacksBtn.Image = global::UI.Properties.Resources.snack;
            this.SnacksBtn.Location = new System.Drawing.Point(0, 225);
            this.SnacksBtn.Name = "SnacksBtn";
            this.SnacksBtn.Size = new System.Drawing.Size(200, 75);
            this.SnacksBtn.TabIndex = 3;
            this.SnacksBtn.Text = "Snacks";
            this.SnacksBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SnacksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SnacksBtn.UseVisualStyleBackColor = true;
            this.SnacksBtn.Click += new System.EventHandler(this.SnacksBtn_Click);
            // 
            // FilmsBtn
            // 
            this.FilmsBtn.FlatAppearance.BorderSize = 0;
            this.FilmsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilmsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilmsBtn.Image = global::UI.Properties.Resources.cinema;
            this.FilmsBtn.Location = new System.Drawing.Point(0, 144);
            this.FilmsBtn.Name = "FilmsBtn";
            this.FilmsBtn.Size = new System.Drawing.Size(100, 75);
            this.FilmsBtn.TabIndex = 2;
            this.FilmsBtn.Text = "Films";
            this.FilmsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FilmsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FilmsBtn.UseVisualStyleBackColor = true;
            this.FilmsBtn.Click += new System.EventHandler(this.FilmsBtn_Click);
            // 
            // GebruikersBtn
            // 
            this.GebruikersBtn.FlatAppearance.BorderSize = 0;
            this.GebruikersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GebruikersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GebruikersBtn.Image = global::UI.Properties.Resources.user;
            this.GebruikersBtn.Location = new System.Drawing.Point(0, 75);
            this.GebruikersBtn.Name = "GebruikersBtn";
            this.GebruikersBtn.Size = new System.Drawing.Size(200, 75);
            this.GebruikersBtn.TabIndex = 1;
            this.GebruikersBtn.Text = "Gebruikers";
            this.GebruikersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GebruikersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GebruikersBtn.UseVisualStyleBackColor = true;
            this.GebruikersBtn.Click += new System.EventHandler(this.GebruikersBtn_Click);
            // 
            // PaneelBtn
            // 
            this.PaneelBtn.FlatAppearance.BorderSize = 0;
            this.PaneelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaneelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaneelBtn.Image = global::UI.Properties.Resources.home;
            this.PaneelBtn.Location = new System.Drawing.Point(0, 0);
            this.PaneelBtn.Name = "PaneelBtn";
            this.PaneelBtn.Size = new System.Drawing.Size(200, 75);
            this.PaneelBtn.TabIndex = 0;
            this.PaneelBtn.Text = "Paneel";
            this.PaneelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PaneelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PaneelBtn.UseVisualStyleBackColor = true;
            this.PaneelBtn.Click += new System.EventHandler(this.PaneelBtn_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.pieChart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.pieChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChart1.Legends.Add(legend1);
            this.pieChart1.Location = new System.Drawing.Point(483, 12);
            this.pieChart1.Name = "pieChart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Pie1";
            this.pieChart1.Series.Add(series1);
            this.pieChart1.Size = new System.Drawing.Size(262, 207);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "chart1";
            // 
            // pieChart2
            // 
            this.pieChart2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(210)))), ((int)(((byte)(65)))));
            this.pieChart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.pieChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChart2.Legends.Add(legend2);
            this.pieChart2.Location = new System.Drawing.Point(206, 12);
            this.pieChart2.Name = "pieChart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Pie2";
            this.pieChart2.Series.Add(series2);
            this.pieChart2.Size = new System.Drawing.Size(262, 207);
            this.pieChart2.TabIndex = 1;
            this.pieChart2.Text = "chart1";
            // 
            // containerPanele
            // 
            this.containerPanele.Location = new System.Drawing.Point(206, 521);
            this.containerPanele.Name = "containerPanele";
            this.containerPanele.Size = new System.Drawing.Size(539, 19);
            this.containerPanele.TabIndex = 2;
            // 
            // panelPanel
            // 
            this.panelPanel.Location = new System.Drawing.Point(206, 225);
            this.panelPanel.Name = "panelPanel";
            this.panelPanel.Size = new System.Drawing.Size(539, 224);
            this.panelPanel.TabIndex = 3;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(766, 552);
            this.Controls.Add(this.panelPanel);
            this.Controls.Add(this.containerPanele);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoguitBtn;
        private System.Windows.Forms.Button SnacksBtn;
        private System.Windows.Forms.Button FilmsBtn;
        private System.Windows.Forms.Button GebruikersBtn;
        private System.Windows.Forms.Button PaneelBtn;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart2;
        private System.Windows.Forms.Panel containerPanele;
        private System.Windows.Forms.Panel panelPanel;
        private System.Windows.Forms.Button addMovie;
    }
}