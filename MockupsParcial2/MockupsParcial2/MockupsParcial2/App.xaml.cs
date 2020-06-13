﻿using System;
using MockupsParcial2.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MockupsParcial2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EstudiantePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
