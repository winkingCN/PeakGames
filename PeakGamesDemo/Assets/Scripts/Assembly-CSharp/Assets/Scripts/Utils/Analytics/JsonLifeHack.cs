using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonLifeHack : JsonBaseData
	{
		public int hacked_cl_stage;

		public JsonInventory hacked_inventory;

		public JsonInventory inventory;
	}
}
