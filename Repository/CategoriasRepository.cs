using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
 
namespace ASPCoreSample.Repository
{
    public class CategoriasRepository : IRepository<Categorias>
    {
        private string connectionString;
        public CategoriasRepository(IConfiguration configuration)
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
 
        public void Add(Categorias item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO Categorias (descricao) VALUES(@Descricao)", item);
            }
 
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public IEnumerable<Categorias> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Categorias>("SELECT * FROM Categorias");
            }
        }
 
        public Categorias FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Categorias>("SELECT * FROM Categorias WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Categorias WHERE Id=@Id", new { Id = id });
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Update(Categorias item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Categorias SET descricao = @Descricao WHERE id = @Id", item);
            }
        }
    }
}