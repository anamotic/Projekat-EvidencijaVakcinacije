using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajLokacijuSO : SystemOperationBase
    {
        Lokacija lokacija;
        public int Result { get; set; }

        public KreirajLokacijuSO(Lokacija lokacija)
        {
            this.lokacija = lokacija;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Kreiraj(lokacija);
        }
    }
}
