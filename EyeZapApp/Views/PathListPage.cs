using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class PathListPage : ContentPage
	{
		ListView PathList;
		public PathListPage()
		{
			Title = "Skills";

			PathList = new ListView ();

			PathList.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) => {
				await Navigation.PushAsync(new PathPage((Pathology)PathList.SelectedItem));
			};

			Content = new StackLayout { 
				Children = {
					PathList
				}
			};
		}

		protected async override void OnAppearing ()
		{
			base.OnAppearing ();

			if (PathList.ItemsSource == null) {
				using (var a = Acr.UserDialogs.UserDialogs.Instance.Loading ()) {
					PathList.ItemsSource = await PathologyController.Default.GetPaths();
				}
			}
		}

	}
}


