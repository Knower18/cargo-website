using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data.Entity;
using WebApplication27.classes;

namespace WebApplication27
{
    public partial class admin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadShipments();
        }

        private void LoadShipments()
        {
            using (var db = new database())
            {
                var shipments = db.shimpentss
                    .Include(s => s.Sender)
                    .Include(s => s.Receiver)
                    .Include(s => s.cargocompany)
                    .ToList();
                List<Shipments> shipments1 = new List<Shipments>();
                shipments1.AddRange(shipments);
                shipments1.Reverse();
                rptShipments.DataSource = shipments1;
                rptShipments.DataBind();
            }
        }

        public static string GetStatusClass(string status)
        {
            switch (status)
            {
                case "in-office": return "status-office";
                case "in-transit": return "status-transit";
                case "out-for-delivery": return "status-delivery";
                case "delivered": return "status-delivered";
                default: return "";
            }
        }
        protected string GetSelectedStatus(string status)
        {
            return $"<asp:ListItem Value=\"{status}\" Selected=\"True\">{status}</asp:ListItem>";
        }
        protected string GetStatusColor(string status)
        {
            switch (status)
            {
                case "in-office": return "#ff9800";
                case "in-transit": return "#2196F3";
                case "out-for-delivery": return "#FFC107";
                case "delivered": return "#4CAF50";
                default: return "#ccc";
            }
        }
        protected void rptShipments_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int shipmentId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "UpdateStatus")
            {
                DropDownList ddl = (DropDownList)e.Item.FindControl("ddlStatus_" + shipmentId);
                if (ddl != null)
                {
                    string newStatus = ddl.SelectedValue;

                    using (var db = new database())
                    {
                        var shipment = db.shimpentss.FirstOrDefault(s => s.ShipmentID == shipmentId);
                        if (shipment != null)
                        {
                            shipment.Status = newStatus;
                            db.SaveChanges();
                        }
                    }

                    LoadShipments();
                }
            }
            else if (e.CommandName == "EditShipment")
            {
                Response.Redirect("edit_shipment.aspx?id=" + shipmentId);
            }
            else if (e.CommandName == "DeleteShipment")
            {
                using (var db = new database())
                {
                    var shipment = db.shimpentss.FirstOrDefault(s => s.ShipmentID == shipmentId);
                    if (shipment != null)
                    {
                        db.shimpentss.Remove(shipment);
                        db.SaveChanges();
                        LoadShipments();
                    }
                }
            }

        }
    }
}
