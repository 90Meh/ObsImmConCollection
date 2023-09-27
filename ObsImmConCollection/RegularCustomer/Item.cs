using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.RegularCustomer
{
    internal class Item
    {
        public Item(int id, string Name)
        {
            Id = id;
            this.Name = Name;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
