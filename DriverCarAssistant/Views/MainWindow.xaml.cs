using DriverCarAssistant.Views;
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

namespace DriverCarAssistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResetButtonState();
            ((Button)FindName("Button1")).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1EBD55"));
            ((Button)FindName("Button1")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
            var page = new Drivers();
            mainFrame.Content = page;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResetButtonState();
            ((Button)FindName("Button1")).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1EBD55"));
            ((Button)FindName("Button1")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
            var page = new Drivers();
            mainFrame.Content = page;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResetButtonState();
            ((Button)FindName("Button2")).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1EBD55"));
            ((Button)FindName("Button2")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
            var page = new Cars();
            mainFrame.Content = page;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResetButtonState();
            ((Button)FindName("Button3")).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1EBD55"));
            ((Button)FindName("Button3")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
            var page = new Trailers();
            mainFrame.Content = page;
        }

        private void ResetButtonState()
        {
            ((Button)FindName("Button1")).Foreground = Brushes.White;
            ((Button)FindName("Button2")).Foreground = Brushes.White;
            ((Button)FindName("Button3")).Foreground = Brushes.White;
            ((Button)FindName("Button1")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#30302F"));
            ((Button)FindName("Button2")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#30302F"));
            ((Button)FindName("Button3")).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#30302F"));
        }
    }
}
