using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class G_KController : Controller
    {
        //
        // GET: /G_K/

        public ActionResult G_K()
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
