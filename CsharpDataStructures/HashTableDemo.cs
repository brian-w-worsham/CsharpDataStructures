using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class HashTableDemo
    {
        internal static void Run() 
        {
            ArrayList myList = new ArrayList();

            myList.Add(100001);
            myList.Add("John");
            myList.Add("Doe");
            myList.Add("123 Main St");
            myList.Add("Atlanta");
            myList.Add("GA");
            myList.Add("30303");
            myList.Add("IT");
            myList.Add("abc.gmail.com");

            // HashTables = key /value pairs

            Hashtable hashtable = new Hashtable();

            hashtable.Add("EmployeeNumber", 100001);
            hashtable.Add("FirstName", "John");
            hashtable.Add("LastName", "Doe");
            hashtable.Add("Address", "123 Main St");
            hashtable.Add("City", "Atlanta");
            hashtable.Add("State", "GA");
            hashtable.Add("Zip", "30303");
            hashtable.Add("Department", "IT");
            hashtable.Add("Email", "abc.gmail.com");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine($"Key: {item} Value: {hashtable[item]}");
                Console.WriteLine("--------------------");
            }

            // The DictionjaryEntry type allows us to use key and value properties which is easier to read
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");
                Console.WriteLine("--------------------");
            }

            // check if the key email exists in the hashtable
            Console.WriteLine(hashtable.Contains("Email"));
            if (hashtable.ContainsKey("Email"))
            {
                Console.WriteLine("Email exists in the hashtable");
            }
            else
            {
                Console.WriteLine("Email does not exist in the hashtable");
            }

            // check if the value abc.gmail.com exists in the hashtable
            Console.WriteLine(hashtable.ContainsValue("abc.gmail.com"));

            hashtable.Remove("Email");

            hashtable["Zip"] = "30303";

            Console.WriteLine(hashtable.IsReadOnly);
            Console.WriteLine(hashtable.IsFixedSize);
            Console.WriteLine(hashtable.Values);
            Console.WriteLine(hashtable.Keys);
            Console.WriteLine(hashtable.Count);

            hashtable.Clear();
        }
    }
}
