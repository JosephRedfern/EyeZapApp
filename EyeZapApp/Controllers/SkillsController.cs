using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System;

namespace EyeZapApp
{
	public class SkillsController
	{
		public Uri API_ENDPOINT = new Uri("http://next-list.usefinch.io/");

		public readonly static SkillsController Default = new SkillsController();

		private SkillsController ()
		{
			//TODO: things
		}

		public async Task<string[]> GetSkills(){
			using(var client = new HttpClient ()){
				client.BaseAddress = this.API_ENDPOINT;


				var response = await client.GetAsync ("skills/");

				if (response.StatusCode == HttpStatusCode.OK) {
					var a = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync ());
					return null;
				} else {
					return null;
				}
			}

			return new string []{
				"Visual Acuity",
				"Visual Field",
				"Ocular Motility",
				"Fundoscopy",
				"Pupils"
			};
		}
	}
}

