using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineNewsWebApp.Models;

namespace OnlineNewsWebApp.Interface
{
    public interface INewsCategoryRepository
    {
        List<NewsCategory> GetAllNewsCategory();
        NewsCategory AddNewsCat(NewsCategory newscategory);
        bool UpdateNewsCategory(NewsCategory newsCategory);
        NewsCategory GetNewsCategory(int CategoryID);
        void DeleteNewsCategory(int CategoryID);
        List<NewsCategory> GetSimilarNews(int id);

    }
}