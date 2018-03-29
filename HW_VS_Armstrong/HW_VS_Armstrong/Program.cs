using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Armstrong數
問題描述：

所謂 " Armstrong數 " 是指一個三位數的整數，其各位數字之立方和等於該數本身。
例如： 153 是一個 Armstrong數，因為 153 = 1 三次方 + 5三次方 + 3三次方 。
試撰寫一程式，判斷是否為 Armstrong數。

輸入說明：
輸入一個三位數正整數。

輸出說明：
是 阿姆斯壯數輸出 Yes ，不是 阿姆斯壯數輸出 No 的訊息。*/

            Console.WriteLine("請輸入一個三位數以判斷是不是阿姆斯壯數");
            int input, a, b, c;
            input = int.Parse(Console.ReadLine());
            a = input / 100; 
            b = input % 100/10;
            c = input % 10;
            Console.WriteLine(input == (a * a * a + b * b * b + c * c * c) ? "是阿姆斯壯數": "不是阿姆斯壯數");

            Console.ReadKey();
            

            
                  





        }
    }
}
