﻿using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillFlashcardPage : ContentPage
	{
		public SkillFlashcardPage (Skill skill)
		{
			this.Icon = "Edit.png";
			this.Title = "Flashcards";
		

			if(skill.flashcards.Count > 0){
				Image im = new Image { Aspect = Aspect.AspectFit};

				im.Source = ImageSource.FromUri (new Uri (String.Format ("{0}{1}", Config.API_ENDPOINT, skill.flashcards [0].url)));

				Content = new ScrollView {
					Content = im
				};
			}else{
				Content = new Label { Text = "This will have flashcards n stuff" } ;
			}
		}
	}
}


