﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MB.Views;

using Xamarin.Forms;

namespace MB
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MB.Views.LoginPage());
        }

		protected override void OnStart ()
		{

        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
