using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            book.Description = BookDescriptionTextBox.Text;
            book.PublicationDate = DateTime.Parse(BookPublicationDateTextBox.Text);
            book.Quantity = int.Parse(BookQuantityTextBox.Text);
            book.Price = double.Parse(BookPriceTextBox.Text);
            book.Author = BookAuthorTextBox.Text;
            book.BookCategoryId = int.Parse(BookCategoryIdComboBox.SelectedValue.ToString());

            _service.CreateBook(book);

            //về màn hình chính f5
            this.Close();
            //nhan nut save


        }
    }
}
