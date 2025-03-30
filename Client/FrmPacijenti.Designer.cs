namespace Client
{
    partial class FrmPacijenti
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
            dgvPacijenti = new DataGridView();
            btnDodajPacijenta = new Button();
            btnIzmeni = new Button();
            rbDete = new RadioButton();
            rbAdolescent = new RadioButton();
            rbOdraslaOsoba = new RadioButton();
            btnObrisi = new Button();
            btnGlavna = new Button();
            label1 = new Label();
            rbStaraOsoba = new RadioButton();
            label2 = new Label();
            rbSvi = new RadioButton();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            SuspendLayout();
            // 
            // dgvPacijenti
            // 
            dgvPacijenti.BackgroundColor = Color.White;
            dgvPacijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacijenti.Location = new Point(12, 128);
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.RowHeadersWidth = 51;
            dgvPacijenti.Size = new Size(702, 347);
            dgvPacijenti.TabIndex = 0;
            // 
            // btnDodajPacijenta
            // 
            btnDodajPacijenta.BackColor = Color.IndianRed;
            btnDodajPacijenta.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajPacijenta.ForeColor = SystemColors.Control;
            btnDodajPacijenta.Location = new Point(744, 128);
            btnDodajPacijenta.Name = "btnDodajPacijenta";
            btnDodajPacijenta.Size = new Size(162, 49);
            btnDodajPacijenta.TabIndex = 2;
            btnDodajPacijenta.Text = "Dodaj Novog";
            btnDodajPacijenta.UseVisualStyleBackColor = false;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.IndianRed;
            btnIzmeni.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = SystemColors.Control;
            btnIzmeni.Location = new Point(744, 274);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(162, 52);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "   Izmeni podatke";
            btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // rbDete
            // 
            rbDete.AutoSize = true;
            rbDete.BackColor = SystemColors.ActiveCaption;
            rbDete.Font = new Font("Footlight MT Light", 10.2F);
            rbDete.ForeColor = SystemColors.ActiveCaptionText;
            rbDete.Location = new Point(57, 548);
            rbDete.Name = "rbDete";
            rbDete.Size = new Size(105, 23);
            rbDete.TabIndex = 5;
            rbDete.TabStop = true;
            rbDete.Text = "Dete           ";
            rbDete.TextAlign = ContentAlignment.MiddleCenter;
            rbDete.UseVisualStyleBackColor = false;
            // 
            // rbAdolescent
            // 
            rbAdolescent.AutoSize = true;
            rbAdolescent.BackColor = SystemColors.ActiveCaption;
            rbAdolescent.Font = new Font("Footlight MT Light", 10.2F);
            rbAdolescent.ForeColor = SystemColors.ActiveCaptionText;
            rbAdolescent.Location = new Point(57, 591);
            rbAdolescent.Name = "rbAdolescent";
            rbAdolescent.Size = new Size(104, 23);
            rbAdolescent.TabIndex = 6;
            rbAdolescent.TabStop = true;
            rbAdolescent.Text = "Adolescent";
            rbAdolescent.UseVisualStyleBackColor = false;
            // 
            // rbOdraslaOsoba
            // 
            rbOdraslaOsoba.AutoSize = true;
            rbOdraslaOsoba.BackColor = SystemColors.ActiveCaption;
            rbOdraslaOsoba.Font = new Font("Footlight MT Light", 10.2F);
            rbOdraslaOsoba.ForeColor = SystemColors.ActiveCaptionText;
            rbOdraslaOsoba.Location = new Point(254, 548);
            rbOdraslaOsoba.Name = "rbOdraslaOsoba";
            rbOdraslaOsoba.Size = new Size(128, 23);
            rbOdraslaOsoba.TabIndex = 7;
            rbOdraslaOsoba.TabStop = true;
            rbOdraslaOsoba.Text = "Odrasla osoba";
            rbOdraslaOsoba.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.IndianRed;
            btnObrisi.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisi.ForeColor = SystemColors.Control;
            btnObrisi.Location = new Point(744, 422);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(162, 53);
            btnObrisi.TabIndex = 8;
            btnObrisi.Text = "Obrisi Pacijenta";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnGlavna
            // 
            btnGlavna.BackColor = Color.IndianRed;
            btnGlavna.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGlavna.ForeColor = SystemColors.Control;
            btnGlavna.Location = new Point(715, 525);
            btnGlavna.Name = "btnGlavna";
            btnGlavna.Size = new Size(177, 89);
            btnGlavna.TabIndex = 9;
            btnGlavna.Text = "Glavna strana";
            btnGlavna.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 34);
            label1.Name = "label1";
            label1.Size = new Size(156, 24);
            label1.TabIndex = 10;
            label1.Text = "Lista pacijenata";
            // 
            // rbStaraOsoba
            // 
            rbStaraOsoba.AutoSize = true;
            rbStaraOsoba.BackColor = SystemColors.ActiveCaption;
            rbStaraOsoba.Font = new Font("Footlight MT Light", 10.2F);
            rbStaraOsoba.ForeColor = SystemColors.ActiveCaptionText;
            rbStaraOsoba.Location = new Point(254, 591);
            rbStaraOsoba.Name = "rbStaraOsoba";
            rbStaraOsoba.Size = new Size(125, 23);
            rbStaraOsoba.TabIndex = 11;
            rbStaraOsoba.TabStop = true;
            rbStaraOsoba.Text = "Stara osoba    ";
            rbStaraOsoba.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(140, 500);
            label2.Name = "label2";
            label2.Size = new Size(153, 24);
            label2.TabIndex = 12;
            label2.Text = "Starosna grupa";
            // 
            // rbSvi
            // 
            rbSvi.AutoSize = true;
            rbSvi.BackColor = SystemColors.ActiveCaption;
            rbSvi.Font = new Font("Footlight MT Light", 10.2F);
            rbSvi.ForeColor = SystemColors.ActiveCaptionText;
            rbSvi.Location = new Point(156, 626);
            rbSvi.Name = "rbSvi";
            rbSvi.Size = new Size(95, 23);
            rbSvi.TabIndex = 13;
            rbSvi.TabStop = true;
            rbSvi.Text = "Svi           ";
            rbSvi.TextAlign = ContentAlignment.MiddleCenter;
            rbSvi.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 15;
            label3.Text = "Pretraga:";
            // 
            // FrmPacijenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.seamless_pattern_with_flat_medical_icons_medicine_or_health_insurance_research_background_healthcare_and_laboratory_equipment_digital_paper_health_check_or_treatment_texture_vector;
            ClientSize = new Size(918, 661);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(rbSvi);
            Controls.Add(rbStaraOsoba);
            Controls.Add(dgvPacijenti);
            Controls.Add(rbAdolescent);
            Controls.Add(label2);
            Controls.Add(rbOdraslaOsoba);
            Controls.Add(label1);
            Controls.Add(rbDete);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodajPacijenta);
            Controls.Add(btnObrisi);
            Controls.Add(btnGlavna);
            Name = "FrmPacijenti";
            Text = "Pacijenti";
            Load += FrmPacijenti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvPacijenti;
        public Button btnDodajPacijenta;
        public Button btnIzmeni;
        public RadioButton rbDete;
        public RadioButton rbAdolescent;
        public RadioButton rbOdraslaOsoba;
        public Button btnObrisi;
        public Button btnGlavna;
        public Label label1;
        public RadioButton rbStaraOsoba;
        public Label label2;
        public RadioButton rbSvi;
        public TextBox textBox1;
        public Label label3;

        public DataGridView DgvPacijenti { get => dgvPacijenti; set => dgvPacijenti = value; }
        public Button BtnDodaj { get => btnDodajPacijenta; set => btnDodajPacijenta = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Button BtnGlavna { get => btnGlavna; set => btnGlavna = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public RadioButton RbDete { get => rbDete; set => rbDete = value; }
        public RadioButton RbAdolescent { get => rbAdolescent; set => rbAdolescent = value; }
        public RadioButton RbOdraslaOsoba { get => rbOdraslaOsoba; set => rbOdraslaOsoba = value; }
        public RadioButton RbStaraOsoba { get => rbStaraOsoba; set => rbStaraOsoba = value; }
        public RadioButton RbSvi { get => rbSvi; set => rbSvi = value; }
    }
}