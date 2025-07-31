using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class caritem
    {
        [Key]
        public int CarItemID { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
       
        public users users { get; set; }
        [Required, StringLength(50)]
        public string VehicleType { get; set; }

        [Required, StringLength(50)]
        public string Make { get; set; }

        [Required, StringLength(50)]
        public string Model { get; set; }

        [StringLength(10)]
        public string Year { get; set; }

        [StringLength(50)]
        public string VIN { get; set; }

        [StringLength(20)]
        public string PlateNumber { get; set; }

        [StringLength(20)]
        public string Color { get; set; }

        public byte[] PhotoPath { get; set; }  // saved file path on server
    }
}