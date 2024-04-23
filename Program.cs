using System;

namespace target_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int maximumItemCount = 5;
            int expectedResult = 200;


            Target_sum target_sum = new Target_sum(arrayInt, maximumItemCount, expectedResult);

            Console.ReadKey();


        }
    }
}
