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
            GroupShifter gs = new GroupShifter();
            var input = new List<string>(){"acd", "dfg", "wyz", "yab", "mop",
                    "bdfh", "a", "x", "moqs"};
            gs.GetGroupShiftedStrings(input);
            Console.ReadLine();
        }
    }

}
