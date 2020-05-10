using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_18_Helpers.Controllers
{
    using Models;
    public class CategoryController : Controller
    {
        NORTHWND db = new NORTHWND();
        public ActionResult Index()
        {
            IEnumerable<Category> kategoriler = db.Categories;
            return View(kategoriler);
        }

        public ActionResult KategoriGetir(int id)
        {
            Category kategori = db.Categories.Find(id);
            return View(kategori);
        }
    }
}