using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System.ComponentModel;

namespace Client.GUIController
{
    public class LokacijaGUIController
    {
        private static LokacijaGUIController instance;
        FrmLokacija forma;
        UCDodajLokaciju dodajLokaciju;
        UCPregledSmena pregledSmena;
        UCKontrolaSmena kontrolaSmena;
        private Lokacija selektovanaLokacija;
        private ZRLok selektovanaSmena;
        public static LokacijaGUIController Instance
        {
            get
            {
                if (instance == null)
                    instance = new LokacijaGUIController();
                return instance;
            }
        }
        private LokacijaGUIController() { }
        public void ShowFrmLokacija()
        {
            forma = new FrmLokacija();
            forma.AutoSize = true;

            BindingList<Lokacija> lokacije = new BindingList<Lokacija>(Communication.Instance.UcitajListuLokacija());
            forma.dgvLokacije.DataSource = lokacije;
            forma.dgvLokacije.Columns["naziv"].HeaderText = "Naziv";
            forma.dgvLokacije.Columns["adresa"].HeaderText = "Adresa";
            forma.dgvLokacije.Columns["Id"].Visible = false;
            forma.dgvLokacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            forma.btnDodajLokaciju.Click += DodajLokaciju;
            forma.btnSmene.Click += SmeneRadnika;
            forma.btnObrisi.Click += ObrisiLokaciju;
            forma.btnNazad.Click += BtnGlavna_Click;
            forma.Show();
        }
        private void BtnGlavna_Click(object sender, EventArgs e)
        {
            forma.Close();
            MainGUIController.Instance.ShowFrmMain();
        }
        public void ObrisiLokaciju(object sender, EventArgs e)
        {
            if (forma.dgvLokacije.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete lokaciju?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Lokacija odabranaLokacija = forma.dgvLokacije.SelectedRows[0].DataBoundItem as Lokacija;
                    Response res = Communication.Instance.ObrisiLokaciju(odabranaLokacija);
                    if (res.Exception == null)
                    {
                        MessageBox.Show("Lokacija je obrisana.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindingList<Lokacija> lokacije = new BindingList<Lokacija>(Communication.Instance.UcitajListuLokacija());
                        forma.dgvLokacije.DataSource = lokacije;
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati lokaciju za brisanje.");
            }
        }
        public void DodajLokaciju(object sender, EventArgs e)
        {
            dodajLokaciju = new UCDodajLokaciju();
            forma.Controls.Clear();
            forma.Controls.Add(dodajLokaciju);
            dodajLokaciju.BtnDodaj.Click += BtnDodaj_Click;
            dodajLokaciju.BtnNazad.Click += BtnNazad_Click;
        }
        private void BtnNazad_Click(object sender, EventArgs e)
        {
            forma.Close();
            LokacijaGUIController.Instance.ShowFrmLokacija();
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            var textBoxes = new List<TextBox> { dodajLokaciju.TxtAdresa, dodajLokaciju.TxtNaziv };
            bool isValid = true;
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.BackColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    textBox.BackColor = SystemColors.Window;
                }
            }
            if (!isValid)
            {
                MessageBox.Show("Molimo popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lokacija lokacija = new Lokacija
            {
                Naziv = dodajLokaciju.TxtNaziv.Text.Trim(),
                Adresa = dodajLokaciju.TxtAdresa.Text.Trim()
            };
            Response res = Communication.Instance.KreirajLokaciju(lokacija);
            if (res.Exception == null)
            {
                MessageBox.Show("Lokacija uspešno dodata!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
                ShowFrmLokacija();
            }
            else
            {
                MessageBox.Show("Došlo je do greške pri dodavanju lokacije: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SmeneRadnika(object sender, EventArgs e)
        {
            if (forma.dgvLokacije.SelectedRows.Count != 1)
            {
                MessageBox.Show("Morate odabrati tačno jednu lokaciju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Lokacija odabrana = forma.dgvLokacije.SelectedRows[0].DataBoundItem as Lokacija;
            if (odabrana == null)
            {
                MessageBox.Show("Greška pri odabiru lokacije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selektovanaLokacija = odabrana;
            pregledSmena = new UCPregledSmena();
            forma.Controls.Clear();
            forma.Controls.Add(pregledSmena);
            pregledSmena.Dock = DockStyle.Fill;

            BindingList<ZRLok> smene = new BindingList<ZRLok>(Communication.Instance.UcitajListuZRLok(odabrana.Id));
            pregledSmena.DgvSmene.DataSource = smene;
            pregledSmena.DgvSmene.Columns["Id"].Visible = false;
            pregledSmena.DgvSmene.Columns["IDZR"].Visible = false;
            pregledSmena.DgvSmene.Columns["IDLok"].Visible = false;
            pregledSmena.DgvSmene.Columns["Lokacija"].Visible = false;
            pregledSmena.DgvSmene.Columns["ZdravstveniRadnik"].Visible = false;

            pregledSmena.RbPredstojece.CheckedChanged += (s, e) => { if (pregledSmena.RbPredstojece.Checked) FilterSmene(); };
            pregledSmena.RbPrethodne.CheckedChanged += (s, e) => { if (pregledSmena.RbPrethodne.Checked) FilterSmene(); };
            pregledSmena.RbSve.CheckedChanged += (s, e) => { if (pregledSmena.RbSve.Checked) FilterSmene(); };

            List<ZdravstveniRadnik> radnici = Communication.Instance.UcitajListuZRadnika();
            ZdravstveniRadnik placeholderRadnik = new ZdravstveniRadnik { Id = -1, Ime = "Zdravstveni", Prezime = "radnik" };
            radnici.Insert(0, placeholderRadnik);

            pregledSmena.CmbRadnici.DataSource = radnici;
            pregledSmena.CmbRadnici.DisplayMember = "ImePrezime";
            pregledSmena.CmbRadnici.ValueMember = "Id";
            pregledSmena.CmbRadnici.SelectedIndexChanged += cmbRadnici_IzabraniRadnik;

            pregledSmena.BtnDodaj.Click += DodajSmenuKlik;
            pregledSmena.BtnIzmeni.Click += IzmeniSmenuKlik;
            pregledSmena.BtnObrisi.Click += ObrisiSmenuKlik;
            pregledSmena.BtnNazad.Click += NazadKlik;
        }
        private void cmbRadnici_IzabraniRadnik(object sender, EventArgs e)
        {
            if (pregledSmena.CmbRadnici.SelectedItem is ZdravstveniRadnik izabraniRadnik)
            {
                List<ZRLok> sveSmene = Communication.Instance.UcitajListuZRLok(selektovanaLokacija.Id);
                IEnumerable<ZRLok> filtriraneSmene = sveSmene.Where(sm => sm.ZdravstveniRadnik.Id == izabraniRadnik.Id);
                pregledSmena.DgvSmene.DataSource = new BindingList<ZRLok>(filtriraneSmene.ToList());
            }
        }
        private void FilterSmene()
        {
            List<ZRLok> sveSmene = Communication.Instance.UcitajListuZRLok(selektovanaLokacija.Id);
            IEnumerable<ZRLok> filtrirane;
            DateTime danasnjiDatum = DateTime.Now.Date;

            if (pregledSmena.RbPredstojece.Checked)
                filtrirane = sveSmene.Where(p => p.DatumSmena.Date > danasnjiDatum);
            else if (pregledSmena.RbPrethodne.Checked)
                filtrirane = sveSmene.Where(p => p.DatumSmena.Date < danasnjiDatum);
            else
                filtrirane = sveSmene;

            BindingList<ZRLok> smene = new BindingList<ZRLok>(filtrirane.ToList());
            pregledSmena.DgvSmene.DataSource = smene;
        }
        private void NazadKlik(object sender, EventArgs e)
        {
            forma.Close();
            ShowFrmLokacija();
        }
        public void ObrisiSmenuKlik(object sender, EventArgs e)
        {
            if (pregledSmena.DgvSmene.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete smenu?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ZRLok odabranaSmena = pregledSmena.DgvSmene.SelectedRows[0].DataBoundItem as ZRLok;
                    Response res = Communication.Instance.ObrisiZRLok(odabranaSmena);
                    if (res.Exception == null)
                    {
                        MessageBox.Show("Smena je obrisana.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindingList<ZRLok> smene = new BindingList<ZRLok>(Communication.Instance.UcitajListuZRLok(odabranaSmena.Id));
                        pregledSmena.DgvSmene.DataSource = smene;
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Odaberite smenu za brisanje.");
            }
        }
        private void DodajSmenuKlik(object sender, EventArgs e)
        {
            kontrolaSmena = new UCKontrolaSmena();
            pregledSmena.Controls.Clear();
            pregledSmena.Controls.Add(kontrolaSmena);

            List<ZdravstveniRadnik> radnici = Communication.Instance.UcitajListuZRadnika();
            ZdravstveniRadnik placeholderRadnik = new ZdravstveniRadnik { Id = -1, Ime = "Zdravstveni", Prezime = "radnik" };
            radnici.Insert(0, placeholderRadnik);

            kontrolaSmena.CmbZdravstveniRadnik.DataSource = radnici;
            kontrolaSmena.CmbZdravstveniRadnik.DisplayMember = "ImePrezime";
            kontrolaSmena.CmbZdravstveniRadnik.ValueMember = "Id";

            List<Lokacija> lokacije = Communication.Instance.UcitajListuLokacija();
            Lokacija placeholderLokacija = new Lokacija { Id = -1, Naziv = "Lokacija" };
            lokacije.Insert(0, placeholderLokacija);

            kontrolaSmena.CmbLokacija.DataSource = lokacije;
            kontrolaSmena.CmbLokacija.DisplayMember = "Naziv";
            kontrolaSmena.CmbLokacija.ValueMember = "Id";

            kontrolaSmena.BtnNazad.Click += NazadKlik;
            kontrolaSmena.BtnSacuvaj.Click += SacuvajSmenuKlik;
            
          }
        private void SacuvajSmenuKlik(object sender, EventArgs e)
        {
            if (!(kontrolaSmena.CmbZdravstveniRadnik.SelectedItem is ZdravstveniRadnik radnik) || radnik.Id == -1)
            {
                MessageBox.Show("Morate izabrati zdravstvenog radnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(kontrolaSmena.CmbLokacija.SelectedItem is Lokacija lokacija) || lokacija.Id == -1)
            {
                MessageBox.Show("Morate izabrati lokaciju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime datumSmene = kontrolaSmena.CmDatumSmene.SelectionStart;
            if (datumSmene.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Datum smene mora biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ZRLok zrLok = new ZRLok
            {
                IDZR = radnik.Id,
                IDLok = lokacija.Id,
                DatumSmena = datumSmene,
                Lokacija = lokacija,
                ZdravstveniRadnik = radnik
            };
            Response res = Communication.Instance.KreirajZRLok(zrLok);
            if (res.Exception == null)
            {
                MessageBox.Show("Smena je sačuvana!", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindingList<ZRLok> smene = new BindingList<ZRLok>(Communication.Instance.UcitajListuZRLok(selektovanaLokacija.Id));
                pregledSmena.DgvSmene.DataSource = smene;
                pregledSmena.DgvSmene.Refresh();

            }
            else
            {
                MessageBox.Show("Greška prilikom čuvanja smene: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IzmeniSmenuKlik(object sender, EventArgs e)
        {
            if (pregledSmena.DgvSmene.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati smenu koju želite da izmenite.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ZRLok odabrana = pregledSmena.DgvSmene.SelectedRows[0].DataBoundItem as ZRLok;
            if (odabrana.DatumSmena.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Nije moguće menjati smenu koja je već prošla!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.selektovanaSmena = odabrana;

            kontrolaSmena = new UCKontrolaSmena();
            pregledSmena.Controls.Clear();
            pregledSmena.Controls.Add(kontrolaSmena);

            List<ZdravstveniRadnik> radnici = Communication.Instance.UcitajListuZRadnika();
            kontrolaSmena.CmbZdravstveniRadnik.DataSource = radnici;
            kontrolaSmena.CmbZdravstveniRadnik.DisplayMember = "ImePrezime";
            kontrolaSmena.CmbZdravstveniRadnik.ValueMember = "Id";
            kontrolaSmena.CmbZdravstveniRadnik.SelectedItem = radnici.FirstOrDefault(r => r.Id == selektovanaSmena.ZdravstveniRadnik.Id);

            List<Lokacija> lokacije = Communication.Instance.UcitajListuLokacija();
            kontrolaSmena.CmbLokacija.DataSource = lokacije;
            kontrolaSmena.CmbLokacija.DisplayMember = "Naziv";
            kontrolaSmena.CmbLokacija.ValueMember = "Id";
            kontrolaSmena.CmbLokacija.SelectedItem = lokacije.FirstOrDefault(l => l.Id == selektovanaSmena.Lokacija.Id);
            kontrolaSmena.CmDatumSmene.SetDate(selektovanaSmena.DatumSmena);

            kontrolaSmena.BtnNazad.Click += BtnNazad_Click;
            kontrolaSmena.BtnSacuvaj.Click += IzmeniSmenu;
           }

        private void IzmeniSmenu(object sender, EventArgs e )
        {
            if (!(kontrolaSmena.CmbZdravstveniRadnik.SelectedItem is ZdravstveniRadnik radnik) || radnik.Id == -1)
            {
                MessageBox.Show("Morate izabrati zdravstvenog radnika!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(kontrolaSmena.CmbLokacija.SelectedItem is Lokacija lokacija) || lokacija.Id == -1)
            {
                MessageBox.Show("Morate izabrati lokaciju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime datumSmene = kontrolaSmena.CmDatumSmene.SelectionStart;
            if (datumSmene.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Datum smene mora biti u budućnosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ZRLok zrLok = new ZRLok
            {
                Id = this.selektovanaSmena.Id,
                IDZR = radnik.Id,
                IDLok = lokacija.Id,
                DatumSmena = datumSmene,
                Lokacija = lokacija,
                ZdravstveniRadnik = radnik
            };
            Response res = Communication.Instance.PromeniZRLok(zrLok);
            if (res.Exception == null)
            {
                MessageBox.Show("Smena je izmenjena!", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindingList<ZRLok> smene = new BindingList<ZRLok>(Communication.Instance.UcitajListuZRLok(selektovanaLokacija.Id));
                pregledSmena.DgvSmene.DataSource = smene;
                pregledSmena.DgvSmene.Refresh();
            }
            else
            {
                MessageBox.Show("Greška prilikom čuvanja smene: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

