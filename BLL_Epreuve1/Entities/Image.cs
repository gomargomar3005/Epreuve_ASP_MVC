using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Epreuve.Entities
{
    public class Image
    {
        public int Id_Image { get; set; }
        public string Nom_Image { get; set; }
        public string Url { get; set; }
        public int Id_Produit { get; set; }

        public Image(int id_image, string nom_image, string url, int id_produit)
        {
            Id_Image = id_image;
            Nom_Image = nom_image;
            Url = url;
            Id_Produit = id_produit;
        }
    }
}
