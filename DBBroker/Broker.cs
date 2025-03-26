using Common.Domain;
using Microsoft.Data.SqlClient;
using System.Diagnostics;


namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

         public int Kreiraj(IEntity entity) 
          {
              SqlCommand command = connection.CreateCommand();
              command.CommandText = $"insert into {entity.TableName} {entity.InsertValues}";
            Debug.WriteLine(command.CommandText);
            object a = command.ExecuteScalar();
              if (a != null)
              {
                  return (int)a;
              }
              else return 0;

          } 

        public void Promeni(IEntity entity)  
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"UPDATE {entity.TableName} SET {entity.UpdateValues} WHERE {entity.PrimarniKljuc} ";
            command.ExecuteNonQuery();

        }
        public void Obrisi(IEntity entity) 
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.DeleteValues}";
            command.ExecuteNonQuery();
        }
        public List<IEntity> Pretrazi(IEntity entity)  
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT {entity.SearchValues} FROM  {entity.TableName} ";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> rezultat = entity.GetReaderList(reader);
            return rezultat;
        }
         public List<IEntity> GetAll(IEntity entity)
         {
             SqlCommand command = connection.CreateCommand();
             command.CommandText = $"select * from {entity.TableName}";
             SqlDataReader reader = command.ExecuteReader();
             List<IEntity> list = entity.GetReaderList(reader);
            Debug.WriteLine($"Broj zapisa iz baze: {list.Count}");


            return list;
         }

        // pravim posebnu get all metodu sa uslovom
        public List<IEntity> UcitajSaUslovom(IEntity entity, string query)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> result = entity.GetReaderList(reader);
            reader.Close();
            return result;
        }

        //metoda za izlistavanje radnika koji mogu da pristupe sistemu
        public List<IEntity> logInUcitavanje(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();

            if (entity is ZdravstveniRadnik zRadnik)
            {
                command.CommandText = "SELECT * FROM ZdravstveniRadnik WHERE KorisnickoIme = @korisnickoIme AND sifra = @sifra";
                command.Parameters.AddWithValue("@korisnickoIme", zRadnik.KorisnickoIme);
                command.Parameters.AddWithValue("@sifra", zRadnik.Sifra);
            }
            else
            {
                throw new Exception("Neispravan entitet za ovu metodu!");
            }

            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);

            // Ako je lista prazna
            if (list.Count == 0)
            {
                Debug.WriteLine("Nije pronađen nijedan rezultat!");
            }

            reader.Close();
            return list;
        }
        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        
    }
}

