using System.ComponentModel.DataAnnotations;

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
