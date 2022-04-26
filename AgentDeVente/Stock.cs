using System;
using System.ComponentModel.DataAnnotations;

namespace GLMainProject
{
    public class Stock
    {
        public Stock()
        {

        }

        [Key]
        public int ID { get; set; }
        public Produit produit { get; set; }
        public DateTime DateProduction { get; set; }
        public DateTime DatePeremption { get; set; }
        public int InStock { get; set; }

    }
}
