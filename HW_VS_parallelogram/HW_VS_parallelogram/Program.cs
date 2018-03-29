using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_parallelogram
{
    class Program
    {
        static void Main(string[] args)
        {

//繪製平行四邊形
//輸入: 讓使用者輸入一個數字 n。
//輸出: n* n 的平行四邊形，請使用空白鍵與* 進行輸出。

            Console.WriteLine("讓使用者輸入一個數字 n");
            int n = int.Parse(Console.ReadLine());
            int j = 1;
            int i = 1;
            for (int H = 1; H <= n; H++)
            {
                for (i = n; i >= j; i--)  //因為星星是字串所以無法在第一層迴圈裡表示  此for迴圈控制橫向的星星幾顆
                {
                    Console.Write(" ");
               
                }

                for (i = n; i >= 1; i--)  //因為星星是字串所以無法在第一層迴圈裡表示  此for迴圈控制橫向的星星幾顆
                {
                    Console.Write("*");

                }

                Console.WriteLine("");
                j++;
            }


        Console.ReadKey();

        }
    }
}
