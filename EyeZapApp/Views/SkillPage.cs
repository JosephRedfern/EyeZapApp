using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillPage : TabbedPage
	{
		public SkillPage (Skill skill)
		{
			Title = skill.name;

			var skillVideo = new SkillVideoPage (skill);
			var skillFlashcardPage = new SkillFlashcardPage (skill);

			this.Children.Add (skillVideo);
			this.Children.Add (skillFlashcardPage);


		}
	}
}


