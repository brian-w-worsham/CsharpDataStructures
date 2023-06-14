using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class ProblemsWithNonGenericDS
    {
        internal static void Run() { 
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add(1); arrayList.Add(2); arrayList.Add(3); arrayList.Add(4);

            arrayList.Add("5");
            arrayList.Add("6");

            arrayList.Add(true);
            arrayList.Add(false);

            // non-generic collections are not type safe
            // blows up when it tries to access a non-integer element
            //System.InvalidCastException: 'Unable to cast object of type 'System.String' to type 'System.Int32'.'
            //foreach (int number in arrayList)
            //{
            //    Console.WriteLine(number);
            //}

            // non-generic collections are not performant
            // boxing and unboxing
            // boxing - converting a value type to a reference type
            // unboxing - converting a reference type to a value type
            // boxing and unboxing is expensive
            // boxing and unboxing is not type safe
            // boxing and unboxing is not performant
            // boxing and unboxing is not memory efficient
        }
    }
}
