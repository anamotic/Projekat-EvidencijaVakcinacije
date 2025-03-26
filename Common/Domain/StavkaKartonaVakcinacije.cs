using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Common.Domain
{
    [Serializable]
    public class StavkaKartonaVakcinacije : IEntity
    {
        public int Id { get; set; }
        public int IDKartona { get; set; }
        public KartonVakcinacije Karton { get; set; }
        public DateTime DatumVakcinacije { get; set; }
        public bool NezeljenaReakcija { get; set; }
        public string Napomena { get; set; }
        public int IDVakcine { get; set; }
        public Vakcina Vakcina { get; set; }
        public int rbDoze { get; set; }

        [Browsable(false)]
        public string TableName => "StavkaKartonaVakcinacije";
        [Browsable(false)]
        public string InsertValues => $"(idKarton,  datumVakcinacije, nezeljenaReakcija, napomena, idVakcine, rbDoze) OUTPUT Inserted.rb VALUES ('{IDKartona}','{DatumVakcinacije.ToString("yyyy-MM-dd")}', '{(NezeljenaReakcija ? 1 : 0)}', '{Napomena}', '{IDVakcine}', '{rbDoze}')";
        [Browsable(false)]
        public string UpdateValues => $"datumVakcinacije = '{DatumVakcinacije.ToString("yyyy-MM-dd")}', nezeljenaReakcija = {(NezeljenaReakcija ? 1 : 0)}, napomena = '{Napomena}' WHERE rb = {Id}";
        [Browsable(false)]
        public string DeleteValues => $"rb={Id}";
        [Browsable(false)]
        public string SelectValues => "";
        [Browsable(false)]
        public string SearchValues { get; set; }
        [Browsable(false)]
        public string PrimarniKljuc => $"rb = {Id}";
        [Browsable(false)]
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entiteti = new List<IEntity>();
            while (reader.Read())
            {
                StavkaKartonaVakcinacije stavka = new StavkaKartonaVakcinacije();

                stavka.Id = reader.GetInt32(reader.GetOrdinal("rb"));
                stavka.NezeljenaReakcija = reader.GetBoolean(reader.GetOrdinal("nezeljenaReakcija"));
                stavka.DatumVakcinacije = Convert.ToDateTime(reader["datumVakcinacije"]);
                stavka.Napomena = reader.GetString(reader.GetOrdinal("napomena"));
                stavka.rbDoze = reader.GetInt32(reader.GetOrdinal("rbDoze"));

                stavka.IDKartona = reader.GetInt32(reader.GetOrdinal("idKarton"));
                stavka.Karton = new KartonVakcinacije
                {
                    Id = stavka.IDKartona,
                    IDPacijent = reader.GetInt32(reader.GetOrdinal("idPacijent")),
                    IDZR = reader.GetInt32(reader.GetOrdinal("idZR")),
                };
               
                stavka.IDVakcine = reader.GetInt32(reader.GetOrdinal("idVakcine"));
                stavka.Vakcina = new Vakcina
                {
                    Id = reader.GetInt32(reader.GetOrdinal("idVakcine")),
                    Naziv = reader.GetString(reader.GetOrdinal("naziv")),
                    Proizvodjac = reader.GetString(reader.GetOrdinal("proizvodjac")),
                    DozvoljenBr = reader.GetInt32(reader.GetOrdinal("dozvoljenBr")),
                    Obavezna = reader.GetBoolean(reader.GetOrdinal("obavezna"))
                };


                entiteti.Add(stavka);
            }
            reader.Close();
            return entiteti;
        }


    }
}
