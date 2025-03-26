using Common.Domain;
using System.ComponentModel;
namespace Client.UserControls
{
    public partial class UCKontrolaPacijenata : UserControl
    {
        public UCKontrolaPacijenata()
        {
            InitializeComponent();

            BindingList<StarosnaGrupa> grupe = new BindingList<StarosnaGrupa>();

            foreach (StarosnaGrupa grupa in Enum.GetValues(typeof(StarosnaGrupa)))
            {
                grupe.Add(grupa);
            }

            cmbStarosnaGrupa.DataSource = grupe;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        private void UCKontrolaPacijenata_Load(object sender, EventArgs e)
        {

        }
    }
}
