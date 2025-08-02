using UnityEngine;

namespace MapScene
{
	public class MapDisplayController : MonoBehaviour
	{
		public MapDisplay[] MapDisplays;

		private int EMAOPJNDEML;

		private int JPPPBPMGLKP;

		private int KIEPHJLIHEE;

		private const float OMEODEBFOBK = 3.963f;

		private const float GDEAAAMJBOP = -3f;

		private const float IFBKGDILGJH = 4.15f;

		private const float PAOLDJALODF = -2.8f;

		private const float OFCMNNIAJDC = 0.8f;

		public static float GetPositionX(NAOEEJLHFDL LKLPEEEPMCE)
		{
			float num = ((!ONCMBJKLKIL.PEFHCKMBHOM) ? 3.963f : 4.15f);
			return (LKLPEEEPMCE != NAOEEJLHFDL.Right) ? (num * -1f) : num;
		}

		public static float GetPositionY()
		{
			return (!ONCMBJKLKIL.PEFHCKMBHOM) ? (-3f) : (-2.8f);
		}

		public static float GetScale()
		{
			return (!ONCMBJKLKIL.PEFHCKMBHOM) ? 1f : 0.8f;
		}

		public void OnMapDisplaysChange()
		{
			KCADDPACELN();
		}

		private void KCADDPACELN()
		{
			EMAOPJNDEML = 0;
			JPPPBPMGLKP = 0;
			float num = 0f;
			float num2 = 0f;
			int i = 0;
			for (int num3 = MapDisplays.Length; i < num3; i++)
			{
				bool activeSelf = MapDisplays[i].gameObject.activeSelf;
				switch (MapDisplays[i].MapSide)
				{
				case NAOEEJLHFDL.Left:
					if (activeSelf)
					{
						num += MapDisplays[i].HeightOffset;
					}
					MapDisplays[i].OnMapDisplayUpdated(EMAOPJNDEML, num);
					if (activeSelf)
					{
						EMAOPJNDEML++;
					}
					break;
				case NAOEEJLHFDL.Right:
					if (activeSelf)
					{
						num2 += MapDisplays[i].HeightOffset;
					}
					MapDisplays[i].OnMapDisplayUpdated(JPPPBPMGLKP, num2);
					if (activeSelf)
					{
						JPPPBPMGLKP++;
					}
					break;
				}
			}
		}
	}
}
