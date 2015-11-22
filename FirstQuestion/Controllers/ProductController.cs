using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstQuestion.Controllers
{

    public class ProductController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }


        public ActionResult ProductId(string brandname, string productname, string id)
        {
            var colour = Request.QueryString["colour"];

            if (string.IsNullOrEmpty(id))
            {
                //Do something special here, may be to redirect to another page
            }
            else
            {
                ViewBag.ProductId = id;
            }

            ViewBag.BrandName = brandname;
            ViewBag.ProductName = productname;
            ViewBag.ProductColour = string.IsNullOrEmpty(colour) ? "Not specified" : colour;

            return View();
        }
    }
}