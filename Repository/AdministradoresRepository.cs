using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using ASPCoreSample.Models;
 
namespace ASPCoreSample.Repository
{
    public class AdministradoresRepository : IRepository<Administradores>
    {
        private string connectionString;
        public AdministradoresRepository(IConfiguration configuration)
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
 
        public void Add(Administradores item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO Administradores (nome, login, senha) VALUES(@Nome,@Login,@Senha)", item);
            }
 
        }
 
        public IEnumerable<Administradores> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Administradores>("SELECT * FROM Administradores");
            }
        }

        public IEnumerable<Administradores> FindAllT => throw new System.NotImplementedException();

        public Administradores FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Administradores>("SELECT * FROM Administradores WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
 
        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Administradores WHERE Id=@Id", new { Id = id });
            }
        }
 
        public void Update(Administradores item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Administradores SET nome = @Nome,  login  = @Login, senha= @Senha WHERE id = @Id", item);
            }
        }

     
    }
}