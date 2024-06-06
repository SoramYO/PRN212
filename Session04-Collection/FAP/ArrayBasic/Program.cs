namespace ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntegerListV6();
        }

        static void PlayWithIntegerListV6()
        {
            int a = 10;
            int b = a; //primitive, value-type; b có value của a
            //mảng chơi trò gán bằng thì sao
            int[] arr1 = { 5, 10, 15, 20 }; //new ngầm int[4] 

            int[] arr2 = { 2, 4, 6, 8 };

            Console.WriteLine("Arr2 first");
            foreach (int x in arr2)
                Console.Write($"{x} ");
            Console.WriteLine();

            arr2 = arr1; //2 chàng 1 nàng

            arr1[0] = 999;

            Console.WriteLine("Arr2 after a sign");
            foreach (int x in arr2)
                Console.Write($"{x} ");
            Console.WriteLine();
            arr2[1] = 662024;
            Console.WriteLine("Arr1 after a modify by arr2");
            foreach (int x in arr1)
                Console.Write($"{x} ");
            Console.WriteLine();
        }
        //toán tử với mọi trong tập hợp
        static void PlayWithIntegerListV5()
        {
            int[] arr = new int[10]; //10 elements 10 phần tử 
                                     //int lẻ nay đc gom chung trong tên arr. arr là biến má mì quản lí 10 biến con kiểu int arr[0] arr[1], ....
                                     //có 11 biến: 1 má mì + 10 biến con
            arr[0] = 5;
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            //gán trước 4 giá trị cho 4 biến đầu 
            //vùng 6 biến int còn lại sẽ mang default - object là vậy k đủ info là mang default
            //số -> default = 0
            //bool -> default = false
            //object -> default = null trỏ đáy ram
            Console.WriteLine("The list of number");
            //for (int i = 0; i < arr.Length; i++)
            for (int i = 0; i < 4; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine(@"
The list of number");
            foreach (int x in arr) //toán tử với mọi x thuộc tập hợp arr - là 1 đống biến int [i]
                //x có quyền bằng từng con số trong mảng = phần tử thứ [i]
                Console.Write($"{x} ");
            Console.WriteLine();


        }
        static void PlayWithIntegerListV4()
        {
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            Console.WriteLine("The list of 5, 10, (printed by using for each)");
            //với mỗi x rơi vào in tập arr thì x có thể = arr[0] hoặc arr[1] hoặc arr[2] hoặc arr[3] hoặc arr[4] hoặc arr[5] hoặc arr[6] hoặc arr[7] hoặc arr[8] hoặc arr[9]
            //arr[i] toán tử với mọi trong tập hợp toán học
            //chơi với x chính là chơi với arr[i]
            foreach (int x in arr)
            {
                Console.Write($"{x} ");//
                //với x sẽ quét từng phần tử trong value
            }
            Console.WriteLine();
            //sql nói chung
            //select * from student where province in ('HN', 'HCM', 'DN')
            foreach (var x in arr)
            {
                Console.Write($"{x * 2} ");
            }
        }
        static void PlayWithIntegerListV3()
        {
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //in mảng, in từng biến 1
            Console.WriteLine("the list of 5, 10....");
            //  Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");
            //xài lố phần từ app bị giết ngay - out of range exception
            //for (int i = 0; i < 10; i++)
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            //tính tổng của mảng
            int sum = 0;
            Console.WriteLine("The list sum of 5 10 ....");
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum 5 10 15 ... " + sum);

        }
        //challenge 1: HÃY LƯU TRỮ VÀ IN RA DÃY SỐ 5 10 15 20 25 30 35 40 45 50
        //Challenge 2: HÃY LƯU TRỮ LƯỢNG MƯA TỪNG NGÀY CỦA TỪNG NĂM
        //             QUY MÔ DATA: 365 x SỐ NĂM
        //MỤC TIÊU CHALLENGE 2: LƯU TRỮ NHIỀU DATA, CHƯA BÀN XỬ LÍ
        //LƯU DỮ LIỆU TRONG RAM: BIẾN
        //LƯU TRỮ DỮ LIỆU LÂU DÀI - THIẾT BỊ LƯU TRỮ HDD/SSD
        //                          CÂY THƯ MỤC, DATA BASE
        //CẦN NHIỀU BIẾN THÌ LƯU ĐƯỢC NHIỀU VALUE

        //VÌ TẠI 1 THỜI ĐIỂM, 1 BIẾN CHỈ LƯU ĐƯỢC 1 VALUE
        static void PlayWithIntegerListV2()
        {
            //khai báo sỉ các biến: khai báo nhiều biến, nhưng nhanh và hiệu quả
            //mảng là kĩ thuật khai báo biến, nhiều biến cung lúc, cùng kiểu, cùng tên và sát nhau trong ram - y chang dãy nhà chung cư
            //int[] arr1; //arr1 không phải là 1 biến int vì có dấu []
            // arr1 là 1 biến không phải biến int mà là biến , mà là tên gọi, mà là tên biến đại diện cho nhiều biến int khác
            //tức là biến arr không mang giá trị 5 10 15 20; mà nó là tên gọi chung
            //cho nhiều biến int khác mà nó nắm giữ quản lí
            //arr: tui gọi là biến má mì(tú ông, tú bà)
            //hỏi arr: ông có gì, bà có gì, tôi có nhiều kẻ dưới tay, dưới trướng
            //nghe mùi bang hội , nhiều kẻ cùng style - mảng là nhiều biến cùng kiểu
            // int[] arr = 10; gãy vì arr là ám chỉ nhiều biến int, cần thêm nhiều value; vì không là biến đơn
            int[] arr1 = { 1 };
            int[] arr2 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //new ngầm
            //arr2 đại diện cho 10 biến int khác
            //            5 là giá trị của biến đầu tiên int trong 10 biến int
            //            10 là giá trị của biến thứ 2 int trong 10 biến int
            //mỗi biến trong mảng là 1 phần tử của mảng
            //element of array
            int[] arr3 = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];

            int[] arr4 = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            int[] arr5 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            int[] arr6;

            arr6 = new int[10];

            arr6[0] = 5;
            arr6[1] = 10;
            arr6[2] = 15;
            arr6[3] = 20;
            //.....

            int[] arr7 = new int[10];
            arr7[0] = 5;
            arr7[1] = 10;
            arr7[2] = 15;
            arr7[3] = 20;
            //tổng quát : có 2 cách khai báo mảng - khai báo nhiều biến
            //vừa khai báo vừa gán giá trị cho mảng
            //khai báo mảng 1 câu lệnh sau đó gán value cho từng phần tử
            //cách này gõ từng biến hơi mất sức

            //new int[...] chính là xin vùng ram bự để chưa biens khác
            //new có thể ngầm k cần gõ ra new chơi trò khai báo mảng vừa gán value
            //vậy nên khai báo mảng theo style nào
            //thực tế: style 2 lí do ta đâu biết trước hết value của mảng


            int[] arr8 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            int[] arr9 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            //má mì quản lí 10 biến int khác
            //                       [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]
            //                    arr[0]
            //                    int a
            //                        arr[1]
            //                        int b
            //[] biểu diễn tên phụ khi các biến xài chung tên arr
            //arr => má mì quản lí 10 đứa cùng tên arr phân biệt bằng tên phụ
            //        arr[0] arr[1] arr[2] arr[3] ... arr[9] là biến int
            //                        dưới trướng
            //arr không ngoặc vuông là: má mì
            //arr ngoặc vuông những đưa dưới bàn tay má mì => đứa/biến lưu value thực sự
            //arr[0] là có value 5
            //arr[1] là có value 10

            //[0... tối đa-1]  [0..9] nếu mảng 10 phần tử
            //0 -> 9 gọi là chỉ số phần tử của mảng biến thứ 0..9
            //index 1
            //khi chơi với mảng index 1 chạy từ 0 dến 9 ta sẽ dùng vòng lặp
            //chơi với for i [0..9]
            //ta sờ được các biến k mất sức 2 dòng lệnh for
            //mảng 500000 phần tử 2 dòng lệnh
            //ưu điểm dùng ít lệnh mà quét được nhiều biến







        }
        static void PlayWithIntegerListV1()
        {
            //HÃY LƯU TRỮ VÀ IN RA DÃY SỐ 5 10 15 20 25 30 35 40 45 50
            //kĩ thuật trâu bò
            //int a, b, c, d, e;
            //int f, g, h, i, j;
            //a = 5; b = 10; c = 15; d = 20; e = 25; f = 30; g = 35; h = 50; i = 45; j = 50;
            //khai báo lẻ

            int a = 5, b = 10, c = 15, d = 20, e = 25, f = 30, g = 35, h = 50, i = 45, j = 50;
            //in kết quả 
            Console.WriteLine("The list of 5 10 15 ...");
            Console.WriteLine($"{a} {b} {c} {d} {e}{f} {g} {h} {i} {j}");
            //khai báo lẻ rời rạc từng biến
            //cách này không hiệu quả mất sức nếu có nhiều biến
            //cần lưu trữ bao nhiêu value ta cần bấy nhiêu biến

            //tính toán, xử lí: tính tổng của chúng
            int sum = a + b + c + d + e + f + g + h + i + j;
            //tưởng tượng tính lượng mưa cả năm - tự tay gõ 365 biến
            Console.WriteLine("Sum 5 10 15 ..." + sum);
        }
    }
}
//CHỐT HẠ: MĂNG LÀ KHAI BÁO NHIỀU BIẾN CÙNG LÚC CÙNG KIỂU CÙNG TÊN, Ở SÁT NHAU TRONG RAM
//VẬY THÌ GÁN GIÁ TRI CHO NHIỀU BIẾN THÌ SẼ LÀ LÔI TỪNG BIẾN THỨ [I] RA = VALUE; 
//THƯỜNG MẢNG SẼ LUÔN CHƯA ĐẦY, MỌI BIẾN SẼ CHƯA ĐC GÁN VALUE
//EX. LƯỢNG MƯA TỪNG NGÀY TRONG NĂM -> MÃNG 365 BIẾN DOUBLE
//TẠI LÚC NÀY - 6/2024 MẢNG MỚI ĐẦY 1/2
//FOR HET NĂM LÀ KO CĂN THIẾT, DO 1/2 NĂM CÔN LẠI LÀ 0 - DEFAULT, ĐÃ SANG NGÀY MỚI ĐÂU MÀ ĐO MƯA! ! !
//* CHƠI VỚI MÃNG TA HAY - LUÔN FOR ĐẾN COUNT - COUNT LÀ 1 BIỀN ĐỂM LƯU SỐ LƯỢNG BIẾN ĐANG CÓ VALUE! ! !!
//COUNT = 4, MÀNG CÓ 10 BIẾN, BIẾT NGAY CÒN 6 BIẾN SẼ CẦN GÁN VALUE! !!
//FOR ĐẾN 4 TRONG BÀI NÀY, FOR ĐẾN COUNT ĐẦM BẢO IN VALUE CÓ NGHĨA, CÒN LẠI DEFAULT KO CARE!|
//CHỐT HẠ: GÁN MẢNG CHO MẢNG, MÁ MÌ = MÁ MÌ KHÁC, 2 CHÀNG 1 NÀNG
// 2 MÁ MÌ CÙNG QUẢN 1 ĐÁM! !!