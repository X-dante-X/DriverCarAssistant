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
    /// Interaction logic for Trailers.xaml
    /// </summary>
    public partial class Trailers : Page
    {
        public Trailers()
        {
            InitializeComponent();
            using Context context = new Context();
            var trailers = from Trailer in context.Trailers
                       select Trailer;
            foreach (var trailer in trailers)
            {
                Button button = new Button();
                button.Content = trailer.Nubmer;
                button.Click += (sender, e) => ShowTrailerDetails(trailer);

                ButtonContainer.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page newPage = new InsertTrailer();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }
        private void ShowTrailerDetails(Trailer trailer)
        {
            TrailerDetails detailsPage = new TrailerDetails(trailer);
            NavigationService.Navigate(detailsPage);
        }
    }
}
