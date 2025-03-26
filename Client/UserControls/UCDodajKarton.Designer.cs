namespace Client.UserControls
{
    partial class UCDodajKarton
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
            btnPacijent = new Button();
            btnSacuvaj = new Button();
            btnNazad = new Button();
            label1 = new Label();
            label2 = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            SuspendLayout();
            // 
            // btnPacijent
            // 
            btnPacijent.BackColor = Color.Lavender;
            btnPacijent.Font = new Font("Footlight MT Light", 12F);
            btnPacijent.ForeColor = Color.DarkSlateBlue;
            btnPacijent.Location = new Point(95, 182);
            btnPacijent.Name = "btnPacijent";
            btnPacijent.Size = new Size(203, 39);
            btnPacijent.TabIndex = 0;
            btnPacijent.Text = "Odaberite pacijenta";
            btnPacijent.UseVisualStyleBackColor = false;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = Color.Lavender;
            btnSacuvaj.Font = new Font("Footlight MT Light", 12F);
            btnSacuvaj.ForeColor = Color.DarkSlateBlue;
            btnSacuvaj.Location = new Point(376, 187);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(201, 34);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvajte karton";
            btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // btnNazad
            // 
            btnNazad.BackColor = Color.Lavender;
            btnNazad.Font = new Font("Footlight MT Light", 12F);
            btnNazad.ForeColor = Color.DarkSlateBlue;
            btnNazad.Location = new Point(376, 269);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(201, 34);
            btnNazad.TabIndex = 2;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 12F);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(74, 58);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 3;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 12F);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(256, 58);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Prezime";
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Footlight MT Light", 12F);
            txtIme.Location = new Point(28, 106);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(142, 29);
            txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Footlight MT Light", 12F);
            txtPrezime.Location = new Point(222, 106);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(143, 29);
            txtPrezime.TabIndex = 6;
            // 
            // UCDodajKarton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNazad);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnPacijent);
            Name = "UCDodajKarton";
            Size = new Size(611, 384);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnPacijent;
        public Button btnSacuvaj;
        public Button btnNazad;
        public Label label1;
        public Label label2;
        public TextBox txtIme;
        public TextBox txtPrezime;
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Button BtnPacijent { get => btnPacijent; set => btnPacijent = value; }
    }
}
