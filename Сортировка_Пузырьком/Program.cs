using System;

namespace Сортировка_Пузырьком
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {0 , 2, 1, -9, 8, 7, 3, 9 };
            int temp;

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j+1])
                    {
                        temp = num[j+1];
                        num[j+1] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
