using System;

namespace Generics_1
{
    class MyClass<T>
    {
        public static MyClass<T> FactoryMethod()
        {
            return new MyClass<T>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = MyClass<int>.FactoryMethod();
            var value2 = MyClass<string>.FactoryMethod();

            Console.ReadLine();
        }
    }
}
