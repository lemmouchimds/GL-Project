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
        public Client client { get; set; }
        public DateTime Date { get; set; }
        
    }
}
