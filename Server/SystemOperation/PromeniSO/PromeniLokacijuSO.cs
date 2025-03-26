using Common.Domain;

namespace Server.SystemOperation.PromeniSO
{
    public class PromeniLokacijuSO : SystemOperationBase
    {
        private Lokacija lokacija;
        public PromeniLokacijuSO(Lokacija lokacija)
        {
            this.lokacija = lokacija;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Promeni(lokacija);
        }
    }
}
