﻿using System;

namespace SelfCSharp.Ch09.Practice
{
    struct MyStruct
    {
        public string Message;
        public int Value;

        public MyStruct(string message, int value)
        {
            this.Message = message;
            this.Value = value;
        }
    }
    
    public class Practice3
    {
        static void Main(string[] args)
        {
            MyStruct s;
            s.Message = "こんにちは";

            Console.WriteLine(s.Message);
        }     
    }
}