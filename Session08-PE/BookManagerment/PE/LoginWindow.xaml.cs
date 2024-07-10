using BookManagementDAL.Models;
using System.Windows;
namespace PE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainScreen mainScreen = new();
            mainScreen.Show();
            this.Hide();
            //UserService userService = new();
            //var user = userService.CheckUserLogin(txtEmail.Text, txtPassword.Text);

            //if (user != null)
            //{
            //    if (user.Role == 1 || user.Role == 2)
            //    {
            //        Session.CurrentUser = user;
            //        AutoCloseMessageBox autoCloseMessageBox = new AutoCloseMessageBox("Login successful", 1);
            //        autoCloseMessageBox.ShowDialog();
            //        MainScreen mainScreen = new();
            //        mainScreen.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        AutoCloseMessageBox autoCloseMessageBox = new AutoCloseMessageBox("You have no permission to access system!", 1);
            //        autoCloseMessageBox.ShowDialog();
            //    }
            //}
            //else
            //{
            //    AutoCloseMessageBox autoCloseMessageBox = new AutoCloseMessageBox("Wrong Email or Password", 1);
            //    autoCloseMessageBox.ShowDialog();
            //}
        }


        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
public static class Session
{
    public static UserAccount? CurrentUser { get; set; }
}