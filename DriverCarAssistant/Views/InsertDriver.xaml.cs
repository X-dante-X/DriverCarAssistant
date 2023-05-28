using DriverCarAssistant.DBContext;
using DriverCarAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Policy;
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
    /// Interaction logic for InsertDriver.xaml
    /// </summary>
    public partial class InsertDriver : Page
    {
        public InsertDriver()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            Driver driver = new Driver()
            {
                PESEL = int.Parse(((TextBox)FindName("PESEL")).Text),
                FirstName = ((TextBox)FindName("FirstName")).Text,
                SecondName = ((TextBox)FindName("SecondName")).Text,
                Passport = new Passport()
                {
                    PassportNumber = ((TextBox)FindName("PassportNumber")).Text,
                    DateOfBirth = ((DatePicker)FindName("PassportDateOfBirth")).SelectedDate ?? DateTime.MinValue,
                    DateOfIssue = ((DatePicker)FindName("PassportDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                    DateOfExpiry = ((DatePicker)FindName("PassportDateOfExpiry")).SelectedDate ?? DateTime.MinValue
                },
                DrivingLicense = new DrivingLicense()
                {
                    DateOfIssue = ((DatePicker)FindName("DrivingLicenseDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                    DateOfExpiry = ((DatePicker)FindName("DrivingLicenseDateOfExpiry")).SelectedDate ?? DateTime.MinValue
                },

                Code95DateOfIssue = ((DatePicker)FindName("Code95DateOfIssue")).SelectedDate ?? DateTime.MinValue,
                Code95DateOfExpiry = ((DatePicker)FindName("Code95DateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                Visa = new Visa()
                {
                    VisaNumber = ((TextBox)FindName("VisaNumber")).Text,
                    DateOfIssue = ((DatePicker)FindName("VisaDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                    DateOfExpiry = ((DatePicker)FindName("VisaDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                },
                TachoKardDateOfIssue = ((DatePicker)FindName("TachoKardDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                TachoKardDateOfExpiry = ((DatePicker)FindName("TachoKardDateOfExpiry")).SelectedDate ?? DateTime.MinValue
            };

            context.Drivers.Add(driver);

            context.SaveChanges();
        }
    }
}
