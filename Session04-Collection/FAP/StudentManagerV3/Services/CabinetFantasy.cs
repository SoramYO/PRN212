namespace StudentManagerV3.Services
{
    public class CabinetFantasy<T> //t là data type 
                                   //sẽ là bất kì student hay lecturer và các datatype khác
                                   //class data type đưa vào như 1 param: generic tui làm việc tổng quát chung chung với các datatype

    //neww CabinetFantasy<Student>(); new CabinetFantasy<Lecturer>();
    {
        private T[] _arr;
        private int _count = 0;

        public CabinetFantasy(int size) => _arr = new T[size];
        //TODO nếu size <= 0 hoặc quá lớn thì sẽ báo lỗi
        //CRUD
        public void AddAnItem(T x) => _arr[_count++] = x;
        //TODO nếu _count >= size thì báo lỗi
        public void PrintItems()
        {
            if (_count <= 0)
            {
                Console.WriteLine("Tủ chưa có item nào");
                return;
            }
            Console.WriteLine($"There is/are {_count} item(s)in cabinet");
            for (int i = 0; i < _count; i++)
                Console.WriteLine(_arr[i]);//gọi thầm tên em toString
        }
    }
}
- // BÌNH LUẬN VỀ XÀI MẢNG - ARRAY
  // MĂNG LÀ 1 KĨ THUẬT KHAI BÁO NHIỀU BIẾN CÙNG LÚC, CÙNG KIỂU, CÙNG TÊN, Ở SÁT NHAU
  //int[] arr = new int[10] nghĩa là ta có 10 biến int, 10 phần tử, 10 element
  //value của mỗi biến từ từ gán hoặc gán luôn...

//Student[] arr = new Student[10] nghĩa là có 10 biến Student đang chờ trỏ vào 10 vùng new Student() { } vì biến object thì phải trỏ vùng new

// còn biến int, long, double... biến primitive - value type lưu trực tiếp value trong biến
// - CHƠI VỚI MẢNG DỄ HIỂU, DỄ DÙNG, [I] = .... SET, GĂN GIÁ TRỊ CHO BIẾN, CHO PHẦN TỨ

//                                   [I] GETC) LÃY GIA TRI RA DUNG
//*GIÁ PHẢI TRẢ CỦA XÀI MẢNG
//- BỊ GIỚI HẠN KÍCH THƯỚC, KO NỚI THÊM ĐC SỐ PHẦN TỬ, MUỐN NỚI, THÌ XIN NEW HOÀN TOÀN MẢNG MỚI, COPY MẢNG CŨ SANG
// - PHẢI ĐI KÈM BIẾN COUNT, ĐỂ FOR ĐẾN ĐÚNG SỐ PHẦN TỬ ĐÃ ĐC GÁN GIÁ TRỊ CON CHỪNG NULL REFERENCE EXCEPTION 

// - XOÁ 1 PHẦN TỬ KHỎI MÀNG, KO XÓÁ ĐC,
//5 10 15 20 25
//[] [][][][] →> 20 BYTE
//  5 10 20 25 ->XOÁ LÀ LỪA ĐẢO, DỜI CHỖ, GIẢM BIẾN COUNT

//SUY NGHĨ VỀ 1 MÁNG CO GIÃN SỐ PHÂN TỨ! ! !
//TỨC LÀ: CẦN THÊM CHỖ, CHO THEM
//XÓÁ, XOÁ LUÔN
// LUÔN LUÔN DUY TRÌ ĐC COUNT == ĐÚNG SỐ PHẦN TỬ ĐANG CÓ
//KO CẦN BIẾN COUNT RIÊNG LẺ
//KHỞI ĐẦU PHẢI TRỐNG RỖNG, KO CÓ PHẦN TỬ NÀO, GÁN 1 GIÁ TRỊ, THÌ THỂM 1 PHẦN TỬ

//List , ArrayList,Set , Dictionary ...=> họ class chứa nhiều thứ bên trong (primitive biến object - kiểu như mảng) nhưng co giản số phần tử, thêm, xóa, sửa, đếm số phần tử, ko bị giới hạn số phần tử, ko cần biến count riêng lẻ
//bộ sưu tập - collection 
//giống nhau giữa C# và Java khác cách đặt tên







