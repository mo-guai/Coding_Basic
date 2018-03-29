using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*上傳一個，自動加、減、乘、除、算餘數的計算機
            輸入

            請使用者任意輸入兩個正整數輸出

            列印出 { 第一個輸入值}
            + { 第二個輸入值} = { 結果}
            列印出 { 第一個輸入值}
            - { 第二個輸入值} = { 結果}
            列印出 { 第一個輸入值}
            * { 第二個輸入值} = { 結果}
            列印出 { 第一個輸入值} / { 第二個輸入值} = { 結果}
            列印出 { 第一個輸入值} / { 第二個輸入值}
            的餘數是 = { 結果}*/

            Console.WriteLine("請使用者任意輸入第一個正整數");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("請使用者任意輸入第二個正整數");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("兩數相加");
            Console.WriteLine(a + b);

            Console.WriteLine("兩數相減");
            Console.WriteLine(a - b);

            Console.WriteLine("兩數相乘");
            Console.WriteLine(a * b);


            Console.WriteLine("兩數相除");
            Console.WriteLine(a / b);


            Console.WriteLine("兩數相除得餘數");
            Console.WriteLine(a % b);



            Console.ReadKey();

            

            








        }
    }
}
