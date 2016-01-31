using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace EyeZapApp
{
	public class SummaryPage : ContentPage
	{
		public SummaryPage ()
		{

			Title = "Summary";

			ListView lv = new ListView ();
			var listOptions = new List<Page> ();

			listOptions.Add (new PerformancePage ());
			listOptions.Add (new VideoListPage ());
			listOptions.Add (new FlashcardListPage ());

			lv.ItemsSource = listOptions;

			lv.ItemTapped += async (sender, e) => {
				await Navigation.PushAsync((Page) lv.SelectedItem);
			};

			Content = lv;

		}
	}
}


