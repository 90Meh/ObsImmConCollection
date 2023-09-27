using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.JackPart
{
    internal class Part2 : BasePart
    {
        public Part2(ImmutableList<string> poem) : base(poem)
        {
        }

        public override void AddPart()
        {
            
            Poem.Add("А это пшеница,");
            Poem.Add("Которая в темном чулане хранится");
            Poem.Add("В доме,");
            Poem.Add("Который построил Джек.");
        }
    }
}
