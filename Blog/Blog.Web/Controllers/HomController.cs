using Blog.Framework.Entities;
using Blog.Framework.Sessions;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Blog.Framework.Repositories;
using Blog.Framework.Repositories.Articles;
using Blog.Framework.UnitOfWorks;
using Blog.Framework.Services.Articles;
using Blog.Web.Models;
using Blog.Web.Areas.User.Models.Articles;

namespace Blog.Web.Controllers
{
    public class HomController : Controller
    {
        //public ArticleModel _model { get; set; }
        //public HomeController(ArticleModel model)
        //{
        //    _model = model;
        //}

        //private IArticleUnitOfWork _articleUnitOfWork;
        //public HomController(IArticleUnitOfWork articleUnitOfWork)
        //{
        //    _articleUnitOfWork = articleUnitOfWork;
        //}

        //private IArticleRepository articleRepository;
        //public HomeController(IArticleRepository article)
        //{
        //    articleRepository = article;
        //}

        //private IDataSession articleRepository;
        //public HomeController(IDataSession article)
        //{
        //    articleRepository = article;
        //}

        public ActionResult Index()
        {

            //var model = new ArticleModel();

            //var data = model.GetAllArticle();
            //_articleUnitOfWork.ArticleRepository.Add(new Article { Title = "TTTTest Tittle", Descreption = "Test Description", isPublished = true, EditedOn = DateTime.MinValue, PostedOn = DateTime.Now });
            //_articleUnitOfWork.BeginTransaction();
            //_articleUnitOfWork.Commit();

            //var Session = articleRepository.session;
            //Session.Save(new Article { Title = "TTTTest Tittle", Descreption = "Test Description", isPublished = true, EditedOn = DateTime.MinValue, PostedOn = DateTime.Now });
            //ITransaction _transaction;
            //_transaction = Session.BeginTransaction();
            //try
            //{
            //    if (_transaction != null && _transaction.IsActive)
            //        _transaction.Commit();
            //}
            //catch
            //{
            //    if (_transaction != null && _transaction.IsActive)
            //        _transaction.Rollback();

            //    throw;
            //}
            //finally
            //{
            //    Session.Dispose();
            //}





            //articleRepository.Add(new Article { Title = "TTTTTest Tittle", Descreption = "Test Description", isPublished = true, EditedOn = DateTime.MinValue, PostedOn = DateTime.Now});
            //ITransaction _transaction;
            //ISession Session = articleRepository.session;
            //_transaction = Session.BeginTransaction();
            //try
            //{
            //    if (_transaction != null && _transaction.IsActive)
            //        _transaction.Commit();
            //}
            //catch
            //{
            //    if (_transaction != null && _transaction.IsActive)
            //        _transaction.Rollback();

            //    throw;
            //}
            //finally
            //{
            //    Session.Dispose();
            //}




            return Redirect("~/User/Article/Index");

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}