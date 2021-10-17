using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Введите число > 0");
            int n = Convert.ToInt32(Console.ReadLine());
            int n_2 = 0;
            for (int i = 1; i <= (2 * n - 1); i += 2)

            {

                n_2 += i;

            }

            Console.WriteLine("Квадрат числа {0} равен {1}", n, n_2);
            Console.ReadKey();


        }
    }
}
