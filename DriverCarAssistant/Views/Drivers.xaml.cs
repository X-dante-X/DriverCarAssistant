using DriverCarAssistant.DBContext;
using DriverCarAssistant.Models;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for Drivers.xaml
    /// </summary>
    public partial class Drivers : Page
    {
        public Drivers()
        {
            InitializeComponent();
            using Context context = new Context();
            var drivers = context.Drivers.Include(d => d.Passport)
                            .Include(d => d.DrivingLicense)
                            .Include(d => d.Visa)
                            .ToList();

            foreach (var driver in drivers)
            {
                Button button = new Button();
                string text = $"{driver.FirstName} {driver.SecondName}";
                button.Content = text;
                button.Click += (sender, e) => ShowDriverDetails(driver);
                button.Style = FindResource("AddDriverButtonStyle") as Style;
                ButtonContainer.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page newPage = new InsertDriver();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }
        private void ShowDriverDetails(Driver driver)
        {
            DriverDetails detailsPage = new DriverDetails(driver);
            NavigationService.Navigate(detailsPage);
        }
    }
}
