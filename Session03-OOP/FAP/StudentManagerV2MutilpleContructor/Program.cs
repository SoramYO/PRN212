using StudentManagerV2MutilpleContructor.Entities;

namespace StudentManagerV2MutilpleContructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //Console.WriteLine(x); //ăn đòn lỗi ngay lúc gõ lấy rác trong ram để in

            Student s1 = new("SE1", "Nguyễn Văn An", 2000, 8.6);

            Student s2 = new(gpa: 9.0, yob: 2001, name: "Nguyễn Văn Bình", id: "SE2");
            //name agument đảo thứ tự biến của hàm

            var s3 = new Student("SE3", "Nguyễn Văn Cường");//Default GPA, YOB
            Console.WriteLine("s3 with default value");
            Console.WriteLine(s3);
            s3.SetYob(2006);
            s3.SetGpa(7.5);
            Console.WriteLine("s3 after set value");
            Console.WriteLine(s3);

            //có bao nhiều constructor thì có bấy nhiêu cách new
            //và nhớ là giá trị default nếu không truyền đủ giá trị (k mang rác như biến local)

            //hàm set() get() gọi thoải mái N lần trên từng
            //object mà không tạo ra vùng new mới
            //nó chỉnh sửa info của object vaungf new đã tạo trước đó
            //y chang đổi avatar

            //hàm new kèm contructor -> vùng new mới -> object mới cứ new là vùng object ram mới

            //new phải có tham số nếu không 

            //sv thứ 4
            Student s4 = new Student("SE4", "Nguyễn Văn Dũng", 2002, 8.0);
            //new trả về địa chỉ tọa độ can nhà bự trong ram
            //trả về địa chỉ vùng new, byte thứ mấy trong ram
            //địa chỉ có gán được cho s4 hay s4 gọi là con trỏ pointer, point to vùng new
            //s4. tức là vào vùng new tức là vào vùng new xem có đứa nào punlic ko thì mình giao tiếp với nó
            //y chang đi đến cổng nhà 1 căn nhà bấm chuông đó
            //gia chủ có muốn ra tiếp hay không public hay private

            s4.ShowProfile();
            new Student("SE4", "Nguyễn Văn Dũngxx", 2002, 8.0).ShowProfile();
            //object được tạo ra nhưng lại không tạo biến để móc vào để tham chiếu lâu dài
            //y chang con diều  bay cao đứt dây
            //ta không có cơ hội giựt dây con diều nhiều lần gọi hàm object nhiều lần
            //vùng new được tạo ra mà không có biến móc vào vùng object này gọi là object vô danh, ANONYMOUS OBJECT
            //ta chỉ có cơ hội gọi hàm của nó vào vùng new chấm đúng 1 lần vì vừa new đã có tọa độ chấm được ngay!!!
            //sau đó không lưu tọa độ lâu dài làm sao chấm tiếp, làm sao gọi ram tiếp được
            //vùng ram mà không có con trỏ móc vào chơi trò này mau hết ram. leak memory cho nên java c# có 1 cơ chế giám sát vùng ram runtime có 1 đoạn code nhỏ định kì quét từng vùng ram coi có con diều nào đứt dây không, object nào không có con trỏ nó clear đánh dấu vùng ram tự do để sau này new tiếp đoạn code này gọi là công ty môi trường đô thị dọn rác object - GARBAGE COLLECTOR

            //KHI NÀO CHƠI TRÒ ANONYMOUS OBJECT 
            //TA CHỈ MUỐN TẠO OBJECT, GỌI HÀM, LẤY KẾT QUẢ TRẢ VỀ RỒI K CARE OBJECT
            //=============
            //JAVA
            //Random rd = new Random();
            //double x = rd.nextDouble(); //(0.1)
            //double x = new Random.nextDouble()

            //nếu ta muốn loại bỏ 1 object trong ram dẹp 1 vùng new không dùng nữa thì loại bỏ hết các biến trỏ đến nó là xong
            //loại = cách chó biến con trỏ vùng new khác hoặc cho biến = null trỏ đáy ram là xong
            s4 = null; //vùng new trước đó bị trỏ bởi s4 đã mồ côi
            //CTY MTDT dọn dẹp sớm

            //= null dùng khi: reset biến object của ta, hoặc trả về nothing khi search 1 object ko thấy !!!!
            //thấy thì phải trỏ vùng new đã có

        }
    }
}
