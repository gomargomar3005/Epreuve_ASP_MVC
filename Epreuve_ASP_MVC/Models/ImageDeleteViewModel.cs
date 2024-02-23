using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Epreuve_ASP_MVC.Models
{
    public class ImageDeleteViewModel
    {
        [HiddenInput]
        [ScaffoldColumn(false)]
        public int Id_Image { get; set; }
        [DisplayName("Nom de l'image")]
        public string Nom_Image { get; set; }
        [DisplayName("Télécharger une nouvelle image")]
        public string Url { get; set; }
        [DisplayName("Produit à lier avec l'image")]
        public int Id_Produit { get; set; }
    }
}
