using DriverCarAssistant.DBContext;
using DriverCarAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Interaction logic for CarDetails.xaml
    /// </summary>
    public partial class CarDetails : Page
    {
        private Car Car;
        public CarDetails(Car car)
        {
            InitializeComponent();
            Car = car;
            ((Label)FindName("Name")).Content = ((Label)FindName("Name")).Content+": "+car.Name;
            ((Label)FindName("Number")).Content = ((Label)FindName("Number")).Content + ": " + car.Nubmer;
            ((Label)FindName("LicenseDateOfIssue")).Content = ((Label)FindName("LicenseDateOfIssue")).Content + ": " +car.LicenseDateOfIssue.ToShortDateString();
            ((Label)FindName("LicenseDateOfExpiry")).Content = ((Label)FindName("LicenseDateOfExpiry")).Content + ": " + car.LicenseDateOfExpiry.ToShortDateString();
            ((Label)FindName("MaintenanceDateOfIssue")).Content = ((Label)FindName("MaintenanceDateOfIssue")).Content + ": " + car.MaintenanceDateOfIssue.ToShortDateString();
            ((Label)FindName("MaintenanceDateOfExpiry")).Content = ((Label)FindName("MaintenanceDateOfExpiry")).Content + ": " + car.MaintenanceDateOfExpiry.ToShortDateString();
            ((Label)FindName("InsuranceDateOfIssue")).Content = ((Label)FindName("InsuranceDateOfIssue")).Content + ": " + car.InsuranceDateOfIssue.ToShortDateString();
            ((Label)FindName("InsuranceDateOfExpiry")).Content = ((Label)FindName("InsuranceDateOfExpiry")).Content + ": " + car.InsuranceDateOfExpiry.ToShortDateString();
            ((Label)FindName("LPacketDateOfIssue")).Content = ((Label)FindName("LPacketDateOfIssue")).Content + ": " + car.LPacketDateOfIssue.ToShortDateString();
            ((Label)FindName("LPacketDateOfExpiry")).Content = ((Label)FindName("LPacketDateOfExpiry")).Content + ": " + car.LPacketDateOfExpiry.ToShortDateString();
            ((Label)FindName("TachoСalibrationDateOfIssue")).Content = ((Label)FindName("TachoСalibrationDateOfIssue")).Content + ": " + car.TachoСalibrationDateOfIssue.ToShortDateString();
            ((Label)FindName("TachoСalibrationDateOfExpiry")).Content = ((Label)FindName("TachoСalibrationDateOfExpiry")).Content + ": " + car.TachoСalibrationDateOfExpiry.ToShortDateString();
            ((Label)FindName("ExtinguisherDateOfExpiry")).Content = ((Label)FindName("ExtinguisherDateOfExpiry")).Content + ": " + car.ExtinguisherDateOfExpiry.ToShortDateString();
            ((Label)FindName("Service")).Content = ((Label)FindName("Service")).Content + ": " +car.Service+" km";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            context.Cars.Remove(Car);
            context.SaveChanges();
            Page newPage = new Cars();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }

        private void Button_Click_License(object sender, RoutedEventArgs e)
        {
            CarLicenseUpdate Page = new CarLicenseUpdate(Car);
            NavigationService.Navigate(Page);
        }
        private void Button_Click_Maintenance(object sender, RoutedEventArgs e)
        {
            CarMaintenanceUpdate Page = new CarMaintenanceUpdate(Car);
            NavigationService.Navigate(Page);
        }
        private void Button_Click_Insurance(object sender, RoutedEventArgs e)
        {
            CarInsuranceUpdate Page = new CarInsuranceUpdate(Car);
            NavigationService.Navigate(Page);
        }
        private void Button_Click_LPacket(object sender, RoutedEventArgs e)
        {
            CarLPacketUpdate Page = new CarLPacketUpdate(Car);
            NavigationService.Navigate(Page);
        }        
        private void Button_Click_Tacho(object sender, RoutedEventArgs e)
        {
            CarTachoUpdate Page = new CarTachoUpdate(Car);
            NavigationService.Navigate(Page);
        }
        private void Button_Click_Extinguisher(object sender, RoutedEventArgs e)
        {
            CarExtinguisherUpdate Page = new CarExtinguisherUpdate(Car);
            NavigationService.Navigate(Page);
        }
        private void Button_Click_Service(object sender, RoutedEventArgs e)
        {
            CarServiceUpdate Page = new CarServiceUpdate(Car);
            NavigationService.Navigate(Page);
        }
    }
}
