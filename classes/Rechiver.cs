using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class Rechiver
    {
        [Key]
        public int SenderID { get; set; }
        public int user_id { get; set; }
        [ForeignKey(nameof(user_id))]
        public users users { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string NationalID { get; set; }

        [StringLength(255)]
        public string PickupAddress { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}