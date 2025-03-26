using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.UserControls
{
    partial class UCPregledPacijenata
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
            dgvPacijenti = new DataGridView();
            btnDodajPacijenta = new Button();
            btnOdaberiPacijenta = new Button();
            btnNazad = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).BeginInit();
            SuspendLayout();
            // 
            // dgvPacijenti
            // 
            dgvPacijenti.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPacijenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacijenti.Location = new Point(25, 39);
            dgvPacijenti.Name = "dgvPacijenti";
            dgvPacijenti.RowHeadersWidth = 51;
            dgvPacijenti.Size = new Size(476, 361);
            dgvPacijenti.TabIndex = 0;
            // 
            // btnDodajPacijenta
            // 
            btnDodajPacijenta.Font = new Font("Footlight MT Light", 10.8F);
            btnDodajPacijenta.Location = new Point(508, 133);
            btnDodajPacijenta.Name = "btnDodajPacijenta";
            btnDodajPacijenta.Size = new Size(138, 48);
            btnDodajPacijenta.TabIndex = 1;
            btnDodajPacijenta.Text = "Dodaj pacijenta";
            btnDodajPacijenta.UseVisualStyleBackColor = true;
            // 
            // btnOdaberiPacijenta
            // 
            btnOdaberiPacijenta.Font = new Font("Footlight MT Light", 10.8F);
            btnOdaberiPacijenta.Location = new Point(508, 213);
            btnOdaberiPacijenta.Name = "btnOdaberiPacijenta";
            btnOdaberiPacijenta.Size = new Size(138, 48);
            btnOdaberiPacijenta.TabIndex = 2;
            btnOdaberiPacijenta.Text = "Odaberi";
            btnOdaberiPacijenta.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 10.8F);
            btnNazad.Location = new Point(508, 294);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(138, 48);
            btnNazad.TabIndex = 3;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 16);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "Pacijenti";
            // 
            // UCPregledPacijenata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label1);
            Controls.Add(btnNazad);
            Controls.Add(btnOdaberiPacijenta);
            Controls.Add(btnDodajPacijenta);
            Controls.Add(dgvPacijenti);
            Name = "UCPregledPacijenata";
            Size = new Size(663, 436);
            ((System.ComponentModel.ISupportInitialize)dgvPacijenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacijenti;
        private Button btnDodajPacijenta;
        private Button btnOdaberiPacijenta;
        private Button btnNazad;
        private Label label1;

        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnDodajPacijenta { get => btnDodajPacijenta; set => btnDodajPacijenta = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnOdaberi { get => btnOdaberiPacijenta; set => btnOdaberiPacijenta = value; }
        public DataGridView DgvPacijenti { get => dgvPacijenti; set => dgvPacijenti = value; }
    }
}
