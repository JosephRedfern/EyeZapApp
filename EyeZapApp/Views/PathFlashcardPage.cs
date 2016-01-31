using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class PathFlashcardPage : ContentPage
	{
		public PathFlashcardPage (Pathology path)
		{
			this.Icon = "Edit.png";
			this.Title = "Flashcards";
		

			if(!String.IsNullOrEmpty(path.url)){
				Image im = new Image { Aspect = Aspect.AspectFit};

				im.Source = ImageSource.FromUri (new Uri (String.Format ("{0}{1}", Config.API_ENDPOINT, path.url)));

				Content = new ScrollView {
					Content = im
				};
			}else{
				Content = new Label { Text = "This will have flashcards n stuff" } ;
			}
		}
	}
}


