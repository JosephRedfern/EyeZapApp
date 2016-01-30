using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class UploadPage : ContentPage
	{
		public UploadPage ()
		{
			Title = "Upload Documents";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "You will somehow be able to upload stuff here. Woohoo!" }
				}
			};
		}
	}
}


