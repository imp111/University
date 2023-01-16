using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 5:  Дефинирайте метод, който да извършва определено действие и го извикате в Main().

namespace exercise5
{
    class Program
    {
        public static int Action(int num)
        {
            return num * num;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Squared value of {0} is {1}", input, Action(input));
        }
    }
}
