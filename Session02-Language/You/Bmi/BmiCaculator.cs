namespace Bmi;

/// <summary>
/// Hàm này trả về chỉ số Bmi dựa trên cân nặng và chiều cao Bmi trong khoảng từ 18.5 đén 24.9
/// <param name="weight">Cân nặng do bằng kg</param>
/// <param name="height">Chiều cao đo bằng m</param>
/// </summary>
/// <summary>
/// Class này cung cấp các hàm để tính ra chỉ số BMI của 1 cá nhân bất kì dựa trên chiều cao và cân nặng đồng thời cảnh báo mập ốm
/// </summary>
public class BmiCaculator

{
    //Quy ước đặt tên hàm/method trong C#
    //C# đặt tên hàm theo công thức VERB + OBJECT
    // Dùng cú pháp PASCAL - Pascal Case Notation - Chữ hóa từng đầu từ EX: GetYob() GetName()
    //Java VERB + OBJECT
    //Nhưng theo cú pháp con lạc đà = camel Case Notation chữ hoa Từng đầu từ, từ đầu viết thường
    
    //Viết thêm hàm theo style EXPRESSTION BODT - LUYỆN TẬP
    //Viết hàm in ra chuỗi sau BMI STANDS FOR BODY MASS INDEX CHỈ SỐ KHỐI CƠ THỂ CON SỐ TÍNH TOÁN TỪ CHIỀU CAO VÀ CÂN NẶNG

    public static void PrintBmiMessage() => Console.WriteLine("MI STANDS FOR BODY MASS INDEX CHỈ SỐ KHỐI CƠ THỂ");

    /// <summary>
    /// 
    /// </summary>
    /// <param name="weight"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public static double GetBmi(double weight, double height) => weight / (height * height);
    //C# cung cấp 1 kĩ thuật giúp rút gọn thân hàm khi chỉ có 1 câu lệnh cho phép loại bỏ dấu { } của hàm
    //loại bỏ luôn cả từ return
    //kết quả hàm còn lại cái nịt V1 tên hàm => thân hàm 1 lệnh
    //kĩ thuật này gọi tên là EXPRESSTION BODY, EXPRESSTION BODIED
    //Hàm này có thân/code của hàm nhìn gọn gàng như biểu thức tính toán
    
    // Tuyệt đối không nhầm lẫn với chỉ còn cái nịt v2 kĩ thuật biểu thức lamda - LAMDA EXPRESSTION cũng xài dấu => Nhưng ý nghĩa hoàn toàn khác
    
    // static double GetBmi(double weight, double height)
    // {// tiêu chuẩn thiết kế hàm tốt re-use ngon giống Math.sqrt() Java Math.sqrt() C#
    //     //hàm nhận đầu vào và trả đầu ra 
    //     //tiêu chuẩn hàm y = f(x) = x^2
    //     //               y = f(x) = 25
    //     // ko lệnh nhập và không lệnh xuất
    //     return weight / (height * height);
    // }
}