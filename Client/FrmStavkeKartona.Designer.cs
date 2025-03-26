namespace Client
{
    partial class FrmStavkeKartona
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
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label4 = new Label();
            dgvStavke = new DataGridView();
            btnNazad = new Button();
            btnObrisiStavku = new Button();
            btnDodajStavku = new Button();
            btnPregledStavke = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStavke).BeginInit();
            SuspendLayout();
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Footlight MT Light", 10.8F);
            txtPrezime.Location = new Point(291, 78);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(168, 27);
            txtPrezime.TabIndex = 21;
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Footlight MT Light", 10.8F);
            txtIme.Location = new Point(59, 78);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(148, 27);
            txtIme.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Footlight MT Light", 10.8F);
            label4.Location = new Point(177, 9);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 19;
            label4.Text = "Pregled Kartona";
            // 
            // dgvStavke
            // 
            dgvStavke.BackgroundColor = Color.AntiqueWhite;
            dgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStavke.Location = new Point(16, 151);
            dgvStavke.Name = "dgvStavke";
            dgvStavke.RowHeadersWidth = 51;
            dgvStavke.Size = new Size(569, 294);
            dgvStavke.TabIndex = 18;
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 10.8F);
            btnNazad.ForeColor = Color.Black;
            btnNazad.Location = new Point(653, 395);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(131, 50);
            btnNazad.TabIndex = 17;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // btnObrisiStavku
            // 
            btnObrisiStavku.Font = new Font("Footlight MT Light", 10.8F);
            btnObrisiStavku.ForeColor = Color.Black;
            btnObrisiStavku.Location = new Point(653, 306);
            btnObrisiStavku.Name = "btnObrisiStavku";
            btnObrisiStavku.Size = new Size(129, 53);
            btnObrisiStavku.TabIndex = 16;
            btnObrisiStavku.Text = "Obriši stavku";
            btnObrisiStavku.UseVisualStyleBackColor = true;
            // 
            // btnDodajStavku
            // 
            btnDodajStavku.Font = new Font("Footlight MT Light", 10.8F);
            btnDodajStavku.ForeColor = Color.Black;
            btnDodajStavku.Location = new Point(653, 209);
            btnDodajStavku.Name = "btnDodajStavku";
            btnDodajStavku.Size = new Size(129, 53);
            btnDodajStavku.TabIndex = 15;
            btnDodajStavku.Text = "Dodaj stavku";
            btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // btnPregledStavke
            // 
            btnPregledStavke.Font = new Font("Footlight MT Light", 10.8F);
            btnPregledStavke.ForeColor = Color.Black;
            btnPregledStavke.Location = new Point(651, 118);
            btnPregledStavke.Name = "btnPregledStavke";
            btnPregledStavke.Size = new Size(131, 53);
            btnPregledStavke.TabIndex = 14;
            btnPregledStavke.Text = "Pregled stavke";
            btnPregledStavke.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 10.8F);
            label3.Location = new Point(206, 118);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 13;
            label3.Text = "Stavke kartona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 10.8F);
            label2.Location = new Point(343, 39);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 12;
            label2.Text = "Prezime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 10.8F);
            label1.Location = new Point(111, 39);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 11;
            label1.Text = "Ime";
            // 
            // FrmStavkeKartona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 477);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label4);
            Controls.Add(dgvStavke);
            Controls.Add(btnNazad);
            Controls.Add(btnObrisiStavku);
            Controls.Add(btnDodajStavku);
            Controls.Add(btnPregledStavke);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmStavkeKartona";
            Text = "Pregled kartona";
            ((System.ComponentModel.ISupportInitialize)dgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrezime;
        private TextBox txtIme;
        private Label label4;
        private DataGridView dgvStavke;
        private Button btnNazad;
        private Button btnObrisiStavku;
        private Button btnDodajStavku;
        private Button btnPregledStavke;
        private Label label3;
        private Label label2;
        private Label label1;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnPregledStavke { get => btnPregledStavke; set => btnPregledStavke = value; }
        public Button BtnObrisiStavku { get => btnObrisiStavku; set => btnObrisiStavku = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
    }
}