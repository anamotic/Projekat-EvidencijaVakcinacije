using Common.Domain;

namespace Server.SystemOperation.ObrisiSO
{
    public class ObrisiZRLokSO: SystemOperationBase
    {
        private ZRLok zrLok;

        public ObrisiZRLokSO(ZRLok zrLok)
        {
            this.zrLok = zrLok;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Obrisi(zrLok);
        }
    }
}
