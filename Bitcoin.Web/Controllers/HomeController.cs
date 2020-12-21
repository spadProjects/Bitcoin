using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bitcoin.Web.Classes;

namespace Bitcoin.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BitPay()
        {
            return View();
        }
        public ActionResult PerfectMoney()
        {
            return View();
        }
        [Route("PaymentStatus")]
        public ActionResult PaymentStatus()
        {
            return View();
        }
        [Route("PaymentFailed")]
        public ActionResult PaymentFailed()
        {
            return View();
        }
        [Route("PaymentCompleted")]
        public ActionResult PaymentCompleted()
        {
            return View();
        }
        public ActionResult Payeer()
        {
            var paymentUrl = Classes.Payeer.Pay();
            return Redirect(paymentUrl);
            //return View();
        }
        [Route("Payment/Callback")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route("Payment/Failed")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}