using UnityEngine;

internal class LFPFFONHOAN
{
	private AndroidJavaObject JBOBAGEOMFC;

	public LFPFFONHOAN()
	{
		AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.crashlytics.android.answers.Answers");
		JBOBAGEOMFC = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance", new object[0]);
	}

	public void ILNNDCGJCKG(string GDMGHPJHPEH, LNEGKOGBOAG AAEJFMIBHJN)
	{
		JBOBAGEOMFC.Call(GDMGHPJHPEH, AAEJFMIBHJN.JBOBAGEOMFC);
	}
}
