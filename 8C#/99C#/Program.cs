using System;
using System.Collections.Generic;

class Program
{
    // Generic method to sort an array or list
    static void SortArray<T>(T[] array) where T : IComparable<T>
    {
        Array.Sort(array);  // Sort the array
        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }

    static void SortList<T>(List<T> list) where T : IComparable<T>
    {
        list.Sort();  // Sort the list
        Console.WriteLine("Sorted List: " + string.Join(", ", list));
    }

    static void Main()
    {
        // Integer array
        int[] intArray = { 5, 2, 9, 1, 7 };
        SortArray(intArray);

        // String array
        string[] strArray = { "banana", "apple", "cherry" };
        SortArray(strArray);

        // Integer list
        List<int> intList = new List<int> { 10, 3, 7, 1 };
        SortList(intList);

        // String list
        List<string> strList = new List<string> { "dog", "cat", "bird" };
        SortList(strList);
    }
}
