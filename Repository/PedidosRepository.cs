using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
using System.Text;
 
namespace ASPCoreSample.Repository
{
    public class PedidosRepository : IRepository<Pedidos>
    {
        private string connectionString;
        public PedidosRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
        }


        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }
      

        public void Add(Pedidos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO pedidos (idcliente, idformapag, frete, total, idstatus, data) VALUES(@Idcliente, @Idformapag, @Frete, @Total, @Idstatus, @Data)", item);
            }

        }

    
        public Pedidos FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Pedidos>("SELECT * FROM pedidos WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM pedidos WHERE Id=@Id", new { Id = id });
            }
        }

        public void Update(Pedidos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE pedidos SET idcliente = @Idcliente,  idformapag  = @Idformapag, frete = @Frete, total = @Total, idstatus = @Idstatus, data = @Data WHERE id = @Id", item);
            }
        }


        public IEnumerable<Pedidos> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Pedidos>("SELECT * FROM pedidos");
            }
        }

    
    }
}

