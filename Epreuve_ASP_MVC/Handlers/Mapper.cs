using BLL_Epreuve.Entities;
using Epreuve_ASP_MVC.Models;

namespace Epreuve_ASP_MVC.Handlers
{
    public static class Mapper
    {
        #region Mappers Produit
        public static ProduitListViewModel ToListItem(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitListViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom_Produit = entity.Nom_Produit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Id_Categorie = entity.Id_Categorie
            };
        }

        public static ProduitDetailsViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailsViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom_Produit = entity.Nom_Produit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Id_Categorie = entity.Id_Categorie
            };
        }

        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                0,
                entity.Nom_Produit,
                entity.Description,
                entity.Prix,
                entity.EcoScore,
                entity.Id_Categorie
            );
        }

        #endregion
    }
}
