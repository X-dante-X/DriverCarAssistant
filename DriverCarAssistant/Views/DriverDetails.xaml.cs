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
    /// Interaction logic for DriverDetails.xaml
    /// </summary>
    public partial class DriverDetails : Page
    {
        public DriverDetails(Driver driver)
        {
            InitializeComponent();
            ((Label)FindName("PESEL")).Content = ((Label)FindName("PESEL")).Content + ": " + driver.PESEL;
            ((Label)FindName("FirstName")).Content = ((Label)FindName("FirstName")).Content + ": " + driver.FirstName;
            ((Label)FindName("SecondName")).Content = ((Label)FindName("SecondName")).Content + ": " + driver.SecondName;
            ((Label)FindName("PassportNumber")).Content = ((Label)FindName("PassportNumber")).Content + ": " + driver.Passport.PassportNumber;
            ((Label)FindName("PassportDateOfBirth")).Content = ((Label)FindName("PassportDateOfBirth")).Content + ": " + driver.Passport.DateOfBirth;
            ((Label)FindName("PassportDateOfIssue")).Content = ((Label)FindName("PassportDateOfIssue")).Content + ": " + driver.Passport.DateOfIssue;
            ((Label)FindName("PassportDateOfExpiry")).Content = ((Label)FindName("PassportDateOfExpiry")).Content + ": " + driver.Passport.DateOfExpiry;
            ((Label)FindName("DrivingLicenseDateOfIssue")).Content = ((Label)FindName("DrivingLicenseDateOfIssue")).Content + ": " + driver.DrivingLicense.DateOfIssue;
            ((Label)FindName("DrivingLicenseDateOfExpiry")).Content = ((Label)FindName("DrivingLicenseDateOfExpiry")).Content + ": " + driver.DrivingLicense.DateOfExpiry;
            ((Label)FindName("Code95DateOfIssue")).Content = ((Label)FindName("Code95DateOfIssue")).Content + ": " + driver.Code95DateOfIssue;
            ((Label)FindName("Code95DateOfExpiry")).Content = ((Label)FindName("Code95DateOfExpiry")).Content + ": " + driver.Code95DateOfExpiry;
            ((Label)FindName("VisaNumber")).Content = ((Label)FindName("VisaNumber")).Content + ": " + driver.Visa?.VisaNumber;
            ((Label)FindName("VisaDateOfIssue")).Content = ((Label)FindName("VisaDateOfIssue")).Content + ": " + driver.Visa?.DateOfIssue;
            ((Label)FindName("VisaDateOfExpiry")).Content = ((Label)FindName("VisaDateOfExpiry")).Content + ": " + driver.Visa?.DateOfExpiry;
            ((Label)FindName("TachoKardDateOfIssue")).Content = ((Label)FindName("TachoKardDateOfIssue")).Content + ": " + driver.TachoKardDateOfIssue;
            ((Label)FindName("TachoKardDateOfExpiry")).Content = ((Label)FindName("TachoKardDateOfExpiry")).Content + ": " + driver.TachoKardDateOfExpiry;

        }
    }
}
