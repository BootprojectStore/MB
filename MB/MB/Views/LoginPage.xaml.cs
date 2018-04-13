using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
           
            InitializeComponent ();

            //var LoginBtn = this.FindByName<Button>("LoginBtn");
            //LoginBtn.Clicked += Login_Clicked;
            
            //App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        public async Task Login_Clicked(object sender, EventArgs e)
        {
            //messageLabel.Text = "Try to login";

            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        
        }
    }
}