using System;
using System.ComponentModel.DataAnnotations;

namespace GLMainProject
{
    public class Inventory
    {
        public Inventory()
        {

        }

        [Key]
        public int ID { get; set; }
        public Product Product { get; set; }
        public DateTime DateProduction { get; set; }
        public DateTime DatePeremption { get; set; }
        public int InStock { get; set; }

    }
}
