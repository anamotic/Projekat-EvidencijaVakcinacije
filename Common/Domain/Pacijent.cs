using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Common.Domain
{
    public class Pacijent : IEntity
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public int Godine { get; set; }
        public StarosnaGrupa starosnaGrupa { get; set; }

        [Browsable(false)]
        public string TableName => "Pacijent";
        [Browsable(false)]
        public string InsertValues => $"(ime, prezime, datumRodjenja, godine, idStarosneGrupe) VALUES ('{Ime}', '{Prezime}', '{datumRodjenja:yyyy-MM-dd}', '{Godine}','{(int)starosnaGrupa}')";
        [Browsable(false)]
        public string UpdateValues => $"ime = '{Ime}', prezime = '{Prezime}', datumRodjenja = '{datumRodjenja.ToString("yyyy-MM-dd")}', godine = {Godine}, idStarosneGrupe = {(int)starosnaGrupa}";

        [Browsable(false)]
        public string DeleteValues => $"Id={Id}";
        [Browsable(false)]
        public string SelectValues =>" ";
        [Browsable(false)]
        public string SearchValues {get ; set ;}
        [Browsable(false)]
        public string PrimarniKljuc => $"id = {Id}";
        [Browsable(false)]
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entiteti = new List<IEntity>();
            while (reader.Read())
            {
                Pacijent pacijent = new Pacijent();
                pacijent.Id = Convert.ToInt32(reader["id"]); 
                pacijent.Ime = reader["ime"].ToString();
                pacijent.Prezime = reader["prezime"].ToString();
                pacijent.datumRodjenja = (DateTime)reader["datumRodjenja"];
                pacijent.Godine = Convert.ToInt32(reader["godine"]);
                pacijent.starosnaGrupa = (StarosnaGrupa)Convert.ToInt32(reader["idStarosneGrupe"]);
                entiteti.Add(pacijent);
            }
            reader.Close();
            return entiteti;
        }
    }
}
