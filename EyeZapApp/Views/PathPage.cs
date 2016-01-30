using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class PathPage : ContentPage
	{
		public PathPage ()
		{
			Title = "Path";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "This, is the path page! Path things belong here." }
				}
			};
		}
	}
}


