using BookManagementBLL.Services;
using BookManagementDAL.Models;
using BookManagementUI;
using System.Windows;

namespace PE
{

    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        private BookService _service = new();

        public MainScreen()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {
            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = _service.GetAllBooks();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = BookNameTextBox.Text;
            string description = DescriptionTextBox.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                BookListDataGrid.ItemsSource = null;
                BookListDataGrid.ItemsSource = _service.SearchBooks(keyword);
                return;
            }
            else if (!string.IsNullOrEmpty(description))
            {
                BookListDataGrid.ItemsSource = null;
                BookListDataGrid.ItemsSource = _service.SearchBooks(description);
                return;
            }


        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            BookDetail bookDetail = new();
            bookDetail.ShowDialog();

            RefreshDataGrid();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //lấy cuốn sách user chọn từ lưới để đẩy sang detail
            //không lấy từ table
            //Book selected = (Book)BookListDataGrid.SelectedItem;
            //bị exception nếu k ép được ví dụ k chọn dòng nào
            //bắt excetion hoặc if else
            //Book selectedBook = BookListDataGrid.SelectedItem as Book;
            //as ép vế trái thành vế phải nếu k thành công thì gán null thay vì quăng exception
            //if (selectedBook == null)
            //{
            //    MessageBox.Show("Please select a book to update", "Choose one", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
            //}
            if (BookListDataGrid.SelectedItem is Book selectedBook)
            {
                //tìm cách đẩy selectedBook sang BookDetail
                //không xuông db lấy lại
                BookDetail bookDetail = new();
                //đẩy cuốn sách sang bên kia
                bookDetail.SelectedBook = selectedBook;
                bookDetail.ShowDialog();
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a book to update");
            }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookListDataGrid.SelectedItem is Book selectedBook)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this book?", "Delete Book", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    _service.DeleteBook(selectedBook);
                    RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete");
            }
        }
    }
}
