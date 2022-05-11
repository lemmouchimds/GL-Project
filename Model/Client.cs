using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject
{
    public class Client
    {
        public Client()
        {

        }

        [Key]
        public int ID { get; set; }
        [StringLength(200)]
        public string Designation { get; set; }
        [StringLength(200)]
        public string Adress { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Responsable { get; set; }

        public bool IsRevendeur { get; set; }

        public virtual ICollection<Facture> Factures { get; set; }
    }
}
