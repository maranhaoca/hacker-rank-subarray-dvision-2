using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

        public static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }
                count = sum == d ? count += 1 : count;
                sum = 0;
            }

            return count;
        }
    }
}