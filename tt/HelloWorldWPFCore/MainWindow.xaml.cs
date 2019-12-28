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

namespace HelloWorldWPFCore
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
        //按钮单击事件响应代码
        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello,WPF!");
            //通过控件名字访问控件属性或调用控件方法
            lblInfo.Content = $"当前时间: {DateTime.Now}";
        }
    }
}
