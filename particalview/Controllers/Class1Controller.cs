using particalview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace particalview.Controllers
{
    public class Class1Controller : Controller
    {
        List<Class1> Placese = new List<Class1>()
        {
            new Class1 {PlaceId = 1, Name = " STL Arch ", price = 25.12, Photo = "~/Images/St_Louis_night_expblend_cropped.jpg"},
            new Class1 {PlaceId = 2, Name = " Garden ", price = 12.12, Photo = "~/Images/CLM_CHI_lily pools_horz_adams.jpg"},
            new Class1 {PlaceId = 3, Name = " City Museum ", price = 15.50, Photo = "~/Images/download.jpg"}

        };
        public PartialViewResult Prototype()
        {
            return PartialView();
        }






        // GET: Class1
        public ActionResult Index()
        {
            return View(Placese);
        }
    }
}