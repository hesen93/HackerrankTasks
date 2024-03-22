using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Result
    {

        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void staircase(int n)
        {
            char space = ' ';
            char sharp = '#';
            for (int i = 0; i < n; i++)
            {
                int spaceCounter = n - (i + 1);
                int sharpCounter = i + 1;
                string ladder = new string(space, spaceCounter) + new string(sharp, sharpCounter);
                Console.WriteLine(ladder);
            }

        }

        public static void staircase2(int n)
        {
            string template = new string(' ', n);
            for (int i = 0; i < n; i++)
            {
                var response = template.Substring(i, template.Length - (i + 1)) 
                                                 + new string('#', i + 1);
                Console.WriteLine(response);
            }
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }
    }

}
