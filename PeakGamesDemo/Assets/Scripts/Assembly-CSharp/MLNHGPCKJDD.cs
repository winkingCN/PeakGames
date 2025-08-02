using UnityEngine;

public class MLNHGPCKJDD
{
	public static bool FPJCKMIHJPH(Vector2[] OMEDONLFPDP, Vector2 KJPPPBMDJKG)
	{
		int num = OMEDONLFPDP.Length;
		int num2 = num - 1;
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			if (((OMEDONLFPDP[i].y <= KJPPPBMDJKG.y && KJPPPBMDJKG.y < OMEDONLFPDP[num2].y) || (OMEDONLFPDP[num2].y <= KJPPPBMDJKG.y && KJPPPBMDJKG.y < OMEDONLFPDP[i].y)) && KJPPPBMDJKG.x > (OMEDONLFPDP[num2].x - OMEDONLFPDP[i].x) * (KJPPPBMDJKG.y - OMEDONLFPDP[i].y) / (OMEDONLFPDP[num2].y - OMEDONLFPDP[i].y) + OMEDONLFPDP[i].x)
			{
				flag = !flag;
			}
			num2 = i;
		}
		return flag;
	}
}
