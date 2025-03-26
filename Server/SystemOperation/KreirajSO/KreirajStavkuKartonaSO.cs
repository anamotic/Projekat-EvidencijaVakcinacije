using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajStavkuKartonaSO : SystemOperationBase
    {
        StavkaKartonaVakcinacije stavka;
        public int Result { get; set; }
        public KreirajStavkuKartonaSO(StavkaKartonaVakcinacije stavka)
        {
            this.stavka = stavka;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Kreiraj(stavka);

        }
    }
}
