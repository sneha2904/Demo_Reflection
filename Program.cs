using System;
using System.Reflection;

namespace Demo_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo_Reflection");
            Type T = typeof(int);
            Console.WriteLine("Type of Name:{0}", T.Name);
            Console.WriteLine("Full name of type defined:{0}", T.FullName);
            Console.WriteLine("Type of Assembly which it is defined:{0}", T.Assembly);
            Console.WriteLine("Information about Base type:{0}", T.BaseType);
            DynamicReflection_Class1 obj1 = new DynamicReflection_Class1();
            obj1.firstmethod();
            obj1.secondmethod();

        }
    }
}
