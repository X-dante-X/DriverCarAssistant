﻿using DriverCarAssistant.Models;
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
        public TrailerDetails(Trailer trailer)
        {
            InitializeComponent();
            ((Label)FindName("Name")).Content = ((Label)FindName("Name")).Content + ": " + trailer.Name;
            ((Label)FindName("Number")).Content = ((Label)FindName("Number")).Content + ": " + trailer.Nubmer;
            ((Label)FindName("InsuranceDateOfIssue")).Content = ((Label)FindName("InsuranceDateOfIssue")).Content + ": " + trailer.InsuranceDateOfIssue;
            ((Label)FindName("InsuranceDateOfExpiry")).Content = ((Label)FindName("InsuranceDateOfExpiry")).Content + ": " + trailer.InsuranceDateOfExpiry;
            ((Label)FindName("ExtinguisherDateOfExpiry")).Content = ((Label)FindName("ExtinguisherDateOfExpiry")).Content + ": " + trailer.ExtinguisherDateOfExpiry;
        }
    }
}
