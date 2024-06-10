using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы первого списка через пробел:");
        List<int> list1 = ReadListFromConsole();

        Console.WriteLine("Введите элементы второго списка через пробел:");
        List<int> list2 = ReadListFromConsole();

        List<int> mergedList = MergeLists(list1, list2);

        List<int> sortedList = SortDescending(mergedList);

        Console.WriteLine("Объединённый список, отсортированный по убыванию:");
        Console.WriteLine(string.Join(", ", sortedList));
    }

    static List<int> ReadListFromConsole()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        List<int> list = new List<int>();

        foreach (string part in parts)
        {
            if (int.TryParse(part, out int number))
            {
                list.Add(number);
            }
            else
            {
                Console.WriteLine($"'{part}' не является числом и будет пропущен.");
            }
        }

        return list;
    }

    static List<int> MergeLists(List<int> list1, List<int> list2)
    {
        List<int> mergedList = new List<int>(list1);
        mergedList.AddRange(list2);
        return mergedList;
    }

    static List<int> SortDescending(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                if (list[j] < list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
        return list;
    }
}
