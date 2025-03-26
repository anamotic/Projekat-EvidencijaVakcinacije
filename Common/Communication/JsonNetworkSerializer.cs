using System.Diagnostics;
using System.Net.Sockets;
using System.Text.Json;


namespace Common.Communication
{
        public class JsonNetworkSerializer
        {
            private readonly Socket s;
            private NetworkStream stream;
            private StreamReader reader;
            private StreamWriter writer;

            public JsonNetworkSerializer(Socket s)
            {
                this.s = s;
                stream = new NetworkStream(s);
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream)
                {
                    AutoFlush = true
                };
            }

        public void Send(object z)
        {
            string json = JsonSerializer.Serialize(z, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true // Osiguravamo kompatibilnost imena polja
            });

            writer.WriteLine(json);
        }

        public T Receive<T>()
        {
            try
            {
                string json = reader.ReadLine();

                if (string.IsNullOrEmpty(json))
                {
                    throw new Exception("Primljen je prazan Json");
                }

                // Ako je JSON u formi JsonElement, pravilno ga deserijalizujemo
                JsonElement jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                string rawJson = jsonElement.GetRawText();

                Debug.WriteLine($"Prerađen JSON za deserializaciju: {rawJson}");

                return JsonSerializer.Deserialize<T>(rawJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // Ignoriše velika/mala slova
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Greška prilikom deserijalizacije: {ex.Message}");
            }
        }


        public T ReadType<T>(object podaci)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(podaci));
            }
            catch (Exception ex)
            {
                throw new Exception($"Greška prilikom konverzije tipa: {ex.Message}");
            }
        }

        public void Close()
            {
                stream.Close();
                reader.Close();
                writer.Close();
            }
        }
    }



