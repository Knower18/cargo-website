using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class shimpentss
    {
        [Key]
        public int id { get; set; }
        public int USER_ID { get; set; }
        public int cargo_id { get; set; }
        [ForeignKey("USER_ID")]
        users users { get; set; }
        public string shipment_type { get; set; }
        [ForeignKey("cargo_id")]
        cargocompany cargocompany { get; set; }
        public string statuse { get; set; }
        [Required]
        [MaxLength(20)]
        public string TrackCode { get; set; }
        public DateTime DateTime { get; set; }
        public byte[] cargoimg { get; set; }

    }
}