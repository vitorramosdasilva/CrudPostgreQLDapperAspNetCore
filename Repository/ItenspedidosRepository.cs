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
    public class ItenspedidosRepository : IRepository<Itenspedidos>
    {
        private string connectionString;
        public ItenspedidosRepository(IConfiguration configuration)
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
      

        public void Add(Itenspedidos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO ItensPedidos (idproduto, idpedido, quantidade) VALUES(@Idproduto, @Idpedido, @Quantidade);", item);
            }

        }

    
        public Itenspedidos FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Itenspedidos>("SELECT * FROM ItensPedidos WHERE id = @Id", new { Id = id }).FirstOrDefault();
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

        public void Update(Itenspedidos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE ItensPedidos SET idproduto = @Idproduto,  idpeddo  = @Idpedido, quantidade = @Quantidade WHERE id = @Id", item);
            }
        }


        // public IEnumerable<Itenspedidos> FindAll()
        // {
        //     using (IDbConnection dbConnection = Connection)
        //     {
        //         dbConnection.Open();
        //         return dbConnection.Query<Itenspedidos>("SELECT * FROM ItensPedidos");
        //     }
        // }

        public IEnumerable<Itenspedidos> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Itenspedidos, Produtos, Itenspedidos>(
                    "SELECT c.Id, c.Idproduto, p.preco, c.quantidade, p.nome FROM Itenspedidos c inner Join Produtos p On c.Idproduto = p.Id",
                map: (itenspedidos, produtos) =>
                    {
                        itenspedidos.Produtos = produtos;
                        //itenspedidos.Pedidos = pedidos;
                        return itenspedidos;
                    },
                    splitOn: "Id,Idproduto");

            }
        }




        //  public override IEnumerable<Itenspedidos> FindAll()
        // {
        //     using (IDbConnection dbConnection = Connection)
        //     {
        //         dbConnection.Open();
        //         //return dbConnection.Query<Itenspedidos>("SELECT * FROM ItensPedidos");

        //         return dbConnection.FindAll<Itenspedidos, Produtos,Pedidos Itenspedidos>((itenspedidos, produtos, pedidos) =>
        //         {
        //             itenspedidos.Produtos = produtos;
        //             itenspedidos.Pedidos = pedidos;
        //             return itenspedidos;
        //         });
        //     }
        // }


    }
}

