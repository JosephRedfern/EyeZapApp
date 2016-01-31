using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;


namespace EyeZapApp
{
	public class LoginController
	{
		public readonly static LoginController Default = new LoginController();

		public String Token {get; private set;}

		private LoginController ()
		{
			//TODO: things
		}

		public async Task<bool> Login(String username, String password){
			using(var client = new HttpClient ()){
				client.BaseAddress = Config.API_ENDPOINT;
				//client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				var json = JsonConvert.SerializeObject (new {
					username = username,
					password = password
				});

				HttpContent jsonContent = new StringContent(json, Encoding.UTF8, "application/json");

				var response = await client.PostAsync ("login/", jsonContent);

				if (response.StatusCode == HttpStatusCode.OK) {
					var resDict = JsonConvert.DeserializeObject <Dictionary<string, string>> (await response.Content.ReadAsStringAsync ());
					this.Token = resDict["token"];
					return true;
				} else {
					return false;
				}
			}
		}
	}
}

