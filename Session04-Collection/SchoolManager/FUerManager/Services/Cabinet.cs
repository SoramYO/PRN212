namespace FUerManager.Services
{
    public class Cabinet<T> //type sẽ lưu trữ và xử lí 1 list hay mảng 
    {
        //private T[] _arr; // = new T[100]; //size nếu qua constructor
        //private int _size = 0;
        private List<T> _list = new();//hok cần constructor để truyền size
        //k cần biến count co giãn số phần tử
        public void PrintItems()
        {
            if (_list.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            Console.WriteLine($"Total items: {_list.Count}");
            foreach (T x in _list)
                Console.WriteLine(x);
        }
        public void Add(T x)
        { //validation here trùng
            _list.Add(x);
        }

    }
}
// Data type - Kiểu dữ liệu - Hình Dáng Của Dữ Liệu

//Có 2 loại data type
//1. Primitive data type - Kiểu dữ liệu nguyên thủy - Kiểu dữ liệu cơ bản - 1 giá trị nào đó
// * Tốn đúng 1 vùng ram để lưu trữ giá trị - 1 biến 1 vùng ram
//int long float double char bool

//2. Object là kiểu dữ liệu phức tạp - Complex, composite data type, gồm nhiều info bên trong
//Dog Cat Student Person
//string buffer, SqlCommand, SqlStatement, Exeption
//Ví dụ kiểu object gồm nhiều info bên trong
//Quy tắc:
//1. Có biến có vùng ram được cấp không care loại biến
//2. Biến primitive cần 1 vùng ram lưu value để dùng ngay trong vùng ram được cấp
//int yob = 2004;
//3. Có new có vùng nhớ mới bự chà bá để lưu các info được đổ vào
//Vùng new là object, sờ bên trong vùng new là chỉ số
//Những thứ public qua dấu chấm
//4. Biến object sẽ trỏ vào vùng new bự biến object lưu tọa độ
// vùng new, biến con trỏ
//để có 1 object tốn 2 vung ram
//biến = trỏ đến new()
//Student s = new Student(){};
//5. Dấu chẩm chỉ dành cho object để nhày vào vùng ram được trỏ
// Nhảy vào vùng new

//Ta đã thiết kế xong class - khuôn đúc object
//Class
//{
//    Backing field +
//    Constructor() +
//    Method() +
//    Property() +
//    ToString() 
//}

//Từ class ta clone/new object ta có nhiều object
//Vậy làm sao để quản lý nhiều object: Lưu trữ xử lí: tính toán

//Để quản lí được nhiều object ta cần nhiều biến tương ưng trỏ vùng new tương ứng
//Làm sao để quản lsi nhiều biến
//Array, List, Dictionary, Queue, Stack, Set, Tree, Graph

