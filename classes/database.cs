using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication27.Migrations;

namespace WebApplication27.classes
{
    public class database : DbContext
    {
        public database() : base("Server=DESKTOP-PLJ7V59;Initial Catalog=Kargo;Integrated Security=True;")
        {

        }
        public DbSet<users> users { get; set; }
        public DbSet<cargocompany> cargocompany { get; set; }
        public DbSet<shimpentss> shipment { get; set; }
        public DbSet<adress> adresses { get; set; }
        public DbSet<otp> otps { get; set; }
        public DbSet<Sender> sender { get; set; }
        public DbSet<Rechiver> rechiver { get; set; }
        public DbSet<Shipments> shimpentss { get; set; }
        public DbSet<caritem> caritems { get; set; }
        public DbSet<pets> pets { get; set; }
        public DbSet<funt> furnitureItems { get; set; }
        public DbSet<DocumentShipment> documentShipments { get; set; }
        public DbSet<Others> others { get; set; }
        public DbSet<ClothingShipment> clothingShipments { get; set; }
        public DbSet<DeliveryIssue> deliveryIssue { get; set; }
        public DbSet<retunshipment> retunshipments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<users>().HasIndex(o => o.email).IsUnique();

            modelBuilder.Entity<Shipments>()
          .HasRequired(s => s.Sender)
          .WithMany()
           .HasForeignKey(s => s.SenderID)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipments>()
                .HasRequired(s => s.Receiver)
                .WithMany()
                .HasForeignKey(s => s.ReceiverID)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<retunshipment>()
    .HasRequired(r => r.users)
    .WithMany()
    .HasForeignKey(r => r.userid)
    .WillCascadeOnDelete(false); // ✅ Fixes the error

            modelBuilder.Entity<retunshipment>()
                .HasRequired(r => r.shimpentss)
                .WithMany()
                .HasForeignKey(r => r.shipmentid)
                .WillCascadeOnDelete(true); // only keep one cascade path
        }

    }
}
