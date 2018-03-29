using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Array
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] grade = new int[1];


            int num, count = 1;
            Console.WriteLine("輸入一個正整數 n，輸入 n 個整數 (0 < n < 2147483647) 或輸入-1計算結果");
            num = int.Parse(Console.ReadLine());
            grade[0] = num;
            do
            {
                Console.WriteLine("輸入一個正整數 n，輸入 n 個整數 (0 < n < 2147483647) 或輸入-1計算結果");
                num = int.Parse(Console.ReadLine());
                if (num != -1)
                {
                    Array.Resize(ref grade, grade.Length + 1);//讓陣列空間變大
                    grade[count++] = num;
                }
            } while (num != -1); /*while 是false就往下走  */


            //Console.WriteLine("依輸入順序顯示陣列內容");
            //for (int i = 0; i < count; i++)
            //    Console.WriteLine(grade[i]);


            Console.WriteLine("Length");
            Console.WriteLine(grade.Length);

            Console.WriteLine("Maximum");

            int max = grade[0];//先讓max為陣列的第一個數值
            for (int i = 0; i < count; i++)
            {
                if (max < grade[i])
                { max = grade[i]; }
            }
            Console.WriteLine($"{max}");

            Console.WriteLine("Minimun");

            int min = grade[0]; //先讓min為陣列的第一個數值
            for (int i = 0; i < count; i++)
            {
                if (min > grade[i])
                { min = grade[i]; }
            }
            Console.WriteLine($"{min}");


            Console.WriteLine("Mean");
            float sum = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                sum += grade[i];
            }

            float mean = sum / grade.Length;

            Console.WriteLine($"{mean}");
            Console.ReadKey();
        }
    }
}
