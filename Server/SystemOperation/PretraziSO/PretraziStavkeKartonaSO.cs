using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziStavkeKartonaSO : SystemOperationBase
    {
        public List<StavkaKartonaVakcinacije> Result { get; set; }
        String pretraga;

        public PretraziStavkeKartonaSO(String pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            StavkaKartonaVakcinacije stavka = new StavkaKartonaVakcinacije();

            stavka.SearchValues = $@"
            * 
            FROM StavkaKartonaVakcinacije
            LEFT JOIN
            KartonVakcinacije ON StavkaKartonaVakcinacije.idKarton = KartonVakcinacije.id
            WHERE
             KartonVakcinacije.id = '{pretraga}'";

            List<IEntity> entiteti = broker.Pretrazi(stavka);
            Result = entiteti.Cast<StavkaKartonaVakcinacije>().ToList();
        }
    }
}
       