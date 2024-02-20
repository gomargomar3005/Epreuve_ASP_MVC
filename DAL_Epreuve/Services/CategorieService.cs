using DAL_Epreuve.Entities;
using DAL_Epreuve.Mappers;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Services
{
    public class CategorieService : BaseService,
        ICategorieRepository<Categorie>
    {
        public CategorieService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Categorie> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Categorie_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToCategorie();
                    }
                }
            }
        }

        public Categorie Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Categorie_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id_Categorie", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToCategorie();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }
            }
        }

        public int Insert(Categorie data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_categorie", data.Id_Categorie);
                    command.Parameters.AddWithValue("produit_categorie", data.Produit_Categorie);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Categorie data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Categorie_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("Id_CinemaPlace", data.Id_Categorie);
                    command.Parameters.AddWithValue("id_categorie", data.Id_Categorie);
                    command.Parameters.AddWithValue("produit_categorie", data.Produit_Categorie);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Categorie), $"L'identifiant {data.Id_Categorie} n'est pas das la base de données");
                }
            }
        }
    }
}
