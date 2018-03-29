using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Drinking_games
{
    class Program
    {
        public enum whofirst
        {
            player,
            computer,
        }

        static void Main(string[] args)
        {
            int count = 0;
            Random random = new Random();
            whofirst speaker = whofirst.player;
            speaker = (whofirst)random.Next(0, 2);

            while (count!=2)
            {
             
                while (speaker == whofirst.player && count!=2)
                {
                    //玩家輸入
                    
                    Console.WriteLine(@" 
================================================
現在你喊猜測結果 
請輸入三個數字分別代表 左拳 右拳 及 猜測雙方總和");
                    int[] player = new int[3];

                    for (int i = 0; i < 3; i++)
                    {
                        player[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(""); 
                    int[] com = new int[2];
                    Random ran = new Random();

                    for (int i = 0; i < 2; i++)
                    {   int computer = ran.Next(0, 2);
                        computer = computer * 5;
                        com[i] = computer;}
                    Console.WriteLine($"{com[0]}\n{com[1]}");

                    if (com[0] + com[1] + player[0] + player[1] == player[2])
                    {Console.WriteLine("You're Win");
                        count += 1;
                        speaker = whofirst.player;  }
                    else
                    {  Console.WriteLine("You're Lose");
                        count = 0;
                        speaker = whofirst.computer; }
                }
                while (speaker == whofirst.computer && count!=2)
                {
                    Console.WriteLine("");
                    int[] com = new int[3];
                    Random ran = new Random();

                    for (int i = 0; i < 2; i++)
                    {
                        int computer = ran.Next(0, 2);
                        computer = computer * 5;
                        com[i] = computer;
                    }

                    int computer3 = ran.Next(0, 2);
                    computer3 = (computer3 * 5) + com[0] + com[1];
                    com[2] = computer3;
                    //Console.WriteLine($"{com[0]}{com[1]}{com[2]}");

                    Console.WriteLine("請輸入兩個個數字分別代表 左拳 右拳");
                    int[] player = new int[2];

                    for (int i = 0; i < 2; i++)
                    {
                        player[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"電腦左拳{com[0]}\n電腦右拳{com[1]}\n電腦猜測總和{com[2]}");
                    if (com[0] + com[1] + player[0] + player[1] == com[2])
                    {
                        Console.WriteLine("電腦猜對 You're lose 電腦繼續開始");
                        count += 1;
                        speaker = whofirst.computer;


                    }
                    else
                    {

                        Console.WriteLine("電腦猜錯 You're Win 你繼續開始");
                        count = 0;
                        speaker = whofirst.player;
                    }
                }

            }
            if (speaker == whofirst.player)
            {
                Console.WriteLine(@"
================================================
Winner is player 在你的回合你連贏了兩局");
            }

            if (speaker == whofirst.computer)
            {
                Console.WriteLine(@"
================================================
Winner is computer 在電腦的回合你連輸了兩局");
            }
            Console.ReadKey();
        }
    }
}