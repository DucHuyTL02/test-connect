using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestConnect.Models;

namespace TestConnect.Controllers
{
    public class CategoryController : Controller
    {
        QLBH2Entities database=new QLBH2Entities();
        // GET: Category
        public ActionResult Index()
        {
            return View(database.Category.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cate)
        {
            database.Category.Add(cate);
            database.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult Delete(Category cate)
        {
            cate = database.Category.Where(c => c.IDCate == cate.IDCate).FirstOrDefault();
            return View(cate);
        }
        [HttpPost]
        public ActionResult Delete(string IDCate)
        {
            var cate = database.Category.Where(c => c.IDCate == IDCate).FirstOrDefault();
            database.Category.Remove(cate);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(Category cate)
        {
            cate = database.Category.Where(c => c.IDCate == cate.IDCate).FirstOrDefault();
            return View(cate);
        }
        [HttpPost]
        public ActionResult Edit(string IDCate,Category cate)
        {
            var frwcate = database.Category.Where(c => c.IDCate == cate.IDCate).FirstOrDefault();
            if(frwcate != null){
                frwcate.NameCate = cate.NameCate;
                database.SaveChanges();
                return RedirectToAction("Index");
            }
            else { return View() ; }
        }
        [HttpGet]
        public ActionResult Details(Category cate)
        {
            cate = database.Category.Where(c => c.IDCate == cate.IDCate).FirstOrDefault();
            return View(cate);
        }
    }
}