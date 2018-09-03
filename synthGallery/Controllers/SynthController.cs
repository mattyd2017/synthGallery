using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using synthGallery.Models;
using synthGallery.Data;

namespace synthGallery.Controllers
{
    public class SynthController : Controller
    {
        private SynthesizerRepository _synthesizers = null;

        public  SynthController()
        {
            _synthesizers = new SynthesizerRepository();
        }
        public ActionResult Index()
        {
            var synth = _synthesizers.GetSynths();
            return View(synth);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var synths = _synthesizers.GetSynthesizers((int)id);
            return View(synths);
        }
    }
}