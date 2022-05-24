using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject.Dto
{
    public class StockDto
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public string DateProduction { get; set; }
        public string DatePeremption { get; set; }
        public int Quantitie { get; set; }

    }
}
