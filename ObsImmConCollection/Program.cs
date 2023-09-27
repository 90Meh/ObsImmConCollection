using ObsImmConCollection;
using ObsImmConCollection.RegularCustomer;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //Покупатель
        StartCustomer();
        Console.Clear();

        //Библиотека        
        StartLibrary();
        Console.Clear();

        //Дом который построил Джек

    }

    //Покупатель главный метод
    public static void StartCustomer()
    {
        var _id = 0;
        //Объекты классов
        var _shop = new Shop();
        var _customer = new Customer();
        //Подписка на события коллекции
        _shop.itemsList.CollectionChanged += _customer.OnItemChanged;
        Console.WriteLine("Нажмите A для добавления, D для удаления, X для выхода.");
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
    //Библиотека главный метод
    public static void StartLibrary()
    {
        ConcurrentDictionary<string, int> books = new();
        Task task = Task.Run(() => { PrecentBook(books); });
        string input;
        do
        {
            Console.WriteLine("1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Введите название книги:");
                    var bookName = Console.ReadLine();
                    books.TryAdd(bookName, 0);
                    break;
                case "2":
                    foreach (KeyValuePair<string, int> item in books) Console.WriteLine($"Название книги {item.Key}, Процент прочитанного {item.Value}%");
                    break;
            }

        } while (input != "3");
    }


    //Создание и поиск товара
    public static Item CreateItem(int id)
    {
        return new Item(id, $"Товар от {DateTime.Now}");
    }
    public static Item FindeItem(ObservableCollection<Item> items)
    {
        var i = new Item(0, "");
        Console.WriteLine("Введите Id товара");
        var a = int.TryParse(Console.ReadLine(), out int vvod);
        if (a)
        {
            foreach (var item in items)
            {
                if (item.Id == vvod)
                {
                    i = item;
                }
            }
        }
        else
        {
            FindeItem(items);
        }

        return i;
    }

    //Метод расчёта процентов прочитанного
    public static void PrecentBook(ConcurrentDictionary<string, int> bookCollection)
    {
        while (true)
        {
            foreach (var item in bookCollection)
            {
                Thread.Sleep(100);
                bookCollection[item.Key] = item.Value + 1;
                if (item.Value == 100)
                {
                    if (bookCollection.TryRemove(item.Key, out int retrievedValue))
                    {
                        Console.WriteLine($"Книга {item.Key} удалена");
                    }
                }
            }
        }

    }


}