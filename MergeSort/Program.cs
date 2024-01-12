using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1, -2, 4, 2, -9, 0, 10, 3, -7 };
            MergeSort(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.ReadKey();
        }
        static void Merge(int[] arrayTarget, int[] array1, int[] array2)
        {
            int array1MinInd = 0;
            int array2MinInd = 0;
            int arrayTargetMinINd = 0;

            while (array1MinInd < array1.Length && array2MinInd < array2.Length)
            {
                if (array1[array1MinInd] < array2[array2MinInd])
                {
                    arrayTarget[arrayTargetMinINd] = array1[array1MinInd];
                    array1MinInd++;
                }
                else
                {
                    arrayTarget[arrayTargetMinINd] = array2[array2MinInd];
                    array2MinInd++;
                }
                arrayTargetMinINd++;
            }
            while(array1MinInd < array1.Length)
            {
                arrayTarget[arrayTargetMinINd] = array1[array1MinInd];
                array1MinInd++;
                arrayTargetMinINd++;
            }
            while(array2MinInd < array2.Length)
            {
                arrayTarget[arrayTargetMinINd] = array2[array2MinInd];
                array2MinInd++;
                arrayTargetMinINd++;
            }
        }
        static void MergeSort(int[] array)
        {
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            if (array.Length < 2)
            {
                return;
            }

            for(int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }
            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }
    }
}
