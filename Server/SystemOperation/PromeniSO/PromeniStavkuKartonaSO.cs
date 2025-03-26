using Common.Domain;

namespace Server.SystemOperation.PromeniSO
{
    public class PromeniStavkuKartonaSO : SystemOperationBase
    {
        private StavkaKartonaVakcinacije stavka;
        public PromeniStavkuKartonaSO(StavkaKartonaVakcinacije stavka)
        {
            this.stavka = stavka;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Promeni(stavka);
        }
    }
}
