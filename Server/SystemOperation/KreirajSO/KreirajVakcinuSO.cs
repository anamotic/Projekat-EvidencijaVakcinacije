using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajVakcinuSO : SystemOperationBase
    {
        Vakcina vakcina;

        public int Result { get; set; }
        public KreirajVakcinuSO(Vakcina vakcina)
        {
            this.vakcina = vakcina;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Kreiraj(vakcina);
        }
    }
}
