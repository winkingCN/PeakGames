using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonChangeName : JsonBaseData
	{
		public string old_name;

		public string new_name;
	}
}
