using Client.GUIController;
using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System.ComponentModel;

namespace Client.UIKontrole
{
    public class PacijentGUIController
    {
        private static PacijentGUIController instance;
        FrmPacijenti forma;
        UCKontrolaPacijenata kontrolaPacijenta;
        private Pacijent selektovaniPacijent;

        public static PacijentGUIController Instance
        {
            get
            {
                if (instance == null)
                    instance = new PacijentGUIController();
                return instance;
            }
        }
        private PacijentGUIController() { }

         public void ShowFrmPacijent()
            {
                forma = new FrmPacijenti();
                forma.AutoSize = true;

                BindingList<Pacijent> pacijenti = new BindingList<Pacijent>(Communication.Instance.UcitajListuPacijenata());

                forma.dgvPacijenti.DataSource = pacijenti;

                forma.dgvPacijenti.Columns["starosnaGrupa"].HeaderText = "Starosna grupa";
                forma.dgvPacijenti.Columns["DatumRodjenja"].HeaderText = "Datum rodjenja";
                forma.dgvPacijenti.Columns["DatumRodjenja"].DefaultCellStyle.Format = "d";
                forma.dgvPacijenti.Columns["Id"].Visible = false;
                forma.dgvPacijenti.Columns["starosnaGrupa"].Visible = false;
                forma.dgvPacijenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                forma.rbDete.CheckedChanged += (s, e) => { if (forma.rbDete.Checked) FilterPacijenti(); };
                forma.rbAdolescent.CheckedChanged += (s, e) => { if (forma.rbAdolescent.Checked) FilterPacijenti(); };
                forma.rbOdraslaOsoba.CheckedChanged += (s, e) => { if (forma.rbOdraslaOsoba.Checked) FilterPacijenti(); };
                forma.rbStaraOsoba.CheckedChanged += (s, e) => { if (forma.rbStaraOsoba.Checked) FilterPacijenti(); };
                forma.rbSvi.CheckedChanged += (s, e) => { if (forma.rbSvi.Checked) FilterPacijenti(); };

                forma.btnDodajPacijenta.Click += DodajPacijenta;
                forma.btnIzmeni.Click += IzmeniPacijenta;
                forma.btnObrisi.Click += ObrisiPacijenta;
                forma.btnGlavna.Click += BtnGlavna_Click;
                forma.Show();

            } 

          private void BtnGlavna_Click(object sender, EventArgs e)
          {
            forma.Close();
            MainGUIController.Instance.ShowFrmMain();
          }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            forma.Close();
            PacijentGUIController.Instance.ShowFrmPacijent();
        }

        // Metoda za filtriranje pacijenata po starosnoj grupi
        private void FilterPacijenti()
          {
              List<Pacijent> sviPacijenti = Communication.Instance.UcitajListuPacijenata();
              IEnumerable<Pacijent> filtrirani;

              if (forma.rbDete.Checked)
              {
                  filtrirani = sviPacijenti.Where(p => p.starosnaGrupa == StarosnaGrupa.Dete);
              }
              else if (forma.rbAdolescent.Checked)
              {
                  filtrirani = sviPacijenti.Where(p => p.starosnaGrupa == StarosnaGrupa.Adolescent);
              }
              else if (forma.rbOdraslaOsoba.Checked)
              {
                  filtrirani = sviPacijenti.Where(p => p.starosnaGrupa == StarosnaGrupa.OdraslaOsoba);
              }
              else if (forma.rbStaraOsoba.Checked)
              {
                  filtrirani = sviPacijenti.Where(p => p.starosnaGrupa == StarosnaGrupa.StaraOsoba);
              }
              else if (forma.rbSvi.Checked)
              {
                filtrirani = sviPacijenti;
              }
            else // ako nijedan radio button nije selektovan, prikazace sve pacijente
              {
                  filtrirani = sviPacijenti;
              }

              //  filtrirana lista kao DataSource
              BindingList<Pacijent> pacijenti = new BindingList<Pacijent>(filtrirani.ToList());
              forma.dgvPacijenti.DataSource = pacijenti;
          }

        public void ObrisiPacijenta(object sender, EventArgs e)
            {
                if (forma.dgvPacijenti.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete pacijenta?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Pacijent selectedPacijent = forma.dgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;
                        Response res = Communication.Instance.ObrisiPacijenta(selectedPacijent);

                        if (res.Exception == null)
                        {
                            MessageBox.Show("Pacijent je obrisan.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BindingList<Pacijent> pacijenti = new BindingList<Pacijent>(Communication.Instance.UcitajListuPacijenata());
                            forma.dgvPacijenti.DataSource = pacijenti;
                        }
                        else
                        {
                            MessageBox.Show("Došlo je do greške prilikom brisanja pacijenta: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Morate odabrati pacijenta za brisanje.");
                }
            }

        public void DodajPacijenta(object sender, EventArgs e)
        {
            kontrolaPacijenta = new UCKontrolaPacijenata();
            forma.Controls.Clear();
            forma.Controls.Add(kontrolaPacijenta);

            kontrolaPacijenta.BtnPotvrda.Click += DodajPacijentaKlik;
            kontrolaPacijenta.BtnPotvrda.Text = "Dodaj pacijenta";
            kontrolaPacijenta.BackColor = Color.MistyRose;
            kontrolaPacijenta.BtnNazad.Click += BtnNazad_Click;
            kontrolaPacijenta.DatumRodjenja.DateChanged += DatumRodjenja_Postava;
        }
       
        // Izračunavanje godina i određivanje starosne grupe na osnovu izabranog datuma rodjenja
        private void DatumRodjenja_Postava(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = kontrolaPacijenta.DatumRodjenja.SelectionStart;
            int godine = DateTime.Now.Year - selectedDate.Year;

            // Ako je datum pre ove godine, proveravamo mesec i dan da bi se ispravno izračunale godine
            if (DateTime.Now.Month < selectedDate.Month || (DateTime.Now.Month == selectedDate.Month && DateTime.Now.Day < selectedDate.Day))
            {
                godine--;
            }

            kontrolaPacijenta.TxtGodine.Text = godine.ToString();

            if (godine <= 12)
            {
                kontrolaPacijenta.CmbSGrupa.SelectedItem = StarosnaGrupa.Dete; 
            }
            else if (godine >= 13 && godine <= 19)
            {
                kontrolaPacijenta.CmbSGrupa.SelectedItem = StarosnaGrupa.Adolescent;  
            }
            else if (godine >= 20 && godine <= 64)
            {
                kontrolaPacijenta.CmbSGrupa.SelectedItem = StarosnaGrupa.OdraslaOsoba;  
            }
            else
            {
                kontrolaPacijenta.CmbSGrupa.SelectedItem = StarosnaGrupa.StaraOsoba; 
            }
        }

        private void DodajPacijentaKlik(object sender, EventArgs e)
        {
            var textBoxes = new List<TextBox> { kontrolaPacijenta.TxtIme, kontrolaPacijenta.TxtPrezime, kontrolaPacijenta.TxtGodine };
            bool isValid = true;

            //proveravamo da li su sva polja popunjena
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

            //ako ručno unosimo godine proveravamo da li je broj

            if (!int.TryParse(kontrolaPacijenta.TxtGodine.Text, out int godine))
            {
                MessageBox.Show("Polje 'Godine' mora biti broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent pacijent = new Pacijent
            {
                Ime = kontrolaPacijenta.TxtIme.Text.Trim(),
                Prezime = kontrolaPacijenta.TxtPrezime.Text.Trim(),
                datumRodjenja = kontrolaPacijenta.DatumRodjenja.SelectionStart,
                starosnaGrupa = (StarosnaGrupa)kontrolaPacijenta.CmbSGrupa.SelectedItem,
                Godine = godine
            };

            // slanje zahteva serveru
            Response res = Communication.Instance.KreirajPacijenta(pacijent);

            if (res.Exception == null)
            {
                MessageBox.Show("Pacijent uspešno dodat!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                forma.Close();
                ShowFrmPacijent();

            }
            else
            {
                MessageBox.Show("Došlo je do greške pri dodavanju pacijenta: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IzmeniPacijenta(object sender, EventArgs e)
        {
            if (forma.dgvPacijenti.SelectedRows.Count != 1)
            {
                MessageBox.Show("Morate odabrati tačno jednog pacijenta za izmenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent odabrani = forma.dgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;

            if (odabrani == null)
            {
                MessageBox.Show("Greška pri odabiru pacijenta.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.selektovaniPacijent = odabrani;

            kontrolaPacijenta = new UCKontrolaPacijenata();
            forma.Controls.Clear();
            forma.Controls.Add(kontrolaPacijenta);

            // Popunjavamo polja podacima pacijenta
            kontrolaPacijenta.TxtIme.Text = odabrani.Ime;
            kontrolaPacijenta.TxtPrezime.Text = odabrani.Prezime;
            kontrolaPacijenta.TxtGodine.Text = odabrani.Godine.ToString();
            kontrolaPacijenta.DatumRodjenja.SelectionStart = odabrani.datumRodjenja;
            kontrolaPacijenta.CmbSGrupa.SelectedItem = odabrani.starosnaGrupa;
            kontrolaPacijenta.BtnNazad.Click += BtnNazad_Click;
            kontrolaPacijenta.DatumRodjenja.DateChanged += DatumRodjenja_Postava;
            kontrolaPacijenta.BtnPotvrda.Click += IzmeniPacijentaKlik;
        }

        private void IzmeniPacijentaKlik(object sender, EventArgs e)
        {

            if (this.selektovaniPacijent == null)
            {
                MessageBox.Show("Nije pronađen pacijent za izmenu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var textBoxes = new List<TextBox> { kontrolaPacijenta.TxtIme, kontrolaPacijenta.TxtPrezime, kontrolaPacijenta.TxtGodine };
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

            if (!int.TryParse(kontrolaPacijenta.TxtGodine.Text, out int godine))
            {
                MessageBox.Show("Polje 'Godine' mora biti broj.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pacijent pacijent = new Pacijent
            {
                Id = this.selektovaniPacijent.Id,  
                Ime = kontrolaPacijenta.TxtIme.Text.Trim(),
                Prezime = kontrolaPacijenta.TxtPrezime.Text.Trim(),
                datumRodjenja = kontrolaPacijenta.DatumRodjenja.SelectionStart,
                starosnaGrupa = (StarosnaGrupa)kontrolaPacijenta.CmbSGrupa.SelectedItem,
                Godine = godine
            };

            Response res = Communication.Instance.PromeniPacijenta(pacijent);

            if (res.Exception == null)
            {
                MessageBox.Show("Pacijent uspešno izmenjen!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                forma.Close();
                ShowFrmPacijent();

            }
            else
            {
                MessageBox.Show("Došlo je do greške pri izmeni pacijenta: " + res.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}
   
