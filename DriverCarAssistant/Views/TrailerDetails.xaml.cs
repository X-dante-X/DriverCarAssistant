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
    /// Interaction logic for TrailerDetails.xaml
    /// </summary>
    public partial class TrailerDetails : Page
    {
        private Trailer Trailer;
        public TrailerDetails(Trailer trailer)
        {
            Trailer = trailer;
            InitializeComponent();
            ((Label)FindName("Name")).Content += ": " + trailer.Name;
            ((Label)FindName("Number")).Content += ": " + trailer.Nubmer;
            ((Label)FindName("InsuranceDateOfIssue")).Content += ": " + trailer.InsuranceDateOfIssue.ToShortDateString();
            ((Label)FindName("InsuranceDateOfExpiry")).Content += ": " + trailer.InsuranceDateOfExpiry.ToShortDateString();
            ((Label)FindName("ExtinguisherDateOfExpiry")).Content += ": " + trailer.ExtinguisherDateOfExpiry.ToShortDateString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using Context context = new Context();
            context.Trailers.Remove(Trailer);
            context.SaveChanges();
            Page newPage = new Trailers();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }

        private void Button_Click_Insurance(object sender, RoutedEventArgs e)
        {
            TrailerInsuranceUpdate Page = new TrailerInsuranceUpdate(Trailer);
            NavigationService.Navigate(Page);
        }

        private void Button_Click_Extinguisher(object sender, RoutedEventArgs e)
        {
            TrailerExtinguisherUpdate Page = new TrailerExtinguisherUpdate(Trailer);
            NavigationService.Navigate(Page);
        }
    }
}
