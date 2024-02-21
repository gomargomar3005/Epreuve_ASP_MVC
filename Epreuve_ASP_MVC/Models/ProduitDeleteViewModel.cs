using System.ComponentModel;

namespace Epreuve_ASP_MVC.Models
{
    public class ProduitDeleteViewModel
    {
        [DisplayName("Identifiant du Produit")]
        public int Id_Produit { get; set; }
        [DisplayName("Nom du Produit")]
        public string Nom_Produit { get; set; }
    }
}
