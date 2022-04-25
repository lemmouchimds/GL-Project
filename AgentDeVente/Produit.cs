using System;
using System.Collections.Generic;
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

        public int ID { get; set; } 
        public string Designation { get; set; }
        public float ValNutritionnelle { get; set; }
        public float PoidsNet { get; set; }
        public decimal CoutRevuent { get; set; }
        public decimal GainSouaite { get; set; }
        public decimal PrixFinal
        {
            get { return CoutRevuent + GainSouaite; }
            set { PrixFinal = value; }
        }

    }

    public class ProduitDeriver : Produit
    {
        public ProduitDeriver()
        {

        }

        public List<Produit> Ingredients { get; set; } //todo: not sure of that
    }




}
