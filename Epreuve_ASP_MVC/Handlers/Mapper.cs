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

        public static Produit ToBLL(this ProduitEditForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                entity.Id_Produit,
                entity.Nom_Produit,
                entity.Description,
                entity.Prix,
                entity.EcoScore,
                entity.Id_Categorie
            );
        }

        public static ProduitEditForm ToEditForm(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitEditForm 
            {
                Id_Produit = entity.Id_Produit,
                Nom_Produit = entity.Nom_Produit,
                Description = entity.Description,
                Prix = entity.Prix,
                EcoScore = entity.EcoScore,
                Id_Categorie = entity.Id_Categorie
            };
        }

        public static ProduitDeleteViewModel ToDelete(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDeleteViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom_Produit = entity.Nom_Produit
            };
        }

        #endregion

        #region Mappers Categorie
        public static CategorieListViewModel ToListItem(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieListViewModel()
            {
                Id_Categorie = entity.Id_Categorie,
                Produit_Categorie = entity.Produit_Categorie
            };
        }

        public static Categorie ToBLL(this CategorieCreateForm entity)
        {
            if (entity is null) return null;
            return new Categorie(
                0,
                entity.Produit_Categorie
            );
        }


        public static Categorie ToBLL(this CategorieEditForm entity)
        {
            if (entity is null) return null;
            return new Categorie(
                entity.Id_Categorie,
                entity.Produit_Categorie
            );
        }

        public static CategorieDetailsViewModel ToDetails(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieDetailsViewModel()
            {
                Id_Categorie = entity.Id_Categorie,
                Produit_Categorie = entity.Produit_Categorie
            };
        }

        public static CategorieEditForm ToEditForm(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieEditForm
            {
                Id_Categorie = entity.Id_Categorie,
                Produit_Categorie = entity.Produit_Categorie
            };
        }

        public static CategorieDeleteViewModel ToDelete(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieDeleteViewModel()
            {
                Id_Categorie = entity.Id_Categorie,
                Produit_Categorie = entity.Produit_Categorie
            };
        }

        #endregion

        #region Mapper Image

        public static Image ToBLL(this ImageCreateForm entity)
        {
            if (entity is null) return null;
            return new Image(
                0,
                entity.Nom_Image,
                entity.Url.FileName,
                entity.Id_Produit
            );
        }


        public static Image ToBLL(this ImageEditForm entity)
        {
            if (entity is null) return null;
            return new Image(
                entity.Id_Image,
                entity.Nom_Image,
                entity.Url,
                entity.Id_Produit
            );
        }

        public static ImageEditForm ToEditForm(this Image entity)
        {
            if (entity is null) return null;
            return new ImageEditForm
            {
                Id_Image = entity.Id_Image,
                Nom_Image = entity.Nom_Image,
                Url = entity.Url,
                Id_Produit = entity.Id_Produit
            };
        }

        public static ImageDeleteViewModel ToDelete(this Image entity)
        {
            if (entity is null) return null;
            return new ImageDeleteViewModel()
            {
                Id_Image = entity.Id_Image,
                Nom_Image = entity.Nom_Image,
                Url = entity.Url,
                Id_Produit = entity.Id_Produit
            };
        }

        #endregion
    }
}


