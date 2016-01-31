using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net;

namespace EyeZapApp
{
	public class AssessmentController
	{
		public readonly static AssessmentController Default = new AssessmentController();

		private  AssessmentController ()
		{
			
		}

		public async Task<bool> Upload(int assessmentId, String[][] items){
			using(var client = new HttpClient ()){
				client.BaseAddress = Config.API_ENDPOINT;

				var json = JsonConvert.SerializeObject (new {
					assessmentId = assessmentId,
					responses = items
				});

				HttpContent jsonContent = new StringContent(json, Encoding.UTF8, "application/json");
				jsonContent.Headers.Add ("Authorization", String.Format ("Token {0}", LoginController.Default.Token));

				var response = await client.PostAsync ("assessments", jsonContent);

				if (response.StatusCode == HttpStatusCode.OK) {
					return true;
				} else {
					return true;
				}
			}
		}
	}
}

