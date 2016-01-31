using System;

using Xamarin.Forms;

namespace EyeZapApp
{
	public class SkillVideoPage : ContentPage
	{
		public SkillVideoPage (Skill skill)
		{
			this.Icon = "Video.png";
			this.Title = "Video";

			if (skill.videos.Count > 0) {


				HtmlWebViewSource src = new HtmlWebViewSource {
					Html = String.Format("<!DOCTYPE html><html><body><iframe width=\"100%\" height=\"500px\" src=\"https://www.youtube.com/embed/{0}\" frameborder=\"0\" allowfullscreen></iframe>", skill.videos[0].youtube_id)
				};

				var videoWebview = new WebView {
					Source = src
				};

				Content = videoWebview;
			} else {
				Content = new Label{ Text = "No video for this skill" };
			}
		}
	}
}


