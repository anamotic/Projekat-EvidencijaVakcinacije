using Common.Domain;

namespace Server.SystemOperation.PromeniSO
{
    public class PromeniKartonVakcinacijeSO : SystemOperationBase
    {
        private KartonVakcinacije karton;

        public PromeniKartonVakcinacijeSO(KartonVakcinacije karton)
        {
            this.karton = karton;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Promeni(karton);
        }
    }
}
