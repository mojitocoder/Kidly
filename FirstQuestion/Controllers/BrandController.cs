using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstQuestion.Controllers
{
    public class BrandController : Controller
    {
        public ActionResult Index(string brandname)
        {
            if (string.IsNullOrEmpty(brandname))
            {
                //Brandname is not specified, 
                //  do something special, like showing all brands available in store

                ViewBag.BrandName = "Not specified";
            }
            else ViewBag.BrandName = brandname;

            return View();
        }
    }
}