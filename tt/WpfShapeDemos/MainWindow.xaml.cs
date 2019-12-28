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

namespace WpfShapeDemos
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
        private void btnIncrease_Click(object sender, RoutedEventArgs e)
        {
            Ellipse1.Width += 10;
            Ellipse1.Height += 10;
        }

        private void btnDecrease_Click(object sender, RoutedEventArgs e)
        {
            Ellipse1.Width -= 10;
            Ellipse1.Height -= 10;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Ellipse1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(string.Format("当前大小：({0},{1})", Ellipse1.Width, Ellipse1.Height));
        }
    }
}
