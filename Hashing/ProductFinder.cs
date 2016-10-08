using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class ProductFinder
    {
        /// <summary>
        /// CHecks if a pair exists within the array whose product equal to x
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsProductPairAvailable(List<int> input, int product)
        {
            HashSet<int> map = new HashSet<int>();
            //If the input length is less than two, it means no pair can be found
            if (input == null || input.Count() < 2)
                return false;

            for (int i = 0; i < input.Count(); i++)
            {
                //deal zero as a special case
                if (product == 0 && input[i] == 0)
                    return true;

                //Add each item to the hashSet
                map.Add(input[i]);

                //checkif the current element is divsisble by zero,
                //If it is divisible by zero, check if quotient is available inthe hashset
                //if both conditions are true it means we have identitied the pair for product
                if ((product % input[i]) == 0 && (map.Contains(product / input[i])))
                    return true;

            }
            return false;
        }
    }
}
