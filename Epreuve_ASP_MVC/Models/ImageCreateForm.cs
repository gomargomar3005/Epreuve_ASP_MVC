using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class ImageCreateForm
    {

        [DisplayName("Nom de l'image")]
        [Required(ErrorMessage = "Vous devez donner un nom à l'image.")]
        [MinLength(1, ErrorMessage ="Le nom de l'image doit être d'au moins 1 caractère.")]
        [MaxLength(50, ErrorMessage = "Le nom de l'image ne peut dépasser 50 caractères.")]
        public string Nom_Image { get; set; }
        [DisplayName("Télécharger une nouvelle image")]
        [Required(ErrorMessage = "Vous devez télécharger une image.")]
        public IFormFile Url { get; set; }
        [DisplayName("Produit à lier avec l'image")]
        [Required(ErrorMessage = "Vous devez lier l'image à un produit.")]
        public int Id_Produit { get; set; }
    }
}
