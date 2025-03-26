using Common.Domain;

namespace Server.SystemOperation.KreirajSO
{
    public class KreirajZRLokSO : SystemOperationBase
    {
        ZRLok zLok;
        public int Result { get; set; }

        public KreirajZRLokSO(ZRLok zLok)
        {
            this.zLok = zLok;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Kreiraj(zLok);
        }
    }
}
