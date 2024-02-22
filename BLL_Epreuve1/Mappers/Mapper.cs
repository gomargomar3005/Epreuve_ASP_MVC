using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = BLL_Epreuve.Entities;
using DAL = DAL_Epreuve.Entities;
using BLL_Epreuve.Mappers;
using Shared_Epreuve.Repositories;


namespace BLL_Epreuve.Mappers
{
    internal static class Mapper
    {
        #region Categorie
        public static BLL.Categorie ToBLL(this DAL.Categorie entity)
        {
            if (entity is null) return null;
            return new BLL.Categorie(
                entity.Id_Categorie,
                entity.Produit_Categorie);
        }

        public static DAL.Categorie ToDAL(this BLL.Categorie entity)
        {
            if (entity is null) return null;
            return new DAL.Categorie()
            {
                Id_Categorie = entity.Id_Categorie,
                Produit_Categorie = entity.Produit_Categorie,
            };

        }
        #endregion

        #region Image
        public static BLL.Image ToBLL(this DAL.Image entity)
        {
            if (entity is null) return null;
            return new BLL.Image(
                entity.Id_Image,
                entity.Nom_Image,
                entity.Url,
                entity.Id_Produit);
        }

        public static DAL.Image ToDAL(this BLL.Image entity)
        {
            if (entity is null) return null;
            return new DAL.Image()
            {
                Id_Image = entity.Id_Image,
                Nom_Image = entity.Nom_Image,
                Url = entity.Url,
                Id_Produit = entity.Id_Produit,
            };
        }
        #endregion

        #region Produit

        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.Nom_Produit,
                entity.Description,
                entity.Prix,
                entity.EcoScore,
                entity.Id_Categorie);
        }

        public static DAL.Produit ToDAL(this BLL.Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
            {
                Id_Produit = entity.Id_Produit,
                Nom_Produit = entity.Nom_Produit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Id_Categorie = entity.Id_Categorie,
            };
        }
        #endregion
    }
}
