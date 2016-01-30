using System;

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

		public bool Login(String username, String password){
			if ("redfernjm@cf.ac.uk".Equals (username) && "password".Equals (password)) {
				this.Token = "AnAPIToken";
				return true;
			} else {
				this.Token = null;
				return false;
			}
		}
	}
}

