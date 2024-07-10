using System.Windows;
using System.Windows.Threading;

namespace PE
{
    /// <summary>
    /// Interaction logic for AutoCloseMessageBox.xaml
    /// </summary>
    public partial class AutoCloseMessageBox : Window
    {
        private DispatcherTimer _timer;

        public AutoCloseMessageBox(string message, int displayDurationInSeconds)
        {
            InitializeComponent();
            MessageTextBlock.Text = message;

            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(displayDurationInSeconds)
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            this.Close();
        }
    }
}
