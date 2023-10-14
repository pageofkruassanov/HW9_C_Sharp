using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1:

            const int size = 10;
            Array<int> firstArr = new Array<int>(size);
            for (int i = 0; i < size; i++)
            {
                firstArr[i] = i + 1;
            }
            Console.WriteLine("Массив из 10 чисел: ");
            foreach (int i in firstArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nКол-во чисел массива, больше 3-ех: {firstArr.Greater(3)}");
            Console.WriteLine($"Кол-во чисел массива, меньше 3-ех: {firstArr.Less(3)}");
            Console.ReadLine();

            // Task 2:

            Console.WriteLine("\nПарные значения массива: ");
            firstArr.ShowEven();
            Console.WriteLine("\nНе парные значения массива: ");
            firstArr.ShowOdd();
            Console.ReadLine();
        }
    }
}
