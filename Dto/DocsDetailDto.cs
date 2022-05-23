using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject.Dto
{
    public class DocsDetailDto
    {
        public int ID { get; set; }
        public string Produit { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Label { get; set; }
        
    }
}
