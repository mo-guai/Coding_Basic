using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //            輸出主選單，選單為教學的單元，至少有三個選單（while, do while, for）
            //輸入1代表觀看while單元
            //     輸入2代表觀看do while單元
            //     輸入3代表觀看for單元
            //     輸入q代表離開程式
            //     讀取使用者輸入值（並進行防呆設計）
            //如果使用者輸入不是1, 2, 3, q 則提示使用者只能輸入1, 2, 3, q
            //     並重複輸出主選單
            //     顯示子選單，並進行教學
            //     直接輸入enter 代表繼續閱讀
            //     輸入q代表回到主選單
            //     需繪製流程圖，並打包上傳


            string input = "0";
            while (input != "q")
            {

                Console.WriteLine(@"輸入1代表觀看while單元
輸入2代表觀看do while單元 
輸入3代表觀看for單元
輸入q代表離開程式");

                input = (Console.ReadLine());


                while (input == "1")
                {
                    Console.WriteLine(@"while單元
while：『當..』 的意思。會根據條件式的真假, 來決定是否執行迴圈內的動作。
也就是說 『當條件式結果為真』 ,就執行迴圈內的動作的意思。若為假, 則不予執行 (跳出迴圈)。
條件運算式：可以是任何結果為布林值的運算式或布林變數。");
                    input = Console.ReadLine();
                    if (input == "q")
                    {
                        input = "0";
                        break;
                    }
                    else
                    { Console.WriteLine("請輸入q離開"); }
                }
                while (input == "2")
                {
                    Console.WriteLine(@"Do whhile單元\n
- 和while 語法類似
- 差別在於它條件判斷是while放在body之後
- 迴圈的內容至少會執行過一次
- do…while的結尾一定要加分號");
                    input = Console.ReadLine();
                    if (input == "q")
                    {
                        input = "0";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("請輸入q離開");
                    }

                }
                while (input == "3")
                {
                    Console.WriteLine(@"for單元\for語句使用最為靈活，
它完全可以取代 while 語句。它的一般形式為:
        for(運算式1；運算式2；運算式3) 語句");
                    input = Console.ReadLine();
                    if (input == "q")
                    {

                        input = "0";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("請輸入q離開");
                    }
                }




                if (input != "1" && input != "2" && input != "3" && input != "q")
                {
                    Console.WriteLine("請輸入選單編號或q離開");
                }

                if (input == "q")
                {
                    break;
                }

            }
        }
    }
}
