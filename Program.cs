using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    internal class Program
    {
        static void CountingSort(int [] arr)
        {
            int[] count = new int[arr.Max()+1];
            //Console.WriteLine(string.Join(" ", count));
            foreach (int i in arr)
            {
                count[i] = count[i]+1;
            }
            //Console.WriteLine(string.Join(" ", count));
            for (int i=1;i<count.Length;i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            //Console.WriteLine(string.Join(" ", count));
            int[] result = new int[arr.Length];
            for(int i=arr.Length-1;i>=0;i--)
            {
                count[arr[i]] = count[arr[i]] - 1;
                result[count[arr[i]]] = arr[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
        static void Main(string[] args)
        {
            CountingSort(new int[] { 1, 3, 5, 3, 2, 8, 6, 7 });
            CountingSort(new int[] { 2, 6, 5, 4, 10, 20, 1, 2, 0 });
            Console.ReadLine();
        }
    }
}
