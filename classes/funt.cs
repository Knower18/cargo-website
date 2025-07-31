using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class funt
    {
        [Key]
        public int FurnitureItemID { get; set; }

        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]

        public users users { get; set; }
        public string FurnitureType { get; set; }

        public string Color { get; set; }

        public float Length { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public byte[] Photo { get; set; }
    }
}