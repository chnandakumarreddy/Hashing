using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class MissingElements
    {
        /// <summary>
        /// Get all the missing elements from the input list starting from low to high
        /// </summary>
        /// <param name="input"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public List<int> GetMissingElements(List<int> input, int low, int high)
        {
            var output = new List<int>();
            var map = new HashSet<int>();

            foreach (var num in input)
            {
                map.Add(num);
            }

            for (int i = low; i <= high; i++)
            {
                if (!map.Contains(i))
                    output.Add(i);
            }
            return output;
        }

        public void PrintOutput(List<int> output)
        {
            Console.Write("{");
            foreach (var item in output)
            {
                Console.Write(", "+item);
            }
            Console.Write("}");
        }
    }
}
