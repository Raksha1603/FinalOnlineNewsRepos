using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineNewsWebApp.Interface;
using OnlineNewsWebApp.Models;

namespace OnlineNewsWebApp.DataAccessLayer
{
    public class NewsCategoryAccessLayer : INewsCategoryRepository
    {
        private OnlineNewsWebAppContext _dbcontext = new OnlineNewsWebAppContext();
        private static NewsCategoryAccessLayer repo = new NewsCategoryAccessLayer();
        public static INewsCategoryRepository GetRepository()
        { return repo; }

        public List<NewsCategory> GetAllNewsCategory()
        {
            try
            {
                return _dbcontext.NewsCategory.AsNoTracking().ToList();
            }
            catch
            {
                throw;
            }
        }

        public NewsCategory AddNewsCat(NewsCategory newsCategory)
        {
            try
            {
                _dbcontext.NewsCategory.Add(newsCategory);
                _dbcontext.SaveChanges();
                return (newsCategory);
            }
            catch
            {
                throw;
            }
        }
        public NewsCategory GetNewsCategory(int categoryID)
        {
            try
            {
                NewsCategory newsCategory = _dbcontext.NewsCategory.FirstOrDefault(x => x.CategoryID == categoryID);

                if (newsCategory != null)
                {
                    return newsCategory;
                }
                
                    return null;
            }
            catch
            {
                throw;
            }
        }
        public bool UpdateNewsCategory(NewsCategory newsCategory)
        {
            try
            {
                NewsCategory news = GetNewsCategory(newsCategory.CategoryID);
                if(news != null)
                {
                    news.Description = newsCategory.Description;
                    news.Name = newsCategory.Name;
                    _dbcontext.SaveChanges();
                    return true;
                   
                }

                return false;
                
            }
            catch
            {
                throw;
            }
        }

       

        public void DeleteNewsCategory(int categoryID)
        {
            try
            {
                NewsCategory newsCategory = GetNewsCategory(categoryID);
                if(newsCategory != null)
                {
                    _dbcontext.NewsCategory.Remove(newsCategory);
                    _dbcontext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<NewsCategory> GetSimilarNews(int categoryID)
        {
            List<NewsCategory> lstProduct = new List<NewsCategory>();
            NewsCategory newsCategory = GetNewsCategory(categoryID);

            lstProduct = _dbcontext.NewsCategory.Where(x => x.CategoryID == categoryID && x.Description != newsCategory.Description)
                .OrderBy(u => Guid.NewGuid())
                .Take(5)
                .ToList();
            return lstProduct;
        }
    }
}