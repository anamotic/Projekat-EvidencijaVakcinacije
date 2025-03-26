using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System.ComponentModel;
using System.Diagnostics;

namespace Client.GUIController
{
    internal class StavkeKartonaGUIController
    {
        private static StavkeKartonaGUIController instance;
        private FrmStavkeKartona frmStavke;
        private FrmKartoniVakcinacije frmKartoniVakcinacije;
        private KartonVakcinacije selektovaniKarton;
        private UCKontrolaStavki kontrolaStavki;

        public static StavkeKartonaGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StavkeKartonaGUIController();
                }
                return instance;
            }
        }

        private StavkeKartonaGUIController() { }

        public void SetFrmKartoni(FrmKartoniVakcinacije frmKartoni)
        {
            this.frmKartoniVakcinacije = frmKartoni;
        }

        public void ShowFrmStavke(KartonVakcinacije odabrani)
        {
            this.selektovaniKarton = odabrani;

            if (frmKartoniVakcinacije != null)
                frmKartoniVakcinacije.Hide();

            frmStavke = new FrmStavkeKartona();
            frmStavke.AutoSize = true;

            frmStavke.FormClosing += (s, ev) =>
            {
                if (frmKartoniVakcinacije != null)
                    frmKartoniVakcinacije.Show();
            };

            if (odabrani.Pacijent != null)
            {
                frmStavke.TxtIme.Text = odabrani.Pacijent.Ime;
                frmStavke.TxtPrezime.Text = odabrani.Pacijent.Prezime;
            }

            var stavkeLista = Communication.Instance.UcitajListuStavkiZaKarton(odabrani.Id);
            if (stavkeLista == null)
            {
                MessageBox.Show("Nema podataka za prikaz.");
                stavkeLista = new List<StavkaKartonaVakcinacije>();
            }

            BindingList<StavkaKartonaVakcinacije> stavke = new BindingList<StavkaKartonaVakcinacije>(stavkeLista);

            if (frmStavke.DgvStavke == null)
            {
                MessageBox.Show("Greška: Kontrola za prikaz podataka nije učitana.");
                return;
            }

            frmStavke.DgvStavke.DataSource = stavke;
            frmStavke.DgvStavke.Refresh();
            frmStavke.DgvStavke.Update();

            foreach (var columnName in new string[] { "Id", "IDKartona", "Napomena", "IDVakcine", "Karton", "Vakcina" })
            {
                if (frmStavke.DgvStavke.Columns.Contains(columnName))
                {
                    frmStavke.DgvStavke.Columns[columnName].Visible = false;
                }
            }

            frmStavke.DgvStavke.Columns["NezeljenaReakcija"].HeaderText = "Neželjena Reakcija";
            frmStavke.DgvStavke.Columns["DatumVakcinacije"].HeaderText = "Datum vakcinacije";
            frmStavke.DgvStavke.Columns["rbDoze"].HeaderText = "Redni broj doze";

            if (!frmStavke.DgvStavke.Columns.Contains("NazivVakcine"))
            {
                DataGridViewTextBoxColumn nazivVakcineKolona = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Naziv vakcine",
                    Name = "NazivVakcine",
                    ReadOnly = true
                };
                frmStavke.DgvStavke.Columns.Add(nazivVakcineKolona);
            }

            foreach (DataGridViewRow row in frmStavke.DgvStavke.Rows)
            {
                StavkaKartonaVakcinacije stavka = row.DataBoundItem as StavkaKartonaVakcinacije;
                if (stavka != null && stavka.Vakcina != null)
                {
                    Debug.WriteLine($"Dodajem u tabelu: {stavka.Vakcina.Naziv}");
                    row.Cells["NazivVakcine"].Value = stavka.Vakcina.Naziv;
                }
            }

            frmStavke.DgvStavke.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return; 
                if (frmStavke.DgvStavke.Columns[e.ColumnIndex].Name == "NazivVakcine")
                {
                    StavkaKartonaVakcinacije stavka = frmStavke.DgvStavke.Rows[e.RowIndex].DataBoundItem as StavkaKartonaVakcinacije;
                    if (stavka != null && stavka.Vakcina != null)
                    {
                        e.Value = stavka.Vakcina.Naziv;
                    }
                }
                else if (frmStavke.DgvStavke.Columns[e.ColumnIndex].Name == "rbDoze")
                {
                    StavkaKartonaVakcinacije stavka = frmStavke.DgvStavke.Rows[e.RowIndex].DataBoundItem as StavkaKartonaVakcinacije;
                    if (stavka != null)
                    {
                        e.Value = stavka.rbDoze;
                    }
                }
            };

            frmStavke.DgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            frmStavke.BtnNazad.Click += BtnGlavna_Click;
            frmStavke.BtnDodajStavku.Click += DodajStavku;
            frmStavke.BtnObrisiStavku.Click += ObrisiStavku;
            frmStavke.BtnPregledStavke.Click += PregledStavke;

            frmStavke.Show();
        }

        public void ObrisiStavku(object sender, EventArgs e)
        {
            if (frmStavke.DgvStavke.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete stavku?",
                                                      "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    StavkaKartonaVakcinacije odabranaStavka = frmStavke.DgvStavke.SelectedRows[0].DataBoundItem as StavkaKartonaVakcinacije;
                    if (odabranaStavka == null) return;

                    Response res = Communication.Instance.ObrisiStavku(odabranaStavka);
                    if (res.Exception == null)
                    {
                        MessageBox.Show("Stavka je obrisana.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindingList<StavkaKartonaVakcinacije> stavke = new BindingList<StavkaKartonaVakcinacije>(
                            Communication.Instance.UcitajListuStavkiZaKarton(selektovaniKarton.Id));
                        frmStavke.DgvStavke.DataSource = stavke;
                        frmStavke.DgvStavke.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja stavke: " + res.Exception.Message,
                                        "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Odaberite stavku za brisanje.");
            }
        }

        public void PregledStavke(object sender, EventArgs e)
        {
            if (frmStavke.DgvStavke.SelectedRows.Count != 1)
            {
                MessageBox.Show("Morate izabrati tačno jednu stavku za pregled!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaKartonaVakcinacije odabranaStavka = frmStavke.DgvStavke.SelectedRows[0].DataBoundItem as StavkaKartonaVakcinacije;
            if (odabranaStavka == null)
            {
                MessageBox.Show("Greška pri odabiru stavke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            kontrolaStavki = new UCKontrolaStavki();
            frmStavke.Controls.Clear();
            frmStavke.Controls.Add(kontrolaStavki);
            kontrolaStavki.Dock = DockStyle.Fill;

            var listaSvihVakcina = Communication.Instance.UcitajListuVakcina();
            kontrolaStavki.CbVakcine.DataSource = listaSvihVakcina;
            kontrolaStavki.CbVakcine.DisplayMember = "Naziv";
            kontrolaStavki.TxtDoza.Text = odabranaStavka.rbDoze.ToString();
            kontrolaStavki.TxtNapomena.Text = odabranaStavka.Napomena;
            kontrolaStavki.DatumVakcinacije.SelectionStart = odabranaStavka.DatumVakcinacije;
            kontrolaStavki.DatumVakcinacije.SelectionEnd = odabranaStavka.DatumVakcinacije;
            kontrolaStavki.ChbDa.Checked = odabranaStavka.NezeljenaReakcija;
            kontrolaStavki.ChbNe.Checked = !odabranaStavka.NezeljenaReakcija;

            if (odabranaStavka.Vakcina != null)
            {
                foreach (var vak in listaSvihVakcina)
                {
                    if (vak.Id == odabranaStavka.Vakcina.Id)
                    {
                        kontrolaStavki.CbVakcine.SelectedItem = vak;
                        break;
                    }
                }
            }

            kontrolaStavki.TxtDoza.Enabled = false;
            kontrolaStavki.TxtNapomena.Enabled = false;
            kontrolaStavki.DatumVakcinacije.Enabled = false;
            kontrolaStavki.ChbDa.Enabled = false;
            kontrolaStavki.ChbNe.Enabled = false;
            kontrolaStavki.CbVakcine.Enabled = false;

            kontrolaStavki.BtnSacuvaj.Visible = false;
            kontrolaStavki.BtnNazad.Click += BtnNazad_Click;
            kontrolaStavki.Refresh();
        }

        private void BtnGlavna_Click(object sender, EventArgs e)
        {
            frmStavke.Close();
            KartonVakcinacijeGUIController.Instance.ShowFrmKartoni();
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            frmStavke.Close();
            ShowFrmStavke(selektovaniKarton);
        }

        public void DodajStavku(object sender, EventArgs e)
        {
            if (selektovaniKarton == null)
            {
                MessageBox.Show("Morate izabrati karton vakcinacije pre dodavanja stavke!",
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            kontrolaStavki = new UCKontrolaStavki();
            frmStavke.Controls.Clear();
            frmStavke.Controls.Add(kontrolaStavki);
            kontrolaStavki.Dock = DockStyle.Fill;

            var sveVakcine = Communication.Instance.UcitajListuVakcina();
            kontrolaStavki.CbVakcine.DataSource = new BindingList<Vakcina>(sveVakcine);
            kontrolaStavki.CbVakcine.DisplayMember = "Naziv";

            kontrolaStavki.BtnSacuvaj.Click += SacuvajStavku;
            kontrolaStavki.BtnNazad.Click += BtnNazad_Click;
        }

        public void SacuvajStavku(object sender, EventArgs e)
        {
            if (kontrolaStavki.CbVakcine.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati vakcinu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(kontrolaStavki.TxtDoza.Text, out int doza))
            {
                MessageBox.Show("Polje 'Doza' mora biti broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool nezeljenaReakcija = false;
            if (kontrolaStavki.ChbDa.Checked)
            {
                nezeljenaReakcija = true;
            }
            else if (kontrolaStavki.ChbNe.Checked)
            {
                nezeljenaReakcija = false;
            }

            Vakcina odabranaVakcina = (Vakcina)kontrolaStavki.CbVakcine.SelectedItem;

            var listaStavkiPostojecih = Communication.Instance.UcitajListuStavkiZaKarton(selektovaniKarton.Id) ?? new List<StavkaKartonaVakcinacije>();
            BindingList<StavkaKartonaVakcinacije> stavke = new BindingList<StavkaKartonaVakcinacije>(listaStavkiPostojecih);

            int brojPrimljenihDoza = stavke.Count(s => s.IDVakcine == odabranaVakcina.Id);

            if (brojPrimljenihDoza >= odabranaVakcina.DozvoljenBr)
            {
                MessageBox.Show($"Pacijent je već primio maksimalan broj doza ({odabranaVakcina.DozvoljenBr}) za vakcinu {odabranaVakcina.Naziv}.",
                                "Ograničenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sledeciRedniBrojDoze = brojPrimljenihDoza + 1;

            StavkaKartonaVakcinacije novaStavka = new StavkaKartonaVakcinacije
            {
                IDKartona = selektovaniKarton.Id,
                DatumVakcinacije = kontrolaStavki.DatumVakcinacije.SelectionStart,
                NezeljenaReakcija = nezeljenaReakcija,
                Napomena = kontrolaStavki.TxtNapomena.Text,
                rbDoze = sledeciRedniBrojDoze,
                IDVakcine = odabranaVakcina.Id,
                Vakcina = odabranaVakcina
            };

            Response res = Communication.Instance.KreirajStavkuKartona(novaStavka);
            if (res.Exception == null)
            {
                MessageBox.Show("Stavka uspešno dodata!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindingList<StavkaKartonaVakcinacije> stavkeKartona = new BindingList<StavkaKartonaVakcinacije>(
                    Communication.Instance.UcitajListuStavkiZaKarton(selektovaniKarton.Id));
                frmStavke.DgvStavke.DataSource = stavkeKartona;
                frmStavke.DgvStavke.Refresh();
            }
            else
            {
                MessageBox.Show("Došlo je do greške pri dodavanju stavke: " + res.Exception.Message,
                                "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
