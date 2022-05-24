using System;

namespace GLMainProject.Dto
{
    public class DocsDto
    {
        public DocsDto()
        {

        }

        public int ID { get; set; }
        public string Reference { get; set; }
        public string CustIdName { get; set; }
        public DateTime Date { get; set; }
        public DateTime PayementDate { get; set; }
        public decimal TotalPayed { get; set; }
        public string Payed { get; set; }
    }
}
