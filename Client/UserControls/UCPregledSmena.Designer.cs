namespace Client.UserControls
{
    partial class UCPregledSmena
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
            cmbRadnici = new ComboBox();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnNazad = new Button();
            rbPredstojece = new RadioButton();
            rbPrethodne = new RadioButton();
            rbSve = new RadioButton();
            dgvSmene = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSmene).BeginInit();
            SuspendLayout();
            // 
            // cmbRadnici
            // 
            cmbRadnici.Font = new Font("Footlight MT Light", 10.2F);
            cmbRadnici.FormattingEnabled = true;
            cmbRadnici.Location = new Point(19, 92);
            cmbRadnici.Name = "cmbRadnici";
            cmbRadnici.Size = new Size(170, 27);
            cmbRadnici.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Font = new Font("Footlight MT Light", 10.2F);
            btnDodaj.Location = new Point(41, 153);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(120, 49);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj smenu";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Font = new Font("Footlight MT Light", 10.2F);
            btnIzmeni.Location = new Point(41, 233);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(120, 49);
            btnIzmeni.TabIndex = 2;
            btnIzmeni.Text = "Izmeni smenu";
            btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            btnObrisi.Font = new Font("Footlight MT Light", 10.2F);
            btnObrisi.Location = new Point(41, 305);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(120, 49);
            btnObrisi.TabIndex = 3;
            btnObrisi.Text = "Obrisi smenu";
            btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 10.2F);
            btnNazad.Location = new Point(487, 319);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(107, 49);
            btnNazad.TabIndex = 4;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // rbPredstojece
            // 
            rbPredstojece.AutoSize = true;
            rbPredstojece.Font = new Font("Footlight MT Light", 10.2F);
            rbPredstojece.Location = new Point(495, 78);
            rbPredstojece.Name = "rbPredstojece";
            rbPredstojece.Size = new Size(104, 23);
            rbPredstojece.TabIndex = 5;
            rbPredstojece.TabStop = true;
            rbPredstojece.Text = "Predstojeće";
            rbPredstojece.UseVisualStyleBackColor = true;
            // 
            // rbPrethodne
            // 
            rbPrethodne.AutoSize = true;
            rbPrethodne.Font = new Font("Footlight MT Light", 10.2F);
            rbPrethodne.Location = new Point(495, 126);
            rbPrethodne.Name = "rbPrethodne";
            rbPrethodne.Size = new Size(99, 23);
            rbPrethodne.TabIndex = 6;
            rbPrethodne.TabStop = true;
            rbPrethodne.Text = "Prethodne";
            rbPrethodne.UseVisualStyleBackColor = true;
            // 
            // rbSve
            // 
            rbSve.AutoSize = true;
            rbSve.Font = new Font("Footlight MT Light", 10.2F);
            rbSve.Location = new Point(495, 166);
            rbSve.Name = "rbSve";
            rbSve.Size = new Size(53, 23);
            rbSve.TabIndex = 7;
            rbSve.TabStop = true;
            rbSve.Text = "Sve";
            rbSve.UseVisualStyleBackColor = true;
            // 
            // dgvSmene
            // 
            dgvSmene.BackgroundColor = Color.FloralWhite;
            dgvSmene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSmene.GridColor = SystemColors.HighlightText;
            dgvSmene.Location = new Point(214, 47);
            dgvSmene.Name = "dgvSmene";
            dgvSmene.RowHeadersWidth = 51;
            dgvSmene.Size = new Size(249, 307);
            dgvSmene.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 11F);
            label1.Location = new Point(269, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 9;
            label1.Text = "Smene radnika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 10F);
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 10;
            label2.Text = "Zdravstveni radnik";
            // 
            // UCPregledSmena
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSmene);
            Controls.Add(rbSve);
            Controls.Add(rbPrethodne);
            Controls.Add(rbPredstojece);
            Controls.Add(btnNazad);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(cmbRadnici);
            Name = "UCPregledSmena";
            Size = new Size(616, 383);
            ((System.ComponentModel.ISupportInitialize)dgvSmene).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRadnici;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnNazad;
        private RadioButton rbPredstojece;
        private RadioButton rbPrethodne;
        private RadioButton rbSve;
        private DataGridView dgvSmene;
        private Label label1;
        private Label label2;

        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public DataGridView DgvSmene { get => dgvSmene; set => dgvSmene = value; }
        public RadioButton RbPredstojece { get => rbPredstojece; set => rbPredstojece = value; }
        public RadioButton RbPrethodne { get => rbPrethodne; set => rbPrethodne = value; }
        public RadioButton RbSve { get => rbSve; set => rbSve = value; }
        public ComboBox CmbRadnici { get => cmbRadnici; set => cmbRadnici = value; }
       
    }
}
