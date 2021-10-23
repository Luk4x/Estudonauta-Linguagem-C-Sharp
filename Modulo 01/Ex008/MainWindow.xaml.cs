using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Random ger = new Random();
            int n1 = 0, n2 = 0;
            int.TryParse(txtB1.Text, out n1);
            int.TryParse(txtB2.Text, out n2);
            lbl.Visibility = Visibility.Visible;
            lbl.Content = $"Sorteando de {n1} a {n2}...";
            await Task.Delay(1000);
            lbl.Content = $"Sorteei o valor {ger.Next(n1, n2 + 1)}";
        }
    }
}
