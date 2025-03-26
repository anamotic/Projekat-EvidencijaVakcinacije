using Common.Domain;

namespace Server.SystemOperation.PromeniSO
{
    public class PromeniPacijentaSO : SystemOperationBase
    {
        private Pacijent pacijent;
        public PromeniPacijentaSO(Pacijent pacijent)
        {
            this.pacijent = pacijent;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Promeni(pacijent);
        }
    }
}
