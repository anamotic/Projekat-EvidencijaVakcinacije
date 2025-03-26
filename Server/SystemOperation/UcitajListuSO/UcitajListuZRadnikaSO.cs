using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuZRadnikaSO : SystemOperationBase
    {
        public List<ZdravstveniRadnik> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> entities = broker.GetAll(new ZdravstveniRadnik());
            List<ZdravstveniRadnik> radnici = new List<ZdravstveniRadnik>();
            foreach (ZdravstveniRadnik entity in entities)
            {
                radnici.Add(entity);
            }

            Result = radnici;
        }
    }
}
