using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitnesspro.Web.Controllers
{
    public class ServiceController : Controller
    {
        //
        // GET: /Service/

        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}
