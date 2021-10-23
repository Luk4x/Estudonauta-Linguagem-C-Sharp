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

namespace Ex006
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ushort nasc = 0;
            ushort.TryParse(txtB.Text, out nasc);
            lbl.Content = $"Atualmente estamos em {DateTime.Now.Year}.\nSe você nasceu em {nasc}, então deve ter {DateTime.Now.Year-nasc} anos.";
            lbl.Visibility = Visibility.Visible;
        }
    }
}
