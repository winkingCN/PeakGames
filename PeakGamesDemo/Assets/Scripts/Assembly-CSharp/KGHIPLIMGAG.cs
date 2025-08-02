using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class KGHIPLIMGAG : RuntimeInitializeOnLoadMethodAttribute
{
	public KGHIPLIMGAG()
		: base(RuntimeInitializeLoadType.BeforeSceneLoad)
	{
	}
}
