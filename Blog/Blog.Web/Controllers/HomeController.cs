using Blog.Framework.Entities;
using Blog.Framework.Sessions;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Session = new FrameworkSession().Session;
            Session.Save(new Article { Title = "Test Tittle", Descreption = "Test Description", isPublished = true, EditedOn = DateTime.MinValue, PostedOn = DateTime.Now});
            ITransaction _transaction;
            _transaction = Session.BeginTransaction();
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                Session.Dispose();
            }



            return View();
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