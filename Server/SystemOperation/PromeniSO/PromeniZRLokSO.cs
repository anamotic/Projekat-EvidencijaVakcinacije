using Common.Domain;

namespace Server.SystemOperation.PromeniSO
{
    public class PromeniZRLokSO : SystemOperationBase
    {
        private ZRLok zrLok;
        public PromeniZRLokSO(ZRLok zrLok)
        {
            this.zrLok = zrLok;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Promeni(zrLok);
        }
    }
}
