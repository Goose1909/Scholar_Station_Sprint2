﻿using System;
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

namespace SessionCreationWizardUPDATE
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void NextClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void BackClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }

        private void dateTimeValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            string dateString = this.dateTimePicker.Value.ToString();
            MessageBox.Show(dateString);
        }
    }
}
