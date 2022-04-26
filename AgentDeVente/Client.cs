﻿using System;
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
        public string Designation { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Responsable { get; set; }

        public bool IsRevendeur { get; set; }
    }
}
