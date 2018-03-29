using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_VS_File_save
{
    class Program
    {
        private static string num_string;

        public struct Book //開頭要大寫
        {
            public string name; //不是int
            public int price;
            public int amount;
        }


        static void Main(string[] args)
        {
            //題目
            //使用者輸入欲增加的書目筆數(至少輸入3筆)

            //書目結構

            //標題
            //價錢
            //數量
            //輸入書目，直到符合書目筆數(須防呆)

            //將輸入資料，存成html檔(以表格呈現)


            int num = 3;
            string num_string;// 絕對不要放在do-while裡面!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            do
            {
                Console.WriteLine("請輸入要多少書目筆數 (至少三筆)");
                num_string = Console.ReadLine();
            } while (!int.TryParse(num_string, out num) || !(int.Parse(num_string) >= 3));
            // } while (   !       (int.TryParse(num_string,out num) &&   int.Parse(num_string)>=3)   );//另一種寫法




            Book[] book_array = new Book[num];


            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"請輸入第{i}筆的書名");
                book_array[i - 1].name = Console.ReadLine();

                do
                {
                    Console.WriteLine($"請輸入第{i}筆的價錢");
                } while (!int.TryParse(Console.ReadLine(), out book_array[i - 1].price));

                do
                {
                    Console.WriteLine($"請輸入第{i}筆的數量");
                } while (!int.TryParse(Console.ReadLine(), out book_array[i - 1].amount));

            }
            StringBuilder data = new StringBuilder();


            DateTime dt = DateTime.Now;
            data.AppendLine(@"<!DOCTYPE html>
<html lang = ""en"">
<head>
    <meta charset = ""UTF-8"">
    <meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"">
    <meta http-equiv = ""X-UA-Compatible"" content = ""ie=edge"">
    <title> Document </title>
    <style>
    table, th,td, tr{
                border: 1px solid black;
                padding: 0.5em;
                margin: auto;
                border-collapse: collapse;
td{  color:gray;
}
 text-align: center;
            }
            h1{
                text-align: center;
            }
tr{text-align: center;

}
    </style>
</head>
<body>
    <h1> Book Order </h1>
       <table>
       <tr>
           <th> Book </th>
           <th> Price </th>
           <th> Amount </th>
       </tr>");
            for (int i = 0; i < num; i++)
            {
                data.AppendLine($"<tr><td> {book_array[i].name} </td><td> {book_array[i].price} </td><td> {book_array[i].amount} </td></tr>");
            }

            data.AppendLine($@"<tr><td colspan=""3""> {dt.Day.ToString()}  /  {dt.Month.ToString()}  /  {dt.Year.ToString()} </td> </tr>");

            data.AppendLine(@"
                  </table>

   </body>
   </html> ");

            //新增一個檔案 裝進去 然後用html呈現
            File.WriteAllText("index.html", data.ToString()); //檔案名要框起來
            Process.Start("index.html");//自動打開檔案

        }






    }
}
