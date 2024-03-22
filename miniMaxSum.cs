namespace Test1
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long maximumSum = 0;
            arr.Sort();
            for (int i = 0; i < arr.Count; i++)
            {
                maximumSum += arr[i];
            }
            Console.WriteLine($"{maximumSum - arr[arr.Count - 1]}" +" "+ $"{ maximumSum - arr[0]}");
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
