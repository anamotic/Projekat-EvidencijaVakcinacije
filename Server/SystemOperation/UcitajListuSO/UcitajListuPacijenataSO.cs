using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuPacijenataSO : SystemOperationBase
    {
        public List<Pacijent> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entities = broker.GetAll(new Pacijent());
            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach (Pacijent entity in entities)
            {
                pacijenti.Add(entity);
            }

            Result = pacijenti;
        }
    }
}
