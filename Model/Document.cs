using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GLMainProject
{
    public class Document
    {
        public Document()
        {

        }

        [Key]
        public int ID { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Reference { get; set; }
        public virtual int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public bool Payed { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual ICollection<DocumentDetail> DocumentDetails{ get; set; }

    }
}
