﻿using BookManagementBLL.Services;
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
                if (user.Role == 3)
                {
                    MessageBox.Show("You do not have permission to access this application!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    Session.CurrentUser = user;
                    MessageBox.Show("Login successfully!");

                    MainScreen mainscreen = new();
                    mainscreen.UserAccount = user;
                    mainscreen.Show();
                    this.Hide();

                }
            }
            else
            {
                MessageBox.Show("Login failed!", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
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