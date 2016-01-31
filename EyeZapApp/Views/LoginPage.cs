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
				Placeholder = "your@email.ac.uk",
				Text = "clive",
				Keyboard = Keyboard.Email
			};

			Entry password = new Entry {
				Placeholder = "Password",
				Text = "password123",
				IsPassword = true
			};

			Button login = new Button {
				Text = "Login"
			};

			login.Clicked += async (object sender, EventArgs e) => {
				bool result;

				using (var a = Acr.UserDialogs.UserDialogs.Instance.Loading ("Authenticating...")) {
					result = await LoginController.Default.Login(username.Text,  password.Text);
				}

				if(result){
					Application.Current.MainPage = new NavigationPage(new HomePage()){
						Padding = new Thickness (0, 0, 0, 0)
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


