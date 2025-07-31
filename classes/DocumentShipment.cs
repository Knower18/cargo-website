using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class DocumentShipment
    {
        [Key]
        public int Id { get; set; }

        public int user_id { get; set; }
        [ForeignKey(nameof(user_id))]
        public users users { get; set; }
        [Required]
        [StringLength(100)]
        public string DocumentType { get; set; }

        [Required]
        public double Weight { get; set; } // in grams

        [Required]
        public int Quantity { get; set; }

        public string SpecialInstructions { get; set; }

    }
}