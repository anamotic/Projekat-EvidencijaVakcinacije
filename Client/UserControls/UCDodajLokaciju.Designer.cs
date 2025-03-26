using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.UserControls
{
    partial class UCDodajLokaciju
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
            btnDodaj = new Button();
            btnNazad = new Button();
            txtNaziv = new TextBox();
            txtAdresa = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 10.8F);
            label1.Location = new Point(258, 58);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 0;
            label1.Text = "Adresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 10.8F);
            label2.Location = new Point(76, 58);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 1;
            label2.Text = "Naziv";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Azure;
            btnDodaj.Font = new Font("Footlight MT Light", 10.8F);
            btnDodaj.Location = new Point(116, 169);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(158, 43);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            // 
            // btnNazad
            // 
            btnNazad.BackColor = Color.Azure;
            btnNazad.Font = new Font("Footlight MT Light", 10.8F);
            btnNazad.Location = new Point(258, 259);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(110, 43);
            btnNazad.TabIndex = 3;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = false;
            // 
            // txtNaziv
            // 
            txtNaziv.BackColor = Color.Azure;
            txtNaziv.Font = new Font("Footlight MT Light", 10.8F);
            txtNaziv.Location = new Point(39, 102);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(125, 27);
            txtNaziv.TabIndex = 4;
            // 
            // txtAdresa
            // 
            txtAdresa.BackColor = Color.Azure;
            txtAdresa.Font = new Font("Footlight MT Light", 10.8F);
            txtAdresa.Location = new Point(223, 102);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(125, 27);
            txtAdresa.TabIndex = 5;
            // 
            // UCDodajLokaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            Controls.Add(txtAdresa);
            Controls.Add(txtNaziv);
            Controls.Add(btnNazad);
            Controls.Add(btnDodaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCDodajLokaciju";
            Size = new Size(419, 317);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDodaj;
        private Button btnNazad;
        private TextBox txtNaziv;
        private TextBox txtAdresa;

        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtAdresa { get => txtAdresa; set => txtAdresa = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
    }
}
