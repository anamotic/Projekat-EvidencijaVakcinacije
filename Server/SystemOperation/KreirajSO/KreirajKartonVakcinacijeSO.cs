using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajKartonVakcinacijeSO : SystemOperationBase
    {
        KartonVakcinacije karton;
        public int Result { get; set; }
        public KreirajKartonVakcinacijeSO(KartonVakcinacije karton)
        {
            this.karton = karton;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Kreiraj(karton);
        }
    }
}
