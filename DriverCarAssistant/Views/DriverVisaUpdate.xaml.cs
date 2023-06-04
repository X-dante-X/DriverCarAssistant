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
    /// Interaction logic for DriverVisaUpdate.xaml
    /// </summary>
    public partial class DriverVisaUpdate : Page
    {
        private Driver Driver;
        public DriverVisaUpdate(Driver driver)
        {
            Driver = driver;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            Driver.Visa.VisaNumber = ((TextBox)FindName("VisaNumber")).Text;
            Driver.Visa.DateOfIssue = ((DatePicker)FindName("DateOfIssue")).SelectedDate ?? DateTime.MinValue;
            Driver.Visa.DateOfExpiry = ((DatePicker)FindName("DateOfExpiry")).SelectedDate ?? DateTime.MinValue;
            context.SaveChanges();
            DriverDetails newPage = new DriverDetails(Driver);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }
    }
}
