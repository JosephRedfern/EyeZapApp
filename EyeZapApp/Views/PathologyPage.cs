using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class PathPage : TabbedPage
	{
		public PathPage (Pathology path)
		{
			Title = path.name;

			Children.Add (new PathFlashcardPage (path));
			Children.Add (new MultipleChoiceQuestion ());

		}
	}
}


