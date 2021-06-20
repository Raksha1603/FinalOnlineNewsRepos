using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OnlineNewsWebApp.Models;

namespace OnlineNewsWebApp
{
    public class OnlineNewsWebAppContext: DbContext
    {
        public OnlineNewsWebAppContext() : base("OnlineNewsConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public static OnlineNewsWebAppContext Create()
        {
            return new OnlineNewsWebAppContext();
        }

        public virtual DbSet<International> International { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }

        public virtual DbSet<NewsCategory> NewsCategory { get; set; }
    }
}