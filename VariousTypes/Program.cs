﻿using System;
using System.Text;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            //float numerofloat = 9.123f;
            //string frase = "this string lol";
            int numeroint = -9;
            uint unsnumeroint = 9u;

            //Console.WriteLine(numerofloat);
            //Console.WriteLine(frase);
            Console.WriteLine(numeroint);
            Console.WriteLine(unsnumeroint);

            //char c1 = '\U+27B3';
            char c1 = '\u00A9';
            char c2 = '\u25C6';
            char c3 = '\u229A';
            
            
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            

        }
    }
}
