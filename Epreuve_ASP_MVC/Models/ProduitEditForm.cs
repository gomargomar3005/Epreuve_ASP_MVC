using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class ProduitEditForm
    {
        [DisplayName("Nom du Produit")]
        [Required(ErrorMessage = "Vous devez indiquer le nom du produit.")]
        [MinLength(2, ErrorMessage = "Le nom du produit doit au moins être de 2 caractères.")]
        [MaxLength(100, ErrorMessage = "Le nom du produit ne peut dépasser 100 caractères.")]
        public string Nom_Produit { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Veuillez entrer une description du produit.")]
        [MinLength(20, ErrorMessage = "La description doit au moins être de 20 caractères.")]
        [MaxLength(500, ErrorMessage = "La description ne peut dépasser 500 caractères.")]
        public string Description { get; set; }
        [DisplayName("Prix")]
        [Required(ErrorMessage = "Veuillez indiquer un prix pour le produit à insérer.")]
        public decimal Prix { get; set; }
        [DisplayName("Eco-Score")]
        [Required(ErrorMessage = "Veuillez renseigner l'éco-score.")]
        [RegularExpression("^[A-E]$", ErrorMessage = "L'éco-score doit être A, B, C, D ou E.")]
        public string EcoScore { get; set; }
        [DisplayName("Catégorie")]
        [Required(ErrorMessage = "Veuillez donner une catégorie à votre produit.")]

        public int Id_Categorie { get; set; }
    }
}
