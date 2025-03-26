using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Common.Domain
{
    [Serializable]
    public class ZRLok : IEntity
    {
        public int Id { get; set; }
        public int IDZR { get; set; }
        public int IDLok { get; set; }
        public DateTime DatumSmena { get; set; }
        public ZdravstveniRadnik ZdravstveniRadnik { get; set; }
        public Lokacija Lokacija { get; set; }

        [Browsable(false)]
        public string TableName => "ZRadnikLokacija";

        [Browsable(false)]
        public string InsertValues => $"(idLokacija, idZR, datumSmena) VALUES ({IDLok}, {IDZR}, '{DatumSmena:yyyy-MM-dd}')";

        [Browsable(false)]
        public string UpdateValues => $"idZR = {IDZR}, idLokacija = {IDLok}, datumSmena = '{DatumSmena:yyyy-MM-dd}'";

        [Browsable(false)]
        public string DeleteValues => $"Id = {Id}";

        [Browsable(false)]
        public string SelectValues => "";

        [Browsable(false)]
        public string SearchValues { get; set; }

        [Browsable(false)]
        public string PrimarniKljuc => $"Id = {Id}";

        [Browsable(false)]
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entiteti = new List<IEntity>();
            while (reader.Read())
            {
                entiteti.Add(new ZRLok
                {
                    Id = (int)reader["id"],
                    IDZR = (int)reader["idZR"],
                    IDLok = (int)reader["idLokacija"],
                    DatumSmena = Convert.ToDateTime(reader["datumSmena"]),

                    ZdravstveniRadnik = new ZdravstveniRadnik
                    {
                        Id = (int)reader["id"],
                        Ime = (string)reader["ime"],
                        Prezime = (string)reader["prezime"],
                        KorisnickoIme = (string)reader["korisnickoIme"],
                        Sifra = (string)reader["sifra"]
                    },

                    Lokacija = new Lokacija
                    {
                        Id = (int)reader["id"],
                        Naziv = (string)reader["naziv"],
                        Adresa = (string)reader["adresa"]
                    }
                });
            }
            reader.Close();
            return entiteti;
        }
    }
}
