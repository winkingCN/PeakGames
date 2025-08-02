using UnityEngine;

internal class CJCJCHDOEIK : PLNEBHAJOJP
{
	private static readonly AndroidJavaClass OJJGGEEPELJ = new AndroidJavaClass("io.fabric.unity.android.FabricInitializer");

	public override string JPLFFCHJICB()
	{
		return OJJGGEEPELJ.CallStatic<string>("JNI_InitializeFabric", new object[0]);
	}
}
