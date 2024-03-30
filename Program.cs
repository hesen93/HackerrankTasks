//List<List<int>> arr = new List<List<int>>();
//arr.Add([6, 6, 4]);
//arr.Add([2, 4, 5]);
//arr.Add([2, 4, 5]);
//int diagonal1 = 0;
//int diagonal2=0;
//for (int i = 0; i <= arr.Count-1; i++)
//{
//    diagonal1 += arr[i][i];
//    diagonal2 += arr[(arr.Count - 1) - i][i];
//}
////Console.WriteLine(Math.Abs(diagonal1 - diagonal2));

//    class Result
//{

//    /*
//     * Complete the 'plusMinus' function below.
//     *
//     * The function accepts INTEGER_ARRAY arr as parameter.
//     */

//    public static void plusMinus(List<int> arr)
//    {
//        decimal positiveElements = 0;
//        decimal negativeElements = 0;
//        decimal zeroElements = 0;
//        for (int i = 0;i <= arr.Count-1;i++)
//        {
//            if (arr[i] > 0)
//                positiveElements++;
//            else if (arr[i] < 0)
//                negativeElements++;
//            else if ((arr[i] == 0))
//                zeroElements++;
//        }
//        decimal positiveProportion = positiveElements / (arr.Count);
//        decimal negativeProportion = negativeElements / (arr.Count);
//        decimal zeroProportion = 0;
//        if (negativeElements != 0)
//            zeroProportion = zeroElements / (arr.Count);
//        Console.WriteLine(positiveProportion);
//        Console.WriteLine(negativeProportion);
//        Console.WriteLine(zeroProportion);
//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//        Result.plusMinus(arr);
//    }
//}

using System.Text;

//using Test3;
using Test4;

//Result.staircase2(8);
//string a = "10:56:48PM";
//Console.WriteLine(Result.timeConversion(a));
List<int> list = new List<int>();
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(10);
list.Add(1);
Result.insertionSort1(10, list);