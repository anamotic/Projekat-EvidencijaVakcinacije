using Common.Domain;

namespace Server.SystemOperation.ObrisiSO
{
    public class ObrisiLokacijuSO : SystemOperationBase
    {
        Lokacija lokacija;

        public ObrisiLokacijuSO(Lokacija lokacija)
        {
            this.lokacija = lokacija;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Obrisi(lokacija);
        }
    }
}
