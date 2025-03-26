using Client.GUIController;

namespace Client
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
            btnPrijava.Click += LogInGUIController.Instance.Login;
        }
    }
}
