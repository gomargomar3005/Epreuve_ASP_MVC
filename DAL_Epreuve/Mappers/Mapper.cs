using DAL_Epreuve.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Mappers
{
    public static class Mapper
    {
        public static Categorie ToCategorie(this IDataRecord record)
        {
            if (record is null) return null;
            return new Categorie()
            {
                Id_Categorie = (int)record["Id_Categorie"],
                Produit_Categorie = (string)record["Produit_Categorie"]
            };
        }

        public static Image ToImage(this IDataRecord record)
        {
            if (record is null) return null;
            return new Image()
            {
                Id_Image = (int)record["Id_Image"],
                Nom_Image = (string)record["Nom_Image"],
                Url = (string)record["Url"],
                Id_Produit = (int)record["Id_Produit"]
            };
        }

        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                Nom_Produit = (string)record["Nom_Produit"],
                Description = (string)record["Description"],
                Prix = (decimal)record["Prix"],
                EcoScore = (string)record["EcoScore"],
                Id_Categorie = (int)record["Id_Categorie"]
            };
        }
    }
}