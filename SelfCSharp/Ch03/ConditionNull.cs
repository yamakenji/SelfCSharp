using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class ConditionNull
    {
        static void Main(string[] args)
        {
            string str = null;
            string def = "健司";
            Console.WriteLine(str ?? def);
        }
    }
}
