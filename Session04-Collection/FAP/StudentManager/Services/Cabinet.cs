using StudentManager.Entities;

namespace StudentManager.Services
{
    public class Cabinet
    {
        //đặc tính của cái Tủ sẽ là: sức chứa, chứa loại hồ sơ, đồ vật nào đó, object nào đó, mà là nhiều object. Lập trình: chứa nhiều là KHAI BÁO MÁNG.MÁNG NHỚ ĐI KÈM BIỀN COUNT ĐỂ KIỂM SOÁT SỐ PHẦN TỬ MẢNG

        //HÀNH ĐỘNG CỦA CÁI TỦ: CRUD - CREATE | RETRIEVE/READ | UPDATE | DELETE
        private Student[] _arr = new Student[30];
        private int _count = 0;

        public Cabinet(int size)//tủ đóng theo yêu cầu
        {
            _arr = new Student[size];
        }
        public Cabinet()
        {

        }
        //GET() SET() VIẾT THẾ NÀO??? CÓ LÀ GET() SET() STYLE MỚI ĐÃ HỌC HAY KO
        //KO LÀM GET() SET() KIỀU MỚI, TRUYỀN THỐNG CX KO LUÔN
        //auto-implemented, fullprop
        // NẾU LÀM GET() GET _ARR, THÌ TRẢ VỀ NGUYÊN MẢNG, 30 BIẾN STUDENT TRỎ VÀO 30 VŨNG NEW STUDENT(), KO CÓ XỨ LÍ GÌ THÊM, DATA THÔ ĐƯA RA > THIẾU Ý NGHĨA VIỆC XỬ LÍ HƯỚNG USER -> GET KO CẦN(CHỨ KO PHẢI LÀ KO ĐC LÀM HÀM GET)
        // NẾU LÀM SET() THÌ SAO; SET 1 MẢNG = MÀNG KHÁC, _ARR = MÃNG KHÁC
        //PHÍ CÔNG NEW Ở TRÊN
        //NGOÀI ĐỜI: CHỜ ĐỦ NHIỀU OBJECT MỚI ĐƯA VÀO MẢNG, CHỜ ĐỦ NHIỀU ĐỒ MỚI BỎ VÀO TỦ -> SAI SAI, KO HIỆU QUẢ
        //HAM SET() KO HAY, KO PHẢI KO ĐC
        //MÀ CÁI MẢNG _ARR NÊN CÓ ĐC HỒ SƠ NÀO, THÌ ADD VÀO MẢNG, ADD VÀO TỦ NGAY CÁI ĐÓ, HÀM ADD() CREATE() 1 MÓN XUẤT HIỆN|
        //NGOÀI ĐỜI: ĐÂU CẦN CHỜ ĐỦ NHIỀU ĐƠN HÀNG ĐẾN, NHIỀU K/H GỌI MỚI XỬ LÍ ĐƠN, MỚI TẠO ĐƠN, MÃ LÀ AI ĐẾN PHỤC VỤ LUÔN, CREATE TỪNG CÁI
        //NGOÀI ĐỜI: KO CHỜ 10 XE VÀO 1 LƯỢT, NHƯNG ĐC QUYỀN LÀM
        //TRONG APP: TẠO MỚI TỪNG ĐƠN HÀNG, TỪNG GIỎ HÀNG, MÓN HÀNG TRONG GIỎ ÀO AT 1 LƯƠT: GOM HẾT TRÊN TAY, UP VÀO CÁI XE ĐẨY
        //IMPORT DANH SÁCH SINH VIÊN TỪ BÊN TUYỂN SINH
        //IMPORT DANH SÁCH K/H TỪ BÊN SALES, TỪ BÊN PHẦN MỀM CŨ ĐEM SANG

        //GET COUNT() CÓ VỀ OKIE, THỐNG KÊ SỐ LƯỢNG HỢP LÍ: NÓI RẰNG ĐẦY CHƯA???
        //SET COUNTC) CỔ VỀ OKIE HEM??? KO HỢP LÍ, VÌ NÓ PHẢI PHÂN ÁNH SỐ VALUE ĐC GÁN VÀO MÃNG ,*+ CO LÍ DO, GÁN LUNG TUNG, MÃNG LÚNG VALUE À???
        //NGOÀI ĐỜI: KO CHỜ 10 XE VÀO 1 LƯỢT.

        // CÁC HÀM XỬ LÍ DATA: CRUD TRÊN MẢNG, THEO TỪNG MÓN 1 MỚI HỢP LÍ
        //KO GETO) SETO) TRÊN MẢNG

        public void PrintStudentList()
        {//for hết hay for count, for hết phải kiểm tra null ArrayList khỏi lo
            Console.WriteLine("There is/are {0} student(s) in the cabinet", _count);
            for (int i = 0; i < _count; i++)
            {

                _arr[i].ShowProfile();
            }
        }
        public void AddAStudent()
        {
            //phải có lệnh nhập id, name, yob, gpa của từng sinh viên ở đây!!!
            // arr[_count] = new Student() {....}
            // _count++;
            //lệnh nhập data phụ thuộc vào UI: console, web, form (màn hình trên desktop )


        }

        public void AddAStudent(string id, string name, int yob, double gpa)
        {
            //phải có lệnh nhập id, name, yob, gpa của từng sinh viên ở đây!!!
            // arr[_count] = new Student() {....}
            // _count++;
            //lệnh nhập data phụ thuộc vào UI: console, web, form (màn hình trên desktop )


        }
        public void AddAStudent(Student s)
        {
            //phải có lệnh nhập id, name, yob, gpa của từng sinh viên ở đây!!!
            // arr[_count] = new Student() {....}
            // _count++;
            //lệnh nhập data phụ thuộc vào UI: console, web, form (màn hình trên desktop )
            if (_count == _arr.Length)
            {
                Console.WriteLine("The cabinet is full, cannot add more student");
                return;
            }
            _arr[_count++] = s;
            // _count++;
        }
        // CÁC HÀM TRÙNG TÊN TRONG 1 CLASS, NHƯNG KHÁC THAM SỐ => OVERLOAD, OVERLOADING
        //OVERLOAD LÀ 1 THỂ HIỆN CỦA NGUYÊN LÍ ĐA HÌNH - POLYMORPHISM
        //TỪ 1 HÀM, ÁNH XẠ NHIỀU CÁCH CÀI CODE - IMPLEMENTATION

        //OVERRIDE MỚI ĐÃ HƠN, CHA GỌI HÀM, CÁC CON HƯỚNG ỨNG! !!








    }
}
