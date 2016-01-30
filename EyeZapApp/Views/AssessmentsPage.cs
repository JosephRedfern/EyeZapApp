using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class AssessmentsPage : ContentPage
	{
		public AssessmentsPage ()
		{
			Title = "Assessments";

			var assessmentsList = new ListView {
				ItemsSource = new ContentPage[]{
					new CBDAssessmentPage()
				}
			};

			assessmentsList.ItemSelected += async (sender, e) => {
				await Navigation.PushAsync((ContentPage) assessmentsList.SelectedItem);
			};

			Content = new StackLayout { 
				Children = {
					assessmentsList
				}
			};
		}
	}
}


