using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
 
namespace ASPCoreSample.Repository
{
    public class ProdutosRepository : IRepository<Produtos>
    {
        private string connectionString;
        public ProdutosRepository(IConfiguration configuration)
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
 
        public void Add(Produtos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO Produtos (descricao, preco, idcategoria, imagem, nome) VALUES(@Descricao, @Preco, @Idcategoria, @Imagem, @Nome)", item);
            }
 
        }
 
        public IEnumerable<Produtos> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Produtos>("SELECT * FROM Produtos");
            }
        }
 
        public Produtos FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Produtos>("SELECT * FROM Produtos WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
 
        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Produtos WHERE Id=@Id", new { Id = id });
            }
        }
 
        public void Update(Produtos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Produtos SET descricao = @Descricao,  preco  = @Preco, imagem = @Imagem, nome = @Nome, idcategoria = @Idcategoria WHERE id = @Id", item);
            }
        }
    }
}