using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //求質數Prime number、因數、質因數
            //輸入：請使用者輸入一個介於1000~5000 之間的值
            // 輸出：計算小於等於該值的所有質數、因數、質因數
          

        

            //求質數
            Console.WriteLine("請使用者輸入一個介於1000~5000 之間的值");
            int input = int.Parse(Console.ReadLine());
            Console.Write($"{input}以下的質數有:");


            //i 是為了找到input內的所有數 再去判斷
            int j = 1; //檢驗甚麼是質數
            bool b = true; //用布林值找哪些是質數

            for (int i = 1; i <= input; i++) //從1開始判定是否為i質數 
            {
                b = true; //因為四以後 會出現flase跳出迴圈 因此要再給予true

                for (j = i - 1; j>1; j--)    //質數判定法為:若i不能被2~(i-1)整除 則為質數
                {
                    b = (i % j != 0) && b;   //質數判定子b: 若i不能被j整除 則&&後回寫到b
                }

                if (b)//若b為true(i都未被j整除) 則輸出i 
                {
                    { Console.Write($"{i}, "); }   //讓它不會空行
                }
                
            }
            Console.WriteLine("");
            Console.Write($"{input}的因數有");
            for (int i = 1; i <= input; i++)
            {
                //若input被i整除 則輸出i 
                if (input % i == 0)
                { Console.Write($"{i}, "); }
            }
            Console.WriteLine("");
            Console.Write($"{input}的質因數有");
            for (int i = 1; i <= input; i++)
            {
                b = true;
                for (j = i - 1; j > 1; j--)
                {
                    b = (i % j != 0) && b;
                }

                //質因數多一個判斷子 &&當input能被i整除 
                if (b && (i != 1) && (input % i) == 0)
                { Console.Write($"{i}, "); }
            }
            Console.ReadKey();
        }
    }
}
