using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class MathsController : Controller
    {
        //
        // GET: /Maths/

        public ActionResult Maths()
        {
            if (Session["loggedin"] != null)
            {
                if (((bool)Session["loggedin"]))
                    return View();
            }
            return RedirectToAction("Notuser", "Notuser");
       
        }

    }
}
