using UnityEngine;

public class GAJDBDAHMGG
{
	public static Vector3 FMICGMPJAMC(Vector3 KJPPPBMDJKG, Vector3 HOGNFMAJFME, Vector3 CNACKKNLDDL)
	{
		Vector3 vector = CNACKKNLDDL - HOGNFMAJFME;
		float num = Vector3.Dot(KJPPPBMDJKG - HOGNFMAJFME, vector);
		return HOGNFMAJFME + vector * num;
	}

	public static Vector3 FGJJEGEOPHA(Vector3 KJPPPBMDJKG, Vector3 HOGNFMAJFME, Vector3 CNACKKNLDDL)
	{
		Vector3 vector = CNACKKNLDDL - HOGNFMAJFME;
		float num = Mathf.Clamp01(Vector3.Dot(KJPPPBMDJKG - HOGNFMAJFME, vector));
		return HOGNFMAJFME + vector * num;
	}
}
