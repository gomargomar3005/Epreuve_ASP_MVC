using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Epreuve_ASP_MVC.Models
{
    public class ProduitDetailsViewModel
    {
        [DisplayName("Identifiant du Produit")]
        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]
        public string Nom_Produit { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Prix")]
        public decimal Prix { get; set; }
        [DisplayName("Eco-Score")]
        public string EcoScore { get; set; }
        [DisplayName("Catégorie")]
        public int Id_Categorie { get; set; }
    }
}
