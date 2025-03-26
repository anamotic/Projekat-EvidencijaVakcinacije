using Common.Domain;

namespace Server.SystemOperation.ObrisiSO
{
    public class ObrisiPacijentaSO : SystemOperationBase
    {
        Pacijent pacijent;

        public ObrisiPacijentaSO(Pacijent pacijent)
        {
            this.pacijent = pacijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Obrisi(pacijent);
        }
    }
}
