using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillPage : TabbedPage
	{
		public SkillPage (String skillName)
		{
			Title = skillName;

			var skillVideo = new SkillVideoPage (skillName);
			var skillFlashcardPage = new SkillFlashcardPage (skillName);

			this.Children.Add (skillVideo);
			this.Children.Add (skillFlashcardPage);


		}
	}
}


