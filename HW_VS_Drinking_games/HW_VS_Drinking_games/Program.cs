using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Drinking_games
{
    class Program
    {

        #region 判斷玩家的回合 玩家的輸入
        public static bool Checkinput(string input)
        {
            string[] input_array;
            input_array = input.Split('/', ' ', ',');


            if (input_array.Length != 3)
            {
                return false;
            }

            int output;//暫存而已
            for (int i = 0; i < input_array.Length; i++)
            {
                if (!int.TryParse(input_array[i], out output))
                {
                    return false;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (!(int.Parse(input_array[i]) == 0 || int.Parse(input_array[i]) == 5))
                {
                    return false;
                }
            }

            if (!(int.Parse(input_array[2]) == 0 || int.Parse(input_array[2]) == 5 || int.Parse(input_array[2]) == 10 || int.Parse(input_array[2]) == 15 || int.Parse(input_array[2]) == 20))
            {
                return false;
            }

            return true;
        }
        #endregion


        #region  判斷電腦回合的玩家輸入
        public static bool Checkinput2(string input)
        {
            string[] input_array;
            input = input.Trim();//把前後空格都刪掉
            input_array = input.Split('/', ' ', ',');
            int[] input_arrayint;

            if (input_array.Length != 2)
            {
                return false;
            }

            int output;//暫存而已
            for (int i = 0; i < input_array.Length; i++)
            {
                if (!int.TryParse(input_array[i], out output))
                {
                    return false;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (!(int.Parse(input_array[i]) == 0 || int.Parse(input_array[i]) == 5))
                {
                    return false;
                }
            }
            return true;


        }

        #endregion



        public enum whofirst
        {
            player,
            computer,
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"This is Chinese Drinking Game 5-10-15 
================================================");
            Console.WriteLine(@"
Gmae Rule : Two players. You & Computer.

The aim is to correctly predict the sum total of all the values from the hands displayed by the players.
To begin each round, players extend both hands and reveal either a closed fist (representing a value of 0) or open hand (value of 5) at the same time, much like you would in a game of rock, paper, scissors. 
But at the moment the hands are deployed, the player calls out their prediction of the total value of both hands, which could be 0, 5, or 10.
If the player guesses correctly, he gets to call again, at which point every player has the option of changing their hands.
If the player guesses incorrectly, the call goes to the next in line.
The game ends when one player manages two consecutive correct guesses. The player next in line is forced to drink as punishment.
The next round starts with the winner calling first.

Now you're playing with computer.");
            int count = 0;
            Random random = new Random();
            whofirst speaker = whofirst.player;
            speaker = (whofirst)random.Next(0, 2);



            while (count != 2)
            {
                while (speaker == whofirst.player && count != 2)
                {
                    Console.WriteLine(@"================================================

Player First 
玩家先開始

Please enter 3 digit for left hand, right hand and the guess of total number. 
For each hand, you can only enter 0 or 5, and total for 0, 5, 10, 15 or 20. 
請輸入三個數字分別代表 左拳 右拳 及 猜測雙方總和");
                    string input;

                    Console.WriteLine("");
                    Console.WriteLine("left hand / right hand / guess total");
                    input = Console.ReadLine();


                    while (!Checkinput(input))
                    {
                        Console.WriteLine("Please input correct range of number");
                        input = Console.ReadLine();
                    }

                    string[] input_array;
                    int[] player = new int[3]; //要初始化

                    input_array = input.Split('/', ' ', ',');

                    for (int i = 0; i < 3; i++)
                    {
                        player[i] = int.Parse(input_array[i]);
                    }


                    Console.WriteLine("");
                    int[] com = new int[2];
                    Random ran = new Random();

                    for (int i = 0; i < 2; i++)
                    {
                        int computer = ran.Next(0, 2);
                        computer = computer * 5;
                        com[i] = computer;
                    }
                    Console.WriteLine($"Computer : {com[0]} , {com[1]}");

                    //判斷誰贏
                    if (com[0] + com[1] + player[0] + player[1] == player[2])
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You scored");
                        count += 1;
                        speaker = whofirst.player;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You failed. It's turn to computer");
                        count = 0;
                        speaker = whofirst.computer;
                    }
                }
                //Computer first=============================================================
                while (speaker == whofirst.computer && count != 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(@"
================================================

Computer first
現在是電腦先的回合

Please enter 3 digit for left hand, right hand. 
For each hand, you can only enter 0 or 5.
請輸入兩個數字0或5分別代表 左拳 右拳
  ");
                    string input = Console.ReadLine();
                    while (!Checkinput2(input))
                    {
                        Console.WriteLine("Please input correct range of number");
                        input = Console.ReadLine();

                    }

                    string[] input_array;
                    int[] player = new int[2]; //要初始化

                    input_array = input.Split('/', ' ', ',');

                    for (int i = 0; i < 2; i++)
                    {
                        player[i] = int.Parse(input_array[i]);
                    }



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


                    Console.WriteLine($"computer : {com[0]} , {com[1]} , {com[2]}");
                    if (com[0] + com[1] + player[0] + player[1] == com[2])
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Computer scored. Last chance.");
                        count += 1;
                        speaker = whofirst.computer;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Computer failed. It's your turn");
                        count = 0;
                        speaker = whofirst.player;
                    }
                }

            }
            if (speaker == whofirst.player)
            {
                Console.WriteLine(@"
================================================
You win ! ");
            }

            if (speaker == whofirst.computer)
            {
                Console.WriteLine(@"
================================================
You failed ! ");
            }
            Console.ReadKey();
        }
    }
}