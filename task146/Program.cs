using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(100);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nВведите цифру k: ");
            int k = int.Parse(Console.ReadLine());

            int[] newArray = new int[arr.Length];
            int count = 0;

            foreach (int element in arr)
            {
                if (element % 10 == k)
                {
                    newArray[count] = element;
                    count++;
                }
            }

            Console.WriteLine("Элементы исходного массива, оканчивающиеся на цифру k:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
