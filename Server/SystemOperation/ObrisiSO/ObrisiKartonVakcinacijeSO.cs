using Common.Domain;

namespace Server.SystemOperation.ObrisiSO
{
    public class ObrisiKartonVakcinacijeSO : SystemOperationBase
    {
        KartonVakcinacije karton;

        public ObrisiKartonVakcinacijeSO(KartonVakcinacije karton)
        {
            this.karton = karton;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Obrisi(karton);
        }
    }
}
