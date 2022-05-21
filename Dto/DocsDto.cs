using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject.Dto
{
    public class DocsDto
    {
        public DocsDto()
        {

        }

        public int ID { get; set; }
        public string Reference { get; set; }
        public CustomerNamesOnly CustomerNamesOnly { get; set; }
        public DateTime Date { get; set; }
        public DateTime PayementDate { get; set; }
        public decimal TotalPayed { get; set; }
        public string Payed { get; set; }
    }
}
