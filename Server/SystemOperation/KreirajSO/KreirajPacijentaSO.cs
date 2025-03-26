using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajPacijentaSO : SystemOperationBase
    {
        private readonly Pacijent pacijent;
        public int Result { get; set; }

        public KreirajPacijentaSO(Pacijent pacijent)
        {
            this.pacijent = pacijent;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(pacijent);
        }
    }
}
