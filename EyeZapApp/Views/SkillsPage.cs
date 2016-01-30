using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillsPage : ContentPage
	{
		private ListView SkillsList;

		public SkillsPage ()
		{
			Title = "Skills";


			SkillsList = new ListView ();


			SkillsList.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) => {
				await Navigation.PushAsync(new SkillPage((string) SkillsList.SelectedItem));
			};

			Content = new StackLayout { 
				Children = {
					SkillsList
				}
			};
		}


		protected async override void OnAppearing ()
		{
			base.OnAppearing ();


			SkillsList.ItemsSource = await SkillsController.Default.GetSkills ();
		}
	}	
}


