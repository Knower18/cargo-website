using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class Others
    {
        public int Id { get; set; }

        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]

        public users users { get; set; }

        public string ItemTitle { get; set; }

        public string Description { get; set; }

        public float? Weight { get; set; }

        public string Dimensions { get; set; }
         public byte[] ImageData { get; set; }
    }
}