using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Common.Domain
{
    public class Lokacija : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        [Browsable(false)]
        public string TableName => "Lokacija";
        [Browsable(false)]
        public string InsertValues => $"(naziv, adresa) OUTPUT Inserted.id VALUES ('{Naziv}', '{Adresa}')";
        [Browsable(false)]
        public string UpdateValues => $"naziv = '{Naziv}', adresa = '{Adresa}'  WHERE id = {Id}";
        [Browsable(false)]
        public string DeleteValues => $"Id={Id}";
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
                Lokacija lokacija = new Lokacija();
                lokacija.Id = (int)reader["id"];
                lokacija.Naziv = (string)reader["naziv"];
                lokacija.Adresa = (string)reader["adresa"];
                entiteti.Add(lokacija);
            }
            reader.Close();
            return entiteti;
        }
    }
}
