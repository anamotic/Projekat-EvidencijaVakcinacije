using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziPacijentaSO : SystemOperationBase
    {
       public List<Pacijent> Result { get; set; }
        String pretraga;

        public PretraziPacijentaSO(String pretraga)
        {
            this.pretraga = pretraga;
        }
        protected override void ExecuteConcreteOperation()
        {
            Pacijent pacijent = new Pacijent();

            pacijent.SearchValues = $@"
            * FROM Pacijent 
            WHERE (LOWER(ime + ' ' + prezime) LIKE '%{pretraga}%' 
            OR LOWER(prezime + ' ' + ime) LIKE '%{pretraga}%') 
            OR LOWER(ime) LIKE '%{pretraga}%' 
            OR LOWER(prezime) LIKE '%{pretraga}%' 
            OR CAST(datumRodjenja AS VARCHAR) LIKE '%{pretraga}%'
            OR CAST(godine AS VARCHAR) LIKE '%{pretraga}%'";

           
            List<IEntity> entiteti = broker.Pretrazi(pacijent);

            List<Pacijent> pacijenti = new List<Pacijent>();
            foreach (IEntity item in entiteti)
            {
                pacijenti.Add((Pacijent)item);
            }
            Result = pacijenti;
        }
    }
}
    
