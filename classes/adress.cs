using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class adress
    {
        [Key]
        public int id { get; set; }
        public string street_adress { get; set; }   
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public int userid { get; set; }
        [ForeignKey("userid ")]
        public users users { get; set; }
    }
}