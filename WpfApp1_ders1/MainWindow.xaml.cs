using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace WpfApp1_ders1
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

        private void button_left(object sender, RoutedEventArgs e)
        {
            Button bb = (Button)sender;
            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            bb.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            MessageBox.Show($"Content: {bb.Content.ToString()}\n" +
                $"Font Size: {bb.FontSize}\n" +
                $"Height: {bb.Height}\n" +
                $"Width: {bb.Width}\n" +
                $"Background Color: {bb.Background.ToString()}\n" +
                $"Margin: {bb.Margin.ToString()} ");
        }

        private void button_right(object sender, RoutedEventArgs e) { Button bb = (Button)sender; this.Title = bb.Content.ToString(); grid1.Children.Remove(bb);  }
        
     
    }
       
}
