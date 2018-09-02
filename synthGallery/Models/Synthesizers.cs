using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synthGallery.Models
{
    public class Synthesizers
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string TypeOfSynth { get; set; }

        public string DescriptionHtml { get; set; }

        public Specs[]Specs { get; set; }
        public bool Favourite { get; set; }

        public string DisplayText
        {
            get
            {
                return ModelName + " " + TypeOfSynth;
            }
        }
        public string CoverImageFileName
        {
            get
            {
                return ModelName + ".jpg" ;
            }
        }

    }
}