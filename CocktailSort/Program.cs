using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailSort
{
    class Program
    {
        static void Swap(int[] num, int i, int j)
        {
            int temp;
            temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }
        static void CocktailSort(int[] num)
        {
            int left = 0;
            int right = num.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        Swap(num, i, i + 1);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (num[i - 1] > num[i])
                    {
                        Swap(num, i - 1, i);
                    }
                }
                left++;
            }
            
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 13, -131, 313, 2, 4, 1, 0, 133, 4, -13, 4, 133, 1, 0, 8, 4 };
            CocktailSort(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.ReadKey();
        }
    }
}
