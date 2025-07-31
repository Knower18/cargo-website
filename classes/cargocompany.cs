using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class cargocompany
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string company_name { get; set; }
        public byte[] COMPNAYimg { get; set; }
        public decimal PRICE {  get; set; }
        public DateTime DateTime { get; set; }
        public String DELIVERY_TIME {  get; set; }
    }
}