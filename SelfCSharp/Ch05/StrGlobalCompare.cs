using System;
using System.Globalization;

namespace SelfCSharp.Ch05
{
  class StrGlobalCompare
  {
    static void Main(string[] args)
    {
        var full = "ＷＩＮＧＳ";
        var half = "WINGS";

        var ci = CultureInfo.CurrentCulture.CompareInfo;
        Console.WriteLine(ci.Compare(full, half));
        Console.WriteLine(ci.Compare(full, half, CompareOptions.IgnoreWidth));

        var hiragana = "ぷろじぇくと";
        var katakana = "プロジェクト";
        Console.WriteLine(ci.Compare(hiragana, katakana));
        Console.WriteLine(ci.Compare(hiragana, katakana, CompareOptions.IgnoreKanaType));
    }
  }
}