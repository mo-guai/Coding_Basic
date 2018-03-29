using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Random_cashbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Random a = new Random();
            int b = a.Next(0, 100);
            int win = 0;
            while (win==0)
            
            {
                Console.WriteLine("請猜測0-100間的數字");
                int input = int.Parse(Console.ReadLine());
                if (input == b)
                {
                    count++;
                    Console.WriteLine("恭喜!答對了");
                    win = 1;

                }
                if (input > b)
                {
                    count++;
                    Console.WriteLine($"你猜的數字太大了，目前共猜{count}次");
                }
                if (input < b)
                {
                    count++;
                    Console.WriteLine($"你猜的數字太小了，目前共猜{count}次");
                } 
                
            }
            Console.ReadKey();

        }
    }
}
