using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestConnect.Models;

namespace TestConnect.Controllers
{
    public class ProductsController : Controller
    {
        QLBH2Entities csdl =new QLBH2Entities();
        // GET: Products
       
        public ActionResult danhsachSP(string valueSearch,string searchCate)
        {
            List<Category> categories = csdl.Category.ToList();
            ViewBag.listCate = new SelectList(categories, "IDcate", "NameCate");
            if (valueSearch != null)
            {
                var product =csdl.Products.Where(p=>p.NamePro.Contains(valueSearch)||p.Category.IDCate.Contains(valueSearch)||p.DecriptionPro.Contains(valueSearch));
                return View(product.ToList().OrderByDescending(p=>p.NamePro));
            }
            if (searchCate != null)
            {
                var product = csdl.Products.Where(p => p.IDCate.Contains(searchCate));
                return View(product.ToList());
            }
            else
            {
                return View(csdl.Products.ToList().OrderByDescending(p => p.NamePro));
            }
        }

    }
}