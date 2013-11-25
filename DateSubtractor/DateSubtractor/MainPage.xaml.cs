﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DateSubtractor.Resources;

namespace DateSubtractor
{
    public partial class MainPage : PhoneApplicationPage
    {
        Fields fields;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            fields = new Fields
            {
                StartDate = DateTime.Now,
                NumDays = 10,
                ResultDate = DateTime.Now
            };


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) 
        {
            ResultPanel.DataContext = fields;
        }

        private void GetResultButton_Click(object sender, RoutedEventArgs e)
        {
            fields.ResultDate = fields.StartDate.AddDays(fields.NumDays);
        }

        private void StartDatePicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            if (e.NewDateTime != null)
                fields.StartDate = (DateTime)e.NewDateTime;
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}