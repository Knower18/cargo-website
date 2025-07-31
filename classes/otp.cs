using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class otp
    {
        [Key]
        public int ResetID { get; set; }

       
        public string Email { get; set; }
        public string ResetCode { get; set; }
        public DateTime ExpirationTime { get; set; }
       
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        
    }
}