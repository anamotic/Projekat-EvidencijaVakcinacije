using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziLokacijuSO : SystemOperationBase
    {
        public List<Lokacija> Result { get; set; }
        String pretraga;
        public PretraziLokacijuSO(String pretraga) {
           
            this.pretraga = pretraga;
        }
        protected override void ExecuteConcreteOperation()
        {
            Lokacija lokacija = new Lokacija();

            lokacija.SearchValues = $@"
             * FROM Lokacija 
              WHERE LOWER(naziv) LIKE '%{pretraga}%'
              OR LOWER(adresa) LIKE '%{pretraga}%' ";

            List<IEntity> entiteti = broker.Pretrazi(lokacija);
            List<Lokacija> lokacije = new List<Lokacija>();
            foreach (IEntity item in entiteti)
            {
                lokacije.Add((Lokacija)item);
            }
            Result = lokacije;
        }
    }
    
}
