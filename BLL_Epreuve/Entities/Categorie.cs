using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Categorie
    {
        public int Id_Categorie { get;  private set; }

        public string Produit_Categorie { get; set; }
    }

    public Categorie(int id_categorie, string produit_categorie)
    {
        Id_Categorie = id_categorie;
        Produit_Categorie = produit_categorie;
    }
}
