using System;
using System.Globalization;
namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        
            Console.WriteLine("pls insert the first real n");
            string a1 = Console.ReadLine();
            float f1 = float.Parse(a1);

            Console.WriteLine("pls insert the second real n");
            string a2 = Console.ReadLine();
            float f2 = float.Parse(a2);

            Console.WriteLine("pls insert the third real n");
            string a3 = Console.ReadLine();
            float f3 = float.Parse(a3);

            Console.WriteLine("pls insert the fourth real n");
            string a4 = Console.ReadLine();
            float f4 = float.Parse(a4);

            //string s1 =$;
            Console.WriteLine($"'{f1,6:f2}'");
            Console.WriteLine($"'{f2,6:f2}'");
            Console.WriteLine($"'{f3,6:f2}'");
            Console.WriteLine($"'{f4,6:f2}'");





            
            
        }
    }
}
