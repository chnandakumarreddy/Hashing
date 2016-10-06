using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class GroupShifter
    {
        private readonly int MAX_ALPHA = 26;

        public void GetGroupShiftedStrings(List<string> input)
        {
            //Maintain a hashtable that contains all the strings of same group under string difference key
            Dictionary<string, List<string>> differenceMapper = new Dictionary<string, List<string>>();

            //loop through the items in the input
            //calculate the differnceString
            //If differenceString is alredy available in the dictionary then the string to the existing list
            //If not found add the key and list to the dictionary
            foreach (var item in input)
            {
                var diffString = GetStringDifference(item);
                if (differenceMapper.ContainsKey(diffString))
                {
                    differenceMapper[diffString].Add(item);
                }
                else
                {
                    differenceMapper.Add(diffString, new List<string>() { item });
                }
            }

            //By this step, all the strings were grouped
            foreach (var entry in differenceMapper.Values)
            {
                Console.WriteLine("\n New Group \n");
                foreach (var item in entry)
                {
                    Console.Write(item + " ");
                }
            }
        }
        /// <summary>
        /// Returns the difference of the string as another string.
        /// If input is adf then first difference is 3 and second difference is 1, so the return string is "cb"
        /// So the differnce string length will be always one less than the original string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string GetStringDifference(string str)
        {
            string diffString = string.Empty;
            for (int i = 1; i < str.Length; i++)
            {
                int dif = str[i] - str[i - 1];
                if (dif < 0)
                    dif += MAX_ALPHA;
                diffString += ((char)(dif + 'a'));
            }
            return diffString;
        }
    }
}
