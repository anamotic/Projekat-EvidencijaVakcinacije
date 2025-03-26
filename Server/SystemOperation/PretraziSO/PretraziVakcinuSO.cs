using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziVakcinuSO : SystemOperationBase
    {
        public List<Vakcina> Result { get; set; }
        String pretraga;
        public PretraziVakcinuSO(String pretraga) {
            this.pretraga = pretraga;
        }
        protected override void ExecuteConcreteOperation()
        {
            Vakcina vakcina = new Vakcina();

            vakcina.SearchValues = $@"
            SELECT * FROM Vakcina 
            WHERE LOWER(naziv) LIKE '%{pretraga}%' 
            OR LOWER(proizvodjac) LIKE '%{pretraga}%'
            OR CAST(dozvoljenBr AS VARCHAR) LIKE '%{pretraga}%'";
        
        List<IEntity> entiteti = broker.Pretrazi(vakcina);
        List<Vakcina> vakcine = new List<Vakcina>();
            foreach (IEntity item in entiteti)
            {
                vakcine.Add((Vakcina) item);
            }
            Result = vakcine;
        }
    }
}
