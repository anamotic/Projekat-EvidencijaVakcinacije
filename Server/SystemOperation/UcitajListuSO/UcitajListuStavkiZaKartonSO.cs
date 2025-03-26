using Common.Domain;

namespace Server.SystemOperation.UcitajListuSO
{
    public class UcitajListuStavkiZaKartonSO : SystemOperationBase
    {
        public int IdKartona { get; set; }
        public List<StavkaKartonaVakcinacije> Result { get; set; }

        public UcitajListuStavkiZaKartonSO(int id)
        {
            IdKartona = id;
        }

        protected override void ExecuteConcreteOperation()
        {
            string query = $@"
                SELECT 
                    s.rb,
                    s.idKarton,
                    s.idVakcine,
                    s.datumVakcinacije,
                    s.nezeljenaReakcija,
                    s.napomena,
                    s.rbDoze,
                    k.idPacijent as idPacijent,
                    k.idZRadnik as idZR,
                    v.id as vakcinaId,
                    v.naziv as naziv,
                    v.proizvodjac as proizvodjac,
                    v.dozvoljenBr as dozvoljenBr,
                    v.obavezna as obavezna
                FROM StavkaKartonaVakcinacije s
                INNER JOIN KartonVakcinacije k ON s.idKarton = k.id
                INNER JOIN Vakcina v ON s.idVakcine = v.id
                WHERE s.idKarton = {IdKartona}";

            var list = broker.UcitajSaUslovom(new StavkaKartonaVakcinacije(), query);
            Result = list.Cast<StavkaKartonaVakcinacije>().ToList();
        }
    }
}
