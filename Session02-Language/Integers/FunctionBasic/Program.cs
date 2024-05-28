namespace FunctionBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintList1To100();
            PrintEvenNumbers1To100();
            Sum1To100();
            Console.WriteLine($"Sum even from 1 to 100 {SumEvenNumbers1To100()}");
        }
        //CHALLENGE #1 (C#): VIẾT 1 HÀM IN RA CÁC SỐ TỪ 1 ĐẾN 100
        static void PrintList1To100()
        {
            Console.WriteLine("The list of numbers from 1 to 100:");
            //có sự lặp lại việc gì đó lệnh gì đó ta xài for, while, do while y chang java
            //java, c , c# nếu trong for if else chỉ có 1 lệnh thì không cần dấu {} còn nhiều lệnh thì phải có {}
            for (var i = 1; i <= 100; i++)
                Console.Write(i + " ");

            //sống có trách nhiệm xuống dòng sau khi in 
            Console.WriteLine();
        }
        //CHALLENGE #2 (C#): VIẾT 1 HÀM IN RA CÁC SỐ CHẴN TỪ 1 ĐẾN 100
        static void PrintEvenNumbers1To100()
        {
            Console.WriteLine("The list of even numbers from 1 to 100:");
            for (var i = 1; i <= 100; i++)
                if (i % 2 == 0)
                    Console.Write($"{i} ");


            Console.WriteLine();
        }
        //CHALLENGE #3 (C#): VIẾT 1 HÀM TÍNH TỔNG CÁC SỐ TỪ 1 ĐẾN 100 -> 5050 VÀ IN RA
        static void Sum1To100()
        {
            var sum = 0;
            for (var i = 1; i <= 100; i++)
                sum += i; //sum = sum + i; thuật toán con heo đất tiếp chiêu ôc bu nhồi thịt

            Console.WriteLine($"The sum of numbers from 1 to 100 is {sum}");
        }
        //HÀM CẦN PHẢI TRẢ VỀ 5050 CHO DÙ CHƯA VIẾT CODE XONG => 5050 ĐƯỢC GỌI LÀ EXPECTED VALUE
        //THỰC TẾ KHI CHẠY LÀ MẤY: CÓ THỂ LÀ 6000, 7000 TÙY TÀI NĂNG CODE; NHƯNG CŨNG CÓ THỂ LÀ 5050 THẬT
        //CON SỐ TRẢ VỀ CỦA HÀM ĐƯỢC GỌI LÀ ACTUAL VALUE
        //NẾU EXPECTED VALUE == ACTUAL VALUE => HÀM NGON
        //                   !=              => HÀM BUG
        //KĨ THUẬT KIỂM THỬ CODE CỦA DÂN DEV ĐỂ ĐẢM BẢO HÀM CHẠY ĐÚNG VỚI CÁC CASE/TÌNH HUỐNG CỤ THỂ

        //CHALLENGE #4 (C#): VIẾT 1 HÀM TÍNH TỔNG CÁC SỐ CHẴN TỪ 1 ĐẾN 100 -> 2550
       static int SumEvenNumbers1To100()
        {
            //PrintList1To100();
            //PrintEvenNumbers1To100();
            //Sum1To100();
            //tính tổng các số chẵn từ 1 đến 100 -> 2 4 6 8 10
            //Expected value: 30
            //Actual value: chạy đi đoán xem
            var sum = 0;
            for (var i = 1; i <= 100; i++)
                if (i % 2 == 0) //chẵn thì mới dồn vào heo đất
                    sum += i;
            return sum;
        }

    }
}
//hàm medthod là 1 đơn vị code 1 nhóm các câu lệnh được đặt tên chung 1 cái tên và làm 1 việc gì có thể là :
//              IN RA 1 KẾT QUẢ GÌ ĐÓ HÀM VOID
//              TRẢ VỀ 1 KẾT QUẢ GÌ ĐÓ HÀM CÓ RETURN XXX;
//                                      y = f(x) = x^2
//                                      y = f(5) = 5^2 = 25
//                                      vietsub f của 5 nhận về 25
//                                      sqrt(100)
//                                      vietsub căn bậc 2 của 100 nhận về 10

//HÀM TRUYỀN THỐNG XƯA NAY CHỈ TRẢ VỀ 1 GIÁ TRỊ QUA LỆNH RETURN XXX:

//C# HỖ TRỢ THÊM HÀM CÓ THỂ TRẢ VỀ NHIỀU GIÁ TRỊ NHƯNG ....

//VÍ DỤ: HÀM TÍNH CĂN BẬC 2 GỒM 1 ĐỐNG CÂU LỆNH ĐƯỢC ĐẶT TÊN LÀ
//JAVA: sqrt(x) => trả về chứ không in ra căn bậc 2 của x
//C#  : Math.Sqrt(x) => trả về chứ không in ra căn bậc 2 của x