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
    /// Interaction logic for Drivers.xaml
    /// </summary>
    public partial class Drivers : Page
    {
        public Drivers()
        {
            InitializeComponent();
            using Context context = new Context();
            var drivers = from driver in context.Drivers
                          select new Driver()
                          {
                              PESEL = driver.PESEL,
                              FirstName = driver.FirstName,
                              SecondName = driver.SecondName,
                              Passport = new Passport()
                              {
                                  PassportNumber = driver.Passport.PassportNumber,
                                  DateOfBirth = driver.Passport.DateOfBirth,
                                  DateOfIssue = driver.Passport.DateOfIssue,
                                  DateOfExpiry = driver.Passport.DateOfExpiry
                              },
                              DrivingLicense = new DrivingLicense()
                              {
                                  DateOfIssue = driver.DrivingLicense.DateOfIssue,
                                  DateOfExpiry = driver.DrivingLicense.DateOfExpiry
                              },
                              Code95DateOfIssue = driver.Code95DateOfIssue,
                              Code95DateOfExpiry = driver.Code95DateOfExpiry,
                              Visa = new Visa()
                              {
                                  VisaNumber = driver.Visa.VisaNumber,
                                  DateOfIssue = driver.Visa.DateOfIssue,
                                  DateOfExpiry = driver.Visa.DateOfExpiry
                              },
                              TachoKardDateOfIssue = driver.TachoKardDateOfIssue,
                              TachoKardDateOfExpiry = driver.TachoKardDateOfExpiry
                          };
            foreach (var driver in drivers)
            {
                Button button = new Button();
                string text = $"{driver.FirstName} {driver.SecondName}";
                button.Content = text;
                button.Click += (sender, e) => ShowDriverDetails(driver);

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
