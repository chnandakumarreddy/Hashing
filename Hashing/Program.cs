using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            //GroupShifter gs = new GroupShifter();
            //var input = new List<string>(){"acd", "dfg", "wyz", "yab", "mop",
            //        "bdfh", "a", "x", "moqs"};
            //gs.GetGroupShiftedStrings(input);


            //SubArrayWithZeroSum sZero = new SubArrayWithZeroSum();
            //var input2 = new List<int> { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };
            //sZero.PrintOutput(sZero.GetSubArryasWithZeroSum(input2));

            //SubArrayWithSum saSum = new SubArrayWithSum();
            //var result = saSum.GetSubArrayWithSum(new List<int> { 1, 4, 20, 3, 10, 5 }, 33);
            //Console.WriteLine("["+result.StartIndex+", "+ result.EndIndex+"]");

            //ProductFinder pf = new ProductFinder();
            //Console.WriteLine(pf.IsProductPairAvailable(new List<int> { 10, 20, 9, 40 }, 400));
            //Console.WriteLine(pf.IsProductPairAvailable(new List<int> { 10, 20, 9, 40 }, 190));
            //Console.WriteLine(pf.IsProductPairAvailable(new List<int> { -10, 20, 9, 40 }, -400));

            MissingElements me = new MissingElements();
            me.PrintOutput(me.GetMissingElements(new List<int> { 10, 12, 11, 15 }, 10, 15));

            Console.ReadLine();
        }
    }

}
