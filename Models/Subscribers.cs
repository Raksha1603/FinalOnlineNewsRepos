using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineNewsWebApp.Models
{
    [Table("Subscribers")]
    public class Subscribers
    {
        [Key]
        public int subscriber_id { get; set; }
        public int user_id { get; set; }
        public string Subscription_Type { get; set; }
        public string DateJoined { get; set; }
        public string Mode_Of_Payment { get; set; }
        public string User_Status { get; set; }
    }
}