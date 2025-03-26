using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziZdravstvenogRadnikaSO : SystemOperationBase
    {
        public List<ZdravstveniRadnik> Result { get; set; }
        String pretraga;

        public PretraziZdravstvenogRadnikaSO(String pretraga)
        {
            this.pretraga = pretraga;
        }
        protected override void ExecuteConcreteOperation()
        {
            ZdravstveniRadnik zRadnik = new ZdravstveniRadnik();

            zRadnik.SearchValues = $@"
            * FROM ZdravstveniRadnik 
            WHERE (LOWER(ime + ' ' + prezime) LIKE '%{pretraga}%' 
            OR LOWER(prezime + ' ' + ime) LIKE '%{pretraga}%') 
            OR LOWER(korisnickoIme) LIKE '%{pretraga}%' 
            OR LOWER(sifra) LIKE '%{pretraga}%' ";

            List<IEntity> entiteti = broker.Pretrazi(zRadnik);

            List<ZdravstveniRadnik> radnici = new List<ZdravstveniRadnik>();
            foreach (IEntity item in entiteti)
            {
                radnici.Add((ZdravstveniRadnik)item);
            }
            Result = radnici;
        }
    }
}
