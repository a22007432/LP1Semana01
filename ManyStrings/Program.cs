using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;


            string s1 ="Isto é um string wow \u058D\u058D\u058D\u058D";
            string s2 ="Isto é outro string \u1368";
            string s3 ="Olha mais um, mas este é triste";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            char x = '\u113D';

            string s4 = "oh look: ->" + x + "a mountain!";
            string s5 = $"oh look!:-> {x}{x}{x}{x}{x} a mountain range!";

            Console.WriteLine(s4);
            Console.WriteLine(s5);

            string s6 = $"xx={xx,2:f}";
            string s7 = $"xx={xx,1:p}";
            //n percebo

            Console.WriteLine(s6);
            Console.WriteLine(s7);

            string s8 = $"ii={ii:x}";
            string s9 = $"ii={ii:c}";
            Console.WriteLine(s8);
            Console.WriteLine(s9);
        }

    }
}
