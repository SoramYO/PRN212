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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //mở màn hình MainWindow
            //khai báo biến tạo object và render
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide(); //vì class login kế thừa từ class cha Window của OS, có sẵn hàm của cha là Hide() ẩn chính mình đi không render nữa

        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); //Form Application.Exit();
        }
    }
}
