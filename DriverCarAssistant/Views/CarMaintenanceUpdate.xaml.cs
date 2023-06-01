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
    /// Interaction logic for CarMaintenanceUpdate.xaml
    /// </summary>
    public partial class CarMaintenanceUpdate : Page
    {
        private Car Car;
        public CarMaintenanceUpdate(Car car)
        {
            Car = car;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            Car.MaintenanceDateOfIssue = ((DatePicker)FindName("DateOfIssue")).SelectedDate ?? DateTime.MinValue;
            Car.MaintenanceDateOfExpiry = ((DatePicker)FindName("DateOfExpiry")).SelectedDate ?? DateTime.MinValue;
            context.SaveChanges();
            CarDetails newPage = new CarDetails(Car);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }
    }
}
