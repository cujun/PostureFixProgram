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
using System.Windows.Shapes;

namespace Microsoft.Samples.Kinect.BodyBasics
{
    /// <summary>
    /// SquatExample.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SquatExample : Window
    {
        public SquatExample()
        {
            InitializeComponent();

            this.Top = 150;
            this.Left = 120;
            this.Example.Volume = 0;
            this.Example.MediaEnded += new RoutedEventHandler(ExampleEnded);
        }

        private void ExampleEnded(object sender, EventArgs e)
        {
            this.Example.Position = TimeSpan.FromSeconds(0);
        }
    }
}
