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
using static System.Net.Mime.MediaTypeNames;

namespace DriverCarAssistant.Views
{

    /// <summary>
    /// Interaction logic for Cars.xaml
    /// </summary>
    public partial class Cars : Page
    {
        public Cars()
        {
            InitializeComponent();
            using Context context = new Context();
            var cars = from Car in context.Cars
                       select Car;
            foreach (var car in cars)
            {
                Button button = new Button();
                button.Content = car.Nubmer;
                button.Click += (sender, e) => ShowCarDetails(car);

                ButtonContainer.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page newPage = new InsertCar();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }

        private void ShowCarDetails(Car car)
        {
            CarDetails detailsPage = new CarDetails(car);
            NavigationService.Navigate(detailsPage);
        }
    }
}
