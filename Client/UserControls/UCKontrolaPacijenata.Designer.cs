namespace Client.UserControls
{
    partial class UCKontrolaPacijenata
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPotvrda = new Button();
            cmbStarosnaGrupa = new ComboBox();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtGodine = new TextBox();
            btnNazad = new Button();
            mcDatumRodjenja = new MonthCalendar();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 10.2F);
            label1.Location = new Point(30, 250);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 7;
            label1.Text = "Starosna grupa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 10.2F);
            label2.Location = new Point(30, 189);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 6;
            label2.Text = "Godine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 10.2F);
            label3.Location = new Point(30, 123);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 5;
            label3.Text = "Prezime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Footlight MT Light", 10.2F);
            label4.Location = new Point(30, 62);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 4;
            label4.Text = "Ime";
            // 
            // btnPotvrda
            // 
            btnPotvrda.Font = new Font("Footlight MT Light", 10.2F);
            btnPotvrda.Location = new Point(176, 338);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(127, 49);
            btnPotvrda.TabIndex = 16;
            btnPotvrda.Text = "Sačuvaj izmene";
            btnPotvrda.UseVisualStyleBackColor = true;
            // 
            // cmbStarosnaGrupa
            // 
            cmbStarosnaGrupa.Font = new Font("Footlight MT Light", 10.2F);
            cmbStarosnaGrupa.FormattingEnabled = true;
            cmbStarosnaGrupa.Location = new Point(161, 247);
            cmbStarosnaGrupa.Name = "cmbStarosnaGrupa";
            cmbStarosnaGrupa.Size = new Size(151, 27);
            cmbStarosnaGrupa.TabIndex = 15;
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Footlight MT Light", 10.2F);
            txtIme.Location = new Point(161, 56);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(151, 25);
            txtIme.TabIndex = 14;
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Footlight MT Light", 10.2F);
            txtPrezime.Location = new Point(161, 123);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(151, 25);
            txtPrezime.TabIndex = 13;
            // 
            // txtGodine
            // 
            txtGodine.Font = new Font("Footlight MT Light", 10.2F);
            txtGodine.Location = new Point(161, 186);
            txtGodine.Name = "txtGodine";
            txtGodine.Size = new Size(151, 25);
            txtGodine.TabIndex = 12;
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 10.2F);
            btnNazad.Location = new Point(363, 338);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(126, 49);
            btnNazad.TabIndex = 21;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // mcDatumRodjenja
            // 
            mcDatumRodjenja.Font = new Font("Footlight MT Light", 10.2F);
            mcDatumRodjenja.Location = new Point(403, 62);
            mcDatumRodjenja.Name = "mcDatumRodjenja";
            mcDatumRodjenja.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Footlight MT Light", 10.2F);
            label5.Location = new Point(462, 25);
            label5.Name = "label5";
            label5.Size = new Size(111, 19);
            label5.TabIndex = 19;
            label5.Text = "Datum rođenja";
            // 
            // UCKontrolaPacijenata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(btnNazad);
            Controls.Add(mcDatumRodjenja);
            Controls.Add(label5);
            Controls.Add(btnPotvrda);
            Controls.Add(cmbStarosnaGrupa);
            Controls.Add(txtIme);
            Controls.Add(txtPrezime);
            Controls.Add(txtGodine);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "UCKontrolaPacijenata";
            Size = new Size(719, 431);
            Load += UCKontrolaPacijenata_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Button btnPotvrda;
        public ComboBox cmbStarosnaGrupa;
        public TextBox txtGodine;
        public TextBox txtPrezime;
        public TextBox txtIme;
        public Button btnNazad;
        public MonthCalendar mcDatumRodjenja;
        public Label label5;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtGodine { get => txtGodine; set => txtGodine = value; }
        public MonthCalendar DatumRodjenja { get => mcDatumRodjenja; set => mcDatumRodjenja = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnPotvrda { get => btnPotvrda; set => btnPotvrda = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public ComboBox CmbSGrupa { get => cmbStarosnaGrupa; set => cmbStarosnaGrupa = value; }
    }
}

