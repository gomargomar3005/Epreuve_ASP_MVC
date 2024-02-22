using System.ComponentModel;

namespace Epreuve_ASP_MVC.Models
{
    public class CategorieDetailsViewModel
    {
        [DisplayName("Identifiant Catégorie")]
        public int Id_Categorie { get; set; }
        [DisplayName("Catégorie")]
        public string Produit_Categorie { get; set; }
    }
}
