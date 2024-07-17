using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Models;
using System.Windows;

namespace AirConditionerShop.UI
{
    /// <summary>
    /// Interaction logic for AirConditionnerShop.xaml
    /// </summary>
    public partial class AirConditionnerShop : Window
    {
        private AirConditionService _airConditionService = new AirConditionService();
        public StaffMember StaffMember { get; set; }
        public AirConditionnerShop()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditionerDetail airConditionerDetail = new AirConditionerDetail();
            airConditionerDetail.ShowDialog();

            LoadDataGrid();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (AirConditionDataGridView.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to update");
                return;
            }
            AirConditioner selectedAir = AirConditionDataGridView.SelectedItem as AirConditioner;
            AirConditionerDetail airConditionerDetail = new AirConditionerDetail();
            airConditionerDetail.UpdateAir = selectedAir;
            airConditionerDetail.ShowDialog();

            LoadDataGrid();

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (AirConditionDataGridView.SelectedItem is AirConditioner selectedAir)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    _airConditionService.Delete(selectedAir);
                    LoadDataGrid();
                }
            }

        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
            if (StaffMember.Role == 2)
            {
                CreateButton.Visibility = Visibility.Collapsed;
                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }
        }

        private void LoadDataGrid()
        {
            AirConditionDataGridView.ItemsSource = null;
            AirConditionDataGridView.ItemsSource = _airConditionService.GetAll();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string quantity = SearchByQuantityTextBox.Text;
            string feature = SearchByFeatureTextBox.Text;
            if (!string.IsNullOrEmpty(quantity) || !string.IsNullOrEmpty(feature))
            {
                AirConditionDataGridView.ItemsSource = null;
                AirConditionDataGridView.ItemsSource = _airConditionService.SearchAirConditioner(quantity, feature);
                return;
            }
            else
            {
                MessageBox.Show("Please enter the search criteria");
                LoadDataGrid();
            }

        }
    }
}
