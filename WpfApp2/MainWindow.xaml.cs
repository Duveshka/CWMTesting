using System.Windows;

namespace WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e) //TODO XAML ShowUsages 
        {
            Button1.Width = 200;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Button2.Width = 200;
        }
    }
}