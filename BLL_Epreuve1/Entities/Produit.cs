using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string EcoScore { get; set; }
        public int Id_Categorie { get; set; }

        public Produit(int id_produit, string nom_produit, string description, decimal prix, string ecoscore, int id_categorie)
        {
            Id_Produit = id_produit;
            Nom_Produit = nom_produit;
            Description = description;
            Prix = prix;
            EcoScore = ecoscore;
            Id_Categorie = id_categorie;
        }
    }
}
