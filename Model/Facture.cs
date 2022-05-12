using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GLMainProject
{
    public class Facture
    {
        public Facture()
        {

        }

        [Key]
        public int ID { get; set; }
        public virtual int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<DetailFacture> Details { get; set; }
        
    }
}
