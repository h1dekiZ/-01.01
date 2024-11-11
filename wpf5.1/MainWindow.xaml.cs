using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace wpf5._1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Изменение стиля текстового поля, которое получило фокус
            (sender as FrameworkElement).Style = (Style)Resources["LargeTextBoxStyle"];
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Возвращение стандартного стиля текстовому полю, которое потеряло фокус
            (sender as FrameworkElement).Style = (Style)Resources["SmallTextBoxStyle"];
        }
    }
}