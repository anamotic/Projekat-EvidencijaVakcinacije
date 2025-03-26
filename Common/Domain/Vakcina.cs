using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Common.Domain
{
    public class Vakcina : IEntity
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int DozvoljenBr { get; set; }
        public bool Obavezna { get; set; }

        [Browsable(false)]
        public string TableName => "Vakcina";
        [Browsable(false)]
        public string InsertValues => $"(naziv, proizvodjac, dozvoljenBr, obavezna) OUTPUT Inserted.id VALUES ('{Naziv}', '{Proizvodjac}', {DozvoljenBr}, {(Obavezna ? 1 : 0)})";

        [Browsable(false)]
        public string UpdateValues => $"naziv = '{Naziv}', proizvodjac = '{Proizvodjac}', dozvoljenBr = '{DozvoljenBr}, obavezna = {(Obavezna ? 1 : 0)}'  WHERE id = {Id}";
        [Browsable(false)]
        public string DeleteValues => $"Id={Id}";
        [Browsable(false)]
        public string SelectValues => "";
        [Browsable(false)]
        public string SearchValues { get; set; }
        [Browsable(false)]
        public string PrimarniKljuc => $"id = {Id}";
        [Browsable(false)]
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entiteti = new List<IEntity>();
            while (reader.Read())
            {
                Vakcina vakcina = new Vakcina();
                vakcina.Id = Convert.ToInt32(reader["id"]);
                vakcina.Naziv = reader["naziv"].ToString();
                vakcina.Proizvodjac = reader["proizvodjac"].ToString();
                vakcina.DozvoljenBr = Convert.ToInt32(reader["dozvoljenBr"]);
                vakcina.Obavezna = Convert.ToBoolean(reader["obavezna"]);
                entiteti.Add(vakcina);
            }
            reader.Close();
            return entiteti;
        }
    }
}

