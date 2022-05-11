using System;
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
        
    }
}
