using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using OnlineNewsWebApp;
using OnlineNewsWebApp.DataAccessLayer;
using OnlineNewsWebApp.Interface;
using OnlineNewsWebApp.Models;

namespace OnlineNewsWebApp.Controllers
{
    public class NewsCategoryController : ApiController
    {
        INewsCategoryRepository mydata = NewsCategoryAccessLayer.GetRepository();

        [HttpGet]
        public IEnumerable<NewsCategory> Get()
        {
            return mydata.GetAllNewsCategory();
        }

        public NewsCategory Get(int categoryID)
        {
            return mydata.GetNewsCategory(categoryID);
        }

        [HttpPost]
        public NewsCategory Create(NewsCategory newsCategory)
        {
            return mydata.AddNewsCat(newsCategory);
        }

        [System.Web.Http.HttpPut]
        public bool Update(NewsCategory newsCategory)
        {
            return mydata.UpdateNewsCategory(newsCategory);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            mydata.DeleteNewsCategory(id);
        }

    }
}