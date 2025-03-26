namespace Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnKartoni = new Button();
            btnOdjava = new Button();
            btnPacijenti = new Button();
            btnVakcine = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtLogIn = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLokacije = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKartoni
            // 
            btnKartoni.BackColor = Color.Tan;
            btnKartoni.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKartoni.ForeColor = SystemColors.ButtonHighlight;
            btnKartoni.Location = new Point(36, 289);
            btnKartoni.Name = "btnKartoni";
            btnKartoni.Size = new Size(180, 51);
            btnKartoni.TabIndex = 1;
            btnKartoni.Text = "Kartoni vakcinacije";
            btnKartoni.UseVisualStyleBackColor = false;
            btnKartoni.Click += btnDodaj_Click;
            // 
            // btnOdjava
            // 
            btnOdjava.BackColor = Color.BurlyWood;
            btnOdjava.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOdjava.ForeColor = SystemColors.Control;
            btnOdjava.Location = new Point(538, 404);
            btnOdjava.Name = "btnOdjava";
            btnOdjava.Size = new Size(142, 64);
            btnOdjava.TabIndex = 3;
            btnOdjava.Text = "Odjava";
            btnOdjava.UseVisualStyleBackColor = false;
            // 
            // btnPacijenti
            // 
            btnPacijenti.BackColor = Color.Tan;
            btnPacijenti.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacijenti.ForeColor = SystemColors.ControlLightLight;
            btnPacijenti.Location = new Point(278, 289);
            btnPacijenti.Name = "btnPacijenti";
            btnPacijenti.Size = new Size(180, 51);
            btnPacijenti.TabIndex = 4;
            btnPacijenti.Text = "Pacijenti";
            btnPacijenti.UseVisualStyleBackColor = false;
            // 
            // btnVakcine
            // 
            btnVakcine.BackColor = Color.Tan;
            btnVakcine.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVakcine.ForeColor = SystemColors.ButtonHighlight;
            btnVakcine.Location = new Point(523, 289);
            btnVakcine.Name = "btnVakcine";
            btnVakcine.Size = new Size(179, 51);
            btnVakcine.TabIndex = 11;
            btnVakcine.Text = "Vakcine";
            btnVakcine.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(278, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 157);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(523, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(179, 157);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // txtLogIn
            // 
            txtLogIn.BackColor = Color.Tan;
            txtLogIn.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogIn.ForeColor = Color.White;
            txtLogIn.Location = new Point(176, 15);
            txtLogIn.Name = "txtLogIn";
            txtLogIn.Size = new Size(170, 27);
            txtLogIn.TabIndex = 15;
            txtLogIn.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Footlight MT Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 16;
            label1.Text = "Prijavljeni radnik:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(36, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 157);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnLokacije
            // 
            btnLokacije.BackColor = Color.Tan;
            btnLokacije.Font = new Font("Footlight MT Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLokacije.ForeColor = SystemColors.ButtonHighlight;
            btnLokacije.Location = new Point(523, 15);
            btnLokacije.Name = "btnLokacije";
            btnLokacije.Size = new Size(157, 35);
            btnLokacije.TabIndex = 18;
            btnLokacije.Text = "Lokacije";
            btnLokacije.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(717, 503);
            Controls.Add(btnLokacije);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtLogIn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnVakcine);
            Controls.Add(btnPacijenti);
            Controls.Add(btnOdjava);
            Controls.Add(btnKartoni);
            Name = "FrmMain";
            Text = "Početna strana";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnKartoni;
        public Button btnOdjava;
        public Button btnPacijenti;
        public Button btnVakcine;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtLogIn;
        private Label label1;
        private PictureBox pictureBox1;
        public Button btnLokacije;

        public Button BtnKartoni { get => btnKartoni; set => btnKartoni = value; }
        public Button BtnPacijenti { get => btnPacijenti; set => btnPacijenti = value; }
        public Button BtnOdjava { get => btnOdjava; set => btnOdjava = value; }
        public Button BtnVakcine { get => btnVakcine; set => btnVakcine = value; }
        public Button BtnLokacije { get => btnLokacije; set => btnLokacije = value; }
        public TextBox TxtLogIn { get => txtLogIn; set => txtLogIn = value; }

    }
}