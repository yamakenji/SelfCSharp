using System;

namespace SelfCSharp.Ch05
{
    class StrSplit
    {
        static void Main(string[] args)
        {
            var str1 = "うめ,もも,さくら";
            var result1 = str1.Split(',');
            System.Console.WriteLine(string.Join("&", result1));

            var str2 = "うめ,もも,さくら|あんず";
            var result2 = str2.Split(',', '|');
            System.Console.WriteLine(string.Join("&", result2));

            var str3 = "うめ もも\nさくら\nあんず";
            var result3 = str3.Split();
            System.Console.WriteLine(string.Join("&", result3));
            
            var str4 = "うめ,もも,さくら,あんず";
            var result4 = str4.Split(new[] {','}, 3);
            System.Console.WriteLine(string.Join("&", result4));
          
            var str5 = "うめ\tもも\tさくら\tあんず";
            var result5 = str5.Split(new[] {'\t'}, StringSplitOptions.RemoveEmptyEntries);
            System.Console.WriteLine(string.Join("&", result5));

            var result6 = str5.Split(new[] { '\t' });
            System.Console.WriteLine(string.Join("&", result6));

        }
    }
}