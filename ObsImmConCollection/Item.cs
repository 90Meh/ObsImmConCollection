using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection
{
    internal class Item
    {
        public Item(int id, String Name)
        {
            this.Id = id;
            this.Name = Name;            
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
