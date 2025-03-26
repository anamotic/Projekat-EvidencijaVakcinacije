using Microsoft.Data.SqlClient;

namespace Common.Domain
{
    public interface IEntity
    {
        string PrimarniKljuc { get; }
        string TableName { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string DeleteValues { get; }
        string SelectValues { get; }
        string SearchValues { get; set; }

        List<IEntity> GetReaderList(SqlDataReader reader);
    }
}
