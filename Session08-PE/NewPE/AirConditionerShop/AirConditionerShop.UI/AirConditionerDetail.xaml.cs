using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Models;
using System.Text.RegularExpressions;
using System.Windows;

namespace AirConditionerShop.UI
{
    /// <summary>
    /// Interaction logic for AirConditionerDetail.xaml
    /// </summary>
    public partial class AirConditionerDetail : Window
    {
        private SupplierCompanyService _supplierCompanyService = new();
        private AirConditionService airConditionService = new();
        public AirConditioner UpdateAir { get; set; }
        public AirConditionerDetail()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SupplierComboBox.ItemsSource = _supplierCompanyService.GetAllSupplierCompany();
            SupplierComboBox.DisplayMemberPath = "SupplierName";
            SupplierComboBox.SelectedValuePath = "SupplierId";
            SupplierComboBox.SelectedIndex = 0;
            BookDetailLabel.Content = "Create Air Conditioner";
            if (UpdateAir != null)
            {

                AirConditionerIdTextBox.Text = UpdateAir.AirConditionerId.ToString();
                AirConditionerNameTextBox.Text = UpdateAir.AirConditionerName;
                WarrantyTextBox.Text = UpdateAir.Warranty;
                SoundPressureLevelTextBox.Text = UpdateAir.SoundPressureLevel;
                FeatureFunctionTextBox.Text = UpdateAir.FeatureFunction;
                QuantityTextBox.Text = UpdateAir.Quantity.ToString();
                DollarPriceTextBox.Text = UpdateAir.DollarPrice.ToString();
                SupplierComboBox.SelectedValue = UpdateAir.SupplierId;

                BookDetailLabel.Content = "Update Air Conditioner";
                AirConditionerIdTextBox.IsEnabled = false;
            }

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (UpdateAir != null)
            {
                if (AirConditionerNameTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the fields");
                    return;
                }
                int quantity = int.Parse(QuantityTextBox.Text);
                int price = int.Parse(DollarPriceTextBox.Text);
                if (quantity < 0 && price < 0)
                {
                    MessageBox.Show("Quantity and price must be greater than 0");
                    return;
                }
                if (quantity > 4000000 && price > 4000000)
                {
                    MessageBox.Show("Quantity and price must be lower than 4.000.000");
                    return;
                }
                if (AirConditionerNameTextBox.Text.Length > 90 && AirConditionerNameTextBox.Text.Length < 5)
                {
                    MessageBox.Show("Air conditioner name must be between 5 and 90 characters");
                    return;
                }
                // AirConditionerNameTextBox must begin with the capital letter or digits (1 – 9). AirConditionerName is also allowed with special characters.
                if (!Regex.IsMatch(AirConditionerNameTextBox.Text, @"^[A-Z1-9][a-zA-Z0-9\s]*$"))
                {
                    MessageBox.Show("Air conditioner name must begin with the capital letter or digits (1 – 9). AirConditionerName is also allowed with special characters.");
                    return;
                }
                UpdateAir.AirConditionerName = AirConditionerNameTextBox.Text;
                UpdateAir.Warranty = WarrantyTextBox.Text;
                UpdateAir.SoundPressureLevel = SoundPressureLevelTextBox.Text;
                UpdateAir.FeatureFunction = FeatureFunctionTextBox.Text;
                UpdateAir.Quantity = int.Parse(QuantityTextBox.Text);
                UpdateAir.DollarPrice = double.Parse(DollarPriceTextBox.Text);
                UpdateAir.SupplierId = SupplierComboBox.SelectedValue.ToString();

                airConditionService.Update(UpdateAir);

                MessageBox.Show("Update air conditioner successfully");
                this.Close();
            }
            else
            {
                AirConditioner airConditioner = new()
                {
                    AirConditionerId = int.Parse(AirConditionerIdTextBox.Text),
                    AirConditionerName = AirConditionerNameTextBox.Text,
                    Warranty = WarrantyTextBox.Text,
                    SoundPressureLevel = SoundPressureLevelTextBox.Text,
                    FeatureFunction = FeatureFunctionTextBox.Text,
                    Quantity = int.Parse(QuantityTextBox.Text),
                    DollarPrice = double.Parse(DollarPriceTextBox.Text),
                    SupplierId = SupplierComboBox.SelectedValue.ToString()
                };
                airConditionService.Add(airConditioner);
                MessageBox.Show("Add air conditioner successfully");
                this.Close();

            }



        }
    }
}
