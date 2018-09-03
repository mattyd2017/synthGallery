using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using synthGallery.Models;

namespace synthGallery.Data
{
    public class SynthesizerRepository
    {
        private static Synthesizers[] _synthesizers = new Synthesizers[]
        {
            new Synthesizers()
            {
                Id =1,
                ModelName = "Mini Moog",
                TypeOfSynth = "Monophonic Analog",
                DescriptionHtml = "<p>monophonic analog synthesizer</P>",
                Specs = new Specs[]
              {
                  new Specs() {Voices = "2 analog osicilators", Manufacturer = " Moog ",CountryOfOrigin ="USA " }
              },
            Favourite = false

            },
             new Synthesizers()
            {   Id =2,
                ModelName = "System-8",
                TypeOfSynth = "Virtual Analog",
                DescriptionHtml = "<p>Virtual analog synthesizer</P>",
                Specs = new Specs[]
              {
                  new Specs() {Voices = "8 voice virtual analog oscilators", Manufacturer = " Roland ",CountryOfOrigin ="Japan" }
              },
            Favourite = false

            },
              new Synthesizers()
            {
                Id =3,
                ModelName = "access virus",
                TypeOfSynth = "Virtual Analog",
                DescriptionHtml = "<p>Virtual analog synthesizer</P>",
                Specs = new Specs[]
              {
                  new Specs() {Voices = "virtual analog oscilators", Manufacturer = " Access ",CountryOfOrigin ="Germany" }
              },
            Favourite = false

            },
        };
        public Synthesizers[] GetSynths()
        {
            return _synthesizers;
        }
        public Synthesizers GetSynthesizers(int id)
        {
            Synthesizers synthesizerToReturn = null;
            foreach (var sythesizers in _synthesizers)
            {
                if(sythesizers.Id == id)
                {
                    synthesizerToReturn = sythesizers;
                    break;
                }

            }
            return synthesizerToReturn;
        }
    }
}