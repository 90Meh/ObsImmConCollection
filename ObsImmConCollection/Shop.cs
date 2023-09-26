using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ObsImmConCollection
{
    internal class Shop
    {
        //Класс магазин

        //Список товаров
        public ObservableCollection<Item> itemsList = new();


        //Метод добавления
        public void Add(Item item)
        {
            if (item == null)
            { Console.WriteLine("Customer = null"); }
            else { itemsList.Add(item); }
        }

        //Метод удаления
        public void Remove(Item item)
        { itemsList.Remove(item); }

        
    }
}
