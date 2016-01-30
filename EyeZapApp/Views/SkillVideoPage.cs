using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillVideoPage : ContentPage
	{
		public SkillVideoPage (string skillName)
		{
			this.Icon = "Video.png";
			this.Title = "Video";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "This will contain a video view thingie." }
				}
			};
		}
	}
}


