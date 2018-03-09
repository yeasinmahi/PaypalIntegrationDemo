using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaypalIntegrationDemo.Controllers.Paypal;

namespace PaypalIntegrationDemo.Controllers
{
    public class PaypalController : Controller
    {
        // GET: Paypal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            ViewBag.result = PDTHolder.Success(Request.QueryString.Get("tx"));
            return View("Success");
        }
    }
}