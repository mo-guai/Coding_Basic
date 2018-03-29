using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_palindromic
{
    class Program
    {
        static void Main(string[] args)
        {

            //方法一 持續判斷是否為回文數
            /*     Boolean loop = true;
                while (loop)
                {
                    Console.WriteLine("請輸入一個 5 位數，判斷它是不是回文數。");
                    int input;
                    input = int.Parse(Console.ReadLine());
                    int a, b, c, d, e;
                    a = input / 10000;
                    b = input % 10000 / 1000;
                    c = input % 1000 / 100;
                    d = input % 100 / 10;
                    e = input % 10;

                    if (a == e && b == d)
                    {

                        Console.WriteLine("是回文數。");


                    }
                    else
                    {
                        Console.WriteLine("不是回文數。");
                        loop = true;
                    }
                }


                Console.ReadLine();
            */
            //方法二 詢問後再開始判斷是否為回文數

            
            

            int x = 1;

            while (x == 1)
            {
                Console.WriteLine("請輸入一個 5 位數，判斷它是不是回文數。");
                int input = int.Parse(Console.ReadLine());

                int a, b, c, d, e;
                a = input / 10000;
                b = input % 10000 / 1000;
                c = input % 1000 / 100;
                d = input % 100 / 10;
                e = input % 10;

                if (a == e && b == d)
                {
                    Console.WriteLine("是回文數");
                }
                else
                {
                    Console.WriteLine("不是回文數");
                }

             Console.WriteLine("繼續請輸入1 不繼續請輸入-1");

                x = int.Parse (Console.ReadLine());

            }

            Console.ReadKey();







        }
    }
}
