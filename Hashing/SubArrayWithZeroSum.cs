using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class SubArraysWithZeroSum
    {
        public List<Range> GetSubArryasWithZeroSum(List<int> input)
        {
            List<Range> subArrayWithZeroSum = new List<Range>();
            Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
            int sum = 0;
            for(var i=0; i<input.Count; i++)
            {
                sum += input[i];
                //If the sum is zero then add the sub array to our output (starting index being 0)
                if (sum == 0)
                {
                    subArrayWithZeroSum.Add(new Range(0, i));
                }
                //If the dictionary already contains the sum, 
                //It means that there is a sub array with zero sum, starting with last index of previous sum map
                if (sumMap.ContainsKey(sum))
                {
                    foreach (var itemIndex in sumMap[sum])
                    {
                        subArrayWithZeroSum.Add(new Range(itemIndex + 1, i));
                    }

                    //Add the new index to the existing list of indexes for 'sum'
                    sumMap[sum].Add(i);
                }
                else
                {
                    //If the sum is not present in the dictionary then create a new entry for sum
                    sumMap.Add(sum, new List<int> { i });
                }
            }
            return subArrayWithZeroSum;
        }

        public void PrintOutput(List<Range> output)
        {
            foreach (var item in output)
            {
                Console.WriteLine("["+item.StartIndex+", "+item.EndIndex+"]\n");
            }
        }

    }


}
