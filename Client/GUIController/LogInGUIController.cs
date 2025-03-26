using Common.Communication;
using Common.Domain;

namespace Client.GUIController
{
    internal class LogInGUIController
    {
        private static LogInGUIController instance;
        private FrmLogIn frmLogin;
        private bool uspesnoPrijavljen = false;
        private ZdravstveniRadnik prijavljeniRadnik;


        public static LogInGUIController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogInGUIController();
                }
                return instance;
            }
        }
        private LogInGUIController()
        {
        }

        public void ShowFrmLogin()
        {
            if (frmLogin == null || frmLogin.IsDisposed)
            {
                frmLogin = new FrmLogIn();
                frmLogin.AutoSize = true;
                frmLogin.BtnPrijava.Click += Login;
            }

            frmLogin.Show();
            frmLogin.BringToFront();
        }

        public void Login(object sender, EventArgs e)
        {
            Communication.Instance.Connect();

            ZdravstveniRadnik zRadnik = new ZdravstveniRadnik
            {
                KorisnickoIme = frmLogin.TxtKorIme.Text,
                Sifra = frmLogin.TxtSifra.Text,
            };

            if (string.IsNullOrEmpty(zRadnik.KorisnickoIme) || string.IsNullOrEmpty(zRadnik.Sifra))
            {
                MessageBox.Show("Molimo unesite korisničko ime i šifru.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Response response = Communication.Instance.Login(zRadnik);

            if (response.Result != null)
            {
                prijavljeniRadnik = response.Result as ZdravstveniRadnik;

                if (!uspesnoPrijavljen) // Proverava da li je korisnik već prijavljen
                {
                    MessageBox.Show("Uspešna prijava!", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uspesnoPrijavljen = true; 
                }

                frmLogin.Visible = false;
                MainGUIController.Instance.ShowFrmMain(prijavljeniRadnik);
            }
            else
            {
                MessageBox.Show("Pogrešan unos korisničkog imena ili šifre, pokušajte ponovo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
