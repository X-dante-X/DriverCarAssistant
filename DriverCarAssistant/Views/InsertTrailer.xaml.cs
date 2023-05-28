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
    /// Interaction logic for InsertTrailer.xaml
    /// </summary>
    public partial class InsertTrailer : Page
    {
        public InsertTrailer()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var dataContext = DataContext as Driver;
            using Context context = new Context();
            Trailer trailer = new Trailer()
            {
                Name = ((TextBox)FindName("Name")).Text,
                Nubmer = ((TextBox)FindName("Number")).Text,
                InsuranceDateOfIssue = ((DatePicker)FindName("InsuranceDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                InsuranceDateOfExpiry = ((DatePicker)FindName("InsuranceDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                ExtinguisherDateOfExpiry = ((DatePicker)FindName("ExtinguisherDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
            };

            context.Trailers.Add(trailer);

            context.SaveChanges();
        }
    }
}
