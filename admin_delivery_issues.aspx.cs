using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using WebApplication27.classes;

namespace WebApplication27
{
    public partial class admin_delivery_issues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadIssues();
            }
        }
        private void LoadIssues()
        {
            using (var db = new database())
            {
                var data = db.deliveryIssue.Include(o=> o.users).ToList()
                    .Select(i => new
                    {
                        Name = i.users.Name,
                        email = i.users.email,
                        trackcode = i.trackcode,
                        issue_type = i.issue_type,
                        Decription = i.Decription,
                        date = i.date
                    })
                    .OrderByDescending(i => i.date)
                    .ToList();

                gridIssues.DataSource = data;
                gridIssues.DataBind();
            }
        }

    }
}