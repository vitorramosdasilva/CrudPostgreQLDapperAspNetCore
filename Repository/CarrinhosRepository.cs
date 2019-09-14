using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
using System.Text;
using System;

namespace ASPCoreSample.Repository
{
    public class CarrinhosRepository : IRepository<Carrinhos>
    {
        private string connectionString;
        public CarrinhosRepository(IConfiguration configuration)
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
      

        public void Add(Carrinhos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO Carrinhos (idproduto, nome, quantidade) VALUES(@Idproduto,@nome,1);", item);
            }

        }


    
        public Carrinhos FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Carrinhos>("SELECT * FROM Carrinhos WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }


        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Carrinhos WHERE Id=@Id", new { Id = id });
            }
        }

        public void Update(Carrinhos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Carrinhos SET idproduto = @Idproduto,  idpeddo  = @Idpedido, quantidade = @Quantidade WHERE id = @Id", item);
            }
        }


        public IEnumerable<Carrinhos> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();                
                //return dbConnection.Query<Carrinhos>("SELECT c.Id, c.Idproduto, p.preco, c.quantidade, c.Idcliente, p.nome FROM Carrinhos c inner Join Produtos p On c.Idproduto = p.Id");
                
                return dbConnection.Query<Carrinhos>("SELECT * FROM Carrinhos");
                //SELECT c.Id, c.Idproduto, p.preco, c.quantidade, c.Idcliente, p.nome FROM Carrinhos c inner Join Produtos p On c.Idproduto = p.Id"
            }
        }

   
    }
}

