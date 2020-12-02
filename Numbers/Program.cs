using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Sum(numbers);
            Compare(numbers);
            Console.ReadKey();
        }

        static void Compare(Numbers numbers)
        {

            if (numbers.Num1 > numbers.Num2)
            {
                Console.WriteLine("Первая переменная больше");
            }
            else if (numbers.Num1 < numbers.Num2)
            {
                Console.WriteLine("Вторая переменная больше");
            }
            else
            {
                Console.WriteLine("Первая и вторая переменная равны");
            }
        }

        static void Sum(Numbers numbers)
        {
            Console.WriteLine("Введите первое значение");
            numbers.Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            numbers.Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numbers.Num1} + {numbers.Num2} = { numbers.Num1 + numbers.Num2} ");
        }
    }
}
