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
        //Базовый класс всех частей

        public ImmutableList<string> Poem;

        public virtual void AddPart(ImmutableList<string> strings)
        {
                        
        }

    }
}
