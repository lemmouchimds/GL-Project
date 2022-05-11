using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject
{
    public class Produit
    {
        public Produit()
        {

        }

        [Key]
        public int ID { get; set; }
        [StringLength(200)]
        public string Referance { get; set; }
        [StringLength(200)]
        public string Designation { get; set; }
        
        public double ValNutritionnelle { get; set; }
        public double PoidsNet { get; set; }
        public decimal CoutRevient { get; set; }
        public decimal GainSouaite { get; set; }
        public decimal PrixFinal
        {
            get { return CoutRevient + GainSouaite; }
//            set { PrixFinal = value; }
        }

    }

    public class ProduitDerivee : Produit
    {
        public ProduitDerivee()
        {

        }

        public List<Produit> Ingredients { get; set; } //todo: not sure of that
    }




}
