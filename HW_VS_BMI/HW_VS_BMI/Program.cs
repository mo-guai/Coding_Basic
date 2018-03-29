using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_BMI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入姓名: ");
            string name = Console.ReadLine();

            Console.Write("請輸入身高cm: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("請輸入體重kg: ");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine(name + ",您的BMI是" + weight / ((height / 100) * (height / 100)));

            Console.ReadKey();
        }
    }
}
