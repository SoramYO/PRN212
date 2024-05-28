using Poem.XuanQuynh;//import bên java

namespace Poem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song.PrintSongCode();  
           // UseVerbatim();
           // PrintTuAy();
        }

        static void UseVerbatim()
        {
            //ứng dụng của chuỗi verbatim
            //1. dùng trong đường dẫn tên tệp tin khi có các kí tự đặc biệt liên quan đến \
            //giúp nối chuỗi tự nhiên như bản gốc
            //2. đôi khi verbatim còn dùng trong chuỗi url connection string - chuỗi kết nối cơ sở dữ liệu có thông tin sever \ hay /
            //verbatim có thể dùng kết hợp luôn với $ interpolation
            string path = "C:\\Program Files\\news";
            string path2 = @"C:\Program Files\news";
            string path3 = @"D:\Program Files\news";
            Console.WriteLine(($"Path: {path}"));
            Console.WriteLine(($@"Path: {path2} \/ {path3} "));
        }

        //có câu static chơi với static
        static void PrintTuAy()
        {
            int year = 2024;  // khai bao bien dung cu phap camel Case Notation - cu phap con lac da
            //ví dụ salary, basicSalary
            int month = 5;
            Console.WriteLine("Year : " + year + "/" + month); // ghép chuỗi kiểu truyền thống - string concatenated dùng dấu +



            Console.WriteLine("Year : {0}/{1} ", year, month); //place-holder -  điền vào chỗ trống
                                                               //%d  bên C
                                                               //nếu in nhiều biến {0} {1} {2} các biến cách nhau bằng dấu phẩy

            Console.WriteLine($"Year : {year}/{month}"); // interpolation nội suy giá trị

            //Console.WriteLine("Tu ay trong toi bung nang ha");
            //Console.WriteLine("Mat troi chan li choi qua tim");
            //Console.WriteLine("Hồn tôi là một vườn hoa lá");
            //Console.WriteLine("Rất rộn hương và rộn tiếng chim");

            //Console.WriteLine("Tu ay trong toi bung nang ha\nMat troi chan li choi qua tim\nHồn tôi là một vườn hoa lá\nRất rộn hương và rộn tiếng chim");

            Console.WriteLine(@"
Tu ay trong toi bung nang ha
Mat troi chan li choi qua tim
Hồn tôi là một vườn hoa lá
Rất rộn hương và rộn tiếng chim"); //@ biến chuỗi thằng chuỗi nguyên bản raw string có kí tự gì bên trong chuỗi lúc edit se in y chang
            //có \n thì in \n luôn phế võ công các kí tự đặc biệt thành có sao in vậy
            //kĩ thuật chuỗi này gọi là Verbatim
            //ben java có y chang

            Console.WriteLine(@"
<html>
    <head>

    </head>
    <body>
        <div>

        </div>
    </body>
</html>");

        }



    }
}
