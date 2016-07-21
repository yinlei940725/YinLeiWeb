using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YinLeiWeb.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Photo()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }
    }
}
