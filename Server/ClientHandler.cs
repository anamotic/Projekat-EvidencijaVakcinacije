using Common.Communication;
using Common.Domain;
using Server.SystemOperation;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text.Json;
using Operation = Common.Communication.Operation;
using Response = Common.Communication.Response;

namespace Server
{
    public class ClientHandler
    {
        private JsonNetworkSerializer serializer;
        private Socket socket;
        public static List<ClientHandler> clientHandlers = new List<ClientHandler>();
        public ZdravstveniRadnik zRadnik;
       
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            serializer = new JsonNetworkSerializer(socket);
        }

        public void HandleRequest()
        {
            while (true)
            {
                Request req = (Request)serializer.Receive<Request>();
                Response r = ProcessRequest(req);
                serializer.Send(r);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {
                switch (req.Operation)
                {
                    case Operation.LogIn:
                        Debug.WriteLine($"Primljen zahtev za login: {JsonSerializer.Serialize(req.Argument)}");

                        // Deserijalizacija argumenta u objekat tipa ZdravstveniRadnik
                        ZdravstveniRadnik zRadnik = JsonSerializer.Deserialize<ZdravstveniRadnik>(
                            JsonSerializer.Serialize(req.Argument),
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                        );

                        if (zRadnik == null)
                        {
                            Debug.WriteLine("Greška");
                        }

                        LogInSO so = new LogInSO(zRadnik);
                        so.ExecuteTemplate();
                        ZdravstveniRadnik prijavljeniRadnik = so.Result;

                        if (prijavljeniRadnik != null)
                        {
                            // Kreiramo objekat sa podacima koje želimo poslati klijentu
                            var user = new
                            {
                                ID = prijavljeniRadnik.Id,
                                KorisnickoIme = prijavljeniRadnik.KorisnickoIme,
                                Ime = prijavljeniRadnik.Ime,
                                Prezime = prijavljeniRadnik.Prezime
                            };

                            r.Result = user;
                            r.IsSuccessful = true;
                        }
                        else
                        {
                            r.Exception = new Exception("Pogrešan unos korisničkog imena ili šifre.");
                            r.IsSuccessful = false;
                        }
                        break;



                    case Operation.Logout:
                        clientHandlers.Remove(this);
                        zRadnik = null;
                        Stop(); 
                        break;

                    //KREIRAJ 
                  
                    case Operation.KreirajPacijenta:
                        Controller.Instance.KreirajPacijenta(serializer.ReadType<Pacijent>(req.Argument));
                        break;
                    case Operation.KreirajKartonVakcinacije:
                        Controller.Instance.KreirajKartonVakcinacije(serializer.ReadType<KartonVakcinacije>(req.Argument));
                        break;
                    case Operation.KreirajLokaciju:
                        Controller.Instance.KreirajLokaciju(serializer.ReadType<Lokacija>(req.Argument));
                        break;
                    case Operation.KreirajStavkuKartona:
                        Controller.Instance.KreirajStavkuKartona(serializer.ReadType<StavkaKartonaVakcinacije>(req.Argument));
                        break;
                    case Operation.KreirajVakcinu:
                        Controller.Instance.KreirajVakcinu(serializer.ReadType<Vakcina>(req.Argument));
                        break;
                    case Operation.KreirajZRLok:
                        Controller.Instance.KreirajZRLok(serializer.ReadType<ZRLok>(req.Argument));
                        break;

                        //PROMENI

                    case Operation.PromeniPacijenta:
                        Controller.Instance.PromeniPacijenta(serializer.ReadType<Pacijent>(req.Argument));
                        break;
                    case Operation.PromeniLokaciju:
                        Controller.Instance.PromeniLokaciju(serializer.ReadType<Lokacija>(req.Argument));
                        break;
                    case Operation.PromeniKartonVakcinacije:
                        try
                        {
                            Controller.Instance.PromeniKartonVakcinacije(serializer.ReadType<KartonVakcinacije>(req.Argument));
                            r.Result = "Karton je uspešno promenjen";
                        }
                        catch (Exception ex)
                        {
                            r.Exception = ex;
                        }
                        break;
                    case Operation.PromeniStavkuKartona:
                        Controller.Instance.PromeniStavkuKartonu(serializer.ReadType<StavkaKartonaVakcinacije>(req.Argument));
                        break;
                    case Operation.PromeniVakcinu:
                        Controller.Instance.PromeniVakcinu(serializer.ReadType<Vakcina>(req.Argument));
                        break;
                    case Operation.PromeniZRLok:
                        Controller.Instance.PromeniZRLok(serializer.ReadType<ZRLok>(req.Argument));
                        break;


                    //PRETRAZI 
                    case Operation.PretraziKartonVakcinacije:
                        Controller.Instance.PretraziKarton(serializer.ReadType<String>(req.Argument));
                        break;
                    case Operation.PretraziPacijenta:
                        Controller.Instance.PretraziPacijenta(serializer.ReadType<String>(req.Argument));
                        break;
                    case Operation.PretraziZdravstvenogRadnika:
                        Controller.Instance.PretraziZdravstvenogRadnika(serializer.ReadType<String>(req.Argument));
                        break;
                    case Operation.PretraziLokaciju:
                        Controller.Instance.PretraziLokaciju(serializer.ReadType<String>(req.Argument));
                        break;
                    case Operation.PretraziStavkuKartona:
                        Controller.Instance.PretraziStavku(serializer.ReadType<String>(req.Argument));
                        break;
                    case Operation.PretraziVakcinu:
                        Controller.Instance.PretraziVakcinu(serializer.ReadType<String>(req.Argument));
                        break;
                    case Operation.PretraziZRLok:
                        Controller.Instance.PretraziZRLok(serializer.ReadType<String>(req.Argument));
                        break;

                    //OBRISI

                    case Operation.ObrisiPacijenta:
                        Controller.Instance.ObrisiPacijenta(serializer.ReadType<Pacijent>(req.Argument));
                        break;
                   
                    case Operation.ObrisiKartonVakcinacije:
                        try
                        {
                            Controller.Instance.ObrisiKartonVakcinacije(serializer.ReadType<KartonVakcinacije>(req.Argument));
                        }
                        catch (Exception ex)
                        {
                            r.Exception = ex; 
                        }
                        break;
                  
                    case Operation.ObrisiLokaciju:
                        Controller.Instance.ObrisiLokaciju(serializer.ReadType<Lokacija>(req.Argument));
                        break;
                   
                    case Operation.ObrisiStavkuKartona:
                        Controller.Instance.ObrisiStavkuKartona(serializer.ReadType<StavkaKartonaVakcinacije>(req.Argument));
                        break;
                    case Operation.ObrisiVakcinu:
                        Controller.Instance.ObrisiVakcinu(serializer.ReadType<Vakcina>(req.Argument));
                        break;
                    case Operation.ObrisiZRLok:
                        Controller.Instance.ObrisiZRLok(serializer.ReadType<ZRLok>(req.Argument));
                        break;
                   
                    //UCITAJ LISTU

                    case Operation.UcitajListuPacijenata:
                        r.Result = Controller.Instance.UcitajListuPacijenata();
                        break;
                    case Operation.UcitajListuKartona:
                        r.Result = Controller.Instance.UcitajListuKartona();
                        break;
                    case Operation.UcitajListuStavki:
                        r.Result = Controller.Instance.UcitajListuStavki();
                        break;
                    case Operation.UcitajListuStavkiZaKarton:
                        r.Result = Controller.Instance.UcitajListuStavkiZaKarton(serializer.ReadType<int>(req.Argument));
                        break;

                    case Operation.UcitajListuLokacija:
                        r.Result = Controller.Instance.UcitajListuLokacija();
                        break;
                    case Operation.UcitajListuVakcina:
                        r.Result = Controller.Instance.UcitajListuVakcina();
                        break;
                    case Operation.UcitajListuZRLok:
                        r.Result = Controller.Instance.UcitajListuZRLok(serializer.ReadType<int>(req.Argument));
                        break;
                    case Operation.UcitajListuZRadnika:
                        r.Result = Controller.Instance.UcitajListuZRadnika();
                        break;
                    default:
                        break;
                }
        
            }
            catch (Exception ex)
            {
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return r;
        }
         private bool IsUserActive(List<ClientHandler> clientHandlers, ZdravstveniRadnik zRadnik)
        {
            return clientHandlers.Any(handler => handler.zRadnik.KorisnickoIme.Equals(zRadnik.KorisnickoIme));
        }
         internal void Stop()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
            clientHandlers.Remove(this);
        }
    }
}
