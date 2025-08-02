using System.Reflection;
using Facebook.Unity.Editor.Dialogs;
using UnityEngine;

public class JIGBBPCLJHI
{
	public static void AJDMAMHPMJF()
	{
		string value = "EAAMUbheBQikBAK9s9l9dW3mclZCrWKST3t4woyj0Fm333ZBDfU4BgK5lXeO8HgkTVGWIbLKC0MP5y2xtcNTZCY0UJ4fOX93kcDmQkwMBciDMH3I3fJ8iENQH97jiRrclbRHvljhqvtZAZCkv1WwifFRzBp27dmCwZD";
		MockLoginDialog mockLoginDialog = Object.FindObjectOfType<MockLoginDialog>();
		if (mockLoginDialog != null)
		{
			typeof(MockLoginDialog).GetField("accessToken", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(mockLoginDialog, value);
			typeof(MockLoginDialog).GetMethod("SendSuccessResult", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(mockLoginDialog, null);
			Object.Destroy(mockLoginDialog);
		}
	}
}
