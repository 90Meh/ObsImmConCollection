using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.JackPart
{
    internal class Part1 : BasePart
    {
        public Part1(ImmutableList<string> poem) : base(poem)
        {
        }

        public override void AddPart()
        {     
            base.Poem.Add("Вот дом,");
            base.Poem.Add("Который построил Джек.");
        }
    }
}
