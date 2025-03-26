using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuVakcinaSO : SystemOperationBase
    {
        public List<Vakcina> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {  
            List<IEntity> entities = broker.GetAll(new Vakcina());
            List<Vakcina> vakcine = new List<Vakcina>();
            foreach (Vakcina entity in entities)
            {
                vakcine.Add(entity);
            }

            Result = vakcine;
        }
    }
}
