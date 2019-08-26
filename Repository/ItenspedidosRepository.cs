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
    public class ItensPedidosRepository : IRepository<ItensPedidos>
    {
        private string connectionString;
        public ItensPedidosRepository(IConfiguration configuration)
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
      

        public void Add(ItensPedidos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO ItensPedidos (idproduto, idpedido, quantidade) VALUES(@Idproduto, @Idpedido, @Quantidade)", item);
            }

        }

    
        public ItensPedidos FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<ItensPedidos>("SELECT * FROM ItensPedidos WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM ItensPedidos WHERE Id=@Id", new { Id = id });
            }
        }

        public void Update(ItensPedidos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE ItensPedidos SET idproduto = @Idproduto,  idpeddo  = @Idpedido, quantidade = @Quantidade WHERE id = @Id", item);
            }
        }


        public IEnumerable<ItensPedidos> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<ItensPedidos>("SELECT * FROM ItensPedidos");
            }
        }

   
    }
}

