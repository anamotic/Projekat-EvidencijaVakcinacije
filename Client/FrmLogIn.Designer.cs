namespace Client
{
    partial class FrmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrijava = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSifra = new TextBox();
            txtKorIme = new TextBox();
            SuspendLayout();
            // 
            // btnPrijava
            // 
            btnPrijava.BackColor = Color.Linen;
            btnPrijava.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrijava.ForeColor = SystemColors.GrayText;
            btnPrijava.Location = new Point(131, 246);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(137, 75);
            btnPrijava.TabIndex = 0;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(32, 124);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 1;
            label1.Text = "  Korisnicko ime  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(32, 179);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 2;
            label2.Text = "         Sifra          ";
            // 
            // txtSifra
            // 
            txtSifra.BackColor = Color.MistyRose;
            txtSifra.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSifra.Location = new Point(219, 172);
            txtSifra.Name = "txtSifra";
            txtSifra.PasswordChar = '*';
            txtSifra.Size = new Size(170, 25);
            txtSifra.TabIndex = 3;
            txtSifra.Text = "mm123";
            txtSifra.TextAlign = HorizontalAlignment.Center;
            // 
            // txtKorIme
            // 
            txtKorIme.BackColor = Color.MistyRose;
            txtKorIme.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKorIme.Location = new Point(219, 118);
            txtKorIme.Name = "txtKorIme";
            txtKorIme.Size = new Size(170, 25);
            txtKorIme.TabIndex = 4;
            txtKorIme.Text = "mm123";
            txtKorIme.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vakcine;
            ClientSize = new Size(463, 435);
            Controls.Add(txtKorIme);
            Controls.Add(txtSifra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPrijava);
            Name = "FrmLogIn";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnPrijava;
        public Label label1;
        public Label label2;
        public TextBox txtSifra;
        public TextBox txtKorIme;

        public Button BtnPrijava { get => btnPrijava; set => btnPrijava = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtKorIme { get => txtKorIme; set => txtKorIme = value; }
        public TextBox TxtSifra { get => txtSifra; set => txtSifra = value; }
    }
}
