using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuZRLokSO : SystemOperationBase
    {
        public int idLokacije { get; set; }
        public List<ZRLok> Result { get; set; }
        public UcitajListuZRLokSO(int id)
        {
            idLokacije = id;
        }

        protected override void ExecuteConcreteOperation()
        {
            string query = $@"
                SELECT 
                    zl.id,
                    zl.idZR,
                    zl.idLokacija,
                    zl.datumSmena,
                    l.id as idLokacija,
                    l.naziv,
                    l.adresa,
                    zr.id as idZR,
                    zr.ime,
                    zr.prezime,
                    zr.korisnickoIme,
                    zr.sifra
                FROM ZRadnikLokacija zl
                INNER JOIN Lokacija l ON zl.idLokacija = l.id
                INNER JOIN ZdravstveniRadnik zr ON zl.idZR = zr.id
                WHERE zl.idLokacija = {idLokacije}";
        
            var list = broker.UcitajSaUslovom(new ZRLok(), query);
            Result = list.Cast<ZRLok>().ToList();
        }
    }
}
