using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
 
namespace ASPCoreSample.Repository
{
    public class FormapagamentosRepository : IRepository<Formapagamentos>
    {
        private string connectionString;

        public FormapagamentosRepository(IConfiguration configuration)
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
 
        public void Add(Formapagamentos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO Formapagamentos (descricao) VALUES(@Descricao)", item);
            }
 
        }

      
        public IEnumerable<Formapagamentos> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Formapagamentos>("SELECT * FROM Formapagamentos");
            }
        }

        

        public Formapagamentos FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Formapagamentos>("SELECT * FROM Formapagamentos WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
 
        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Formapagamentos WHERE Id=@Id", new { Id = id });
            }
        }
 
        public void Update(Formapagamentos item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Formapagamentos SET descricao = @Descricao WHERE id = @Id", item);
            }
        }

     
    }
}