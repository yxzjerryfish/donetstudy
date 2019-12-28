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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCubeAnimation
{
    /// <summary>
    /// 此示例取自微软官方示例：
    /// https://github.com/microsoft/WPF-Samples/tree/master/Sample%20Applications/CubeAnimationDemo
    /// 略作调整
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Globals

        private Trackball _trackball;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            // setup trackball for moving the model around
            _trackball = new Trackball();
            _trackball.Attach(this);
            _trackball.Slaves.Add(myViewport3D);
            _trackball.Enabled = true;
        }

        #region Events

        private void OnImage1Animate(object sender, RoutedEventArgs e)
        {
            var s = (Storyboard)FindResource("RotateStoryboard");
            BeginStoryboard(s);
        }

        #endregion
    }
}
