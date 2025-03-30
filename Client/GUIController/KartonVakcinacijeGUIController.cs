using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System.ComponentModel;

namespace Client.GUIController
{
    internal class KartonVakcinacijeGUIController
    {
        private static KartonVakcinacijeGUIController instance;
        private FrmKartoniVakcinacije frmKartoniVakcinacije;
        private UCDodajKarton dodajKarton;
        private UCKontrolaStavki kontrolaStavki;
        private UCPregledKartona pregledKartona;
        private UCPregledPacijenata pregledPacijenata;
        private UCKontrolaPacijenata kontrolaPacijenata;
        private Pacijent odabraniPacijent;
        private KartonVakcinacije selektovaniKarton;
        BindingList<Pacijent> pacijenti;
        BindingList<Pacijent> pacijentiprikaz;


        public static KartonVakcinacijeGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KartonVakcinacijeGUIController();
                }
                return instance;
            }
        }

        private KartonVakcinacijeGUIController()
        {
        }
        internal void ShowFrmKartoni()
        {
            frmKartoniVakcinacije = new FrmKartoniVakcinacije();
            frmKartoniVakcinacije.AutoSize = true;

            BindingList<KartonVakcinacije> kartoni = new BindingList<KartonVakcinacije>(Communication.Instance.UcitajListuKartona());

            frmKartoniVakcinacije.dgvKartoni.DataSource = kartoni;
            frmKartoniVakcinacije.dgvKartoni.Refresh();
            frmKartoniVakcinacije.dgvKartoni.Update();

            frmKartoniVakcinacije.dgvKartoni.Columns["Id"].Visible = false;
            frmKartoniVakcinacije.dgvKartoni.Columns["IDZR"].Visible = false;
            frmKartoniVakcinacije.dgvKartoni.Columns["IDPacijent"].Visible = false;
            frmKartoniVakcinacije.dgvKartoni.Columns["zdravstveniRadnik"].Visible = false;
            frmKartoniVakcinacije.dgvKartoni.Columns["Pacijent"].Visible = false;
            frmKartoniVakcinacije.dgvKartoni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!frmKartoniVakcinacije.dgvKartoni.Columns.Contains("ImePrezimePacijenta"))
            {
                DataGridViewTextBoxColumn imePrezimeKolona = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Ime i Prezime pacijenta",
                    Name = "ImePrezimePacijenta",
                    ReadOnly = true
                };
                frmKartoniVakcinacije.dgvKartoni.Columns.Add(imePrezimeKolona);
            }


            if (!frmKartoniVakcinacije.dgvKartoni.Columns.Contains("BrojStavki"))
            {
                DataGridViewTextBoxColumn brojStavkiKolona = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Broj stavki",
                    Name = "BrojStavki",
                    ReadOnly = true
                };
                frmKartoniVakcinacije.dgvKartoni.Columns.Add(brojStavkiKolona);
            }

            foreach (DataGridViewRow row in frmKartoniVakcinacije.dgvKartoni.Rows)
            {
                KartonVakcinacije karton = row.DataBoundItem as KartonVakcinacije;
                if (karton != null)
                {
                    row.Cells["ImePrezimePacijenta"].Value = $"{karton.Pacijent.Ime} {karton.Pacijent.Prezime}";

                    int brojStavki = 0;
                    var stavkeLista = Communication.Instance.UcitajListuStavkiZaKarton(karton.Id);
                    if (stavkeLista != null)
                    {
                        brojStavki = stavkeLista.Count; // Broj stavki za karton
                    }
                    row.Cells["BrojStavki"].Value = brojStavki;
                }
            }

            frmKartoniVakcinacije.dgvKartoni.CellFormatting += (s, e) =>
            {
                if (frmKartoniVakcinacije.dgvKartoni.Columns[e.ColumnIndex].Name == "ImePrezimePacijenta")
                {
                    KartonVakcinacije karton = frmKartoniVakcinacije.dgvKartoni.Rows[e.RowIndex].DataBoundItem as KartonVakcinacije;
                    if (karton != null && karton.Pacijent != null)
                    {
                        e.Value = $"{karton.Pacijent.Ime} {karton.Pacijent.Prezime}";
                    }
                }

                if (frmKartoniVakcinacije.dgvKartoni.Columns[e.ColumnIndex].Name == "BrojStavki")
                {
                    KartonVakcinacije karton = frmKartoniVakcinacije.dgvKartoni.Rows[e.RowIndex].DataBoundItem as KartonVakcinacije;
                    if (karton != null && karton.Pacijent != null)
                    {
                        if (karton != null)
                        {
                            var stavkeLista = Communication.Instance.UcitajListuStavkiZaKarton(karton.Id);
                            e.Value = stavkeLista?.Count ?? 0;
                        }
                    } 
                } 
            }; 


            frmKartoniVakcinacije.btnDodaj.Click += DodajKarton;
            frmKartoniVakcinacije.btnObrisi.Click += ObrisiKarton;
            frmKartoniVakcinacije.btnGlavna.Click += BtnGlavna_Click;
            frmKartoniVakcinacije.btnPregled.Click += PregledKartona;
            frmKartoniVakcinacije.Show();
        }

        private void PregledKartona(object sender, EventArgs e)
        {
            if (frmKartoniVakcinacije.dgvKartoni.SelectedRows.Count != 1)
            {
                MessageBox.Show("Morate odabrati tačno jedan karton!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KartonVakcinacije odabrani = frmKartoniVakcinacije.dgvKartoni.SelectedRows[0].DataBoundItem as KartonVakcinacije;

            if (odabrani == null)
            {
                MessageBox.Show("Greška pri odabiru pacijenta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmKartoniVakcinacije.Hide();
            StavkeKartonaGUIController.Instance.ShowFrmStavke(odabrani);
        }

        private void BtnGlavna_Click(object sender, EventArgs e)
        {
            frmKartoniVakcinacije.Close();
            MainGUIController.Instance.ShowFrmMain();
        }
        public void ObrisiKarton(object sender, EventArgs e)
        {
            if (frmKartoniVakcinacije.dgvKartoni.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete karton?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    KartonVakcinacije odabraniKarton = frmKartoniVakcinacije.dgvKartoni.SelectedRows[0].DataBoundItem as KartonVakcinacije;
                    Response res = Communication.Instance.ObrisiKarton(odabraniKarton);

                    if (res.Exception == null)
                    {
                        MessageBox.Show("Karton je obrisan.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindingList<KartonVakcinacije> kartoni = new BindingList<KartonVakcinacije>(Communication.Instance.UcitajListuKartona());
                        frmKartoniVakcinacije.dgvKartoni.DataSource = kartoni;
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja pacijenta: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Odaberite pacijenta za brisanje.");
            }
        }
        public void DodajKarton(object sender, EventArgs e)
        {
            dodajKarton = new UCDodajKarton();

            frmKartoniVakcinacije.Controls.Clear();
            dodajKarton.Dock = DockStyle.Fill;
            frmKartoniVakcinacije.Controls.Add(dodajKarton);

            dodajKarton.BtnPacijent.Click += DodajKartonKlik;
            dodajKarton.BtnNazad.Click += BtnNazad_Click;
            dodajKarton.BtnSacuvaj.Click += DodajKartonUDgv;
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {

            frmKartoniVakcinacije.Close();
            ShowFrmKartoni();
           
        }
        private void DodajKartonKlik(object sender, EventArgs e)
        {
            pregledPacijenata = new UCPregledPacijenata();
            frmKartoniVakcinacije.Controls.Clear();
            frmKartoniVakcinacije.BackgroundImage = null;
            pregledPacijenata.Dock = DockStyle.Fill;
            frmKartoniVakcinacije.Controls.Add(pregledPacijenata);

            List<Pacijent> sviPacijenti = Communication.Instance.UcitajListuPacijenata();
            List<KartonVakcinacije> sviKartoni = Communication.Instance.UcitajListuKartona();
            var pacijentiBezKartona = sviPacijenti.Where(p => !sviKartoni.Any(k => k.IDPacijent == p.Id)).ToList();

            pregledPacijenata.DgvPacijenti.DataSource = new BindingList<Pacijent>(pacijentiBezKartona);
            pregledPacijenata.DgvPacijenti.Columns["Id"].Visible = false;
            pregledPacijenata.DgvPacijenti.Columns["starosnaGrupa"].Visible = false;

            pregledPacijenata.BtnOdaberi.Click += OdaberiPacijenta;
            pregledPacijenata.BtnNazad.Click += BtnNazad_Click;
            pregledPacijenata.BtnDodajPacijenta.Click += DodajPacijenta;
            pregledPacijenata.textBox1.TextChanged += Pretrazi_Pacijente;
        }
        private void Pretrazi_Pacijente(object sender, EventArgs e)
        {
            List<Pacijent> sviPacijenti = Communication.Instance.UcitajListuPacijenata();
            List<KartonVakcinacije> sviKartoni = Communication.Instance.UcitajListuKartona();
            var pacijentiBezKartona = sviPacijenti.Where(p => !sviKartoni.Any(k => k.IDPacijent == p.Id)).ToList();

            pacijenti = new BindingList<Pacijent>(pacijentiBezKartona);
            pregledPacijenata.DgvPacijenti.DataSource = pacijenti;

            string unos = pregledPacijenata.textBox1.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(unos))
            {
                pacijentiprikaz = pacijenti;
            }
            else
            {
                var filtrirani = pacijenti.Where(p => (p.Ime != null && p.Ime.ToLower().Contains(unos)) || (p.Prezime != null && p.Prezime.ToLower().Contains(unos))).ToList();
                pacijentiprikaz = new BindingList<Pacijent>(filtrirani);
            }

            pregledPacijenata.DgvPacijenti.DataSource = pacijentiprikaz;
        }

        private void OdaberiPacijenta(object sender, EventArgs e)
        {
            if (pregledPacijenata.DgvPacijenti.SelectedRows.Count != 1)
            {
                MessageBox.Show("Morate selektovati jednog pacijenta za otvaranje kartona!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent odabrani = pregledPacijenata.DgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;
            if (odabrani == null)
            {
                MessageBox.Show("Nije moguće prepoznati selektovanog pacijenta!","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<KartonVakcinacije> sviKartoni = Communication.Instance.UcitajListuKartona();
            bool vecOtvoren = sviKartoni.Any(k => k.IDPacijent == odabrani.Id);
            if (vecOtvoren)
            {
                MessageBox.Show("Za selektovanog pacijenta već postoji otvoren karton!","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dodajKarton.TxtIme.Text = odabrani.Ime;
            dodajKarton.TxtPrezime.Text = odabrani.Prezime;
            odabraniPacijent = odabrani; 
           
            frmKartoniVakcinacije.Controls.Clear();
            dodajKarton.Dock = DockStyle.Fill;
            frmKartoniVakcinacije.Controls.Add(dodajKarton);
        }

        public void DodajPacijenta(object sender, EventArgs e)
        {
            kontrolaPacijenata = new UCKontrolaPacijenata();
            kontrolaPacijenata.Dock = DockStyle.Fill;

            pregledPacijenata.Controls.Clear();
            frmKartoniVakcinacije.BackgroundImage = null;
            pregledPacijenata.Controls.Add(kontrolaPacijenata);

            kontrolaPacijenata.BtnPotvrda.Click += DodajPacijentaKlik;
            kontrolaPacijenata.BtnPotvrda.Text = "Dodaj pacijenta";
            kontrolaPacijenata.BackColor = Color.MistyRose;
            kontrolaPacijenata.BtnNazad.Click += BtnNazad_Click;
            kontrolaPacijenata.DatumRodjenja.DateChanged += DatumRodjenja_Postava;
        }


        // Izračunavanje godina i određivanje starosne grupe na osnovu izabranog datuma rodjenja
        private void DatumRodjenja_Postava(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = kontrolaPacijenata.DatumRodjenja.SelectionStart;
            int godine = DateTime.Now.Year - selectedDate.Year;

            // Ako je datum pre ove godine, proveravamo mesec i dan da bi se ispravno izračunale godine
            if (DateTime.Now.Month < selectedDate.Month || (DateTime.Now.Month == selectedDate.Month && DateTime.Now.Day < selectedDate.Day))
            {
                godine--;
            }

            kontrolaPacijenata.TxtGodine.Text = godine.ToString();

            if (godine <= 12)
            {
                kontrolaPacijenata.CmbSGrupa.SelectedItem = StarosnaGrupa.Dete;
            }
            else if (godine >= 13 && godine <= 19)
            {
                kontrolaPacijenata.CmbSGrupa.SelectedItem = StarosnaGrupa.Adolescent;
            }
            else if (godine >= 20 && godine <= 64)
            {
                kontrolaPacijenata.CmbSGrupa.SelectedItem = StarosnaGrupa.OdraslaOsoba;
            }
            else
            {
                kontrolaPacijenata.CmbSGrupa.SelectedItem = StarosnaGrupa.StaraOsoba;
            }
        }

        private void DodajPacijentaKlik(object sender, EventArgs e)
        {
            var textBoxes = new List<TextBox> { kontrolaPacijenata.TxtIme, kontrolaPacijenata.TxtPrezime, kontrolaPacijenata.TxtGodine };
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

            if (!int.TryParse(kontrolaPacijenata.TxtGodine.Text, out int godine))
            {
                MessageBox.Show("Polje 'Godine' mora biti broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent pacijent = new Pacijent
            {
                Ime = kontrolaPacijenata.TxtIme.Text.Trim(),
                Prezime = kontrolaPacijenata.TxtPrezime.Text.Trim(),
                datumRodjenja = kontrolaPacijenata.DatumRodjenja.SelectionStart,
                starosnaGrupa = (StarosnaGrupa)kontrolaPacijenata.CmbSGrupa.SelectedItem,
                Godine = godine
            };

            Response res = Communication.Instance.KreirajPacijenta(pacijent);

            if (res.Exception == null)
            {
                MessageBox.Show("Pacijent uspešno dodat!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmKartoniVakcinacije.Controls.Remove(kontrolaPacijenata);
                kontrolaPacijenata.Dispose();

                pregledPacijenata = new UCPregledPacijenata();
                frmKartoniVakcinacije.Controls.Clear();
                frmKartoniVakcinacije.Controls.Add(pregledPacijenata);

                BindingList<Pacijent> pacijenti = new BindingList<Pacijent>(Communication.Instance.UcitajListuPacijenata());
                pregledPacijenata.DgvPacijenti.DataSource = pacijenti;
                pregledPacijenata.DgvPacijenti.Refresh();
                pregledPacijenata.DgvPacijenti.Update();

                pregledPacijenata.BtnOdaberi.Click += OdaberiPacijenta;
                pregledPacijenata.BtnNazad.Click += BtnNazad_Click;
                pregledPacijenata.BtnDodajPacijenta.Click += DodajPacijenta;

            }
            else
            {
                MessageBox.Show("Došlo je do greške pri dodavanju pacijenta: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DodajKartonUDgv(object sender, EventArgs e)
        {
            if (dodajKarton.TxtIme.Text == "" || dodajKarton.TxtPrezime.Text == "")
            {
                MessageBox.Show("Morate izabrati pacijenta!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KartonVakcinacije noviKarton = new KartonVakcinacije
            {
                IDPacijent = odabraniPacijent.Id,
                IDZR = 1,
                Pacijent = new Pacijent
                {
                    Id = odabraniPacijent.Id,
                    Ime = dodajKarton.TxtIme.Text,
                    Prezime = dodajKarton.TxtPrezime.Text
                },
                Stavke = new List<StavkaKartonaVakcinacije>() 
            };

            Response res = Communication.Instance.KreirajKartonVakcinacije(noviKarton);

            if (res.Exception == null)
            {
                MessageBox.Show("Karton uspešno dodat u bazu!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindingList<KartonVakcinacije> kartoni = new BindingList<KartonVakcinacije>(Communication.Instance.UcitajListuKartona());

                frmKartoniVakcinacije.dgvKartoni.DataSource = kartoni;
                frmKartoniVakcinacije.dgvKartoni.Refresh();
                frmKartoniVakcinacije.dgvKartoni.Update();

            }
            else
            {
                MessageBox.Show("Došlo je do greške pri dodavanju kartona: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

    





