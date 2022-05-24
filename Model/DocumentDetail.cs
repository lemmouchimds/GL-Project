using System.ComponentModel.DataAnnotations;

namespace GLMainProject
{
    public class DocumentDetail
    {
        public DocumentDetail()
        {

        }

        [Key]
        public int ID { get; set; }
        public virtual int ProduitID { get; set; }
        public virtual Product Produit { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Label { get; set; }
        public int Offset { get; set; }
        public decimal Marging { get; set; }
        public virtual int DocumentID { get; set; }
        public virtual Document Document { get; set; }
    }
}
