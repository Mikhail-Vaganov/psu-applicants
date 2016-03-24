using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyBox();
        }

        static private void DifferentTypes()
        {
            int i = 1;
            double d = 0.234;
            Guid id = Guid.NewGuid();
            string line = "да, это строка";
            DateTime date = new DateTime(2016, 4, 2);
        }

        static private void IntVarables()
        {
            int a = 2;
            int b = 3;
            int c = 5, d = 6;
            int sum = a + b;
            var result = c - d;

            Console.WriteLine(a);
            Console.WriteLine(a + b);
            Console.WriteLine(sum);
            Console.WriteLine("c = {0}, d = {1}", c, d); Console.WriteLine("result = {0}", result);
            Console.ReadLine();
        }

        static void SameTypes()
        {
            int i = 1; Int32 I = 2;
            double d = 0.1; Double D = 0.5;
            string s = "Hello"; String S = "world!";
            char c = 'c'; Char C = 'C';
            bool b = true; Boolean B = false;

            object foo; Object bar;
        }

        static void IfOperator()
        {
            int a = 1, b = 2;
            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            else
            {
                Console.WriteLine("a<b || a==b");
            }

            if (false)
                Console.WriteLine("false");
            if (true)
                Console.WriteLine("true");
        }

        static void Loops()
        {
            int a = 1, b = 0;

            for (int i = 0; i < 10; i++)
            {
                DoSomething();
            }

            while (true || a > b)
            {
                DoSomething();
            }

            do
            {
                DoSomething();
            }
            while (b < a);

            int[] ints = new int[] { 1, 2, 3, 4 };
            foreach (var i in ints)
            {
                DoSomething();
            }
        }

        static void DoSomething()
        {
            Thread.Sleep(1000);
        }

        static void ReadNumberUntilGuess()
        {
            string answer = "Physics";
            string attempt = "";
            do
            {
                Console.WriteLine("Угадай слово)");
                attempt = Console.ReadLine();
            }
            while (attempt != answer);

            Console.WriteLine("rules!");

            Console.WriteLine();
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }

        static void CompareRandom()
        {
            double benchmark = 3;
            Console.WriteLine("Сравниваем с числом {0}", benchmark);
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                double next = Math.Round(10 * r.NextDouble());
                if (next > benchmark)
                    Console.WriteLine("{0} > {1}", next, benchmark);
                else if (next < benchmark)
                    Console.WriteLine("{0} < {1}", next, benchmark);
                else
                    Console.WriteLine("{0} == {1}", next, benchmark);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }

        static void MoneyBox()
        {
            double carCost = 1000;
            double moneyInBox = 0;
            Random r = new Random();

            Console.WriteLine("Изчанально в копилке находилось: {0} денег", moneyInBox);
            while (moneyInBox < carCost)
            {
                double pocketMoney = 100 * r.NextDouble();
                moneyInBox += pocketMoney;
                Console.WriteLine("Нам дали {0:0.00} карманных денег. Сейчас в копилке: {1:0.00} денег", pocketMoney, moneyInBox);
            }

            Console.WriteLine();
            Console.WriteLine("В копилке: {0:0.00} денег - нам как раз хватит на машину, которая стоит {1} денег", moneyInBox, carCost);

            Console.WriteLine();
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }
    }
}
