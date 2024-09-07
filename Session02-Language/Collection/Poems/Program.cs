namespace Poems // em có nhà là folder, em cư ngụ tại poems folder
                //tương đương câu lệnh package poems
                //tương đương package java.until; bên Java
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.ReadLine(); // chờ nhập rồi mới kết thúc
        }

        //static chỉ chơi với static
        static void PrintSong()
        {
            Console.WriteLine("Sóng bắt đầu từ gió");
            Console.WriteLine("Gió bắt đầu từ đâu");
            Console.WriteLine("Em cũng không biết nữa?");
            Console.WriteLine("Khi nào ta yêu nhau!");
        }
        static void PrintSongV2()
        {
            Console.WriteLine("Sóng bắt đầu từ gió\n" + "Gió bắt đầu từ đâu\n" + "Em cũng không biết nữa?\n" + "Khi nào ta yêu nhau!");
        }
        //@ đứng trucows 1 chuỗi giúp ta khi báo 1 chuỗi theo style có sao in vậy chuỗi có gì in đó, có \n thì in \n luôn không còn là xuống hàng
        //kĩ thuật này gọi là verbatim string - raw tring - chuỗi nguyên bản, java cũng có
        //DÙNG KHI TA MUỐN TRONG CODE CÓ NHỮNG ĐOẠN VĂN BẢN MÀ TA MUỐN IN RA NGUYÊN BẢN, KHÔNG CARE KÍ TỰ ĐẶC BIỆT
        //VÍ DỤ TA MUỐN IN CHỮ \n \t
        //ta dùng nó để lưu đường dẫn tên thư mục và tên đường dẫn 1 cách tự nhiên
        static void PrintSongV3()
        {
            Console.WriteLine(@"Sóng bắt đầu từ gió
Gió bắt đầu từ đâu?
Em cũng không biết nữa
Khi nào ta yêu nhau

Con sóng dưới lòng sâu
Con sóng trên mặt nước
Ôi con sóng nhớ bờ
Ngày đêm không ngủ được
Lòng em nhớ đến anh
Cả trong mơ còn thức");

        }
        static void PrintPath()
        {
            //in ra đường dẫn nơi cài dot net
            //C:\Progaram Files\dotnet
            //in ra màn hình thư mục nơi ta lưu trữ các thông tin bài báo  tin tức showbiz
            //C:\news\
            //Console.WriteLine("C:\\Progaram Files\\dotnet");
            Console.WriteLine(@"C:\Progaram Files\dotnet");
            Console.WriteLine(@"C:\news");

        }
        static void Print()
        {
            int year = 1967; //declare a variable and init the value at first and asign value
            Console.WriteLine("Sóng bắt đầu từ gió 1967");
            Console.WriteLine("Sóng bắt đầu từ gió " + year); //ghép chuỗi- concatenation
            Console.WriteLine("Sóng bắt đầu từ gió {0} {1}", year, DateTime.Now.Year - year);//place holder - điền vào chỗ trống {thứ tự mang value sẽ in tính từ 0}
            Console.WriteLine($"Sóng bắt đầu từ gió {year}");//interpolation string- nội suy suy luận trong chuỗi là biến value thì thay thế vào
            Console.WriteLine($"Sóng bắt đầu từ gió {year} {DateTime.Now.Year - year}");
        }

    }

}
