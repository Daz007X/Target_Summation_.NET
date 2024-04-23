using System;
using System.Collections.Generic;

namespace target_sum
{
    internal class Target_sum
    {
        private int[] arrayInt;
        private int maximumItemCount;
        private int expectedResult;
        private List<List<List<int>>> comb;
        private List<List<List<int>>> suc_comb;
        public Target_sum(int[] arrayInt, int maximumItemCount, int expectedResult)
        {
            this.arrayInt = arrayInt;
            this.maximumItemCount = maximumItemCount;
            this.expectedResult = expectedResult;
            this.comb = new List<List<List<int>>>();
            this.suc_comb = new List<List<List<int>>>();
            this.generate_combinations();
            this.fillter();
            this.Displaying();
        }

        public void generate_combinations()
        {
            for (int i = 1; i <= maximumItemCount; i++)
            {
                List<List<int>> X = Combinations.GenerateCombinations(this.arrayInt, i);
                this.comb.Add(X);
            }

        }
        public void fillter()
        {
            foreach (var f_comp in this.comb)
            {
                List<List<int>> X = new List<List<int>>();
                foreach (var s_comp in f_comp)
                {
                    int sums = 0;
                    foreach (var t_comp in s_comp)
                    {
                        sums += int.Parse(t_comp.ToString());
                    }

                    if (sums == this.expectedResult)
                    {
                        X.Add(s_comp);

                    }
                }


                suc_comb.Add(X);
            }
        }

        public void Displaying()
        {
            int index = 1;
            foreach (var f_comp in this.suc_comb)
            {
                if (f_comp.Count == 0)
                {
                    Console.WriteLine($"ใช้ทั้งหมด item count = {index} ค่า ตามนี้ : N/A");
                }
                else
                {
                    Console.Write($"ใช้ทั้งหมด item count = {index} ค่า ตามนี้ : ");
                    foreach (var s_comp in f_comp)
                    {
                        Console.Write("[");
                        foreach (var t_comp in s_comp)
                        {
                            Console.Write($"{t_comp.ToString()},");
                        }
                        Console.Write("], ");
                    }

                    Console.WriteLine();
                }
                index++;
            }

        }

    }

}








