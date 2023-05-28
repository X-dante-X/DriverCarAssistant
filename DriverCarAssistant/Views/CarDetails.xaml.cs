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
    /// Interaction logic for CarDetails.xaml
    /// </summary>
    public partial class CarDetails : Page
    {
        public CarDetails(Car car)
        {
            InitializeComponent();
            ((Label)FindName("Name")).Content = ((Label)FindName("Name")).Content+" "+car.Name;
            ((Label)FindName("Number")).Content = ((Label)FindName("Number")).Content + " " + car.Nubmer;
            ((Label)FindName("LicenseDateOfIssue")).Content = ((Label)FindName("LicenseDateOfIssue")).Content + " " +car.LicenseDateOfIssue;
            ((Label)FindName("LicenseDateOfExpiry")).Content = ((Label)FindName("LicenseDateOfExpiry")).Content + " " + car.LicenseDateOfIssue;
            ((Label)FindName("MaintenanceDateOfIssue")).Content = ((Label)FindName("MaintenanceDateOfIssue")).Content + " " + car.MaintenanceDateOfIssue;
            ((Label)FindName("MaintenanceDateOfExpiry")).Content = ((Label)FindName("MaintenanceDateOfExpiry")).Content + " " + car.MaintenanceDateOfExpiry;
            ((Label)FindName("InsuranceDateOfIssue")).Content = ((Label)FindName("InsuranceDateOfIssue")).Content + " " + car.InsuranceDateOfIssue;
            ((Label)FindName("InsuranceDateOfExpiry")).Content = ((Label)FindName("InsuranceDateOfExpiry")).Content + " " + car.InsuranceDateOfExpiry;
            ((Label)FindName("LPacketDateOfIssue")).Content = ((Label)FindName("LPacketDateOfIssue")).Content + " " + car.LPacketDateOfIssue;
            ((Label)FindName("LPacketDateOfExpiry")).Content = ((Label)FindName("LPacketDateOfExpiry")).Content + " " + car.LPacketDateOfExpiry;
            ((Label)FindName("TachoСalibrationDateOfIssue")).Content = ((Label)FindName("TachoСalibrationDateOfIssue")).Content + " " + car.TachoСalibrationDateOfIssue;
            ((Label)FindName("TachoСalibrationDateOfExpiry")).Content = ((Label)FindName("TachoСalibrationDateOfExpiry")).Content + " " + car.TachoСalibrationDateOfExpiry;
            ((Label)FindName("ExtinguisherDateOfExpiry")).Content = ((Label)FindName("ExtinguisherDateOfExpiry")).Content + " " + car.ExtinguisherDateOfExpiry;
            ((Label)FindName("Service")).Content = ((Label)FindName("Service")).Content + " " +car.Service;
        }
    }
}
