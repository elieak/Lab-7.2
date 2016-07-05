using System;

namespace GenericApp
{
    internal class Program
    {
        private static void Main()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };

            DisplayDictionary(multiDictionary);

            Console.WriteLine("\nRemove (1, one) using remove key, value: ");
            multiDictionary.Remove(1, "one");
            DisplayDictionary(multiDictionary);

            multiDictionary.Remove(2);
            Console.WriteLine("\nRemove (2) using the remove key: ");
            DisplayDictionary(multiDictionary);

            multiDictionary.Add(2, "nee");
            Console.WriteLine("\nAdded (2, nee) using the add key, value: ");
            DisplayDictionary(multiDictionary);

            multiDictionary.Clear();
            Console.WriteLine("\nUsed the Clear method: ");
            DisplayDictionary(multiDictionary);

        }

        private static void DisplayDictionary(MultiDictionary<int, string> multiDictionary)
        {
            if (multiDictionary.Count != 0)
                foreach (var key in multiDictionary)
                    foreach (var value in key.Value)
                        Console.WriteLine($"Key: {key.Key}, Value: {value}");
            else
                Console.WriteLine("The Dictionary has been cleared and is now Empty.");
        }
    }
}
