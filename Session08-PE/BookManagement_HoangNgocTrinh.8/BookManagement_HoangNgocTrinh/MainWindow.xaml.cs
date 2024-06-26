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

        private void LoadBookButton_Click(object sender, RoutedEventArgs e)
        {
            _service = new BookService();
            BookListDataGrid.ItemsSource = _service.GetAllBooks();
        }
    }
}