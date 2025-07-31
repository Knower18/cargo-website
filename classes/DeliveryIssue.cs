using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApplication27.Migrations;

namespace WebApplication27.classes
{
    public class DeliveryIssue
    {
        [Key]
        public int id {  get; set; }
        public int user_id {  get; set; }
        
        public string trackcode { get; set; }
        
        public string issue_type {  get; set; }
        
        public string Decription {  get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        
        [ForeignKey(nameof(user_id))]

        public users users { get; set; }
    }
}