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

namespace NavigationViewSample
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
            foreach(var i in Enumerable.Range(0, 50))
            {
                var win = new NavWindow();
                win.Show();
                win.Close();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.GC.Collect();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (var i in Enumerable.Range(0, 50))
            {
                var win = new Window();
                win.Show();
                win.Close();
            }
        }
    }
}
