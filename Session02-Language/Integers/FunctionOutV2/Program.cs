namespace FunctionOutV2
{
    internal class Program
    {
        //CHALLENGE #1 VIẾT HÀM TRẢ VỀ:
        //TỔNG CÁC SỐ TỪ 1 ĐẾN 10     1+2+3+4+5+6+7+8+9+10= 55
        //TỔNG CÁC SỐ CHẴN TỪ 1 ĐẾN 10 2+4+6+8+10=30
        //SỐ LƯỢNG CA SỐ CHẴN TỪ 1 ĐẾN 10   5
        //TỔNG CÁC SỐ LẺ TỪ 1 ĐẾN 10  1+3+5+7+9=25
        //SỐ LƯỢNG SỐ LẺ TỪ 1 ĐẾN 10  5
        //EXPECTED VALUE: 55, 30, 5, 25, 5
        //static void Main(string[] args)
        //{
        //    //có 3 cách xài out!!
        //    //khai báo biến lẻ như bình thường, và gắn sẵn value cho biến
        //    int sumA = 1000, sumE = 2000, coutE = 3000, sumO = 4000, coutO = 5000; //NGÁO
        //    //GÁN GIÁ TRỊ LÀM GÌ, ĐẰNG NÀO GỌI HÀM ĐƯỢC 5 RETURN
        //    sumA = ConputeOnNumbers(out sumE, out coutE, out sumO, out coutO);

        //    //in kết quả
        //    Console.WriteLine($"Sum All: {sumA} | Sum Evens: {sumE} | Count Evens: {coutE} | Sum Odds: {sumO} | Count Odds: {coutO}"); //interpolation - nội suy ra biến trong chuỗi

        //    //kì vọng EXPECTED VALUE: 55, 30, 5, 25, 5
        //}
        //static void Main(string[] args)
        //{
        //    //có 3 cách xài out!!
        //    //CÁCH 2 KHAI BÁO BIẾN LẺ NHƯ BÌNH THƯỜNG, VÀ GẮN SẴN VALUE CHO BIẾN
        //    int sumA, sumE, coutE, sumO, coutO; 
        //    sumA = ConputeOnNumbers(out sumE, out coutE, out sumO, out coutO);

        //    //in kết quả
        //    Console.WriteLine($"Sum All: {sumA} | Sum Evens: {sumE} | Count Evens: {coutE} | Sum Odds: {sumO} | Count Odds: {coutO}"); //interpolation - nội suy ra biến trong chuỗi

        //    //kì vọng EXPECTED VALUE: 55, 30, 5, 25, 5
        //    //THỰC TẾ LÀ MẤY ĐOÁN XEM CHỜ HÀM ĐÃ CHẠY
        //    //NẾU HÀM TRẢ VỀ Y CHANG KÌ VỌNG        HÀM NGON PASSED
        //    //NẾU HÀM TRẢ VỀ KO NHƯ KÌ VỌNG          HÀM BỊ BUG
        //    //NGHỀ KIỂM THỬ PHẦN MỀM (SWT301) UNIT TEST
        //}
        static void Main(string[] args)
        {
            int sumA = ConputeOnNumbers(out int sumE, out int coutE, out int sumO, out int coutO);
            //XÀI HÀM, GỌI HÀM TIỆN ĐƯỜNG KHAI BÁO BIẾN HỨNG VALUE TRẢ VỀ QUA THAM CHIẾU/THAM SỐ

            //in kết quả
            Console.WriteLine($"Sum All: {sumA} | Sum Evens: {sumE} | Count Evens: {coutE} | Sum Odds: {sumO} | Count Odds: {coutO}"); //interpolation - nội suy ra biến trong chuỗi

        }
        static int ConputeOnNumbers(out int sumEvens, out int coutEvens, out int sumOdds, out int coutOdds)
        {
            sumEvens = 0;
            coutEvens = 0;
            sumOdds = 0;
            coutOdds = 0;
            int sumAll = 0; //biến dành cho return đường chính đạo
            //1 lần duyệt for hỏi đủ các câu thay vì nhiều for, mỗi for 1 câu
            for (int i = 1; i <= 10; i++)
            {
                //gặp i là sum => sumAll
                sumAll += i; //sumAll = sumAll + i; //thuật toán nhồi heo đất, tiếp chiêu, ốc bu nhồi thịt
                if (i % 2 == 0)
                {
                    sumEvens += i; //chẵn thì tính tổng chẵn
                    coutEvens++; //chẵn thì đếm luôn
                }
                else //lẻ thì theo đường lẻ
                {
                    sumOdds += i;
                    coutOdds++;
                }
            }
            return sumAll;
        }
    }
}
//CHALLENGE : VỚI THAM SỐ CÓ TỪ KHÓA IN NGHĨA LÀ KHIẾN CHO BIẾN ĐẦU VÀO 
//KHONG THỂ THAY ĐỔI ĐC VAULE NÓ NHẬN TỪ BÊN NGOÀI BAO GIỜ TRNG HAM PHẢI GIỮ NGUYÊN GIÁ TRỊ
//VÍ DỤ VOID F(IN INT X) TRONG HÀM F CẤM THAY ĐỔI GIÁ TRỊ CỦA X MỘT KHI X ĐƯỢC ĐƯỢC THAY ĐỔI NHẬN VALUE KHI GỌI HÀM 

//VẬY NẾU IN ĐI KÈM VỚI BIẾN OBJECT VÍ DỤ
//VOID F(IN STUDENT S)
//THÌ LÚC NÀY S CÓ ĐƯỢC QUYỀN THAY ĐỔI CÁI GÌ QUANH X HAY KHÔNG 
//VỮNG ÔP THÌ SẼ TRẢ LỜI ĐƯỢC X THỰC SỰ KO ĐƯỢC THAY ĐỔI CÁI GÌ HAY KHÔNG
