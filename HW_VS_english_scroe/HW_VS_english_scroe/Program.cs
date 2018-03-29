using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_english_scroe
{
    class Program
    {
        public struct Score
        {
            public int id;
            public int reading;
            public int listening;
       
        }

        enum List //用列舉型別
        {
            grade=1,data=2,edit=3,end=-1,

        }

        static void Main(string[] args)
        {
            Score [] grade = new Score[0]; //給予陣列
            int count = 0;
            int id = 0;
            int num = 0;
           
            while (count != 2) //用while判斷是否結束程式
            {
                Console.Write("@主選項: 1)輸入成績 2)統計資料 3)修改成績 -1)結束 \n" +
                    "編號: ");
                num = int.Parse(Console.ReadLine());
                
                if(num != 1 && num != 2 && num != 3 && num != -1) //防呆
                { Console.WriteLine("索引超出範圍！"); };

                switch (num)//選單輸入
                {
                    case (int)List.grade: //當選單輸入1的時候
                        Array.Resize(ref grade, grade.Length + 1);//讓陣列空間+1

                        do //用do while讓 迴圈先跑一次 再判斷是否分數輸入正確範圍
                        {   
                            Console.Write("請輸入聽力測驗成績: ");

                            grade[id].listening = int.Parse(Console.ReadLine());
                            if (grade[id].listening > 100 || grade[id].listening < 0) { Console.WriteLine("聽力測驗分數輸入錯誤!"); }
                        } while (grade[id].listening > 100||grade[id].listening < 0); 

                        do //如同聽力成績
                        {
                            Console.Write("請輸入閱讀測驗成績: ");
                            grade[id].reading = int.Parse(Console.ReadLine());
                            if (grade[id].reading > 100 || grade[id].reading < 0) { Console.WriteLine("聽力測驗分數輸入錯誤!"); }
                        } while (grade[id].reading>100||grade[id].reading<0);
                     
                        Console.WriteLine( $"總分{grade[id].listening+grade[id].reading}" ); //計算總分
                        grade[id].id = id; //id為一開始計算輸入的項目 也就是陣列內有幾個空間
                        //id =id+1  ;
                        //id += 1;
                        id++; //每增加一筆聽力成績及閱讀成績 變多一個項目及空間
                        
                        break;

                    case (int)List.data:
                        
                            Console.WriteLine("");
                            for (int i = 0; i < id; i++)//印出陣列所有值
                            {
                            Console.WriteLine(@"項目      聽力測驗      閱讀測驗      總分

----------------------------------------------------------");
                                Console.WriteLine($"{grade[i].id+1}                {grade[i].listening}          {grade[i].reading}        {grade[i].listening + grade[i].reading}\n");
                            }//因為陣列空間是從0開始 所以讓項目要+1 才正確
                        

                        break;

                    case (int)List.edit:
                        Console.Write("修改項目: ");
                        int edit;
                        edit = int.Parse(Console.ReadLine());
                        do
                        {
                            Console.Write("請輸入聽力測驗成績: ");

                            grade[edit-1].listening = int.Parse(Console.ReadLine()); ///因為陣列空間是從0開始 所以輸入項目要-1 才正確
                            if (grade[edit-1].listening > 100 || grade[edit-1].listening < 0) { Console.WriteLine("聽力測驗分數輸入錯誤!"); }
                        } while (grade[edit-1].listening > 100 || grade[edit-1].listening < 0);

                        do
                        {
                            Console.Write("請輸入閱讀測驗成績: ");
                            grade[edit-1].reading = int.Parse(Console.ReadLine());
                            if (grade[edit-1].reading > 100 || grade[edit-1].reading < 0) { Console.WriteLine("聽力測驗分數輸入錯誤!"); }
                        } while (grade[edit-1].reading > 100 || grade[edit-1].reading < 0);




                        break;

                    case (int)List.end:
                      
                        count = 2; //跳出程式迴圈

                        break;

                    default:
                        break;

                }

              
            }
            Console.WriteLine("=============結束程式=============");
            Console.ReadKey();

        }


    }
}
