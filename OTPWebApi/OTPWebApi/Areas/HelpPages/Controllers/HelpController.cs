using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OTPWebApi.Areas.HelpPages.Controllers
{
    public class HelpController : Controller
    {
        //
        // GET: /HelpPages/Help/
        public ActionResult Index()
        {
            return View();
        }
	}
}