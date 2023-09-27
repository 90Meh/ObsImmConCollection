using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsImmConCollection.RegularCustomer
{
    internal class Customer
    {
        public void OnItemChanged(object sender, NotifyCollectionChangedEventArgs e)
        {


            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Item newItem)
                        Console.WriteLine($"Добавлен новый товар: Имя {newItem.Name} ID {newItem.Id}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (e.OldItems?[0] is Item oldItem)
                        Console.WriteLine($"Удален товар: Имя {oldItem.Name} ID {oldItem.Id}");
                    break;
            }

        }
    }
}
