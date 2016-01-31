using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class PerformancePage : ContentPage
	{
		public PerformancePage ()
		{
			Title = "Performance Report";
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello Performance Report" }
				}
			};
		}

		public override String ToString(){
			return this.Title;
		}
	}
}


