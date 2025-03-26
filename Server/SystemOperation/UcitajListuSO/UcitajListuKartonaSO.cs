using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuKartonaSO : SystemOperationBase
    {
        public List<KartonVakcinacije> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            string query = @"
                SELECT k.id, 
                k.idPacijent, 
                k.idZRadnik, 
                p.ime, 
                p.prezime,
                p.godine,
                p.datumRodjenja,
                p.idStarosneGrupe,
                z.korisnickoIme,
                z.sifra
                FROM KartonVakcinacije k
                INNER JOIN Pacijent p ON k.idPacijent = p.id
                INNER JOIN ZdravstveniRadnik z ON k.idZRadnik = z.id";

            var list = broker.UcitajSaUslovom(new KartonVakcinacije(), query);
            Result = list.Cast<KartonVakcinacije>().ToList();
        }
    }
}
