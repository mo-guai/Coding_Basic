using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("樂透機");
            Console.WriteLine("請輸入你的樂透號碼,並且用逗點隔開");
            string string_num = Console.ReadLine();

            while (!StringCheck(string_num))
            {
                Console.WriteLine("你國文有問題 請輸入正確的樂透號碼 並且用逗點隔開 ");
                string_num = Console.ReadLine();
            }
            

            string[] guess_string = string_num.Split(','); //你不知道Split的多寡 所以不能先創一個陣列的new範圍給他
            int[] guess_int = new int[6];
            for (int i = 0; i < 6; i++) //轉換String陣列 成 int陣列
            {
                guess_int[i] =int.Parse (guess_string[i]);
            }
            
            Console.Write($"你的樂透號碼 : ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{guess_int[i]}    ");
            }
            int input = 6;
            int[] lotto = new int[input];
            lotto = GeneraterLotto(input); //傳到Function
            int[] win = new int[6]; //裝中獎的數字

            Console.WriteLine("");
            Console.Write($"此期開獎號碼 : ");
            for (int i = 0; i < lotto.Length; i++)
            {
                Console.Write($"{lotto[i]}    ");

            }
            //開始判斷是否有中獎數字
            Console.WriteLine("");
            int count_win = 0;
            while (true)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (guess_int[i] == lotto[j])
                        {
                            win[count_win] = guess_int[i];
                            count_win++;
                        }
                    }
                }
                if (count_win != 0)
                {
                    Console.WriteLine($"你猜中了{count_win}個");
                    Console.Write("中獎數字有 :");
                    for (int i = 0; i < count_win; i++)
                    {
                        Console.Write($"{win[i]}  ");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"沒有中獎 謝謝惠顧");
                    break;
                }
            }
            Console.ReadKey();

        }
        /// <summary>
        /// 產生樂透號碼
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] GeneraterLotto(int input)
        {

            Random ran = new Random();
            int[] lotto = new int[input];
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = ran.Next(1, 50);//測試的時候可以改成六 看中獎狀況
                                           //CheckRepeat(lotto)
            }

            int flag = 1;
            while (flag != 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    for (int j = 0; i > j; j++)
                    {
                        flag = 0; //無敵重要 代表 沒有同樣的就要跳出整個迴圈
                        if (lotto[i] == lotto[j])
                        {
                            lotto[i] = ran.Next(1, 50);
                            flag++;
                            break;
                        }
                        //這裡不需要break! 要持續判斷是否等於 
                    }
                    if (flag != 0)
                    { break; }
                }
            }
            return lotto;
        }

        public static bool StringCheck(string input)
        {
            string[] guess = input.Split(','); 

            int num;
            for (int i = 0; i < 6; i++)
            {
                if (!int.TryParse(guess[i], out num)) //驚嘆號只影響if 所以 當TryParse 為True 就會out傳到num裡面
                {
                    return false; //代表(int.TryParse(guess[i], out num)為flase 回傳return出去
                }
            }
            if (guess.Length != 6)//防止沒有輸入六個樂透數字
            {
                return false; //代表(int.TryParse(guess[i], out num)為flase 回傳return出去
            }
            for (int i = 0; i < 6; i++)//防止數字範圍錯誤
            {
                if (!(int.Parse(guess[i]) > 0 && int.Parse(guess[i]) < 50))
                {
                    return false; //代表(int.TryParse(guess[i], out num)為flase 回傳return出去

                }
            }
            for (int i = 1; i < 6; i++) //防止重複的樂透數字
            {
                for (int j = 0; j < i; j++)
                {

                    if(guess[i] == guess[j])
                    {
                        return false; //代表(int.TryParse(guess[i], out num)為flase 回傳return出去

                    }

                }
            }

            return true;

        }
    }
}
