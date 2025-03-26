namespace Client.UserControls
{
    partial class UCDodajPacijenta
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
            cmbStarosnaGrupa = new ComboBox();
            c = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIme = new TextBox();
            txtGodine = new TextBox();
            txtPrezime = new TextBox();
            datumRodjenja = new MonthCalendar();
            label1 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // cmbStarosnaGrupa
            // 
            cmbStarosnaGrupa.FormattingEnabled = true;
            cmbStarosnaGrupa.Location = new Point(168, 232);
            cmbStarosnaGrupa.Name = "cmbStarosnaGrupa";
            cmbStarosnaGrupa.Size = new Size(151, 28);
            cmbStarosnaGrupa.TabIndex = 0;
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Footlight MT Light", 10.2F);
            c.Location = new Point(30, 46);
            c.Name = "c";
            c.Size = new Size(35, 19);
            c.TabIndex = 1;
            c.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 10.2F);
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 2;
            label2.Text = "Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 10.2F);
            label3.Location = new Point(30, 163);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 3;
            label3.Text = "Godine";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Footlight MT Light", 10.2F);
            label4.Location = new Point(30, 235);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 4;
            label4.Text = "Starosna grupa";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(168, 39);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(125, 27);
            txtIme.TabIndex = 5;
            // 
            // txtGodine
            // 
            txtGodine.Location = new Point(168, 163);
            txtGodine.Name = "txtGodine";
            txtGodine.Size = new Size(125, 27);
            txtGodine.TabIndex = 6;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(168, 101);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(125, 27);
            txtPrezime.TabIndex = 7;
            // 
            // datumRodjenja
            // 
            datumRodjenja.BackColor = Color.IndianRed;
            datumRodjenja.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumRodjenja.Location = new Point(413, 39);
            datumRodjenja.Name = "datumRodjenja";
            datumRodjenja.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(468, 10);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 9;
            label1.Text = "Datum rođenja";
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodaj.Location = new Point(287, 317);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(158, 59);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj pacijenta";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // DodajPacijenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(btnDodaj);
            Controls.Add(label1);
            Controls.Add(datumRodjenja);
            Controls.Add(txtPrezime);
            Controls.Add(txtGodine);
            Controls.Add(txtIme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(c);
            Controls.Add(cmbStarosnaGrupa);
            Name = "DodajPacijenta";
            Size = new Size(726, 450);
            Load += DodajPacijenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        public ComboBox cmbStarosnaGrupa;
        public Label c;
        public Label label2;
        public Label label3;
        public Label label4;
        public TextBox txtIme;
        public TextBox txtGodine;
        public TextBox txtPrezime;
        public MonthCalendar datumRodjenja;
        public Label label1;
        public Button btnDodaj;

        public ComboBox CmbSGrupa { get => cmbStarosnaGrupa; set => cmbStarosnaGrupa = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtGodine { get => txtGodine; set => txtGodine = value; }
        public MonthCalendar DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => c; set => c = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
    }
}