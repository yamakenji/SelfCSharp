using System;

namespace SelfCSharp.Ch08
{
    class JapaneseMonth
    {
        // 月の名前
        private string[] _month = {"睦月", "如月", "弥生", "卯月", "皐月", "水無月", "文月", "葉月", "長月", "神無月", "霜月", "師走"};
        
        // 和名をキーに月番号を取得するインデクサー
        public int this[string name]
        {
            get
            {
                return Array.IndexOf(this._month, name) + 1;
            }
        }
    }
    
    public class IndexerString
    {
        static void Main(string[] args)
        {
            var mon = new JapaneseMonth();
            Console.WriteLine(mon["卯月"]);
        }    
    }
}