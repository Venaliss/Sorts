using System;

namespace Сортировка_Выбором
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 11, 1, 0, -11, 2, 8, 112, 8, 1, 4, -2, -12 };
            int min;
            int temp;
            for (int i = 0; i < num.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] < num[min])
                    {
                        min = j;
                    }
                }
                temp = num[min];
                num[min] = num[i];
                num[i] = temp;
                min = i;
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]}, ");
            }
            Console.ReadKey();
        }
    }
}
