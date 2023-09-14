using System;

namespace NLHospitalLibrary
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class CurrentUser
	{
		private string userName;
		private string userPosition;

		public string UserName
		{
			get
			{
				return userName;
			}
			set
			{
				userName = value;
			}
		}

		public string UserPosition
		{
			get
			{
				return userPosition;
			}
			set
			{
				userPosition = value;
			}
		}

		public CurrentUser()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public CurrentUser(string username, string userposition)
		{
			UserName = username;
			UserPosition = userposition;
		}
	}
}
