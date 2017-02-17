using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrototypingXamarin
{
	public partial class LoginPage : ContentPage 	{ 		public LoginPage() 		{ 			InitializeComponent(); 			NavigationPage.SetHasNavigationBar(this, false); 			buttonLogin.Clicked += (object sender, EventArgs e) => 			{ 				Navigation.PushModalAsync(new NavigationPage(new MoviesPage())); 			};  		} 	}
}
