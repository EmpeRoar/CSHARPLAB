using DelegateLab;
using System;
using System.Collections.Generic;

namespace LAMBDAEXPRESSIONS
{
    delegate void MeDelegate();
    delegate bool OperatorDelegate(int n);
    delegate decimal SalaryDelegate(decimal range);
    class Program
    {
        static decimal Calculate(decimal salary)
        {
            decimal discount;
            if (salary <= 50.00m)
            {
                discount = (salary * (decimal)0.25);
                salary = salary - discount;
                return salary;
            }
            if (salary <= 100.00m)
            {
                discount = (salary * (decimal)0.5);
                salary = salary - discount;
                return salary;
            }
            return salary;
        }

        static decimal CalculateAmerican(decimal salary)
        {
            decimal discount;
            if (salary <= 25.00m)
            {
                discount = (salary * (decimal)0.25) + 40;
                salary = salary - discount;
                return salary;
            }
            if (salary <= 40.00m)
            {
                discount = (salary * (decimal)0.5) + 400;
                salary = salary - discount;
                return salary;
            }
            return salary;
        }

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

            IEnumerable<int> results = RunThroughNumbersPipe(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 50, 18 }, x => x > 13);
            foreach (int n in results)
                Console.WriteLine(n);

            Console.WriteLine("------------------------");

            decimal[] salaries = { 50.00m, 100.00m };
            IEnumerable<decimal> salaryResults = RunThroughSalaryPipe(salaries, Calculate);
            foreach (decimal salary in salaryResults)
                Console.WriteLine(salary);

            Console.ReadKey();

        }

        static void InvokeDelegate(MeDelegate delegater)
        {
            Console.WriteLine("I will excute the function: InvoiceDelegate");
            delegater();
        }

                                                                                // x => x < 5                    
        static IEnumerable<int> RunThroughNumbersPipe(IEnumerable<int> numbers, OperatorDelegate code)
        {
            foreach (int number in numbers)
            {
                if (code(number))
                    yield return number;
            }
        }

        static IEnumerable<decimal> RunThroughSalaryPipe(IEnumerable<decimal> salaries, SalaryDelegate computation)
        {
            foreach (int salary in salaries)
            {
                yield return computation(salary);
            }
        }

    }
}
