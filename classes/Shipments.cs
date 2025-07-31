using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication27.classes
{
    public class Shipments
    {
        [Key]
        public int ShipmentID { get; set; }
        [ForeignKey(nameof(UserID))]
       public  users users { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(SenderID))]
        public Sender Sender {  get; set; }
        public int SenderID { get; set; }
        [ForeignKey(nameof(ReceiverID))]
        public Rechiver Receiver { get; set; }
        public int ReceiverID { get; set; }
        [ForeignKey(nameof(CargoCompanyID))]
        public cargocompany cargocompany { get; set; }
        public int CargoCompanyID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public string truck_code {  get; set; }
        public byte[] logo_company {  get; set; }
        public byte[] lcatigory_image { get; set; }
        public string Category { get; set; }
        public decimal price { get; set; }
      
    }
}