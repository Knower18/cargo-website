using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class retunshipment
    {
        [Key]
        public int id { get; set; }
        public int userid {  get; set; }
        public  int shipmentid { get; set; }
        [ForeignKey(nameof(userid))]
        public users users { get; set; }
        [ForeignKey(nameof(shipmentid))]
        public Shipments shimpentss { get; set; }
        public string  type { get; set; }
        public string reason {  get; set; }
        public string trackcode {  get; set; }
        public byte[] image { get; set; }
    }
}