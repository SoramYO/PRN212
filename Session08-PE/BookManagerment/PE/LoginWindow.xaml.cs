using BookManagementBLL.Services;
using BookManagementDAL.Models;
using System.Windows;
namespace PE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserService userservice = new();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = userservice.CheckUserLogin(EmailTextBox.Text, PasswordTextBox.Text);

            if (user != null)
            {
                if (user.Role == 1 || user.Role == 2)
                {
                    Session.CurrentUser = user;
                    MessageBox.Show("Login successfully!");

                    MainScreen mainscreen = new();
                    mainscreen.Show();
            this.Hide();

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