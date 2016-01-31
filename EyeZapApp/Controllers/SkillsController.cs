using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System;
using System.Collections.Generic;

namespace EyeZapApp
{

	public class Skill{
		public int id;
		public string name;
		public List<Video> videos;

		public override String ToString(){
			return this.name;
		}
	}

	public class Video{
		public int id;
		public string name;
		public string url;

		public override String ToString(){
			return this.name;
		}
	}



	public class SkillsController
	{

		public readonly static SkillsController Default = new SkillsController();

		public List<Skill> Skills;

		private SkillsController ()
		{
			//TODO: things
		}

		public async Task<List<Skill>> GetSkills(){
			if (this.Skills == null) {
				using (var client = new HttpClient ()) {
					client.BaseAddress = Config.API_ENDPOINT;
					client.DefaultRequestHeaders.Add ("Authorization", String.Format ("Token {0}", LoginController.Default.Token));


					var response = await client.GetAsync ("skills/");

					if (response.StatusCode == HttpStatusCode.OK) {
						this.Skills = JsonConvert.DeserializeObject<List<Skill>> (await response.Content.ReadAsStringAsync ());
					} else {
						return null;
					}
				}
			} 

			return this.Skills;

		}
	}
}

