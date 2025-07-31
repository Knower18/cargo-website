using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class pets
    {
        [Key]
        public int PetShipmentID { get; set; }

        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]

        public users users { get; set; }

        [Required]
        public string PetName { get; set; }

        [Required]
        public string PetType { get; set; }

        public string Breed { get; set; }

        public string Gender { get; set; }

        public string MicrochipID { get; set; }

        public int  Age { get; set; }

        public float Weight { get; set; }

        public string SpecialInstructions { get; set; }

        public byte[] PetPhoto { get; set; }

        public byte[] HealthDocument { get; set; }

       
    }
}