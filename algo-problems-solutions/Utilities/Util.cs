using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace algo_problems_solutions.Utilities
{
    class Util
    {
        public static List<string> FileReading(string path)
        {
            List<string> lines = new List<string>();
            using (StreamReader file = new StreamReader(path))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    lines.Add(ln);
                }
                file.Close();
            }
            return lines;
        }
    }
}
