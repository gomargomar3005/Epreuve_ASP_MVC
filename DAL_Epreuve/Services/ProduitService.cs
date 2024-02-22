using DAL_Epreuve.Entities;
using Microsoft.Extensions.Configuration;
using Shared_Epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Epreuve.Mappers;

namespace DAL_Epreuve.Services
{
    public class ProduitService : BaseService, IProduitRepository<Produit>
    {
        public ProduitService(IConfiguration configuration) : base(configuration, "DB-Epreuve")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Delete";
                    command.Parameters.AddWithValue("Id_Produit", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Produit> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                {
                    command.CommandText = "SP_Produit_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProduit();
                        }
                    }
                }
            }
        }

        public Produit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                {
                    command.CommandText = "SP_Produit_GetById";
                    command.Parameters.AddWithValue("Id_Produit", id);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToProduit();
                        throw new ArgumentOutOfRangeException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                    }
                }

            }
        }

        public int Insert(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Insert";
                    command.Parameters.AddWithValue("nom_produit", data.Nom_Produit);
                    command.Parameters.AddWithValue("description", data.Description);
                    command.Parameters.AddWithValue("prix", data.Prix);
                    command.Parameters.AddWithValue("ecoscore", data.EcoScore);
                    command.Parameters.AddWithValue("id_categorie", data.Id_Categorie);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Produit data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Produit_Update";
                    command.Parameters.AddWithValue("nom_produit", data.Nom_Produit);
                    command.Parameters.AddWithValue("description", data.Description);
                    command.Parameters.AddWithValue("prix", data.Prix);
                    command.Parameters.AddWithValue("ecoscore", data.EcoScore);
                    command.Parameters.AddWithValue("id_categorie", data.Id_Categorie);

                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Produit), $"L'identifiant {data.Id_Produit} n'est pas das la base de données");
                }
            }
        }
    }
}
