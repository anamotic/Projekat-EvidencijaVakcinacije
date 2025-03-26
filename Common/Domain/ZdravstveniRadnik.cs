using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Common.Domain
{
    public class ZdravstveniRadnik : IEntity
    {
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime
        {
            get { return $"{Ime} {Prezime}"; }
        }

        [Browsable(false)]
        public string TableName => "ZdravstveniRadnik";

        [Browsable(false)]
        public string InsertValues => $"(KorisnickoIme, Sifra, Ime, Prezime) VALUES ('{KorisnickoIme}', '{Sifra}', '{Ime}', '{Prezime}')";

        [Browsable(false)]
        public string UpdateValues => $"KorisnickoIme = '{KorisnickoIme}', Sifra = '{Sifra}', Ime = '{Ime}', Prezime = '{Prezime}'";
        [Browsable(false)]
        public string DeleteValues => $"Id = {Id}";
        [Browsable(false)]
        public string SelectValues => $"* FROM {TableName} WHERE KorisnickoIme = '{KorisnickoIme}' AND Sifra = '{Sifra}'";
        [Browsable(false)]
        public string SearchValues { get; set; }
        [Browsable(false)]
        public string PrimarniKljuc => $"id = {Id}";
        [Browsable(false)]
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();

            while (reader.Read())
            {
                ZdravstveniRadnik radnik = new ZdravstveniRadnik
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    KorisnickoIme = reader["KorisnickoIme"].ToString(),
                    Sifra = reader["Sifra"].ToString(),
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString()
                };

                lista.Add(radnik);
            }
            reader.Close();
            return lista;
        }


    }
}
