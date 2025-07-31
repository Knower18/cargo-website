using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class ClothingShipment
    {
        [Key]
        public int Id { get; set; }

        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]

        public users users { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Size { get; set; }

        public float Weight { get; set; }

        public int Quantity { get; set; }

       
        public string SpecialInstructions { get; set; }

        

        public byte[] ImageData { get; set; } // storing image as byte[]

    }
}