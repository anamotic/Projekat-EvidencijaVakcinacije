namespace Client.UserControls
{
    partial class UCPregledVakcina
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
            dgvVakcine = new DataGridView();
            label1 = new Label();
            btnNazad = new Button();
            rbObavezne = new RadioButton();
            rbOpcione = new RadioButton();
            rbSve = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvVakcine).BeginInit();
            SuspendLayout();
            // 
            // dgvVakcine
            // 
            dgvVakcine.BackgroundColor = Color.MintCream;
            dgvVakcine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVakcine.Location = new Point(80, 66);
            dgvVakcine.Name = "dgvVakcine";
            dgvVakcine.RowHeadersWidth = 51;
            dgvVakcine.Size = new Size(613, 418);
            dgvVakcine.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 26);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 1;
            label1.Text = "Lista Vakcina";
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNazad.Location = new Point(614, 505);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(123, 56);
            btnNazad.TabIndex = 2;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // rbObavezne
            // 
            rbObavezne.AutoSize = true;
            rbObavezne.Font = new Font("Footlight MT Light", 13.8F);
            rbObavezne.Location = new Point(80, 519);
            rbObavezne.Name = "rbObavezne";
            rbObavezne.Size = new Size(125, 28);
            rbObavezne.TabIndex = 3;
            rbObavezne.TabStop = true;
            rbObavezne.Text = "Obavezne";
            rbObavezne.UseVisualStyleBackColor = true;
            // 
            // rbOpcione
            // 
            rbOpcione.AutoSize = true;
            rbOpcione.Font = new Font("Footlight MT Light", 13.8F);
            rbOpcione.Location = new Point(227, 519);
            rbOpcione.Name = "rbOpcione";
            rbOpcione.Size = new Size(110, 28);
            rbOpcione.TabIndex = 4;
            rbOpcione.TabStop = true;
            rbOpcione.Text = "Opcione";
            rbOpcione.UseVisualStyleBackColor = true;
            // 
            // rbSve
            // 
            rbSve.AutoSize = true;
            rbSve.Font = new Font("Footlight MT Light", 13.8F);
            rbSve.Location = new Point(359, 519);
            rbSve.Name = "rbSve";
            rbSve.Size = new Size(62, 28);
            rbSve.TabIndex = 5;
            rbSve.TabStop = true;
            rbSve.Text = "Sve";
            rbSve.UseVisualStyleBackColor = true;
            // 
            // UCPregledVakcina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(rbSve);
            Controls.Add(rbOpcione);
            Controls.Add(rbObavezne);
            Controls.Add(btnNazad);
            Controls.Add(label1);
            Controls.Add(dgvVakcine);
            Name = "UCPregledVakcina";
            Size = new Size(775, 592);
            Load += UCPregledVakcina_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVakcine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvVakcine;
        public Label label1;
        public Button btnNazad;
        public RadioButton rbObavezne;
        public RadioButton rbOpcione;
        public RadioButton rbSve;

        public DataGridView DgvVakcine { get => dgvVakcine; set => dgvVakcine = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public RadioButton RbObavezne { get => rbObavezne; set => rbObavezne = value; }
        public RadioButton RbOpcione { get => rbOpcione; set => rbOpcione = value; }
        public RadioButton RbSve { get => rbSve; set => rbSve = value; }

    }
}
