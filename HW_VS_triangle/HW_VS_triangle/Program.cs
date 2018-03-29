using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_triangle
{
    class Program
    {
        static void Main(string[] args)
        {


            //繪製直角三角形，與倒三角形
            //輸入: 請使用者輸入1或 2

            //輸入1代表輸出直角三角形，如下所示(必須使用迴圈印出)

            //﹡

            //﹡ ﹡

            //﹡ ﹡ ﹡

            //﹡ ﹡ ﹡ ﹡

            //﹡ ﹡ ﹡ ﹡ ﹡

            //輸入2代表輸出倒直角三角形，如下所示(必須使用迴圈印出)
            //﹡ ﹡ ﹡ ﹡ ﹡

            //﹡ ﹡ ﹡ ﹡

            //﹡ ﹡ ﹡

            //﹡ ﹡

            //﹡

            Console.WriteLine("請使用者輸入1或 2");
            int input = int.Parse(Console.ReadLine());


            if (input == 1)
            {
                int j = 1;
                int i=1;
                for (int H = 1; H <= 5; H++)
                {
                    for (i = 1; i <= j; i++)  //因為星星是字串所以無法在第一層迴圈裡表示 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                    j = j + 1;
                }
                

            }
            else if(input == 2){
                int j = 1;
                int i = 1;
                for (int H = 1; H <= 5; H--)
                {
                    for (i = 5; i >= j; i--)  //因為星星是字串所以無法在第一層迴圈裡表示  此for迴圈控制橫向的星星幾顆
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine("");

                    j ++;
                }
            }
            Console.ReadKey();
        }
    }
}
