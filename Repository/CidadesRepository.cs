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
    public class CidadesRepository : IRepository<Cidades>
    {
        private string connectionString;
        public CidadesRepository(IConfiguration configuration)
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
 
        public void Add(Cidades item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO Cidades (nome, estado) VALUES(@Nome, @Estado)", item);
            }
 
        }

       

        public IEnumerable<Cidades> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Cidades>("SELECT * FROM Cidades");
            }
        }

        
        public Cidades FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Cidades>("SELECT * FROM Cidades WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
 
        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Cidades WHERE Id=@Id", new { Id = id });
            }
        }
 
        public void Update(Cidades item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Cidades SET nome = @Nome, estado = @Estado WHERE id = @Id", item);
            }
        }

     
    }
}