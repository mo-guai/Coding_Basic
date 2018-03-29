using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Function_gcd_lem
{
    class Program
    {
        enum Keepgoing //練習列舉型別
        {
            Yes = 1, No = 2,
        }
        static void Main(string[] args)
        {


            bool yes = true;
            int gcd = 0;
            int lcm = 0;


            while (yes)
            {
                Console.WriteLine("Please input first number");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Please input second number");
                int b = int.Parse(Console.ReadLine());

                NewMethod(ref gcd, ref lcm, a, b);

                Console.WriteLine($"gcd: {gcd}");
                Console.WriteLine($"lcm: {lcm}");
                Console.WriteLine("=============================================");

                Console.WriteLine("Do you want to continue? Yes = 1  , No =any key");


                int input = int.Parse(Console.ReadLine());
                switch (input)  //練習switch 用法
                {
                    case (int)Keepgoing.Yes:
                        yes = true;
                        break;
                    case (int)Keepgoing.No:
                        yes = false;
                        break;
                    default:
                        break;
                }



            }

            Console.WriteLine("==================結束程式=================");
            Console.ReadKey();

        }

        private static void NewMethod(ref int gcd, ref int lcm, int a, int b)
        {
            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                    lcm = (a * b / gcd);
                }
            }
        }
    }
}
