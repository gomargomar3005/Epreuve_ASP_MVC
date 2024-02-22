using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class CategorieEditForm
    {
        [HiddenInput]
        [Required]
        public int Id_Categorie { get; set; }
        [DisplayName("Catégorie")]
        [Required(ErrorMessage = "Vous devez indiquer la catégorie.")]
        public string Produit_Categorie { get; set; }
    }
}
