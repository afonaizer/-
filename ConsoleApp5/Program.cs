using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание1
            //int[] mass = new int[8];
            //for(int i=0;i<8;i++)
            //{
            //    Console.Write($"mass[{i}]=");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<8;i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}

            //задание 2
            //double[] mass = new double[8] { -1.6, 5.97, 52, -69.8, 1.5, 1.35, 6, 92 };
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] > 0)
            //    {
            //        Console.WriteLine(mass[i]);
            //    }
            //}

            //задание 3
            //int[] mass = new int[6] { -6, 10, 12, 16, -8, 18 };
            //int n = mass.Length;
            //int k = n / 2;
            //int temp;
            //for (int i = 0; i < k; i++)
            //{
            //    temp = mass[i];
            //    mass[i] = mass[n - i - 1];
            //    mass[n - i - 1] = temp;
            //}
            //foreach (int i in mass)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //задание 4
            //Random random = new Random();
            //int h = 12;
            //int[] mass = new int[h];
            //for (int i = 0; i < h; i++)
            //{
            //    mass[i] = random.Next(163, 190);
            //}
            //foreach (int elem in mass)
            //{
            //    Console.WriteLine("{0}", elem);
            //}
            Console.ReadKey();
        }
    }
}
