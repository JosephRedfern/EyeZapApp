using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class VideoListPage : ContentPage
	{
		public VideoListPage ()
		{

			Title = "All Videos";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello Video list Page" }
				}
			};
		}


		public override String ToString(){
			return this.Title;
		}
	}
}


