using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bmi = BmiCaculator.GetBmi(70,1.7); //Math.sqrt() cùng style nhạn vào trả ra
            //y = f(x) = x^2
            //type inferent - ngầm suy luận ra kiểu dữ liệu

            Console.WriteLine("BMI(70 , 1.7): " + bmi); //concatenation - ghép chuỗi
            Console.WriteLine("BMI(70 , 1.7): {0}", bmi); //placeholder - chỗ chứa
            Console.WriteLine($"BMI(70 , 1.7): {bmi}"); //string interpolation - nội suy chuỗi
            Console.WriteLine(@$"BMI(70 , 1.7): {bmi}"); //verbatim string - chuỗi nguyên thô

            string bmiMessage = $"BMI(70 , 1.7): {bmi}"; //tạo chuỗi lẻ bên ngoài ráp vào cw()

            //nguyên lý dấu =, a = b , ở đâu xài b, thì ở đó xài a !!!
            Console.WriteLine($"BMI(70 , 1.7): {BmiCaculator.GetBmi(70,1.7)}");
        }
    }
}
//DLL: Dynamic Link Library - Thư viện , package, thư mục, folsder, namespace
//chứa bên trong nhiều class method để cung cấp tiện ích cho người lập trình làm việc gì đó chẳng hạn DLL để quản lí Camera DLL để móc xuống database DLL để truyền message qua wifi network

//DLL nó không phải là file nhị phân binary code mà là code mã trung tính trung gian không gắn với 1 os cụ thể nó chạy chơi với runtime runtime chơi với os

//App chạy đa nền/platform independent , Cross Platform bản chất là 
//phải có thằng runtime gắn với os cụ thể 
//App chỉ chơi với runtime
//                        --MACOS
//                        --LINUX
//                        --WINDOWS

//App trung tính - code trung tính này gọi là MSIL - Microsoft Intermediate Language
//từ MSIL ==> back ngược lại .cs source code gốc dev viết ra
//                  Revert Engineering - dịch ngược về source code
//                  Decompiler - công cụ dịch ngược
//từ MSIL ==> biến thành machine code binary code / native code
//                         thật gần với os
//                         chỉ dùng ngôn ngữ lâp trình cấp thấp
//Assembly để xem
