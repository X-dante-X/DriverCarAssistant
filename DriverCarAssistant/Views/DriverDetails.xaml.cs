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
    /// Interaction logic for DriverDetails.xaml
    /// </summary>
    public partial class DriverDetails : Page
    {
        private Driver Driver;
        public DriverDetails(Driver driver)
        {
            Driver = driver;
            InitializeComponent();
            ((Label)FindName("PESEL")).Content += ": " + driver.PESEL;
            ((Label)FindName("FirstName")).Content += ": " + driver.FirstName;
            ((Label)FindName("SecondName")).Content += ": " + driver.SecondName;
            ((Label)FindName("PassportNumber")).Content += ": " + driver.Passport.PassportNumber;
            ((Label)FindName("PassportDateOfBirth")).Content += ": " + driver.Passport.DateOfBirth.ToShortDateString();
            ((Label)FindName("PassportDateOfIssue")).Content += ": " + driver.Passport.DateOfIssue.ToShortDateString();
            ((Label)FindName("PassportDateOfExpiry")).Content += ": " + driver.Passport.DateOfExpiry.ToShortDateString();
            ((Label)FindName("DrivingLicenseDateOfIssue")).Content += ": " + driver.DrivingLicense.DateOfIssue.ToShortDateString();
            ((Label)FindName("DrivingLicenseDateOfExpiry")).Content += ": " + driver.DrivingLicense.DateOfExpiry.ToShortDateString();
            ((Label)FindName("Code95DateOfIssue")).Content += ": " + driver.Code95DateOfIssue.ToShortDateString();
            ((Label)FindName("Code95DateOfExpiry")).Content += ": " + driver.Code95DateOfExpiry.ToShortDateString();
            ((Label)FindName("VisaNumber")).Content += ": " + driver.Visa?.VisaNumber;
            ((Label)FindName("VisaDateOfIssue")).Content += ": " + driver.Visa?.DateOfIssue.ToShortDateString();
            ((Label)FindName("VisaDateOfExpiry")).Content += ": " + driver.Visa?.DateOfExpiry.ToShortDateString();
            ((Label)FindName("TachoKardDateOfIssue")).Content += ": " + driver.TachoKardDateOfIssue.ToShortDateString();
            ((Label)FindName("TachoKardDateOfExpiry")).Content += ": " + driver.TachoKardDateOfExpiry.ToShortDateString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            context.Passport.Remove(Driver.Passport);
            context.Visa.Remove(Driver.Visa);
            context.DrivingLicense.Remove(Driver.DrivingLicense);
            if (context.Entry(Driver).State == EntityState.Detached)
            {
                context.Attach(Driver);
            }
            context.Drivers.Remove(Driver);
            context.SaveChanges();
            Page newPage = new Drivers();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }

        private void Button_Click_Passport(object sender, RoutedEventArgs e)
        {
            DriverPassportUpdate Page = new DriverPassportUpdate(Driver);
            NavigationService.Navigate(Page);
        }
        private void Button_Click_DrivingLicense(object sender, RoutedEventArgs e)
        {
            DriverDrivingLicenseUpdate Page = new DriverDrivingLicenseUpdate(Driver);
            NavigationService.Navigate(Page);
        }

        private void Button_Click_Code95(object sender, RoutedEventArgs e)
        {
            DriverCode95Update Page = new DriverCode95Update(Driver);
            NavigationService.Navigate(Page);
        }

        private void Button_Click_Visa(object sender, RoutedEventArgs e)
        {
            DriverVisaUpdate Page = new DriverVisaUpdate(Driver);
            NavigationService.Navigate(Page);
        }

        private void Button_Click_TachoKard(object sender, RoutedEventArgs e)
        {
            DriverTachoKardUpdate Page = new DriverTachoKardUpdate(Driver);
            NavigationService.Navigate(Page);
        }
    }
}
