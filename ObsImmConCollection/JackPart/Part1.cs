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
        public void AddPart (ImmutableList<string> strings)
        {
            //List <string> temp = strings.Add("Вот дом,").Add("Который построил Джек.").ToList();            
            Poem = strings.Add("Вот дом,").Add("Который построил Джек.");
        }
    }
}
