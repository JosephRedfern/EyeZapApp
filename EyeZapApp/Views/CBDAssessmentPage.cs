using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class CBDAssessmentPage : ContentPage
	{
		public CBDAssessmentPage ()
		{
			Title = "Upload Documents";
			ToolbarItems.Add (new ToolbarItem () {
				Text = "Upload"
			});
			var clinicalSettingPicker = new Picker ();

			var clinicalOptions = new string[]{ "Outpatient Department", "Emergency Assessment Unit", "Ward" };

			foreach (var option in clinicalOptions) {
				clinicalSettingPicker.Items.Add (option);
			}

			var grades = new string[]{ "FY2 Doctor", "ST1-2", "ST3+", "Consultant", "Other"};
			var gradePicker = new Picker ();

			foreach (var grade in grades) {
				gradePicker.Items.Add (grade);
			}

			Content = new ScrollView{
				Content = 
					new StackLayout { 
					Children = {
						new Label{Text="Clinical Setting"},
						clinicalSettingPicker,
						new Label{Text = "Description of Patient Seen", Style=Device.Styles.SubtitleStyle},
						new Editor{HeightRequest = 100},
						new Label{Text = "Chosen Learning Focus", Style=Device.Styles.SubtitleStyle},
						new Editor{HeightRequest = 100},
						new Label{Text = "Feedback: What was done well?", Style=Device.Styles.SubtitleStyle},
						new Editor{HeightRequest = 100},
						new Label{Text = "Feedback: Suggested areas for development", Style=Device.Styles.SubtitleStyle},
						new Editor{HeightRequest = 100},
						new Label{Text="Assessor Signature", Style=Device.Styles.SubtitleStyle},
						new Entry(),
						new Label{Text="Assessor Grade", Style=Device.Styles.SubtitleStyle},
						gradePicker,
						new Label{Text="GMC Signature", Style=Device.Styles.SubtitleStyle},
						new Entry(),
					}
				}
			};
		}

		public override String ToString(){
			return "Case Based Discussion";
		}
	}
}


