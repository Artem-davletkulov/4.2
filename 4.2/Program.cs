using System;


namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите значение индекса {i}: ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
               if (mas[i] % 2 == 0)
               {
                    k++;
               }
                Console.WriteLine("Число: " +mas[i]);
                Console.WriteLine("Кол-во четных чисел: " +k);
                Console.ReadLine();
            }
           

        }
    }
}
