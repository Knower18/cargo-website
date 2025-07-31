using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication27.classes;



namespace WebApplication27
{
    public partial class addcargo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
            
        

        protected void submitCargo_Click(object sender, EventArgs e)
        {
            using (var db = new database())
            {
                var cargo = new cargocompany
                {
                    company_name = cargoName.Text.Trim(),
                    PRICE = decimal.TryParse(price.Text, out decimal p) ? p : 0,
                    DELIVERY_TIME = cargoDescription.Text.Trim(),
                    DateTime = DateTime.Today,
                    
                };

                // ✅ Handle image upload
                if (cargoImage.HasFile)
                {
                    using (var binaryReader = new BinaryReader(cargoImage.PostedFile.InputStream))
                    {
                        cargo.COMPNAYimg = binaryReader.ReadBytes(cargoImage.PostedFile.ContentLength);
                    }
                }

                db.cargocompany.Add(cargo);
                db.SaveChanges();

                // Optional: Show success or redirect
                Response.Redirect("manage-cargo.aspx"); // or stay on same page
            }
        }
    }
}