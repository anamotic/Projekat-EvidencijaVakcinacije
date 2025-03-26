namespace Client
{
    partial class FrmLokacija
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
            dgvLokacije = new DataGridView();
            label1 = new Label();
            btnNazad = new Button();
            btnDodajLokaciju = new Button();
            btnSmene = new Button();
            btnObrisi = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLokacije).BeginInit();
            SuspendLayout();
            // 
            // dgvLokacije
            // 
            dgvLokacije.BackgroundColor = Color.White;
            dgvLokacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLokacije.Location = new Point(67, 103);
            dgvLokacije.Name = "dgvLokacije";
            dgvLokacije.RowHeadersWidth = 51;
            dgvLokacije.Size = new Size(428, 188);
            dgvLokacije.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Footlight MT Light", 15.2F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(184, 19);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 1;
            label1.Text = "Dom zdravlja Palilula  ";
            // 
            // btnNazad
            // 
            btnNazad.BackColor = Color.Snow;
            btnNazad.Font = new Font("Footlight MT Light", 10.8F);
            btnNazad.ForeColor = SystemColors.ActiveCaptionText;
            btnNazad.Location = new Point(513, 362);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(102, 55);
            btnNazad.TabIndex = 2;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = false;
            // 
            // btnDodajLokaciju
            // 
            btnDodajLokaciju.BackColor = Color.Snow;
            btnDodajLokaciju.Font = new Font("Footlight MT Light", 10.8F);
            btnDodajLokaciju.ForeColor = SystemColors.ActiveCaptionText;
            btnDodajLokaciju.Location = new Point(501, 117);
            btnDodajLokaciju.Name = "btnDodajLokaciju";
            btnDodajLokaciju.Size = new Size(128, 44);
            btnDodajLokaciju.TabIndex = 3;
            btnDodajLokaciju.Text = "Dodaj lokaciju";
            btnDodajLokaciju.UseVisualStyleBackColor = false;
            // 
            // btnSmene
            // 
            btnSmene.BackColor = Color.Snow;
            btnSmene.Font = new Font("Footlight MT Light", 10.8F);
            btnSmene.ForeColor = SystemColors.ActiveCaptionText;
            btnSmene.Location = new Point(197, 309);
            btnSmene.Name = "btnSmene";
            btnSmene.Size = new Size(179, 44);
            btnSmene.TabIndex = 4;
            btnSmene.Text = "Pregled smena";
            btnSmene.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Snow;
            btnObrisi.Font = new Font("Footlight MT Light", 10.8F);
            btnObrisi.ForeColor = SystemColors.ActiveCaptionText;
            btnObrisi.Location = new Point(502, 199);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(128, 44);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "Obrisi lokaciju";
            btnObrisi.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Footlight MT Light", 12.2F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(197, 58);
            label2.Name = "label2";
            label2.Size = new Size(220, 22);
            label2.TabIndex = 6;
            label2.Text = "Ogranci za vakcinaciju  ";
            // 
            // FrmLokacija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(642, 429);
            Controls.Add(label2);
            Controls.Add(btnObrisi);
            Controls.Add(btnSmene);
            Controls.Add(btnDodajLokaciju);
            Controls.Add(btnNazad);
            Controls.Add(label1);
            Controls.Add(dgvLokacije);
            Name = "FrmLokacija";
            Text = "Lokacije";
            ((System.ComponentModel.ISupportInitialize)dgvLokacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvLokacije;
        public Label label1;
        public Button btnNazad;
        public Button btnDodajLokaciju;
        public Button btnSmene;
        public Button btnObrisi;
        public Label label2;

        public DataGridView DgvLokacije { get => dgvLokacije; set => dgvLokacije = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnDodajLokaciju { get => btnDodajLokaciju; set => btnDodajLokaciju = value; }
        public Button BtnSmene { get => btnSmene; set => btnSmene = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
    }
}