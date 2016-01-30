using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillsPage : ContentPage
	{
		public SkillsPage ()
		{
			Title = "Skills";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "This is the skills page. Skills related stuff will go here." }
				}
			};
		}
	}
}


