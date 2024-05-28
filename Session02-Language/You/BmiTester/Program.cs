using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var bmi = BmiCaculator.GetBmi(70,1.7);
            //var làm biếng khai báo data type 
            //nhưng phải gán giá trị ngay lập cho biến không xđ kiểu data type ngay lúc khai báo
            //biến mang data type là value được gắn vào
            //bmi chính là double, do value trả về từ hàm GetBmi() là double
            //bmi = "70 / (1.7 * 1.7) = 24.221453287197235"
            //type inference - suy luận ngầm kiểu datatype của 1 biến
            Console.WriteLine($"BMI (w: 70 | h: 1m7): {bmi}"); //interpolation
            Console.WriteLine($"BMI (w: 70 | h: 1m7):" + bmi);// concatenation
            Console.WriteLine("BMI (w: 70 | h: 1m7): {0}", bmi);//placeholder
            BmiCaculator.PrintBmiMessage();
        }
    }
}
