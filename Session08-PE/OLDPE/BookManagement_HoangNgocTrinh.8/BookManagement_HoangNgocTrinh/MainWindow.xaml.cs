using BookManagement.BLL.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookManagement_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookService _service = new();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void BookMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //đây là hàm sẽ tự được gọi khi cửa sổ này mở lên -Event xuất hiện khi gọi hàm gì - lạp trình sự kiện onclick trong xử lí nút bấm trên html
            //ta sẽ fill vào datagrid tuy nhiên ta sẽ tách việc câu lệnh fill vào datagrid ra 1 hàm riêng để dễ đọc
            //vì việc fill vào grid sẽ xuất hiện nhiều lần
            //1. Mở màn hình lên fill
            //2. Nhấn nút tạo mới cuốn sách tạo mới xong phải f5 lại grid thì mới có cuốn sách mới được thêm
            //3. sửa 1 cuốn sách
            //4. xóa 1 cuốn sách
            //hàm này được dùng ở nhiều nới gọi là helper function private void FillDataGrid()

            LoadDataGrid();

        }
        private void LoadDataGrid()
        {
            BookListDataGrid.ItemsSource = null; //xóa lưới vì đề phòng có data trước đó
            BookListDataGrid.ItemsSource = _service.GetAllBooks();//tải lại data
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookDetailWindow bookDetailWindow = new();
            bookDetailWindow.ShowDialog();
            //f5 grid
            LoadDataGrid();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}