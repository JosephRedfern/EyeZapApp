using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class FlashcardListPage : ContentPage
	{
		public FlashcardListPage ()
		{
			Title = "All Flashcards";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello flashcard list Page" }
				}
			};
		}


		public override String ToString(){
			return this.Title;
		}
	}
}


