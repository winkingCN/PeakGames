using System;

namespace Assets.Scripts.Utils.Analytics
{
	[Serializable]
	public class JsonDeviceDataWithInventory : JsonDeviceData
	{
		public JsonInventory inventory;

		public JsonDeviceDataWithInventory()
		{
			inventory = new JsonInventory();
			inventory.LDOCFEGBGNK();
		}
	}
}
