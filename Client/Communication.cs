using Common.Communication;
using Common.Domain;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Client
{
    public class Communication
    {

        private Socket socket;
        private JsonNetworkSerializer serializer;
        private static Communication _instance;
        public bool connected = false;
        private NetworkStream stream;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication()
        {

        }

        public void Connect()
        {
            if (connected) // Ako je već povezan, da ne bi stvarao nove instance.
                return;
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Thread.Sleep(2000); // Pauza od 2 sekunde
                socket.Connect("127.0.0.1", 9999);
                stream = new NetworkStream(socket);
                serializer = new JsonNetworkSerializer(socket);
                connected = true;
            }
            catch (SocketException ex)
            {
                connected = false; // connected je false ako se povezivanje ne uspe.
                throw new Exception("Neuspelo povezivanje sa serverom: " + ex.Message);
            }
        }

        public void Disconnect()
        {
            if (socket != null)
            {
                if (socket.Connected)
                {
                    socket.Shutdown(SocketShutdown.Both);
                }
                socket.Close();
                socket = null;
            }
            connected = false;
            stream?.Close();
        }

        public void Send(Request req)
        {
            if (!connected) throw new InvalidOperationException("Nema konekcije sa serverom.");

            try
            {
                string json = JsonSerializer.Serialize(req);
                byte[] data = Encoding.UTF8.GetBytes(json + "\n");
                stream.Write(data, 0, data.Length);
                stream.Flush();
            }
            catch (Exception ex)
            {
                throw new Exception("Greška: " + ex.Message);
            }
        }
        public Response Receive()
        {
            if (!connected)
                throw new InvalidOperationException("Nema konekcije sa serverom.");

            try
            {
                Response response = serializer.Receive<Response>();
                if (response.Exception == null)
                    return response;
                else
                    throw new Exception(response.Exception.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Greška: " + ex.Message);
            }
        }
        internal Response Login(ZdravstveniRadnik zRadnik)
        {
            Request req = new Request
            {
                Argument = zRadnik,
                Operation = Operation.LogIn
            };
            serializer.Send(req);
            Response response = serializer.Receive<Response>();
            response.Result = serializer.ReadType<ZdravstveniRadnik>(response.Result); // deserijalizujemo result u user-a
            return response;
        }
        internal void Logout()
        {
            try
            {
                if (socket != null && serializer != null)
                {
                    Request req = new Request
                    {
                        Operation = Operation.Logout,
                    };

                    Debug.WriteLine("Šaljem logout zahtev serveru...");
                    serializer.Send(req);
                    Debug.WriteLine("Logout zahtev poslat.");


                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null; // socket je null nakon zatvaranja
                }

                _instance = null; // Resetovanje instance ako je potrebno
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Logout failed: " + ex.Message);
            }
        } 
        internal Response KreirajKartonVakcinacije(KartonVakcinacije karton)
        {
            Request request = new Request
            {
                Argument = karton,
                Operation = Operation.KreirajKartonVakcinacije
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response KreirajPacijenta(Pacijent pacijent)
        {
            Request request = new Request
            {
                Argument = pacijent,
                Operation = Operation.KreirajPacijenta
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response KreirajVakcinu(Vakcina vakcina)
        {
            Request request = new Request
            {
                Argument = vakcina,
                Operation = Operation.KreirajVakcinu
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response KreirajStavkuKartona(StavkaKartonaVakcinacije stavka)
        {
            Request request = new Request
            {
                Argument = stavka,
                Operation = Operation.KreirajStavkuKartona
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response KreirajLokaciju(Lokacija lokacija)
        {
            Request request = new Request
            {
                Argument = lokacija,
                Operation = Operation.KreirajLokaciju
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response KreirajZRLok(ZRLok zrLok)
        {
            Request request = new Request
            {
                Argument = zrLok,
                Operation = Operation.KreirajZRLok
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }

        public Response PromeniKarton(KartonVakcinacije karton)
        {
            Request request = new Request
            {
                Argument = karton,
                Operation = Operation.PromeniKartonVakcinacije
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        public Response PromeniStavku(StavkaKartonaVakcinacije stavka)
        {
            Request request = new Request
            {
                Argument = stavka,
                Operation = Operation.PromeniStavkuKartona
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        public Response PromeniPacijenta(Pacijent pacijent)
        {
            Request request = new Request
            {
                Argument = pacijent,
                Operation = Operation.PromeniPacijenta
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        public Response PromeniVakcinu(Vakcina vakcina)
        {
            Request request = new Request
            {
                Argument = vakcina,
                Operation = Operation.PromeniVakcinu
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        public Response PromeniLokaciju(Lokacija lokacija)
        {
            Request request = new Request
            {
                Argument = lokacija,
                Operation = Operation.PromeniLokaciju
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        public Response PromeniZRLok(ZRLok zrLok)
        {
            Request request = new Request
            {
                Argument = zrLok,
                Operation = Operation.PromeniZRLok
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response ObrisiKarton(KartonVakcinacije karton)
        {
            Request request = new Request
            {
                Argument = karton,
                Operation = Operation.ObrisiKartonVakcinacije
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response ObrisiStavku(StavkaKartonaVakcinacije stavka)
        {
            Request request = new Request
            {
                Argument = stavka,
                Operation = Operation.ObrisiStavkuKartona
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response ObrisiPacijenta(Pacijent pacijent)
        {
            Request request = new Request
            {
                Argument = pacijent,
                Operation = Operation.ObrisiPacijenta
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response ObrisiVakcinu(Vakcina vakcina)
        {
            Request request = new Request
            {
                Argument = vakcina,
                Operation = Operation.ObrisiVakcinu
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response ObrisiLokaciju(Lokacija lokacija)
        {
            Request request = new Request
            {
                Argument = lokacija,
                Operation = Operation.ObrisiLokaciju
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response ObrisiZRLok(ZRLok zrLok)
        {
            Request request = new Request
            {
                Argument = zrLok,
                Operation = Operation.ObrisiZRLok
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziKarton(KartonVakcinacije karton)
        {
            Request request = new Request
            {
                Argument = karton,
                Operation = Operation.PretraziKartonVakcinacije
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziStavku(StavkaKartonaVakcinacije stavka)
        {
            Request request = new Request
            {
                Argument = stavka,
                Operation = Operation.PretraziStavkuKartona
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziPacijenta(Pacijent pacijent)
        {
            Request request = new Request
            {
                Argument = pacijent,
                Operation = Operation.PretraziPacijenta
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziZdravstvenogRadnika(ZdravstveniRadnik zRadnik)
        {
            Request request = new Request
            {
                Argument = zRadnik,
                Operation = Operation.PretraziZdravstvenogRadnika
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziVakcinu(Vakcina vakcina)
        {
            Request request = new Request
            {
                Argument = vakcina,
                Operation = Operation.PretraziVakcinu
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziLokaciju(Lokacija lokacija)
        {
            Request request = new Request
            {
                Argument = lokacija,
                Operation = Operation.PretraziLokaciju
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal Response PretraziZRLok(ZRLok zrLok)
        {
            Request request = new Request
            {
                Argument = zrLok,
                Operation = Operation.PretraziZRLok
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return response;
        }
        internal List<KartonVakcinacije> UcitajListuKartona()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuKartona
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<KartonVakcinacije>>(response.Result);

        }
        internal List<StavkaKartonaVakcinacije> UcitajListuStavki()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuStavki
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<StavkaKartonaVakcinacije>>(response.Result);

        }
        internal List<StavkaKartonaVakcinacije> UcitajListuStavkiZaKarton(int idKartona)
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuStavkiZaKarton,
                Argument = idKartona // Šaljemo ID kartona serveru
            };

            serializer.Send(request);
            Response response = serializer.Receive<Response>();

            if (response.Exception == null)
            {
                return serializer.ReadType<List<StavkaKartonaVakcinacije>>(response.Result);
            }
            else
            {
                MessageBox.Show("Došlo je do greške pri učitavanju stavki: " + response.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<StavkaKartonaVakcinacije>();
            }
        }

        internal List<Pacijent> UcitajListuPacijenata()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuPacijenata
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Pacijent>>(response.Result);

        }
        internal List<Vakcina> UcitajListuVakcina()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuVakcina
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Vakcina>>(response.Result);

        }
        internal List<ZdravstveniRadnik> UcitajListuZRadnika()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuZRadnika
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<ZdravstveniRadnik>>(response.Result);
        }
            internal List<Lokacija> UcitajListuLokacija()
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuLokacija
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();
            return serializer.ReadType<List<Lokacija>>(response.Result);

        }
        internal List<ZRLok> UcitajListuZRLok(int idLokacija)
        {
            Request request = new Request
            {
                Operation = Operation.UcitajListuZRLok,
                Argument = idLokacija
            };
            serializer.Send(request);
            Response response = serializer.Receive<Response>();

            if (response.Exception == null)
            {
                return serializer.ReadType<List<ZRLok>>(response.Result);
            }
            else
            {
                MessageBox.Show("Došlo je do greške pri učitavanju smena: " + response.Exception.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ZRLok>();

            }
        }
    }
}
