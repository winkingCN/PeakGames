using UnityEngine;

public static class FPMIEKMJFGO
{
	public static float OOGJOGPHBNJ(Vector2 LLAEDBFNCCP, Vector2 BMIOECELGCA)
	{
		float num = Vector2.Angle(LLAEDBFNCCP, BMIOECELGCA);
		if (Vector3.Cross(LLAEDBFNCCP, BMIOECELGCA).z > 0f)
		{
			num = 360f - num;
		}
		return num;
	}
}
