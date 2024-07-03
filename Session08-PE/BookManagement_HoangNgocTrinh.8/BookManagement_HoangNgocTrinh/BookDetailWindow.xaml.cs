using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
using System.Windows;

namespace BookManagement_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for BookDetailWindow.xaml
    /// </summary>
    public partial class BookDetailWindow : Window
    {

        public BookDetailWindow()
        {
            InitializeComponent();
        }
        //2 cái service:

        private BookService _service = new();//lưu sách
        private CategoryService _categoryService = new(); //danh sách cate
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //đổ vào combobox 5 dòng category - treo đầu dê bán thịt chó  chọn sefthelp nhưng lấy 5
            BookCategoryIdComboBox.ItemsSource = _categoryService.GetAllCategories();
            BookCategoryIdComboBox.DisplayMemberPath = "BookGenreType";
            BookCategoryIdComboBox.SelectedValuePath = "BookCategoryId";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.BookId = int.Parse(BookIdTextBox.Text);
            book.BookName = BookNameTextBox.Text;
            book.Description = DescriptionTextBox.Text;
            book.PublicationDate = DateTime.Now;
            book.Quantity = int.Parse(QuantityTextBox.Text);
            book.Price = double.Parse(PriceTextBox.Text);
            book.Author = AuthorTextBox.Text;
            book.BookCategoryId = int.Parse(BookCategoryIdComboBox.SelectedValue.ToString());

            _service.CreateBook(book);

            //về màn hình chính f5
            this.Close();
            //nhan nut save


        }
    }
}
