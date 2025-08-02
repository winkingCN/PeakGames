using System;
using UnityEngine;

internal static class GEILEFJEADA
{
	public static bool FHGEHEFAHKO(ref Color PHBGMCOPNMH, Color LFCIOGDKBFB)
	{
		if (PHBGMCOPNMH.r == LFCIOGDKBFB.r && PHBGMCOPNMH.g == LFCIOGDKBFB.g && PHBGMCOPNMH.b == LFCIOGDKBFB.b && PHBGMCOPNMH.a == LFCIOGDKBFB.a)
		{
			return false;
		}
		PHBGMCOPNMH = LFCIOGDKBFB;
		return true;
	}

	public static bool MJKCDEJNFNI<T>(ref T PHBGMCOPNMH, T LFCIOGDKBFB) where T : IEquatable<T>
	{
		if (PHBGMCOPNMH.Equals(LFCIOGDKBFB))
		{
			return false;
		}
		PHBGMCOPNMH = LFCIOGDKBFB;
		return true;
	}

	public static bool KCBJBBNPGCI<T>(ref T PHBGMCOPNMH, T LFCIOGDKBFB) where T : struct
	{
		if (PHBGMCOPNMH.Equals(LFCIOGDKBFB))
		{
			return false;
		}
		PHBGMCOPNMH = LFCIOGDKBFB;
		return true;
	}

	public static bool MNFFPBCNGEL<T>(ref T PHBGMCOPNMH, T LFCIOGDKBFB) where T : class
	{
		if ((PHBGMCOPNMH == null && LFCIOGDKBFB == null) || (PHBGMCOPNMH != null && PHBGMCOPNMH.Equals(LFCIOGDKBFB)))
		{
			return false;
		}
		PHBGMCOPNMH = LFCIOGDKBFB;
		return true;
	}
}
