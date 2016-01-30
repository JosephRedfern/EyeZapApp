using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillFlashcardPage : ContentPage
	{
		public SkillFlashcardPage (String skillName)
		{
			this.Icon = "Edit.png";
			this.Title = "Flashcards";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "This will have flashcards n stuff" }
				}
			};
		}
	}
}


