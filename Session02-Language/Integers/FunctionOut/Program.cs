namespace FunctionOut
{
    internal class Program
    {
        //CHALLENGE #1: KIỂM TRA KEYOUT THÌ ẢNH HƯỞNG THẾ NÀO ĐẾN BIẾN GỐC- BIẾN ĐC TRUYỀN VÀO TRONG HÀM
        static void Main(string[] args)
        {
            int x = 2004; //biến gốc, 1 biến riêng
            DoSomeThing(out x); //TRONG C: DoSomeThing(&x);
            Console.WriteLine("after calling DoSomeThing, x = {0}", x);

        }
        //                        DoSomeThing(int* p) //C
        static void DoSomeThing(out int p) //1 biến riêng, BẮT BUỘC TRONG HÀM PHẢI CÓ P = ???;
                                           //TUI HỨA CHẮC KÈO SẼ CÓ VALUE!!!!!
        {
            //p là pointer, p trỏ đến biến int x xa xa ngoài hàm
            //p thay đổi giá trị nghĩa là x ngoài kia thay đổi
            p = 6789;

        }
    }
}
//OUT LÀ KEY WORD NẰM Ở THAM SỐ HÀM MANG Ý NGHĨA:
// TRONG HÀM BẮT BUỘC PHẢI CÓ 1 CÂU LỆNH GÁN GIÁ TRỊ CỤ THỂ NÀO ĐÓ (HOẶC 1 BIỂU THỨC TÍNH TOÁN) CHO BIẾN OUT!!
//CÓ THỂ CÓ NHIỀU BIẾN OUT 1 GIÁ TRỊ NÀO ĐÓ
// NỚI XÀI HÀM OUT, THÌ PHẢI DÙNG OUT Ở BIẾN HỨNG VALUE
// VỪA KHAI BÁO BIẾN DÙNG ĐỂ HỨNG TRONG LỜI GỌI HÀM OUT LÀ CÁCH KHAI BÁO NGẮN GỌI
// OUT LÀ BIẾN CON TRỎ NHẬN VÀO TỌA ĐỌ ĐỊA CHỈ SỐ NHÀ CỦA BIẾN BÊN NGOÀI, TRAO CHÌA KHÓA TRAO ĐỊA CHỈ 
//TRONG HÀM THAY ĐỔI NGOÀI HÀM THAY ĐỔI
