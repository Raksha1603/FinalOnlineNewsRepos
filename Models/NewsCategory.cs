using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineNewsWebApp.Models
{

        public class NewsCategory
        {
            [Key]
            public int CategoryID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
}
