using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    public static class ArrayListDemo
    {
        internal static void Run()
        {
            // ArrayList(), ArrayList(int capacity), ArrayList(ICollection c), ArrayList(IEnumerable c)

            ArrayList myList = new();

            myList.Add(123);
            // you can use multiple data types to the arrayList
            myList.Add("Hello");
            myList.Add(123.45);
            myList.Add(true);
            myList.Add(null);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            int firstElement = (int)myList[0];
            string secondElement = (string)myList[1];
            double thirdElement = (double)myList[2];

            myList[4] = "007";
            myList.Insert(5, "Fifth Element");

            myList.Remove("Hello");
            myList.RemoveAt(0);
            myList.RemoveRange(1, 2);

            for(int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"MyList[{i}] = {myList[i]}");
            }

            Console.WriteLine(myList.Capacity);

            Console.WriteLine(myList.Contains("007"));

            object[] myListCopy = new object[myList.Count];

            myList.CopyTo(myListCopy);

            // Array.Sort
            myList.Sort();
            myList.Reverse();

            myList.Clear();
            
        }
    }
}
