using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    class Result
    {

        /*
         * Complete the 'insertionSort1' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY arr
         */

        public static void insertionSort1(int n, List<int> arr)
        {
            List<int> arrNew = new List<int>();
            int changer = arr[n-1];
            for (int i = n-2; i >= 0; i--)
            {
                if(changer < arr[i])
                {
                    arr[i +1] = arr[i];
                    foreach(int item in arr)
                    {
                        Console.Write(item + " ");
                        
                    }
                    Console.WriteLine();
                    if(i == 0)
                    {
                        arr[i] = changer;
                        foreach (int item in arr)
                        {
                            Console.Write(item + " ");

                        }
                        Console.WriteLine();
                    }
                }
               
                else
                {
                    arr[i+1] = changer;
                    foreach(int item in arr)
                        Console.Write(item + " ");
                    break;
                }


            }
            
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.insertionSort1(n, arr);
        }
    }
}
