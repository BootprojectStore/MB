using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MB
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MB.Views.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("ios=567d21de-19c6-4803-af65-dfd8f7eb45cf;", typeof(Analytics), typeof(Crashes));

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
