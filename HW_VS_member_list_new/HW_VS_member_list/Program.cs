using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_member_list
{
    class Program
    {
        public static string D3 { get; private set; }

        //編號,姓名,生日,電話

        public struct Member //開頭要大寫
        {
            public int id;
            public string name; //不是int
            public string bd;
            public string phone;
        }

        enum List //用列舉型別
        {
            all = 1, add = 2, delete = 3, edit = 4, addfile = 5, end = -1,

        }
        static void Main(string[] args)
        {


            Console.WriteLine(@"會員登錄系統

請撰寫一個會員登錄系統，並設計一個結構用來表示每一位會員的欄位資料，
會員的資料在程式開始時必須事先從檔案中讀取，最後也必須存入檔案。
如檔案一開始不存在，則必須自動建立。會員編號必須介於0至100之間，
列印時必須要印滿三個字元，不足者必須補上0。

請使用函式實作，列印時請用格式化字串進行對齊。
");

            string num_string;
            int num;
            int count = 0;
            string input;
            string bd_string;
            int edit_num;
            int delete_num;
            DateTime bd = new DateTime();


            Member[] array = new Member[101]; //給予陣列

            string path = "member.csv";

            string[] content = File.ReadAllLines(path);//寫入內容

            //Console.WriteLine("File read");
            //for (int i = 0; i < content.Length; i++)//印出陣列內容
            //{
            //    Console.WriteLine(content[i]);
            //}




            #region MyRegion
            string x;
            x = content[0].ToString();
            string[] test = x.Split(',');

            //array[0].id = int.Parse(test[0]);
            //array[0].name = test[1];
            //array[0].bd = test[2];
            //array[0].phone = test[3];
            //Console.WriteLine($"{array[1].id}, {array[1].name}, {array[1].bd}, {array[1].phone}\n"); //測試用




            string y;
            y = content[1].ToString();
            string[] test1 = y.Split(',');
            array[1].id = int.Parse(test1[0]);
            array[1].name = test1[1];
            array[1].bd = test1[2];
            array[1].phone = test1[3];


            string z;
            z = content[2].ToString();
            string[] test3 = z.Split(',');
            array[2].id = int.Parse(test3[0]);
            array[2].name = test3[1];
            array[2].bd = test3[2];
            array[2].phone = test3[3];

            string m;
            m = content[3].ToString();
            string[] test4 = m.Split(',');
            array[3].id = int.Parse(test4[0]);
            array[3].name = test4[1];
            array[3].bd = test4[2];
            array[3].phone = test4[3];


            string n;
            n = content[4].ToString();
            string[] test5 = n.Split(',');
            array[4].id = int.Parse(test5[0]);
            array[4].name = test5[1];
            array[4].bd = test5[2];
            array[4].phone = test5[3];
            //for (int i = 0; i < 4; i++)
            //{
            //    StringBuilder cb = new StringBuilder();
            //    cb.AppendLine($"{content[i]}");
            //Console.WriteLine($"{cd.ToString}");

            //}

            //string content_string  = content.Split(',');
            #endregion
            while (count != 3)
            {

                Console.WriteLine("選項：1)檢視全部, 2)新增, 3)刪除, 4)修改, 5)篩選編號, -1) 結束");

                num_string = Console.ReadLine();

                while (!int.TryParse(num_string, out num)) 
                {
                    Console.WriteLine("請輸入正確選項號碼");
                    num_string = Console.ReadLine();

                }


                switch (num)
                {
                    case (int)List.all:
                        Console.WriteLine("編號 , 姓名 , 生日 , 電話");

                        Console.WriteLine("");

                        for (int i = 0; i < array.Length; i++)//印出陣列所有值
                        {


                            if (array[i].id != 0)
                            {
                                Console.WriteLine($"{array[i].id.ToString("D3")} , {array[i].name} , {array[i].bd} . {array[i].phone}\n");
                            }//因為陣列空間是從0開始 所以讓項目要+1 才正確
                        }


                        break;
                    case (int)List.add:

                        Console.Write("請輸入編號(介於0-100) : ");

                        input = Console.ReadLine();


                        while (int.Parse(input) > 100 || int.Parse(input) < 0||int.Parse(input)==0)
                        {
                            Console.WriteLine("錯誤！超出範圍！請重新輸入");
                            input = Console.ReadLine();
                        }

                        while (int.Parse(input) == 1 || int.Parse(input) == 2 || int.Parse(input) == 3 || int.Parse(input) == 4)
                        {
                            Console.WriteLine("錯誤！編號已有匯入內容！請重新輸入");
                            input = Console.ReadLine();
                        }

                        array[int.Parse(input)].id = int.Parse(input);
                            Console.Write("姓名");
                            array[int.Parse(input)].name = Console.ReadLine();
                            Console.Write("生日(年/月/日)");

                        do
                        {
                            bd_string = Console.ReadLine();

                        } while (DateTime.TryParse(bd_string,out bd));  

                            //Console.WriteLine(bd.ToString("yyyy-MM-dd"));
                            array[int.Parse(input)].bd = bd.ToString("yyyy/MM/dd");

                            Console.Write("電話");
                            array[int.Parse(input)].phone = Console.ReadLine();
                            Console.WriteLine("會員新增成功!");

                        break;

                    case (int)List.delete:

                        Console.WriteLine("輸入要刪除的編號");
                        delete_num = int.Parse(Console.ReadLine());
                        //array[delete_num] = null;
                        //array.RemoveAt(delete_num);

                        while (array[delete_num].id == 0)
                        {
                            Console.WriteLine("此標號不存在 請重新輸入");

                            delete_num = int.Parse(Console.ReadLine());

                        }
                        //while (delete_num ==1|| delete_num == 2 || delete_num == 3 || delete_num == 4)
                        //{
                        //    Console.WriteLine("此有匯入資料 不能刪除 請重新輸入");
                        //    delete_num = int.Parse(Console.ReadLine());

                        //}

                        array[delete_num].id = 0;
                        Console.WriteLine("");
                        Console.WriteLine("刪除成功 !");
                        Console.WriteLine("");

                        break;

                    case (int)List.edit:
                        
                        Console.WriteLine("輸入要修改的編號");
                        edit_num = int.Parse(Console.ReadLine());
                        //array[edit_num].id = edit_num;

                        while (array[edit_num].id == 0 || edit_num == 0 || edit_num > 100 || edit_num < 0)
                        {
                            Console.WriteLine("此標號不存在 請重新輸入");

                            edit_num = int.Parse(Console.ReadLine());

                        }


                        //while (edit_num==4|| edit_num == 1|| edit_num == 2|| edit_num == 3)
                        //{
                        //    Console.WriteLine("錯誤！編號已有匯入資料！請重新輸入");
                        //    edit_num = int.Parse(Console.ReadLine());

                        //}

                        Console.WriteLine("姓名");
                        array[edit_num].name = Console.ReadLine();
                        Console.WriteLine("生日(年/月/日)");

                        bd_string = Console.ReadLine();
                        //DateTime bd = new DateTime();
                        DateTime.TryParse(bd_string, out bd);
                        //Console.WriteLine(bd.ToString("yyyy-MM-dd"));
                        array[edit_num].bd = bd.ToString("yyyy/MM/dd");

                        Console.WriteLine("電話");
                        array[edit_num].phone = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("會員修改成功!");
                        Console.WriteLine("");

                        break;
                    case (int)List.addfile:


                        Console.Write("輸入起始編號");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("輸入結束編號");
                        int b = int.Parse(Console.ReadLine());
                        string[] array_add = new string[100];
                        StringBuilder abc = new StringBuilder();


                        for (int i = a; i <= b; i++)
                        {

                            if (array[i].id != 0)
                            {
                                abc.AppendLine($"{array[i].id.ToString("D3")}, {array[i].name}, {array[i].bd}, {array[i].phone}\n");

                            }
                        }
                        Console.Write("輸入資料檔名");
                        string path2 = Console.ReadLine();
                        File.WriteAllText(path2, abc.ToString());
                        Console.WriteLine("檔案寫入成功");




                        break;



                    case (int)List.end:

                        StringBuilder ok = new StringBuilder();
                        ok.AppendLine("編號 , 姓名 , 生日 , 電話");
                        for (int i = 1; i < 101; i++)
                        {
                            
                            if (array[i].id != 0)
                            {
                                
                            ok.AppendLine($"{array[i].id.ToString("D3")}, {array[i].name}, {array[i].bd}, {array[i].phone}\n");


                            }
                        }
                        File.WriteAllText("member.csv", ok.ToString());

                        Console.WriteLine("寫入member.txt成功！");
                        count = 3;
                        break;

                    default:
                        Console.WriteLine("請輸入正確選項號碼");
                        break;

                        
                }
            }
            Console.WriteLine("==================================結束程式==================================");




        }
    }
}
