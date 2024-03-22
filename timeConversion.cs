using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Result
    {

        /*{(a!=b ? $"{b+2}" : $"{ b = 3}") }
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            string newTime = s.Substring(0, 8);
            int a = int.Parse(s[0].ToString());
           
            int b = int.Parse(s[1].ToString());
            string newTime2 = $"{(a!=b ? $"{a*10 + b +12}"  : $"{23}")}{newTime[2]}{newTime[3]}{newTime[4]}{newTime[5]}{newTime[6]}{newTime[7]}";
            string newTime3 = "";
            if (s[8] == 'P')
            {
                if (s[0]=='1' && s[1]=='2')
                {
                    return newTime;
                }
                else
                {
                    return newTime2;
                }
                
            }
            else
            {
                if(s[0] == '1' && s[1] == '2')
                {
                    return newTime3 += $"{0}{0}{newTime[2]}{newTime[3]}{newTime[4]}{newTime[5]}{newTime[6]}{newTime[7]}";
                }
                else
                    return newTime;

            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
