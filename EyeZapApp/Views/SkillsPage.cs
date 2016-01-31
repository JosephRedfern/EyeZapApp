using System;
using System.Linq;

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
				await Navigation.PushAsync(new SkillPage((Skill)SkillsList.SelectedItem));
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

			if (SkillsList.ItemsSource == null) {
				using (var a = Acr.UserDialogs.UserDialogs.Instance.Loading ()) {
					SkillsList.ItemsSource = await SkillsController.Default.GetSkills ();
				}
			}
		}
	}	
}


