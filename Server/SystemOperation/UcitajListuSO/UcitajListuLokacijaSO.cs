using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuLokacijaSO : SystemOperationBase
    {
        public List<Lokacija> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entities = broker.GetAll(new Lokacija());
            List<Lokacija> lokacije = new List<Lokacija>();
            foreach (Lokacija entity in entities)
            {
                lokacije.Add(entity);
            }

            Result = lokacije;
        }
    }
}
