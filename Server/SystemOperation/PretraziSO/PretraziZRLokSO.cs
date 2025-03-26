using Common.Domain;

namespace Server.SystemOperation.PretraziSO
{
    public class PretraziZRLokSO : SystemOperationBase
    {
        public List<ZRLok> Result { get; set; }
        ZdravstveniRadnik zRadnik;
        Lokacija lokacija;
        int a = 0;
        public PretraziZRLokSO(ZdravstveniRadnik zRadnik)
        {
            this.zRadnik = zRadnik;

        }
        public PretraziZRLokSO(Lokacija lokacija)
        {
            this.lokacija = lokacija;
            a = 1;
        }

        protected override void ExecuteConcreteOperation()
        {
            ZRLok zrLok = new ZRLok();


            if (a == 0)
            {
                zrLok.SearchValues = $@"
                *
                FROM [ZRadnikLokacija] zrLok
                JOIN Lokacija l ON zrLok.idLokacija = l.id
                JOIN ZdravstveniRadnik zR ON zrLok.idLokacija = zR.id
                WHERE zrLok.idPLokacija = {lokacija.Id}";
            }
            if (a == 1)
            {
                zrLok.SearchValues = $@"
               *
                FROM [ZRadnikLokacija] zrLok
                JOIN Lokacija l ON zrLok.idLokacija = l.id
                JOIN ZdravstveniRadnik zR ON zrLok.idZR = zR.id
                WHERE zrLok.idZR = {zRadnik.Id}";
            }

            List<IEntity> entiteti = broker.Pretrazi(zrLok);

            List<ZRLok> zrLokacija = new List<ZRLok>();
            foreach (IEntity item in entiteti)
            {
                zrLokacija.Add((ZRLok)item);
            }
            Result = zrLokacija;
        }
    }
}
