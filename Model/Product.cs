using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject
{
    public class Product
    {
        public Product()
        {

        }

        [Key]
        public int ID { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Referance { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Designation { get; set; }
        
        public double ValNutritionnelle { get; set; }
        public double PoidsNet { get; set; }
        public decimal CoutRevient { get; set; }
        public decimal GainSouaite { get; set; }

        public decimal TotalQuantity { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<DocumentDetail> DocumentDetails { get; set; }
        public decimal PrixFinal
        {
            get { return CoutRevient + GainSouaite; }
//            set { PrixFinal = value; }
        }
    }

    public class ProduitDerivee : Product
    {
        public ProduitDerivee()
        {

        }

        public List<Product> Ingredients { get; set; } //todo: not sure of that
    }




}
