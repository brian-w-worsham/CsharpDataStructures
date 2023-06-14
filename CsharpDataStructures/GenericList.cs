using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class GenericList
    {
        internal static void Run() 
        {
            List<string> names = new List<string>();
            names.Add("James Bond");
            names.Add("Jason Bourne");

            //names.Add(1);
            //names.Add(true);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
