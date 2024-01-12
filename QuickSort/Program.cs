using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static int Partition(int[] arrayTarget, int start, int end)
        {
            int value = arrayTarget[end];
            int position = start;

            for (int i = start; i < end; i++)
            {
                if (arrayTarget[i] <= value)
                {
                    int temp = arrayTarget[i];
                    arrayTarget[i] = arrayTarget[position];
                    arrayTarget[position] = temp;
                    position++;
                }
            }
            arrayTarget[end] = arrayTarget[position];
            arrayTarget[position] = value;
            return position;
        }

        static void QuickSort(int[] array, int start, int end)
        {
            if(start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }
        
        static void Main(string[] args)
        {
            int[] num = { 0, -12, 213, 1, 133, -32, 1, 33, 5, 7, 3,-12121, 21, 6, 424, 754, 203 };
            QuickSort(num, 0, num.Length-1);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.ReadKey();
        }
    }
}
