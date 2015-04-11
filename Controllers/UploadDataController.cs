using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
{
    public class UploadDataController : Controller
    {
        Database1Entities2 db = new Database1Entities2();
        //
        // GET: /UploadData/

        public ActionResult UploadData()
        {
            if (Session["loggedin"] != null)
            {
                if (((bool)Session["loggedin"]))
                    return View(db.Movies.ToList());
            }
            return RedirectToAction("Notuser", "Notuser");
        }
        [HttpPost]

        public ActionResult Upload()
        {
            Movie m = new Movie();

            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i];
                string mov = @"~\Movies\" + file.FileName;
                m.Movie1 = @"/Movies/" + file.FileName;
                db.Movies.Add(m);
                db.SaveChanges();
                file.SaveAs(Server.MapPath(mov));
            }
            return RedirectToAction("UploadData", "UploadData");
        }
    }
}
