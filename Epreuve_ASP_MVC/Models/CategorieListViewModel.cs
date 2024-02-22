using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class CategorieListViewModel
    {
        [ScaffoldColumn(false)]
        public int Id_Categorie { get; set; }
        [DisplayName("Catégorie")]
        public string Produit_Categorie { get; set; }
    }
}
