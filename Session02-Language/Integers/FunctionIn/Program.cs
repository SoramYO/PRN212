namespace FunctionOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoSomeThingV2(500); //dự kiến in 500; nhưng vẫn có thể in 1000 trong hàm 
            //tao đưa bao nhiêu in bấy nhiêu
        }
        // nơi gọi gửi cho 1 biến thực ra chỉ xin value
        static void DoSomeThing(int n) //truyền tham trị -- pass by value
        {
            //thay đổi trên biến n thì chỉ là thay đổi trong n không ảnh hưởng đến cái biến mà đã từng đưa value chon không ảnh hưởng đến biên lúc gọi hàm này
            n = 6789;//sbtc - san bằng tất cả
            Console.WriteLine($"n in method {n}");
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    int x = 2004;
        //    DoSomeThing(x);
        //    Console.WriteLine("x after calling method: {0}", x);//place holder
        //}

        static void DoSomeThingV2(in int n) //truyền tham trị -- pass by value
                                            // IN KHIẾN THAM SỐ ĐẦU VÀO THÀNH READONLY CHỈ XÀI MÀ KHÔNG SỬA
                                            //ĐẢM BẢO ĐẦU VÀO GIỮ NGUYÊN Ý ĐỊNH TRUYỀN VÀO HÀM
        {
            //n = 1000;
            //in các số từ 1 to n
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            //sống có trách nhiệm xuống hàng sau khi in xong
            Console.WriteLine();
        }


    }
}
//ĐẶT VẤN ĐỀ: TRONG CÂU LỆNH SQL THAO TÁC TRÊN TABLE CÓ NHIỀU DÒNG 
//VÍ DỤ TABLE STUDENT CÓ NHIỀU DÒNG MỖI DÒNG LÀ 1 BẠN SINH VIÊN
//VỚI CÁC INFO: ID, NAME, AGE, DOB , PLACE OF BIRTH, GPA,....

//TA CÓ NHU CẦU THỐNG KÊ TÍNH TOÁN TRÊN TẬP DATA TÍNH TOÁN TRÊN TẬP DATA NHIỀU NÀY ...
//VÍ DỤ: TÍNH XEM HIỆN CÓ BAO NHIÊU SINH VIÊN
//       TÍNH XEM CÓ BAO NHIÊU SINH VIÊN QUÊ Ở BÌNH DƯƠNG
//       TÍNH XEM HIỆN CÓ BAO NHIÊU SINH VIÊN ĐIỂM TB >= 8
//       TÍNH XEM HIỆN CÓ BAO NHIÊU SINH VIÊN ĐIỂM TB < 5
//       TÍNH XEM HIỆN CÓ BAO NHIÊU SINH VIÊN ĐIỂM TB >= 8 VÀ QUÊ Ở BÌNH DƯƠNG

// NẾU LÀM 5 HÀM => PHÍ CÔNG DUYỆT FOR LẠI TỪ ĐẦU CHO MỖI HÀM
//TIẾP CẬN MỚI: DUYỆT FOR 1 LẦN GẶP TỪNG ĐỨA HỎI LUÔN 5 CÂU
//TRÚNG CÂU NÀO THÌ ++ BIẾN ĐẾM ĐÓ LÊN
//HÀM XỬ LÍ TRẢ VỀ NHIỀU HƠN 1 GIÁ, DO CÔNG ĐI 1 LẦN LUÔN NHIỀU ĐẠI LƯỢNG
//TA CẦN KĨ THUẬT GIÚP HÀM TRẢ VỀ NHIỀU GIÁ TRỊ (MÀ KHÔNG PHẢI LÀ MẢNG)
//TA TRẢ GÍ TRỊ QUA NGÕ /HẺM/NGẢ/ĐƯỜNG THAM SỐ PARAMETER CỦA HÀM
//HÀM CÓ THỂ NHẬN VÀO VÔ SỐ THAM SỐ TA TRẢ DATA RA HÀM QUA THAM SỐ
//TA DÙNG 2 KEYWORD: OUT VÀ REF

//NẾU LÀM ĐƯỢC ĐIỀU NÀY CÓ VẺ GIỐNG CÂU 

//SELECT COUNT() SUM() AVERAGE() FROM TABLE ..
//CÙNG 1 LẦN SELECT TRONG TABLE TA TÍNH LUÔN VÀI GIÁ TRỊ
