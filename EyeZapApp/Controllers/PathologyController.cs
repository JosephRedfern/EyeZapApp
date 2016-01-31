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

	public class Pathology{
		public int id;
		public string name;
		public string url;

		public override string ToString ()
		{
			return name;
		}
	}
		

	public class PathologyController
	{

		public readonly static PathologyController Default = new PathologyController();

		public List<Pathology> Paths;

		private PathologyController()
		{
			//TODO: things
		}

		public async Task<List<Pathology>> GetPaths(){
			if (this.Paths == null) {
				using (var client = new HttpClient ()) {
					client.BaseAddress = Config.API_ENDPOINT;
					client.DefaultRequestHeaders.Add ("Authorization", String.Format ("Token {0}", LoginController.Default.Token));


					var response = await client.GetAsync ("pathology/");

					if (response.StatusCode == HttpStatusCode.OK) {
						this.Paths = JsonConvert.DeserializeObject<List<Pathology>> (await response.Content.ReadAsStringAsync ());
					} else {
						return null;
					}
				}
			} 

			return this.Paths;

		}
	}
}

