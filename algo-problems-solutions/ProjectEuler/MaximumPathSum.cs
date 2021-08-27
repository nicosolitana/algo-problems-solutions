using algo_problems_solutions.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace algo_problems_solutions.ProjectEuler
{
    class MaximumPathSum
    {
        private static List<List<int>> GetIntList()
        {
            List<List<int>> valueLst = new List<List<int>>();
            List<string> inputs = Util.FileReading("max_path_sum.txt");

            foreach (string i in inputs)
            {
                string[] value = i.Split(' ');
                valueLst.Add(value.Select(v => Convert.ToInt32(v)).ToList<int>());
            }
            return valueLst;
        }


        private static double GetSum()
        {
            double sum = 0;
            int i = 0;
            List<List<int>> valueLst = GetIntList();
            foreach (List<int> v in valueLst)
            {
                if (v.Count() == 1)
                    sum += v[i];
                else
                {
                    Console.WriteLine(v[i] + "   " + v[i + 1]);
                    if (v[i] > v[i + 1])
                        sum += v[i];
                    else
                    {
                        sum += v[i + 1];
                        i++;
                    }
                }
            }
            return sum;
        }

        public static void init()
        {
            Console.WriteLine("Maximum Path Sum is " + GetSum());
            Console.ReadLine();
        }
    }
}
