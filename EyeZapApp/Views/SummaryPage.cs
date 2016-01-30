using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SummaryPage : ContentPage
	{
		public SummaryPage ()
		{

			Title = "Summary";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "This is the summary page. A summary will go here. " }
				}
			};
		}
	}
}


