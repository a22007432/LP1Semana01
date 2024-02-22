using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 ="Isto é um string wow \u058D\u058D\u058D\u058D";
            string s2 ="Isto é outro string \u1368";
            string s3 ="Olha mais um, mas este é triste";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
