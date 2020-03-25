namespace reserveren_form
{
    partial class Form1
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
            this.back_button = new System.Windows.Forms.Button();
            this.reserveer = new System.Windows.Forms.Label();
            this.film_naam = new System.Windows.Forms.Label();
            this.black_panel = new System.Windows.Forms.Panel();
            this.Red_onderkant = new System.Windows.Forms.Panel();
            this.red_bovenkant = new System.Windows.Forms.Panel();
            this.ticket = new System.Windows.Forms.Label();
            this.ticket_normal = new System.Windows.Forms.Label();
            this.ticket_kind = new System.Windows.Forms.Label();
            this.Ticket_60plus = new System.Windows.Forms.Label();
            this.popcornpass = new System.Windows.Forms.Label();
            this.silverpass = new System.Windows.Forms.Label();
            this.goldenpass = new System.Windows.Forms.Label();
            this.prijs_normal = new System.Windows.Forms.Label();
            this.prijs_kind = new System.Windows.Forms.Label();
            this.prijs_60plus = new System.Windows.Forms.Label();
            this.prijs_popcornpass = new System.Windows.Forms.Label();
            this.prijs_silverpass = new System.Windows.Forms.Label();
            this.prijs_goldpass = new System.Windows.Forms.Label();
            this.amount_normal = new System.Windows.Forms.TextBox();
            this.amount_kind = new System.Windows.Forms.TextBox();
            this.amount_60plus = new System.Windows.Forms.TextBox();
            this.amount_popcornpass = new System.Windows.Forms.TextBox();
            this.amount_silverpass = new System.Windows.Forms.TextBox();
            this.amount_goldpass = new System.Windows.Forms.TextBox();
            this.abonnementen = new System.Windows.Forms.Label();
            this.snacks = new System.Windows.Forms.Label();
            this.stoelen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.amount_popcorn = new System.Windows.Forms.TextBox();
            this.amount_limonade = new System.Windows.Forms.TextBox();
            this.amount_chips = new System.Windows.Forms.TextBox();
            this.amount_comfort = new System.Windows.Forms.TextBox();
            this.amount_loveseat = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.totaal_label = new System.Windows.Forms.Label();
            this.totaal_bedrag = new System.Windows.Forms.Label();
            this.red_bovenkant.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back_button.Location = new System.Drawing.Point(28, 72);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(101, 48);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Terug";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserveer
            // 
            this.reserveer.AutoSize = true;
            this.reserveer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveer.Location = new System.Drawing.Point(209, 88);
            this.reserveer.Name = "reserveer";
            this.reserveer.Size = new System.Drawing.Size(134, 24);
            this.reserveer.TabIndex = 1;
            this.reserveer.Text = "Reserveer   >>";
            this.reserveer.Click += new System.EventHandler(this.label1_Click);
            // 
            // film_naam
            // 
            this.film_naam.AutoSize = true;
            this.film_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.film_naam.Location = new System.Drawing.Point(359, 88);
            this.film_naam.Name = "film_naam";
            this.film_naam.Size = new System.Drawing.Size(61, 24);
            this.film_naam.TabIndex = 2;
            this.film_naam.Text = "naam";
            // 
            // black_panel
            // 
            this.black_panel.BackColor = System.Drawing.Color.Black;
            this.black_panel.Location = new System.Drawing.Point(0, 49);
            this.black_panel.Name = "black_panel";
            this.black_panel.Size = new System.Drawing.Size(900, 17);
            this.black_panel.TabIndex = 3;
            // 
            // Red_onderkant
            // 
            this.Red_onderkant.BackColor = System.Drawing.Color.DarkRed;
            this.Red_onderkant.Location = new System.Drawing.Point(-2, 450);
            this.Red_onderkant.Name = "Red_onderkant";
            this.Red_onderkant.Size = new System.Drawing.Size(900, 40);
            this.Red_onderkant.TabIndex = 4;
            // 
            // red_bovenkant
            // 
            this.red_bovenkant.BackColor = System.Drawing.Color.DarkRed;
            this.red_bovenkant.Controls.Add(this.black_panel);
            this.red_bovenkant.Location = new System.Drawing.Point(-2, 0);
            this.red_bovenkant.Name = "red_bovenkant";
            this.red_bovenkant.Size = new System.Drawing.Size(900, 66);
            this.red_bovenkant.TabIndex = 5;
            // 
            // ticket
            // 
            this.ticket.AutoSize = true;
            this.ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket.Location = new System.Drawing.Point(166, 143);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(82, 25);
            this.ticket.TabIndex = 6;
            this.ticket.Text = "Tickets";
            // 
            // ticket_normal
            // 
            this.ticket_normal.AutoSize = true;
            this.ticket_normal.Location = new System.Drawing.Point(93, 193);
            this.ticket_normal.Name = "ticket_normal";
            this.ticket_normal.Size = new System.Drawing.Size(103, 17);
            this.ticket_normal.TabIndex = 7;
            this.ticket_normal.Text = "Normaal (12+) ";
            // 
            // ticket_kind
            // 
            this.ticket_kind.AutoSize = true;
            this.ticket_kind.Location = new System.Drawing.Point(93, 220);
            this.ticket_kind.Name = "ticket_kind";
            this.ticket_kind.Size = new System.Drawing.Size(87, 17);
            this.ticket_kind.TabIndex = 8;
            this.ticket_kind.Text = "Kind (0-12)  ";
            // 
            // Ticket_60plus
            // 
            this.Ticket_60plus.AutoSize = true;
            this.Ticket_60plus.Location = new System.Drawing.Point(93, 249);
            this.Ticket_60plus.Name = "Ticket_60plus";
            this.Ticket_60plus.Size = new System.Drawing.Size(93, 17);
            this.Ticket_60plus.TabIndex = 9;
            this.Ticket_60plus.Text = "60-plus (60+)";
            // 
            // popcornpass
            // 
            this.popcornpass.AutoSize = true;
            this.popcornpass.Location = new System.Drawing.Point(82, 325);
            this.popcornpass.Name = "popcornpass";
            this.popcornpass.Size = new System.Drawing.Size(96, 17);
            this.popcornpass.TabIndex = 10;
            this.popcornpass.Text = "Popcorn Pass";
            // 
            // silverpass
            // 
            this.silverpass.AutoSize = true;
            this.silverpass.Location = new System.Drawing.Point(82, 355);
            this.silverpass.Name = "silverpass";
            this.silverpass.Size = new System.Drawing.Size(78, 17);
            this.silverpass.TabIndex = 11;
            this.silverpass.Text = "Silver Pass";
            // 
            // goldenpass
            // 
            this.goldenpass.AutoSize = true;
            this.goldenpass.Location = new System.Drawing.Point(82, 382);
            this.goldenpass.Name = "goldenpass";
            this.goldenpass.Size = new System.Drawing.Size(73, 17);
            this.goldenpass.TabIndex = 12;
            this.goldenpass.Text = "Gold Pass";
            // 
            // prijs_normal
            // 
            this.prijs_normal.AutoSize = true;
            this.prijs_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijs_normal.Location = new System.Drawing.Point(203, 193);
            this.prijs_normal.Name = "prijs_normal";
            this.prijs_normal.Size = new System.Drawing.Size(51, 17);
            this.prijs_normal.TabIndex = 13;
            this.prijs_normal.Text = "€ 11,-";
            // 
            // prijs_kind
            // 
            this.prijs_kind.AutoSize = true;
            this.prijs_kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijs_kind.Location = new System.Drawing.Point(206, 220);
            this.prijs_kind.Name = "prijs_kind";
            this.prijs_kind.Size = new System.Drawing.Size(42, 17);
            this.prijs_kind.TabIndex = 14;
            this.prijs_kind.Text = "€ 6,-";
            // 
            // prijs_60plus
            // 
            this.prijs_60plus.AutoSize = true;
            this.prijs_60plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijs_60plus.Location = new System.Drawing.Point(206, 248);
            this.prijs_60plus.Name = "prijs_60plus";
            this.prijs_60plus.Size = new System.Drawing.Size(42, 17);
            this.prijs_60plus.TabIndex = 15;
            this.prijs_60plus.Text = "€ 8,-";
            // 
            // prijs_popcornpass
            // 
            this.prijs_popcornpass.AutoSize = true;
            this.prijs_popcornpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijs_popcornpass.Location = new System.Drawing.Point(198, 325);
            this.prijs_popcornpass.Name = "prijs_popcornpass";
            this.prijs_popcornpass.Size = new System.Drawing.Size(37, 17);
            this.prijs_popcornpass.TabIndex = 16;
            this.prijs_popcornpass.Text = "€5,-";
            this.prijs_popcornpass.Click += new System.EventHandler(this.prijs_popcornpass_Click);
            // 
            // prijs_silverpass
            // 
            this.prijs_silverpass.AutoSize = true;
            this.prijs_silverpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijs_silverpass.Location = new System.Drawing.Point(198, 354);
            this.prijs_silverpass.Name = "prijs_silverpass";
            this.prijs_silverpass.Size = new System.Drawing.Size(52, 17);
            this.prijs_silverpass.TabIndex = 17;
            this.prijs_silverpass.Text = "Gratis";
            // 
            // prijs_goldpass
            // 
            this.prijs_goldpass.AutoSize = true;
            this.prijs_goldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijs_goldpass.Location = new System.Drawing.Point(198, 381);
            this.prijs_goldpass.Name = "prijs_goldpass";
            this.prijs_goldpass.Size = new System.Drawing.Size(52, 17);
            this.prijs_goldpass.TabIndex = 18;
            this.prijs_goldpass.Text = "Gratis";
            this.prijs_goldpass.Click += new System.EventHandler(this.prijs_goldpass_Click);
            // 
            // amount_normal
            // 
            this.amount_normal.Location = new System.Drawing.Point(285, 193);
            this.amount_normal.Name = "amount_normal";
            this.amount_normal.Size = new System.Drawing.Size(31, 22);
            this.amount_normal.TabIndex = 19;
            // 
            // amount_kind
            // 
            this.amount_kind.Location = new System.Drawing.Point(285, 220);
            this.amount_kind.Name = "amount_kind";
            this.amount_kind.Size = new System.Drawing.Size(31, 22);
            this.amount_kind.TabIndex = 20;
            // 
            // amount_60plus
            // 
            this.amount_60plus.Location = new System.Drawing.Point(285, 249);
            this.amount_60plus.Name = "amount_60plus";
            this.amount_60plus.Size = new System.Drawing.Size(31, 22);
            this.amount_60plus.TabIndex = 21;
            // 
            // amount_popcornpass
            // 
            this.amount_popcornpass.Location = new System.Drawing.Point(277, 325);
            this.amount_popcornpass.Name = "amount_popcornpass";
            this.amount_popcornpass.Size = new System.Drawing.Size(31, 22);
            this.amount_popcornpass.TabIndex = 22;
            // 
            // amount_silverpass
            // 
            this.amount_silverpass.Location = new System.Drawing.Point(277, 355);
            this.amount_silverpass.Name = "amount_silverpass";
            this.amount_silverpass.Size = new System.Drawing.Size(31, 22);
            this.amount_silverpass.TabIndex = 23;
            // 
            // amount_goldpass
            // 
            this.amount_goldpass.Location = new System.Drawing.Point(277, 384);
            this.amount_goldpass.Name = "amount_goldpass";
            this.amount_goldpass.Size = new System.Drawing.Size(31, 22);
            this.amount_goldpass.TabIndex = 24;
            // 
            // abonnementen
            // 
            this.abonnementen.AutoSize = true;
            this.abonnementen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonnementen.Location = new System.Drawing.Point(126, 284);
            this.abonnementen.Name = "abonnementen";
            this.abonnementen.Size = new System.Drawing.Size(158, 25);
            this.abonnementen.TabIndex = 25;
            this.abonnementen.Text = "Abonnementen";
            // 
            // snacks
            // 
            this.snacks.AutoSize = true;
            this.snacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snacks.Location = new System.Drawing.Point(465, 150);
            this.snacks.Name = "snacks";
            this.snacks.Size = new System.Drawing.Size(84, 25);
            this.snacks.TabIndex = 26;
            this.snacks.Text = "Snacks";
            // 
            // stoelen
            // 
            this.stoelen.AutoSize = true;
            this.stoelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoelen.Location = new System.Drawing.Point(445, 292);
            this.stoelen.Name = "stoelen";
            this.stoelen.Size = new System.Drawing.Size(207, 50);
            this.stoelen.TabIndex = 27;
            this.stoelen.Text = "Speciale stoelen\r\n(standaard normaal)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Popcorn zout/zoet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Limonade (Fanta/Cola)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chips (eigen keuze)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Extra comfort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Loveseat (2-stoelen)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(616, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "€ 4,-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "€ 7,-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(619, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "€ 0,80";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(619, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "€ 1,20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(619, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "€ 1,50";
            // 
            // amount_popcorn
            // 
            this.amount_popcorn.Location = new System.Drawing.Point(690, 192);
            this.amount_popcorn.Name = "amount_popcorn";
            this.amount_popcorn.Size = new System.Drawing.Size(31, 22);
            this.amount_popcorn.TabIndex = 38;
            // 
            // amount_limonade
            // 
            this.amount_limonade.Location = new System.Drawing.Point(690, 219);
            this.amount_limonade.Name = "amount_limonade";
            this.amount_limonade.Size = new System.Drawing.Size(31, 22);
            this.amount_limonade.TabIndex = 39;
            // 
            // amount_chips
            // 
            this.amount_chips.Location = new System.Drawing.Point(690, 253);
            this.amount_chips.Name = "amount_chips";
            this.amount_chips.Size = new System.Drawing.Size(31, 22);
            this.amount_chips.TabIndex = 40;
            // 
            // amount_comfort
            // 
            this.amount_comfort.Location = new System.Drawing.Point(690, 359);
            this.amount_comfort.Name = "amount_comfort";
            this.amount_comfort.Size = new System.Drawing.Size(31, 22);
            this.amount_comfort.TabIndex = 41;
            // 
            // amount_loveseat
            // 
            this.amount_loveseat.Location = new System.Drawing.Point(690, 388);
            this.amount_loveseat.Name = "amount_loveseat";
            this.amount_loveseat.Size = new System.Drawing.Size(31, 22);
            this.amount_loveseat.TabIndex = 42;
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.Khaki;
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(775, 371);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(111, 57);
            this.next_button.TabIndex = 43;
            this.next_button.Text = "Verder";
            this.next_button.UseVisualStyleBackColor = false;
            // 
            // totaal_label
            // 
            this.totaal_label.AutoSize = true;
            this.totaal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaal_label.Location = new System.Drawing.Point(785, 219);
            this.totaal_label.Name = "totaal_label";
            this.totaal_label.Size = new System.Drawing.Size(73, 25);
            this.totaal_label.TabIndex = 44;
            this.totaal_label.Text = "Totaal";
            // 
            // totaal_bedrag
            // 
            this.totaal_bedrag.AutoSize = true;
            this.totaal_bedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaal_bedrag.Location = new System.Drawing.Point(799, 257);
            this.totaal_bedrag.Name = "totaal_bedrag";
            this.totaal_bedrag.Size = new System.Drawing.Size(48, 18);
            this.totaal_bedrag.TabIndex = 45;
            this.totaal_bedrag.Text = "€ 0,00";
            this.totaal_bedrag.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 490);
            this.Controls.Add(this.totaal_bedrag);
            this.Controls.Add(this.totaal_label);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.amount_loveseat);
            this.Controls.Add(this.amount_comfort);
            this.Controls.Add(this.amount_chips);
            this.Controls.Add(this.amount_limonade);
            this.Controls.Add(this.amount_popcorn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stoelen);
            this.Controls.Add(this.snacks);
            this.Controls.Add(this.abonnementen);
            this.Controls.Add(this.amount_goldpass);
            this.Controls.Add(this.amount_silverpass);
            this.Controls.Add(this.amount_popcornpass);
            this.Controls.Add(this.amount_60plus);
            this.Controls.Add(this.amount_kind);
            this.Controls.Add(this.amount_normal);
            this.Controls.Add(this.prijs_goldpass);
            this.Controls.Add(this.prijs_silverpass);
            this.Controls.Add(this.prijs_popcornpass);
            this.Controls.Add(this.prijs_60plus);
            this.Controls.Add(this.prijs_kind);
            this.Controls.Add(this.prijs_normal);
            this.Controls.Add(this.goldenpass);
            this.Controls.Add(this.silverpass);
            this.Controls.Add(this.popcornpass);
            this.Controls.Add(this.Ticket_60plus);
            this.Controls.Add(this.ticket_kind);
            this.Controls.Add(this.ticket_normal);
            this.Controls.Add(this.ticket);
            this.Controls.Add(this.red_bovenkant);
            this.Controls.Add(this.Red_onderkant);
            this.Controls.Add(this.film_naam);
            this.Controls.Add(this.reserveer);
            this.Controls.Add(this.back_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.red_bovenkant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label reserveer;
        private System.Windows.Forms.Label film_naam;
        private System.Windows.Forms.Panel black_panel;
        private System.Windows.Forms.Panel Red_onderkant;
        private System.Windows.Forms.Panel red_bovenkant;
        private System.Windows.Forms.Label ticket;
        private System.Windows.Forms.Label ticket_normal;
        private System.Windows.Forms.Label ticket_kind;
        private System.Windows.Forms.Label Ticket_60plus;
        private System.Windows.Forms.Label popcornpass;
        private System.Windows.Forms.Label silverpass;
        private System.Windows.Forms.Label goldenpass;
        private System.Windows.Forms.Label prijs_normal;
        private System.Windows.Forms.Label prijs_kind;
        private System.Windows.Forms.Label prijs_60plus;
        private System.Windows.Forms.Label prijs_popcornpass;
        private System.Windows.Forms.Label prijs_silverpass;
        private System.Windows.Forms.Label prijs_goldpass;
        private System.Windows.Forms.TextBox amount_normal;
        private System.Windows.Forms.TextBox amount_kind;
        private System.Windows.Forms.TextBox amount_60plus;
        private System.Windows.Forms.TextBox amount_popcornpass;
        private System.Windows.Forms.TextBox amount_silverpass;
        private System.Windows.Forms.TextBox amount_goldpass;
        private System.Windows.Forms.Label abonnementen;
        private System.Windows.Forms.Label snacks;
        private System.Windows.Forms.Label stoelen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amount_popcorn;
        private System.Windows.Forms.TextBox amount_limonade;
        private System.Windows.Forms.TextBox amount_chips;
        private System.Windows.Forms.TextBox amount_comfort;
        private System.Windows.Forms.TextBox amount_loveseat;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label totaal_label;
        internal System.Windows.Forms.Label totaal_bedrag;
    }
}

