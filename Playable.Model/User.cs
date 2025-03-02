using System;
using Playable.Model.ENUM;

namespace Playable.Model
{
	public class User
	{
		public int ID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public Activity Activity { get; set; }
		public Gender Gender { get; set; }
	}
}

