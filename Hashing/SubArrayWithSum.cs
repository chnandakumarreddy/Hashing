using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class SubArrayWithSum
    {
        /// <summary>
        /// Gets the first occurance of subarray with a given sum, returns null otherwise
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Range GetSubArrayWithSum(List<int> input, int inputSum)
        {
            Dictionary<int, int> sumMap = new Dictionary<int, int>();
            int sum = 0;
            for (int i = 0; i < input.Count(); i++)
            {
                sum += input[i];
                if (sum == inputSum)
                    return new Range(0, i);
                if (sumMap.ContainsKey(sum - inputSum))
                {
                    return new Range(sumMap[sum - inputSum], i);
                }
                sumMap[sum] = i;
            }
            return null;
        }
    }
}
