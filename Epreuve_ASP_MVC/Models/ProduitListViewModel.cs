using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class ProduitListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]
        public string Nom_Produit { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Prix")]
        public decimal Prix { get; set; }
        [DisplayName("Eco-Score")]
        public string EcoScore { get; set; }
        [ScaffoldColumn(false)]
        public int Id_Categorie { get; set; }
    }
}
