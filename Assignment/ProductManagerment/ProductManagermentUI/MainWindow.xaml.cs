using IronBarCode;
using ProductManagementDAL.Models;
using ProductManagermentBLL.Services;
using QRCoder;
using QRCoder.Xaml;
using System.Drawing;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace ProductManagermentUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductService _productService = new();
        private CategoryService _categoryService = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GenerateBarcode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ProductNameTextBox.Text))
                {
                    // Create product object
                    Product product = new Product
                    {
                        //random id unique for each product
                        Id = Guid.NewGuid(),
                        Name = ProductNameTextBox.Text,
                        Description = ProductDescriptionTextBox.Text,
                        Price = decimal.Parse(ProductPriceTextBox.Text),
                        CategoryId = int.Parse(CategoryCombo.SelectedValue.ToString()),
                        ImagePath = ProductNameTextBox.Text // This will be updated later
                    };


                    // Generate QR code
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(product.Id.ToString(), QRCodeGenerator.ECCLevel.Q);
                    XamlQRCode qrCode = new XamlQRCode(qrCodeData);
                    DrawingImage qrCodeAsXaml = qrCode.GetGraphic(20);
                    QrCodeImage.Source = qrCodeAsXaml;

                    //save qr code image to file
                    QRCode qrCodeSave = new QRCode(qrCodeData);
                    Bitmap qrCodeBitmap = qrCodeSave.GetGraphic(20);
                    string qrCodePath = $"D:\\Documents\\PRN212\\{ProductNameTextBox.Text}qrcode.png";
                    qrCodeBitmap.Save(qrCodePath);

                    // Generate barcode
                    GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(product.Id.ToString(), BarcodeWriterEncoding.Code93);
                    string barcodePath = $"D:\\Documents\\PRN212\\{ProductNameTextBox.Text}barcode.png";
                    barcode.SaveAsPng($"D:\\Documents\\PRN212\\{ProductNameTextBox.Text}barcode.png");

                    // Load the saved barcode image into a BitmapImage
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(barcodePath, UriKind.RelativeOrAbsolute);
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                    BarCodeImage.Source = bitmapImage;

                    product.BarCode = barcodePath;
                    // Add product to database
                    _productService.AddProduct(product);
                }
                else
                {
                    MessageBox.Show("Please enter a product name to generate a QR code.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CategoryCombo.ItemsSource = _categoryService.GetAllCategory();
            CategoryCombo.DisplayMemberPath = "Name";
            CategoryCombo.SelectedValuePath = "Id";
        }

        private void ScanQRCodeButton_Click(object sender, RoutedEventArgs e)
        {
            ScanQRCode scanQRCode = new ScanQRCode();
            scanQRCode.Show();
        }
    }
}