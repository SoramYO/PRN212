using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Models;
using System.Windows;

namespace AirConditionerShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StaffMemberService _staffMemberService = new();
        public StaffMember StaffMember { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = _staffMemberService.StaffLogin(UsernameTextBox.Text, PasswordTextBox.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password!");
            }
            else
            {
                if (user.Role == 1 || user.Role == 2)
                {
                    MessageBox.Show("Login successful!");
                    AirConditionnerShop airConditionnerShop = new();
                    airConditionnerShop.StaffMember = user;
                    airConditionnerShop.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("You are not authorized to login!");
                }
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}