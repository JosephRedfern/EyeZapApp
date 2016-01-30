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

			Button upload = new Button {
				Text = "Upload Documents"
			};

			upload.Clicked += async (object sender, EventArgs e) => {
				await Navigation.PushAsync(new UploadPage());
			};

			Content = new StackLayout {
				Children = {
					summary,
					skills,
					path,
					upload
				}
			};
		}
	}
}


