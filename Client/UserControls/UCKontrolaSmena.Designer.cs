namespace Client.UserControls
{
    partial class UCKontrolaSmena
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
            mcDatumSmene = new MonthCalendar();
            btnSacuvaj = new Button();
            btnNazad = new Button();
            cmbZdravstveniRadnik = new ComboBox();
            cmbLokacija = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 11F);
            label1.Location = new Point(327, 41);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Datum smene";
            // 
            // mcDatumSmene
            // 
            mcDatumSmene.Font = new Font("Footlight MT Light", 11F);
            mcDatumSmene.Location = new Point(272, 70);
            mcDatumSmene.Name = "mcDatumSmene";
            mcDatumSmene.TabIndex = 1;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Font = new Font("Footlight MT Light", 11F);
            btnSacuvaj.Location = new Point(57, 320);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(128, 39);
            btnSacuvaj.TabIndex = 2;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 11F);
            btnNazad.Location = new Point(336, 320);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(128, 39);
            btnNazad.TabIndex = 3;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // cmbZdravstveniRadnik
            // 
            cmbZdravstveniRadnik.Font = new Font("Footlight MT Light", 11F);
            cmbZdravstveniRadnik.FormattingEnabled = true;
            cmbZdravstveniRadnik.Location = new Point(45, 106);
            cmbZdravstveniRadnik.Name = "cmbZdravstveniRadnik";
            cmbZdravstveniRadnik.Size = new Size(170, 27);
            cmbZdravstveniRadnik.TabIndex = 4;
            cmbZdravstveniRadnik.Text = "Zdravstveni radnik";
            // 
            // cmbLokacija
            // 
            cmbLokacija.Font = new Font("Footlight MT Light", 11F);
            cmbLokacija.FormattingEnabled = true;
            cmbLokacija.Location = new Point(45, 185);
            cmbLokacija.Name = "cmbLokacija";
            cmbLokacija.Size = new Size(170, 27);
            cmbLokacija.TabIndex = 5;
            cmbLokacija.Text = "Lokacija";
            // 
            // UCKontrolaSmena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            Controls.Add(cmbLokacija);
            Controls.Add(cmbZdravstveniRadnik);
            Controls.Add(btnNazad);
            Controls.Add(btnSacuvaj);
            Controls.Add(mcDatumSmene);
            Controls.Add(label1);
            Name = "UCKontrolaSmena";
            Size = new Size(577, 407);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar mcDatumSmene;
        private Button btnSacuvaj;
        private Button btnNazad;
        private ComboBox cmbZdravstveniRadnik;
        private ComboBox cmbLokacija;
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public ComboBox CmbZdravstveniRadnik { get => cmbZdravstveniRadnik; set => cmbZdravstveniRadnik = value; }
        public ComboBox CmbLokacija { get => cmbLokacija; set => cmbLokacija = value; }
        public MonthCalendar CmDatumSmene { get => mcDatumSmene; set => mcDatumSmene = value; }
    }
}
