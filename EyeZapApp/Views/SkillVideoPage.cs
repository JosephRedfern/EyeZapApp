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
				var videoWebview = new WebView {
					Source = new UrlWebViewSource {
						Url = String.Format ("{0}uploads/{1}", Config.API_ENDPOINT, skill.videos [0].url)
					}
				};

				Content = videoWebview;
			} else {
				Content = new Label{ Text = "No video for this skill" };
			}
		}
	}
}


