using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Epreuve_ASP_MVC.Models
{
    public class ProduitDeleteViewModel
    {
        [ScaffoldColumn(false)]
        [DisplayName("Identifiant du Produit")]
        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]
        public string Nom_Produit { get; set; }
    }
}
