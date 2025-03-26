using Common.Domain;

namespace Server.SystemOperation.ObrisiSO
{
    public class ObrisiStavkuKartonaSO : SystemOperationBase
    {
        StavkaKartonaVakcinacije stavka;

        public ObrisiStavkuKartonaSO(StavkaKartonaVakcinacije stavka)
        {
            this.stavka = stavka;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Obrisi(stavka);
        }
    }
}
