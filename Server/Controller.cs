using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using Server.SystemOperation.KreirajSO;
using Server.SystemOperation.ObrisiSO;
using Server.SystemOperation.PretraziSO;
using Server.SystemOperation.PromeniSO;
using Server.SystemOperation.UcitajListuSO;

namespace Server
{
    public class Controller
    {
        private Broker broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() 
        {
            broker = new Broker();
        }
        public object Login(ZdravstveniRadnik zRadnik)
        {
            LogInSO so = new LogInSO(zRadnik);
            so.ExecuteTemplate();

            if (so.Result == null)
            {
                return new { Result = (object)null };
            }

            var user = new
            {
                ID = so.Result.Id,
                KorisnickoIme = so.Result.KorisnickoIme,
                Ime = so.Result.Ime,
                Prezime = so.Result.Prezime
            };

            return new { Result = user };  
        }

        public int KreirajPacijenta(Pacijent pacijent)
        {
            KreirajPacijentaSO so = new KreirajPacijentaSO(pacijent);
            so.ExecuteTemplate();
            return so.Result;
        }

        public int KreirajVakcinu(Vakcina vakcina)
        {
            KreirajVakcinuSO so = new KreirajVakcinuSO(vakcina);
            so.ExecuteTemplate();
            return so.Result;
        }

        public int KreirajLokaciju(Lokacija lokacija)
        {
            KreirajLokacijuSO so = new KreirajLokacijuSO(lokacija);
            so.ExecuteTemplate();
            return so.Result;
        }

        public int KreirajKartonVakcinacije(KartonVakcinacije karton)
        {
            KreirajKartonVakcinacijeSO so = new KreirajKartonVakcinacijeSO(karton);
            so.ExecuteTemplate();
            return so.Result;
        }

        public int KreirajStavkuKartona(StavkaKartonaVakcinacije stavka)
        {
            KreirajStavkuKartonaSO so = new KreirajStavkuKartonaSO(stavka);
            so.ExecuteTemplate();
            return so.Result;
        }
        public int KreirajZRLok(ZRLok zrLok)
        {
            KreirajZRLokSO so = new KreirajZRLokSO(zrLok);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<KartonVakcinacije> UcitajListuKartona()
        {
            UcitajListuKartonaSO so = new UcitajListuKartonaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Pacijent> UcitajListuPacijenata()
        {
            UcitajListuPacijenataSO so = new UcitajListuPacijenataSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<StavkaKartonaVakcinacije> UcitajListuStavki()
        {
            UcitajListuStavkiSO so = new UcitajListuStavkiSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<StavkaKartonaVakcinacije> UcitajListuStavkiZaKarton(int id)
        {
            UcitajListuStavkiZaKartonSO so = new UcitajListuStavkiZaKartonSO(id);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<ZdravstveniRadnik> UcitajListuZRadnika()
        {
            UcitajListuZRadnikaSO so = new UcitajListuZRadnikaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Lokacija> UcitajListuLokacija()
        {
            UcitajListuLokacijaSO so = new UcitajListuLokacijaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Vakcina> UcitajListuVakcina()
        {
            UcitajListuVakcinaSO so = new UcitajListuVakcinaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<ZRLok> UcitajListuZRLok(int id)
        {
            UcitajListuZRLokSO so = new UcitajListuZRLokSO(id);
            so.ExecuteTemplate();
            return so.Result;
        }

        public void ObrisiPacijenta(Pacijent pacijent)
        {
            ObrisiPacijentaSO obrisiPacijentaSO = new ObrisiPacijentaSO(pacijent);
            obrisiPacijentaSO.ExecuteTemplate();
        }
        public void ObrisiVakcinu(Vakcina vakcina)
        {
            ObrisiVakcinuSO obrisiVakcinuSO = new ObrisiVakcinuSO(vakcina);
            obrisiVakcinuSO.ExecuteTemplate();

        }
        public void ObrisiLokaciju(Lokacija lokacija)
        {
            ObrisiLokacijuSO obrisiLokacijuSO = new ObrisiLokacijuSO(lokacija);
            obrisiLokacijuSO.ExecuteTemplate();
        }
        public void ObrisiKartonVakcinacije(KartonVakcinacije karton)
        {
            ObrisiKartonVakcinacijeSO obrisiKartonSO = new ObrisiKartonVakcinacijeSO(karton);
            obrisiKartonSO.ExecuteTemplate();
        }
        public void ObrisiStavkuKartona(StavkaKartonaVakcinacije stavka)
        {
            ObrisiStavkuKartonaSO obrisiStavkuSO = new ObrisiStavkuKartonaSO(stavka);
            obrisiStavkuSO.ExecuteTemplate();
        }
        public void ObrisiZRLok(ZRLok zrLok)
        {
            ObrisiZRLokSO obrisiZRLokSO = new ObrisiZRLokSO(zrLok);
            obrisiZRLokSO.ExecuteTemplate();
        }

        public void PromeniKartonVakcinacije(KartonVakcinacije karton)
        {
            PromeniKartonVakcinacijeSO promeniKartonSO = new PromeniKartonVakcinacijeSO(karton);
            promeniKartonSO.ExecuteTemplate();
        }
        public void PromeniPacijenta(Pacijent pacijent)
        {
            PromeniPacijentaSO promeniPacijentaSO = new PromeniPacijentaSO(pacijent);
            promeniPacijentaSO.ExecuteTemplate();
        }
        public void PromeniZRLok(ZRLok zrLok)
        {
            PromeniZRLokSO promeniZRLokSO = new PromeniZRLokSO(zrLok);
            promeniZRLokSO.ExecuteTemplate();
        }
        public void PromeniVakcinu(Vakcina vakcina)
        {
            PromeniVakcinuSO promeniVakcinuSO = new PromeniVakcinuSO(vakcina);
            promeniVakcinuSO.ExecuteTemplate();
        }
        public void PromeniLokaciju(Lokacija lokacija)
        {
            PromeniLokacijuSO promeniLokacijuSO = new PromeniLokacijuSO(lokacija);
            promeniLokacijuSO.ExecuteTemplate();
        }
        public void PromeniStavkuKartonu(StavkaKartonaVakcinacije stavka)
        {
            PromeniStavkuKartonaSO promeniStavkuSO = new PromeniStavkuKartonaSO(stavka);
            promeniStavkuSO.ExecuteTemplate();
        }

        public List<ZRLok> PretraziZRLok(object argument)
        {
            if (argument is ZdravstveniRadnik zRadnik)
            {
                PretraziZRLokSO so = new PretraziZRLokSO(zRadnik);
                so.ExecuteTemplate();
                return so.Result;
            }
            else if (argument is Lokacija lokacija)
            {
                PretraziZRLokSO so = new PretraziZRLokSO(lokacija);
                so.ExecuteTemplate();
                return so.Result;
            }
            else
            {
                throw new ArgumentException("Argument mora biti tip ZdravstveniRadnik ili Lokacija.");
            }
        }
        public List<Pacijent> PretraziPacijenta(String pretraga)
        {
            PretraziPacijentaSO so = new PretraziPacijentaSO(pretraga);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<ZdravstveniRadnik> PretraziZdravstvenogRadnika(String pretraga)
        {
            PretraziZdravstvenogRadnikaSO so = new PretraziZdravstvenogRadnikaSO(pretraga);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<Vakcina> PretraziVakcinu(String pretraga)
        {
            PretraziVakcinuSO so = new PretraziVakcinuSO(pretraga);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Lokacija> PretraziLokaciju(String pretraga)
        {
            PretraziLokacijuSO so = new PretraziLokacijuSO(pretraga);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<KartonVakcinacije> PretraziKarton(String pretraga)
        {
            PretraziKartonVakcinacijeSO so = new PretraziKartonVakcinacijeSO(pretraga);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<StavkaKartonaVakcinacije> PretraziStavku(String pretraga)
        {
            PretraziStavkeKartonaSO so = new PretraziStavkeKartonaSO(pretraga);
            so.ExecuteTemplate();
            return so.Result;
        }

    }
}