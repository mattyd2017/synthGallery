using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace synthGallery.Controllers
{
    public class SynthController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.ModelName = "Model D mini moog";
            ViewBag.Type = "MonoPhonic";
            ViewBag.Description = "<p>monophonic analog synthesizier</P>";

            ViewBag.Specs = new string[]
            {
                "voices: 2 analog oscilators",
                "manufacturer: Moog",
                "country of origin: USA"
            };
            return View();
        }
    }
}