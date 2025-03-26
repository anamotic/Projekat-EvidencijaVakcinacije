namespace Client
{
    partial class FrmKartoniVakcinacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKartoniVakcinacije));
            dgvKartoni = new DataGridView();
            btnDodaj = new Button();
            btnObrisi = new Button();
            btnGlavna = new Button();
            btnPregled = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKartoni).BeginInit();
            SuspendLayout();
            // 
            // dgvKartoni
            // 
            dgvKartoni.BackgroundColor = Color.SteelBlue;
            dgvKartoni.BorderStyle = BorderStyle.Fixed3D;
            dgvKartoni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKartoni.Location = new Point(352, 12);
            dgvKartoni.Name = "dgvKartoni";
            dgvKartoni.RowHeadersWidth = 51;
            dgvKartoni.Size = new Size(435, 464);
            dgvKartoni.TabIndex = 0;
            dgvKartoni.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.SteelBlue;
            btnDodaj.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = SystemColors.Control;
            btnDodaj.Location = new Point(12, 217);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(166, 62);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Otvorite novi karton";
            btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.SteelBlue;
            btnObrisi.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnObrisi.ForeColor = SystemColors.Control;
            btnObrisi.Location = new Point(12, 303);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(166, 62);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrišite karton";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // btnGlavna
            // 
            btnGlavna.BackColor = Color.SteelBlue;
            btnGlavna.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGlavna.ForeColor = SystemColors.Control;
            btnGlavna.Location = new Point(12, 393);
            btnGlavna.Name = "btnGlavna";
            btnGlavna.Size = new Size(166, 62);
            btnGlavna.TabIndex = 3;
            btnGlavna.Text = "Početna strana";
            btnGlavna.UseVisualStyleBackColor = false;
            // 
            // btnPregled
            // 
            btnPregled.BackColor = Color.SteelBlue;
            btnPregled.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPregled.ForeColor = SystemColors.Control;
            btnPregled.Location = new Point(12, 128);
            btnPregled.Name = "btnPregled";
            btnPregled.Size = new Size(166, 62);
            btnPregled.TabIndex = 4;
            btnPregled.Text = "Pregled kartona";
            btnPregled.UseVisualStyleBackColor = false;
            // 
            // FrmKartoniVakcinacije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 467);
            Controls.Add(btnPregled);
            Controls.Add(btnGlavna);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(dgvKartoni);
            Name = "FrmKartoniVakcinacije";
            Text = "Kartoni Vakcinacije";
            ((System.ComponentModel.ISupportInitialize)dgvKartoni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvKartoni;
        public Button btnDodaj;
        public Button btnObrisi;
        public Button btnGlavna;
        public Button btnPregled;

        public DataGridView DGVKartoni { get => dgvKartoni; set => dgvKartoni = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Button BtnGlavna { get => btnGlavna; set => btnGlavna = value; }
}
}