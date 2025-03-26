using Common.Domain;
using System.ComponentModel;


namespace Client.UserControls
{
    public partial class UCDodajPacijenta : UserControl
    {
        public UCDodajPacijenta()
        {
            InitializeComponent();
            cmbStarosnaGrupa.DataSource = Enum.GetValues(typeof(StarosnaGrupa));
            BindingList<StarosnaGrupa> grupe = new BindingList<StarosnaGrupa>();
            cmbStarosnaGrupa.DataSource = grupe;
            cmbStarosnaGrupa.DisplayMember = "Starosna Grupa";
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        private void DodajPacijenta_Load(object sender, EventArgs e)
        {

        }
    }
}
