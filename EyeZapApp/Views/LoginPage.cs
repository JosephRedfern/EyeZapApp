using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			Image logo = new Image {
				Source = ImageSource.FromFile ("Logo.png")
			};

			Entry username = new Entry {
				Placeholder = "your@email.ac.uk"
			};

			Entry password = new Entry {
				Placeholder = "Password",
				IsPassword = true
			};

			Button login = new Button {
				Text = "Login"
			};

			login.Clicked += async (object sender, EventArgs e) => {
				if(LoginController.Default.Login(username.Text,  password.Text)){
					await DisplayAlert("OK", "YOU'RE IN!", "Belter");
					Application.Current.MainPage = new NavigationPage(new HomePage()){
						Padding = new Thickness (5, Device.OnPlatform(20,0,0), 5, 0)
					};
				}else{
					await DisplayAlert("Incorrect Credentials", "Your username and/or password was not reconised", "Try Again");

				}
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					logo,
					new StackLayout{
						Padding = new Thickness(40, 0, 40, 0),
						Children = {
							username,
							password,
							login
						}
					}
				}
			};
		}
	}
}


