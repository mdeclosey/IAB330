﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IAB330assignment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
        
        private void registerBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void tabsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage1());
        }

        private void settingsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }

        private void itemBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpecificItem());
        }

    }
}
