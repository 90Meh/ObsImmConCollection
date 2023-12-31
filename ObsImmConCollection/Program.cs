﻿using ObsImmConCollection;
using ObsImmConCollection.JackPart;
using ObsImmConCollection.RegularCustomer;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.IO;
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
        StartJack();
        

        Console.ReadKey();
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
    //Джек главный метод
    public static void StartJack()
    {
        //Стартовый пустой лист
        ImmutableList<string> jackHouse = ImmutableList.Create<string>();
        List<BasePart> parts = new List<BasePart>();

        //Создание и вывод
        var part1 = new Part1();
        parts.Add(part1);
        part1.AddPart(jackHouse);
        var part2 = new Part2();
        parts.Add(part2);
        part2.AddPart(part1.Poem);
        var part3 = new Part3();
        parts.Add(part3);
        part3.AddPart(part2.Poem);
        var part4 = new Part4();
        parts.Add(part4);
        part4.AddPart(part3.Poem);
        var part5 = new Part5();
        parts.Add(part5);
        part5.AddPart(part4.Poem);
        var part6 = new Part6();
        parts.Add(part6);
        part6.AddPart(part5.Poem);
        var part7 = new Part7();
        parts.Add(part7);
        part7.AddPart(part6.Poem);
        var part8 = new Part8();
        parts.Add(part8);
        part8.AddPart(part7.Poem);
        var part9 = new Part9();
        parts.Add(part9);
        part9.AddPart(part8.Poem);


        foreach (var item in parts)
        {
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXX");
            foreach (var poe in item.Poem)
            {
                Console.WriteLine(poe);
            }
        }
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