using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class UnderstandGenerics
    {
        internal static void Run()
        {
            Console.WriteLine(Calculator.AreEqual(10, 20));
            // cannot convert from 'string' to 'int'
            Console.WriteLine(Calculator.AreEqual("10", "20"));
            Console.WriteLine(Calculator.AreEqual(10, "10"));

            Console.WriteLine(Calculator.AreEqual<int>(10, 10));
            Console.WriteLine(Calculator.AreEqual<string>("10", "10"));
        }
    }

    internal class Calculator
    {
        // overloading methods to handle different types of parameters can become a maintenance nightmare
        public static bool AreEqual(int value1, int value2)
        {
            return value1.Equals(value2);
        }

        public static bool AreEqual(string value1, string value2)
        {
            return value1.Equals(value2);
        }

        public static bool AreEqual(int value1, string value2)
        {
            return value1.Equals(int.Parse(value2));
        }

        // GENERIC
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        // Generics can be used with classes, interfaces, methods, delegates, and events
        // Generics are used to create type-safe data structures
        // Generics are used to create type-safe algorithms
        // Generics are used to create type-safe collections
        // Generics are used to create type-safe classes
        // Generics are used to create type-safe interfaces
        // Generics are used to create type-safe methods
        // Generics are used to create type-safe delegates
        // Generics are used to create type-safe events
        // Generics provide improved re-usability
        // Generics provide improved performance because boxing and unboxing is not required
    }


    internal class MyGenericClass<T1, T2>
    { 
    }

    internal class MyGenericClassTwo<T1>
    {
    }
}
