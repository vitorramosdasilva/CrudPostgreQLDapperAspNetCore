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
    public class ClientesRepository : IRepository<Clientes>
    {
        private string connectionString;
        public ClientesRepository(IConfiguration configuration)
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
      

        public void Add(Clientes item)
        {
            

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                StringBuilder Sql = new StringBuilder();

                Sql.Append("INSERT INTO clientes(");
                Sql.Append("idcidade, nome, email, cpf, rg, datanasc, fone, login, senha,"); 
                Sql.Append("logradouro, cep, bairro, numero)");
                Sql.Append("VALUES (@Idcidade, @Nome, @Email, @Cpf, @Rg, @Datanasc, @Fone, @Login, @Senha, @Logradouro,"); 
                Sql.Append("@Cep, @Bairro, @Numero);");
                
                dbConnection.Execute(Sql.ToString(), item);
            }

        }

         public Clientes FindByEmail(string email)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Clientes>("SELECT * FROM Clientes WHERE email = @Email", new { Email = email }).FirstOrDefault();
            }
        }

    
        public Clientes FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Clientes>("SELECT * FROM Clientes WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Clientes WHERE Id=@Id", new { Id = id });
            }
        }

        public void Update(Clientes item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                StringBuilder Sql    = new StringBuilder();

                Sql.Append("UPDATE Clientes SET idcidade = @Idcidade,  nome  = @Nome, email = @Email,");
                Sql.Append("cpf = @Cpf, rg = @Rg, datanasc = @Datanasc, logradouro = @Logradouro, cep = @Cep, bairro = @Cep,"); 
                Sql.Append("numero = @Numero WHERE id = @Id");

                dbConnection.Query(Sql.ToString(), item);
            }
        }


        public IEnumerable<Clientes> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Clientes>("SELECT * FROM Clientes");
            }
        }


        public string ValidateLogin(Clientes cli)
        {
            string authentication = "Failed";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                
                string Sql = "Select * From Clientes Where Email = @Email and Senha = @Senha";

             if (dbConnection.Query<Clientes>(Sql.ToString(), cli).FirstOrDefault() != null){
                    authentication = "Success";
                }
   
                return authentication;

            }

        }

    }
}

