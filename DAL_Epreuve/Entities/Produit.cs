using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Entities
{
    public class Produit
    {
        public int Id_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public string Description { get; set; }
        public decimal Prix { get; set; }
        public string EcoScore { get; set; }
        public int Id_Categorie { get; set; }

    }
}
