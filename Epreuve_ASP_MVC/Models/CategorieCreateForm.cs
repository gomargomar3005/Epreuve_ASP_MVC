using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Epreuve_ASP_MVC.Models
{
    public class CategorieCreateForm
    {
        [DisplayName("Catégorie")]
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string Produit_Categorie { get; set; }
    }
}