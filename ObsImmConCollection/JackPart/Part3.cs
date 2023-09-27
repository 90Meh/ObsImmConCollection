using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.JackPart
{
    internal class Part3 : BasePart
    {
        public Part3(ImmutableList<string> poem) : base(poem)
        {
        }

        public override void AddPart()
        {            
            List<string> parts = new List<string>() 
            { "А это веселая птица-синица,", 
                "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек." 
            };
            Poem.AddRange(parts);
        }
    }
}
