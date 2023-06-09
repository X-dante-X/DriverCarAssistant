﻿using DriverCarAssistant.DBContext;
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
    /// Interaction logic for InsertCar.xaml
    /// </summary>
    public partial class InsertCar : Page
    {
        public InsertCar()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using Context context = new Context();
            Car car = new Car()
            {
                Name = ((TextBox)FindName("Name")).Text ?? "Empty",
                Nubmer = ((TextBox)FindName("Number")).Text ?? "Empty",
                LicenseDateOfIssue = ((DatePicker)FindName("LicenseDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                LicenseDateOfExpiry = ((DatePicker)FindName("LicenseDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                MaintenanceDateOfIssue = ((DatePicker)FindName("MaintenanceDateOfIssue")).SelectedDate ?? DateTime.MinValue,    
                MaintenanceDateOfExpiry = ((DatePicker)FindName("MaintenanceDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                InsuranceDateOfIssue = ((DatePicker)FindName("InsuranceDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                InsuranceDateOfExpiry = ((DatePicker)FindName("InsuranceDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                LPacketDateOfIssue = ((DatePicker)FindName("LPacketDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                LPacketDateOfExpiry = ((DatePicker)FindName("LPacketDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                TachoСalibrationDateOfIssue = ((DatePicker)FindName("TachoCalibrationDateOfIssue")).SelectedDate ?? DateTime.MinValue,
                TachoСalibrationDateOfExpiry = ((DatePicker)FindName("TachoCalibrationDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                ExtinguisherDateOfExpiry = ((DatePicker)FindName("ExtinguisherDateOfExpiry")).SelectedDate ?? DateTime.MinValue,
                Service = !string.IsNullOrEmpty(((TextBox)FindName("Service")).Text) ? int.Parse(((TextBox)FindName("Service")).Text) : 0
            };

            context.Cars.Add(car);

            context.SaveChanges();
            Page newPage = new Cars();
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(newPage);
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!Char.IsDigit(ch))
                {
                    e.Handled = true;
                    break;
                }
            }
        }
    }
}
