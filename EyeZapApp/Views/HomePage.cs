using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			Title = "Home";

			//Summary, Skills, Path, Upload Documents

			Button summary = new Button {
				Text = "Summary"
			};

			summary.Clicked += async (object sender, EventArgs e) => {
				await Navigation.PushAsync(new SummaryPage());
			};

			Button skills = new Button {
				Text = "Skills"
			};

			skills.Clicked += async (object sender, EventArgs e) => {
				await Navigation.PushAsync(new SkillsPage());
			};

			Button path  = new Button {
				Text = "Path"
			};

			path.Clicked += async (object sender, EventArgs e) => {
				await Navigation.PushAsync(new PathPage());
			};

			Button assessments = new Button {
				Text = "Assessments"
			};

			assessments.Clicked += async (object sender, EventArgs e) => {
				await Navigation.PushAsync(new AssessmentsPage());
			};

			Content = new StackLayout {
				Children = {
					summary,
					skills,
					path,
					assessments
				}
			};
		}
	}
}


