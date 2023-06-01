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
    /// Interaction logic for CarTachoUpdate.xaml
    /// </summary>
    public partial class CarTachoUpdate : Page
    {
        private Car Car;
        public CarTachoUpdate(Car car)
        {
            Car = car;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            Car.TachoСalibrationDateOfIssue = ((DatePicker)FindName("DateOfIssue")).SelectedDate ?? DateTime.MinValue;
            Car.TachoСalibrationDateOfExpiry = ((DatePicker)FindName("DateOfExpiry")).SelectedDate ?? DateTime.MinValue;
            context.SaveChanges();
            CarDetails newPage = new CarDetails(Car);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }
    }
}
