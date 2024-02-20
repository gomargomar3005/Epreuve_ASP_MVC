using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Entities
{
    public class Panier
    {
        public int Id_Panier { get; set; }
        public int Quantite {  get; set; }
        public int Id_Produit { get; set; }
        public int Id_Commande { get; set; }

    }
}
