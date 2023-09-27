using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.JackPart
{
    abstract class BasePart
    {
        public BasePart(ImmutableList<string> poem)
        {
            Poem = poem;
        }

        public ImmutableList<string> Poem { get;  set; }

        public virtual void AddPart()
        {
                        
        }

    }
}
