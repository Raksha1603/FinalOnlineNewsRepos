using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineNewsWebApp.Models
{
    [Table("International")]
    public class International
    {
        [Key]
        public int InternationalNewsID { get; set; }
        public int CategoryID { get; set; }
        public string NewsType { get; set; }
        public string HeadLine { get; set; }
        public string SubHeadLine { get; set; }
        public string Country { get; set; }
        public string DatePosted { get; set; }
        public string SourceName { get; set; }
        public string NewsContent { get; set; }
        public string Image3 { get; set; }
        public string Video { get; set; }
        public string AdditionalComment { get; set; }
        public string SubscriptionBased { get; set; }
    }
}