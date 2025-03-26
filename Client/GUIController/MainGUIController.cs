using Client.UIKontrole;
using Client.UserControls;
using Common.Domain;
using System.ComponentModel;

namespace Client.GUIController
{
    internal class MainGUIController
    {
        private static MainGUIController instance;
        private FrmMain frmMain;
        private UCPregledVakcina pregledVakcina;
        private FrmLogIn frmLogIn;
        private ZdravstveniRadnik prijavljeniRadnik;
        public static MainGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainGUIController();
                }
                return instance;
            }
        }

        private MainGUIController()
        {
        }

        internal void ShowFrmMain(ZdravstveniRadnik radnik = null)
        {
            if (frmMain == null || frmMain.IsDisposed) // Proveravam da li je forma već kreirana
            {
                frmMain = new FrmMain();
                frmMain.AutoSize = true;

                frmMain.btnOdjava.Click += BtnOdjava_Click;
                frmMain.btnKartoni.Click += BtnKartoniVakcinacije_Click;
                frmMain.btnPacijenti.Click += BtnPacijenti_Click;
                frmMain.btnVakcine.Click += BtnVakcine_Click;
                frmMain.btnLokacije.Click += BtnLokacije_Click;
            }

            if (radnik != null)
            {
                prijavljeniRadnik = radnik;
            }
            if (prijavljeniRadnik != null)
            {
                frmMain.TxtLogIn.Text = $"{prijavljeniRadnik.Ime} {prijavljeniRadnik.Prezime}";
            }

            if (!frmMain.Visible)
            {
                frmMain.Show();
            }
            else
            {
                frmMain.BringToFront(); // Ako je već otvorena da bude u fokusu
            }
        }
        private void BtnKartoniVakcinacije_Click(object sender, EventArgs e)
        {
            frmMain.Hide();
            KartonVakcinacijeGUIController.Instance.ShowFrmKartoni();
        }

        private void BtnPacijenti_Click(object sender, EventArgs e)
        {
            frmMain.Hide();
            PacijentGUIController.Instance.ShowFrmPacijent();
        }
        private void BtnLokacije_Click(object sender, EventArgs e)
        {
            frmMain.Hide();
            LokacijaGUIController.Instance.ShowFrmLokacija();
        }
        private void BtnVakcine_Click(object sender, EventArgs e)
        {
            Form form = new Form
            {
                Text = "Pregled vakcine",
                Size = new Size(1000, 800)
            };

            UCPregledVakcina pv = new UCPregledVakcina
            {
                Dock = DockStyle.Fill
            };

            pv.dgvVakcine.DataSource = Communication.Instance.UcitajListuVakcina();
            if (pv.dgvVakcine.Columns.Count > 0)
            {

                pv.dgvVakcine.Columns["Id"].Visible = false;
                pv.dgvVakcine.Columns["Naziv"].HeaderText = "Naziv";
                pv.dgvVakcine.Columns["Proizvodjac"].HeaderText = "Proizvođač";
                pv.dgvVakcine.Columns["DozvoljenBr"].HeaderText = "Dozvoljen broj doza";
                pv.dgvVakcine.Columns["Obavezna"].Visible = false;
                pv.dgvVakcine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Podaci su učitani, ali kolone nisu generisane!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pv.btnNazad.Click += (s, e) =>
            {
                form.Close();
                ShowFrmMain();
            };


            pv.rbObavezne.CheckedChanged += (s, e) => { if (pv.rbObavezne.Checked) FilterVakcine(); };
            pv.rbOpcione.CheckedChanged += (s, e) => { if (pv.rbOpcione.Checked) FilterVakcine(); };
            pv.rbSve.CheckedChanged += (s, e) => { if (pv.rbSve.Checked) FilterVakcine(); };

            void FilterVakcine()
            {
                List<Vakcina> sveVakcine = Communication.Instance.UcitajListuVakcina();
                IEnumerable<Vakcina> filtrirani;

                if (pv.rbObavezne.Checked)
                {
                    filtrirani = sveVakcine.Where(p => p.Obavezna == true);
                }
                else if (pv.rbOpcione.Checked)
                {
                    filtrirani = sveVakcine.Where(p => p.Obavezna == false);
                }
                else if (pv.rbSve.Checked)
                {
                    filtrirani = sveVakcine;
                }
                else
                {
                    filtrirani = sveVakcine;
                }

                BindingList<Vakcina> vakcine = new BindingList<Vakcina>(filtrirani.ToList());
                pv.dgvVakcine.DataSource = vakcine;
            }

            form.Controls.Add(pv);


            form.ShowDialog();
        }
        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Da li ste sigurni da želite da zatvorite aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmMain.Hide();
                LogInGUIController.Instance.ShowFrmLogin();
            }
            else
            {
                // Korisnik je odustao od zatvaranja, ne radimo ništa
            }
        }

    }
}
