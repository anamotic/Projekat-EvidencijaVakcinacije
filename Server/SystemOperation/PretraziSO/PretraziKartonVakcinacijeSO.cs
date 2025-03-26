using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziKartonVakcinacijeSO : SystemOperationBase
    {
        public List<KartonVakcinacije> Result { get; set; }
        String pretraga;

        public PretraziKartonVakcinacijeSO(String pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            KartonVakcinacije karton = new KartonVakcinacije();

            karton.SearchValues = $@"
            KartonVakcinacije.id,
            Pacijent.ime, 
            Pacijent.prezime,
            FROM
            KartonVakcinacije
            LEFT JOIN
            Pacijent ON KartonVakcinacije.idPacijent = Pacijent.id
            LEFT JOIN
            ZdravstveniRadnik ON KartonVakcinacije.idZRadnik = ZdravstveniRadnik.id
            LEFT JOIN
            StavkaKartonaVakcinacije ON KartonVakcinacije.id = StavkaKartonaVakcinacije.idKarton
            WHERE
            (KartonVakcinacije.idPacijent = '{pretraga}' OR
            Pacijent.ime LIKE '%{pretraga.ToLower()}%' OR
            Pacijent.prezime LIKE '%{pretraga.ToLower()}%')";

            List<IEntity> entiteti = broker.Pretrazi(karton);
            Result = entiteti.Cast<KartonVakcinacije>().ToList();
        }
    }
}
    

