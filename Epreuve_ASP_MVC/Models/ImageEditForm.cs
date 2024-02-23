using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class ImageEditForm
    {
        [HiddenInput]
        [Required]
        public int Id_Image { get; set; }
        [DisplayName("Nom de l'image")]
        [Required(ErrorMessage = "Vous devez donner un nom à l'image.")]
        public string Nom_Image { get; set; }
        [DisplayName("Télécharger une nouvelle image")]
        [Required(ErrorMessage = "Vous devez télécharger une image pour valider la modification.")]
        public string Url { get; set; }
        [DisplayName("Produit à lier avec l'image")]
        [Required(ErrorMessage = "Vous devez lier l'image à un produit.")]
        public int Id_Produit { get; set; }
    }
}
