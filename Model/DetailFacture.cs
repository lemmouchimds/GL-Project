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

        public decimal Price { get; set; }

        [StringLength(200)]
        public virtual string FactureID{ get; set; }
        public virtual Facture Facture { get; set; }
    }
}
