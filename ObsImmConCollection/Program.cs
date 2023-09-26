using ObsImmConCollection;
using System.Collections.ObjectModel;

internal class Program
{
    private static void Main(string[] args)
    {
        var _id = 0;
        //Объекты классов
        var _shop = new Shop();
        var _customer = new Customer();

        //Подписка на события коллекции
        _shop.itemsList.CollectionChanged += _customer.OnItemChanged;

        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.A:
                    _shop.Add(CreateItem(_id));
                    _id++;
                    break;
                    case ConsoleKey.D:
                    _shop.Remove(FindeItem(_shop.itemsList));
                    break;
                default:
                    Console.WriteLine(key.Key + " клавиша была нажата");
                    break;
            }

        } while (key.Key != ConsoleKey.X);

    }

    public static Item CreateItem (int id)
    {        
        return new Item(id, $"Товар от {DateTime.Now}");        
    }
    public static Item FindeItem(ObservableCollection<Item> items)
    {
        var i = new Item(0, "");
        Console.WriteLine("Введите Id товара");        
        var a = int.TryParse(Console.ReadLine(), out int vvod);
        foreach (var item in items)
        {
            if (item.Id == vvod)
            {
                i = item;
            }
        }
        return i;
    }
}