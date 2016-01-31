using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class MultipleChoiceQuestion : ContentPage
	{
		public MultipleChoiceQuestion ()
		{
			Title = "Multiple Choice";

			Label q1 = new Label{ Text = "Identify the visual field defect below." };

			var answers = new String[]{"Choose an option", "Bitemporal hemianopia", "Binasal hemianopia", "Central scotoma", "Right homonymous hemianopia", "Temporal homonymous hemianopia"};

			Picker q1a = new Picker ();

			foreach (var a in answers) {
				q1a.Items.Add (a);
			}

			var button = new Button {Text="Submit"};
			button.Clicked += (object sender, EventArgs e) =>  {
				if(q1a.SelectedIndex == 1){
					DisplayAlert("Correct!", "Well done, that's the right answer", "OK");
				}else{
					DisplayAlert("Incorrect", String.Format("The correct answer is {0}", answers[1]), "OK");
				}
			};

			Content = new StackLayout { 
				Children = {
					q1,
					new Image{
						Source = ImageSource.FromUri(new Uri("http://i.imgur.com/q7l03ZG.png"))
					},
					q1a,
					button
				}
			};
		}
	}
}


