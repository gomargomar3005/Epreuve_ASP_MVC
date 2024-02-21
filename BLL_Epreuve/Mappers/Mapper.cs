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
    public static class Mapper
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
    }
}
