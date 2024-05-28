namespace FunctionRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6868;
            DoSomeThing(ref x);//tao ko chắc hứa có value trả về hay không mày phải nên tự lo trước
                               //1 giá trị default 
            Console.WriteLine("after calling DoSomeThing, x = {0}", x);

        }
        static void DoSomeThing(ref int p)
        {

            p = 3979; //thần tài nhỏ, thần tài lớn
        }
        //REF RẤT GIỐNG OUT, CŨNG LÀ TRUYỀN THAM CHIẾU NHƯNG
        //REF KHÔNG HỨA TRONG HÀM SẼ THAY ĐỔI BIẾN BÊN NGOÀI XA XA
        //NHƯNG NẾU CÓ THAY ĐỔI THÌ BÊN NGOÀI THAY ĐỔI NHƯ OUT
        //THAM CHIẾU NHƯNG LỎNG LẺO HƠN OUT, KHÔNG HỨA RETURN
        //XÀI SẼ KHÁC 1 XÍU
        //BẮT BUỘC BIẾN TRUYỀN VÀO REF PHẢI CÓ GIÁ TRỊ DEFAULT NÀO ĐÓ TRƯỚC KHÔNG THÌ GỌI
        //HÀM XONG, MANG TIẾNG GỌI HÀM MÀ LẠI KO CÓ VALUE, XẤU NHẤT LẤY VALUE MẶC ĐỊNH RA XÀI!!

        //static void Main(string[] args)
        //{
        //    int n = 30; //1 3 5 7 9 11 13 15 17 19 21 23 25 27 29 => 225
        //    int sumA = ConputeOnNumbers(n, out int sumE, out int coutE, out int sumO, out int coutO);
        //    Console.WriteLine("Count odds : {0}", coutO);
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="sumEvens"></param>
        /// <param name="coutEvens"></param>
        /// <param name="sumOdds"></param>
        /// <param name="coutOdds"></param>
        /// <returns></returns>
        static int ConputeOnNumbers(in int n, out int sumEvens, out int coutEvens, out int sumOdds, out int coutOdds)
        {
            sumEvens = 0;
            coutEvens = 0;
            sumOdds = 0;
            coutOdds = 0;
            int sumAll = 0; //biến dành cho return đường chính đạo
            //1 lần duyệt for hỏi đủ các câu thay vì nhiều for, mỗi for 1 câu
            for (int i = 1; i <= n; i++)
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
