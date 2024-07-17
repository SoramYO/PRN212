using LibraryDAL;
using LibraryDAL.Models;
using Microsoft.EntityFrameworkCore;
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

namespace Library.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LibraryDbContext _context;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book
            {
                BookName = BookNameTextBox.Text,
                BookCategoryId = int.Parse(CategoryTextBox.Text),
            };
            _context = new LibraryDbContext();

            _context.Books.Add(book);
            _context.SaveChanges();
            LoadDataGrid();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _context = new LibraryDbContext();
            BookListDataGrid.ItemsSource = _context.Books.ToList();
        }
        private void LoadDataGrid()
        {
            BookListDataGrid.ItemsSource = null;
            _context = new LibraryDbContext();
            BookListDataGrid.ItemsSource = _context.Books.ToList();
        }

        private void DeleteBookButton_Click(object sender, RoutedEventArgs e)
        {
            _context = new LibraryDbContext();
            _context.Books.Remove(BookListDataGrid.SelectedItem as Book);
            _context.SaveChanges();
            LoadDataGrid();
        }
    }
}