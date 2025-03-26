using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuStavkiSO : SystemOperationBase
    {
        public List<StavkaKartonaVakcinacije> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entities = broker.GetAll(new StavkaKartonaVakcinacije());
            List<StavkaKartonaVakcinacije> stavke = new List<StavkaKartonaVakcinacije>();
            foreach (StavkaKartonaVakcinacije entity in entities)
            {
                stavke.Add(entity);
            }

            Result = stavke;
        }

    }
}
