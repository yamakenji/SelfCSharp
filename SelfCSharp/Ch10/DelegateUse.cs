using System;

namespace SelfCSharp.Ch10
{
    delegate void OutputProcess(string str);
    
    public class DelegateUse
    {
        void ArrayWaik(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        static void AddQuote(string data)
        {
            Console.WriteLine($" [{data}] ");
        }

        static void AddComma(string data)
        {
            Console.WriteLine($" '{data}' ");
        }

        static void Front4(string data)
        {
            Console.WriteLine(data.Substring(0, 4));
        }

        static void Main(string[] args)
        {
            var data = new[] {"あかまきがみ", "あおまきがみ", "きまきがみ"};
            var du = new DelegateUse();
            var c = new Counter();
            OutputProcess proc1 = AddQuote;
            proc1 += Front4;
            OutputProcess proc2 = AddComma;
            du.ArrayWaik(data, proc1);
            du.ArrayWaik(data, proc2);
            du.ArrayWaik(data, c.AddLength);
            Console.WriteLine(c.Result);
        }
    }

    class Counter
    {
        public int Result { get; private set; }

        public void AddLength(string value)
        {
            Result += value.Length;
        }
    }
}