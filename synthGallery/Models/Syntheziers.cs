using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace synthGallery.Models
{
    public class Syntheziers
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }

        public string DescriptionHtml { get; set; }

        public Specs[]Specs { get; set; }
        private bool Favourite { get; set; }

        public string DisplayText
        {
            get
            {
                return ModelName + " " + Type;
            }
        }
        public string CoverImageFileName
        {
            get
            {
                return ModelName.Replace(" ", "-").ToLower()+ "-" + Type+ ".jpg" ;
            }
        }

    }
}