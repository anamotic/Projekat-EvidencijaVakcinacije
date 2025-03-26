using Common.Domain;

namespace Server.SystemOperation.PromeniSO
{
    public class PromeniVakcinuSO : SystemOperationBase
    {
        private Vakcina vakcina;
        public PromeniVakcinuSO(Vakcina vakcina)
        {
            this.vakcina = vakcina;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Promeni(vakcina);
        }
    }
}
