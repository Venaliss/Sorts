using System;

namespace Сортировка_Вставками
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 1331, -12, 122, 0, -111, 123, 7 };
            int index;
            int currentNumber;
            for (int i = 0; i < num.Length; i++)
            {
                index = i;
                currentNumber = num[i];
                while (index > 0 && currentNumber < num[index - 1])
                {
                    num[index] = num[index - 1];
                    index--;
                }
                num[index] = currentNumber;
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.ReadKey();
        }
    }
}
