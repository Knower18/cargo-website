using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class users
    {
        [Key]
        public int Id { get; set; }
   

        public string Name { get; set; }
        public string lasname { get; set; } 
        
        [Required]
        [MaxLength(255)]
        public string email { get; set; }
      
       
        public string password { get; set; }
        public string phone { get; set; }
       
        public string kamlik {  get; set; }
        public byte[] profileimg { get; set; }
        public bool isadmin {  get; set; }
       

    }
}