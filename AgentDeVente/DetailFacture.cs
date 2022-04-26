using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject
{
    public class DetailFacture
    {
        public DetailFacture()
        {

        }

        [Key]
        public int ID { get; set; }
        public Produit Produit { get; set; }
        public int Quantity { get; set; }
    }
}
