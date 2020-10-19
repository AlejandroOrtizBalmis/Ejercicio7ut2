using System.Windows;
using System.Windows.Controls;

namespace Ejercicio7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            primerRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoTextBlock.FontSize = double.Parse((sender as RadioButton).Tag.ToString());
        }
    }
}
