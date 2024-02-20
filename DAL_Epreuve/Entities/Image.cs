using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Epreuve.Entities
{
    public class Image
    {
        public int Id_Image { get; set; }
        public string Nom_Image { get; set; }
        public string Url { get; set; }
        public int Id_Produit { get; set; }

    }
}
