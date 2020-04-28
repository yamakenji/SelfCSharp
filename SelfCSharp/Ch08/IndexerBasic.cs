﻿using System;

namespace SelfCSharp.Ch08
{
    class FreeArray
    {
        private int _size;
        private int[] _list;
        
        // コンストラクタ
        public FreeArray(int size)
        {
            this._size = size;
            this._list = new int[size];
        }
        
        // インデクサー
        public int this[int index]
        {
            set
            {
                this._list[this.GetIndex(index)] = value;
            }

            get
            {
                return this._list[this.GetIndex(index)];
            }
        }
        
        // index値を再計算するprivateメソッド
        private int GetIndex(int index)
        {
            if (index < 0)
            {
                return 0;
            }

            return index % this._size;
        }
    }
    class IndexerBasic
    {
        static void Main(string[] args)
        {
            var array = new FreeArray(5);
            array[0] = 1;
            array[1] = 10;
            array[2] = 15;
            array[3] = 30;
            array[4] = 60;

            Console.WriteLine(array[2]);
            Console.WriteLine(array[-10]);
            Console.WriteLine(array[6]);
        }   
    }
}