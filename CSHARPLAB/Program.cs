using DelegateLab;
using System;
using System.Collections.Generic;

namespace CSHARPLAB
{

    delegate void MeDelegate();
    delegate bool OperatorDelegate(int n);
    class Program
    {
        static bool LessThanFive(int n) { return n < 5;  }
        static bool LessThanTen(int n) { return n < 10; }
        static bool LessGreaterThirteen(int n) { return n > 13; }
        static void Main(string[] args)
        {
            DelegateLabClass delegateLab = new DelegateLabClass();
            MeDelegate del = new MeDelegate(delegateLab.Foo);            
            del();


            MeDelegate del2 = delegateLab.Foo;
            del2();

            InvokeDelegate(del2);
            InvokeDelegate(delegateLab.Goo);

            Console.WriteLine("------------------------");

            IEnumerable<int> results = RunThroughNumbersPipe(new[] { 1,2,3,4,5,6,7,8,9,10,13,50,18 }, LessGreaterThirteen);
            foreach (int n in results)
                Console.WriteLine(n);
            
            Console.ReadKey();

        }

        static void InvokeDelegate(MeDelegate delegater)
        {
            Console.WriteLine("I will excute the function: InvoiceDelegate");
            delegater();
        }

        static IEnumerable<int> RunThroughNumbersPipe(IEnumerable<int> numbers, OperatorDelegate code )
        {
            foreach (int number in numbers)
            {
                if (code(number))
                    yield return number;
            }
        }

    }
}
