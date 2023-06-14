using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class SortedListDemo
    {
        internal static void Run()
        {
            // Key-value - HashTable vs SortedList

            SortedList sortedList = new SortedList();
            sortedList.Add(1, "One");
            sortedList.Add(5, "Five");
            sortedList.Add(4, "Four");
            sortedList.Add(2, "Two");
            sortedList.Add(3, "Three");

            //sortedList.Add(4, "Four"); // System.ArgumentException: 'Item has already been added. Key in dictionary: '4'  Key being added: '4''

            for(int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Key: " + sortedList.GetKey(i) + " Value: " + sortedList.GetByIndex(i));
                Console.WriteLine(sortedList[i]);
                Console.Write(sortedList.GetKey(i) + ":" + sortedList.GetByIndex(i));
            }

            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine(entry.Key + ": " + entry.Key);
            }

            sortedList.Remove(1);
            sortedList.RemoveAt(3);

            Console.WriteLine("-------------");

            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine(entry.Key + ": " + entry.Key);
            }

            Console.WriteLine(sortedList.Contains(1));
            Console.WriteLine(sortedList.ContainsValue("Four"));
        }
    }
}
