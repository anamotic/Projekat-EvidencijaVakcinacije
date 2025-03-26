using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajStarosnuGrupuSO : SystemOperationBase
    {
        StarosnaGrupa sGrupa;

        public KreirajStarosnuGrupuSO(StarosnaGrupa sGrupa)
        {
            this.sGrupa = sGrupa;
        }

        protected override void ExecuteConcreteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
