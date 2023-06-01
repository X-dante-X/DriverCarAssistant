using DriverCarAssistant.DBContext;
using DriverCarAssistant.Models;
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

namespace DriverCarAssistant.Views
{
    /// <summary>
    /// Interaction logic for CarServiceUpdate.xaml
    /// </summary>
    public partial class CarServiceUpdate : Page
    {
        private Car Car;
        public CarServiceUpdate(Car car)
        {
            Car = car;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            Car.Service = int.Parse(((TextBox)FindName("Service")).Text);
            context.SaveChanges();
            CarDetails newPage = new CarDetails(Car);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!Char.IsDigit(ch))
                {
                    e.Handled = true;
                    break;
                }
            }
        }
    }
}
