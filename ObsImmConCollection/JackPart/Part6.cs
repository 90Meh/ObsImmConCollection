using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.JackPart
{
    internal class Part6 : BasePart
    {
        public void AddPart(ImmutableList<string> strings)
        {
            var par = new List<string>()
            {   "А это корова безрогая,",
                "Лягнувшая старого пса без хвоста,",
                "Который за шиворот треплет кота,",
                "Который пугает и ловит синицу,",
                "Которая часто ворует пшеницу,",
                "Которая в темном чулане хранится",
                "В доме,",
                "Который построил Джек."};
            Poem = strings.AddRange(par);
        }
    }
}
