using BookManagementBLL.Services;
using BookManagementDAL.Models;
using System.Windows;

namespace BookManagementUI
{
    /// <summary>
    /// Interaction logic for BookDetail.xaml
    /// </summary>
    public partial class BookDetail : Window
    {
        private BookService _service = new();
        private CategoryService _categoryService = new();
        public Book SelectedBook { get; set; }

        public BookDetail()
        {
            InitializeComponent();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBook == null)
            {
                AddBook();
            }
            else
            {
                UpdateBook();
            }

            this.Close();
        }
        private void UpdateBook()
        {
            SelectedBook.BookName = BookNameTextBox.Text;
            SelectedBook.Description = DescriptionTextBox.Text;
            SelectedBook.Author = AuthorTextBox.Text;
            SelectedBook.PublicationDate = DateTime.Parse(PublicationDateDatePicker.Text);
            SelectedBook.Quantity = int.Parse(QuantityTextBox.Text);
            SelectedBook.Price = double.Parse(PriceTextBox.Text);
            SelectedBook.BookCategoryId = int.Parse(BookCategoryIdComboBox.SelectedValue.ToString());

            _service.UpdateBook(SelectedBook);
        }
        private void AddBook()
        {
            if (BookNameTextBox.Text.Length < 5 || BookNameTextBox.Text.Length > 90)
            {
                MessageBox.Show("BookName must be between 5 and 90 characters");
                return;
            }

            if (!char.IsUpper(BookNameTextBox.Text[0]) || BookNameTextBox.Text.Skip(1).Any(char.IsUpper))
            {
                MessageBox.Show("BookName must start with a capital letter and only the first letter can be uppercase");
                return;
            }

            if (int.Parse(QuantityTextBox.Text) < 0 || int.Parse(QuantityTextBox.Text) > 4000000)
            {
                MessageBox.Show("Quantity must be between 0 and 4000000");
                return;
            }

            if (double.Parse(PriceTextBox.Text) < 0 || double.Parse(PriceTextBox.Text) > 4000000)
            {
                MessageBox.Show("Price must be between 0 and 4000000");
                return;
            }
            Book book = new()
            {
                BookId = int.Parse(BookIdTextBox.Text),
                BookName = BookNameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Author = AuthorTextBox.Text,
                PublicationDate = DateTime.Parse(PublicationDateDatePicker.Text),
                Quantity = int.Parse(QuantityTextBox.Text),
                Price = double.Parse(PriceTextBox.Text),
                BookCategoryId = int.Parse(BookCategoryIdComboBox.SelectedValue.ToString())
            };

            _service.AddBook(book);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookCategoryIdComboBox.ItemsSource = _categoryService.GetAllCategories();
            BookCategoryIdComboBox.DisplayMemberPath = "BookGenreType";
            BookCategoryIdComboBox.SelectedValuePath = "BookCategoryId";

            if (_book != null)
            {
                BookIdTextBox.Text = SelectedBook.BookId.ToString();
                BookNameTextBox.Text = SelectedBook.BookName;
                DescriptionTextBox.Text = SelectedBook.Description;
                AuthorTextBox.Text = SelectedBook.Author;
                PublicationDateDatePicker.Text = SelectedBook.PublicationDate.ToString();
                QuantityTextBox.Text = SelectedBook.Quantity.ToString();
                PriceTextBox.Text = SelectedBook.Price.ToString();
                BookCategoryIdComboBox.SelectedValue = SelectedBook.BookCategoryId;
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}