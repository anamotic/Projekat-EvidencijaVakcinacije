using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Diagnostics;


namespace Common.Domain
{
    [Serializable]
    public class KartonVakcinacije : IEntity
    {
        public int Id { get; set; }
        public int IDPacijent { get; set; }
        public int IDZR { get; set; }
        public ZdravstveniRadnik zdravstveniRadnik { get; set; }
        public List<StavkaKartonaVakcinacije> Stavke { get; set; }
        public Pacijent Pacijent { get; set; }

        [Browsable(false)]
        public string TableName => "KartonVakcinacije";
        [Browsable(false)]
        public string InsertValues => $"(idPacijent, idZRadnik) VALUES ('{IDPacijent}','{IDZR}')";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string DeleteValues => $"id={Id}";
        [Browsable(false)]
        public string SelectValues => "";
        [Browsable(false)]
        public string SearchValues { get; set; }
        [Browsable(false)]
        public string PrimarniKljuc => $"id = {Id}";
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entiteti = new List<IEntity>();

            while (reader.Read())
            {
                KartonVakcinacije karton = new KartonVakcinacije();

                karton.Id = reader.GetInt32(reader.GetOrdinal("id"));
                karton.IDPacijent = reader.GetInt32(reader.GetOrdinal("idPacijent"));

                karton.Pacijent = new Pacijent
                {
                    Id = karton.IDPacijent,
                    Ime = reader.GetString(reader.GetOrdinal("ime")),
                    Prezime = reader.GetString(reader.GetOrdinal("prezime")),
                    Godine = reader.GetInt32(reader.GetOrdinal("godine")),
                    datumRodjenja = reader.GetDateTime(reader.GetOrdinal("datumRodjenja")),
                    starosnaGrupa = (StarosnaGrupa)Convert.ToInt32(reader["idStarosneGrupe"])

                };

                karton.IDZR = reader.GetInt32(reader.GetOrdinal("idZRadnik"));
                karton.zdravstveniRadnik = new ZdravstveniRadnik
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Ime = reader.GetString(reader.GetOrdinal("ime")),
                    Prezime = reader.GetString(reader.GetOrdinal("prezime")),
                    KorisnickoIme = reader.GetString(reader.GetOrdinal("korisnickoIme")),
                    Sifra = reader.GetString(reader.GetOrdinal("sifra")),
                };

                karton.Stavke = new List<StavkaKartonaVakcinacije>();
                entiteti.Add(karton);


            }
            reader.Close();
            if (entiteti == null) { Console.WriteLine("Greška!"); }
            return entiteti;
        }
    }
}
