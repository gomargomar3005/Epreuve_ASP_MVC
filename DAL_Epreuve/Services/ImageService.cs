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
    public class ImageService : BaseService, IImageRepository<Image>
    {
        public ImageService(IConfiguration configuration) : base(configuration, "DB-Epreuve")
        {
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Image_Delete";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(id), $"L'identifiant {id} n'est pas das la base de données");
                }
            }
        }

        public IEnumerable<Image> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Image_GetAll";
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return reader.ToImage();
                    }
                }
            }
        }

        public Image Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = "SP_Image_GetById";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id_Image", id);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) return reader.ToImage();
                    throw new ArgumentException(nameof(id), $"L'identifiant {id} n'existe pas dans la base de données.");
                }

            }
        }

        public int Insert(Image data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Image_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("nom_image", data.Nom_Image);
                    command.Parameters.AddWithValue("url", data.Url);
                    command.Parameters.AddWithValue("id_produit", data.Id_Produit);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(Image data)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Image_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("nom_image", data.Nom_Image);
                    command.Parameters.AddWithValue("url", data.Url);
                    command.Parameters.AddWithValue("id_produit", data.Id_Produit);

                    connection.Open();
                    if (command.ExecuteNonQuery() <= 0)
                        throw new ArgumentException(nameof(data.Id_Image), $"L'identifiant {data.Id_Image} n'est pas das la base de données");
                }
            }
        }
    }
}
