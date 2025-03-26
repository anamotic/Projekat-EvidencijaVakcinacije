using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Client.UserControls
{
    partial class UCKontrolaStavki
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSacuvaj = new Button();
            btnNazad = new Button();
            txtNapomena = new TextBox();
            txtDoza = new TextBox();
            cbDa = new CheckBox();
            cbNe = new CheckBox();
            cbVakcine = new ComboBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Footlight MT Light", 10.8F);
            monthCalendar1.Location = new Point(47, 76);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 10.8F);
            label1.Location = new Point(95, 36);
            label1.Name = "label1";
            label1.Size = new Size(147, 19);
            label1.TabIndex = 1;
            label1.Text = "Datum vakcinacije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 10.8F);
            label2.Location = new Point(355, 59);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 2;
            label2.Text = "Vakcina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 10.8F);
            label3.Location = new Point(355, 142);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 3;
            label3.Text = "Doza:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Footlight MT Light", 10.8F);
            label4.Location = new Point(386, 214);
            label4.Name = "label4";
            label4.Size = new Size(144, 19);
            label4.TabIndex = 4;
            label4.Text = "Nezeljena reakcija";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Footlight MT Light", 10.8F);
            label5.Location = new Point(38, 329);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 5;
            label5.Text = "Napomena:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Font = new Font("Footlight MT Light", 10.8F);
            btnSacuvaj.Location = new Point(209, 391);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(111, 44);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            btnNazad.Font = new Font("Footlight MT Light", 10.8F);
            btnNazad.Location = new Point(386, 391);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(109, 44);
            btnNazad.TabIndex = 7;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            // 
            // txtNapomena
            // 
            txtNapomena.Font = new Font("Footlight MT Light", 10.8F);
            txtNapomena.Location = new Point(150, 329);
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(494, 27);
            txtNapomena.TabIndex = 8;
            // 
            // txtDoza
            // 
            txtDoza.Font = new Font("Footlight MT Light", 10.8F);
            txtDoza.Location = new Point(429, 135);
            txtDoza.Name = "txtDoza";
            txtDoza.Size = new Size(151, 27);
            txtDoza.TabIndex = 11;
            // 
            // cbDa
            // 
            cbDa.AutoSize = true;
            cbDa.Font = new Font("Footlight MT Light", 10.8F);
            cbDa.Location = new Point(375, 251);
            cbDa.Name = "cbDa";
            cbDa.Size = new Size(52, 23);
            cbDa.TabIndex = 12;
            cbDa.Text = "Da";
            cbDa.UseVisualStyleBackColor = true;
            // 
            // cbNe
            // 
            cbNe.AutoSize = true;
            cbNe.Font = new Font("Footlight MT Light", 10.8F);
            cbNe.Location = new Point(489, 251);
            cbNe.Name = "cbNe";
            cbNe.Size = new Size(51, 23);
            cbNe.TabIndex = 13;
            cbNe.Text = "Ne";
            cbNe.UseVisualStyleBackColor = true;
            // 
            // cbVakcine
            // 
            cbVakcine.Font = new Font("Footlight MT Light", 10.8F);
            cbVakcine.FormattingEnabled = true;
            cbVakcine.Location = new Point(429, 56);
            cbVakcine.Name = "cbVakcine";
            cbVakcine.Size = new Size(151, 27);
            cbVakcine.TabIndex = 14;
            // 
            // UCKontrolaStavki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(cbVakcine);
            Controls.Add(cbNe);
            Controls.Add(cbDa);
            Controls.Add(txtDoza);
            Controls.Add(txtNapomena);
            Controls.Add(btnNazad);
            Controls.Add(btnSacuvaj);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "UCKontrolaStavki";
            Size = new Size(687, 453);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSacuvaj;
        private Button btnNazad;
        private TextBox txtNapomena;
        private TextBox txtDoza;
        private CheckBox cbDa;
        private CheckBox cbNe;
        private ComboBox cbVakcine;


        public TextBox TxtNapomena { get => txtNapomena; set => txtNapomena = value; }
        public TextBox TxtDoza { get => txtDoza; set => txtDoza = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public CheckBox ChbDa { get => cbDa; set => cbDa = value; }
        public CheckBox ChbNe { get => cbNe; set => cbNe = value; }
        public ComboBox CbVakcine { get => cbVakcine; set => cbVakcine = value; }
        public MonthCalendar DatumVakcinacije { get => monthCalendar1; set => monthCalendar1 = value; }
    }
}
