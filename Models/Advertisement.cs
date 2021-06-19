using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineNewsWebApp.Models
{
    [Table("Advertisement")]
    public class Advertisement
    {
        [Key]
        public int ADId { get; set; }
        public string Description { get; set; }
        public string Image2 { get; set; }
        public string Link { get; set; }
        public string AltText { get; set; }

    }
}