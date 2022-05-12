using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLMainProject
{
    public class Customer
    {
        public Customer()
        {

        }

        [Key]
        public int ID { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Designation { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Adress { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Email { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Responsable { get; set; }

        public bool IsRevendeur { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
