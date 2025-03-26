using Common.Domain;

namespace Server.SystemOperation.ObrisiSO
{
    public class ObrisiVakcinuSO : SystemOperationBase
    {
        Vakcina vakcina;

        public ObrisiVakcinuSO(Vakcina vakcina)
        {
            this.vakcina = vakcina;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Obrisi(vakcina);
        }
    }
}
