using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using synthGallery.Models;

namespace synthGallery.Controllers
{
    public class SynthController : Controller
    {
        public ActionResult Detail()
        {
            var synths = new Synthesizers()
            {
              ModelName = "mini-moog",
              TypeOfSynth = "Monophonic Analog",
              DescriptionHtml = "<p>monophonic analog synthesizer</P>",
              Specs = new Specs[]
              {
                  new Specs() {Voices = "2 analog osicilators", Manufacturer = " Moog ",CountryOfOrigin ="USA " }
              }
              
            };

            
            return View(synths);
        }
    }
}