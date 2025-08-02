using System;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	public class EventCallback
	{
		public MonoBehaviour Target;

		public string MethodName = string.Empty;

		public void LAPGGGMFPFB(UnityEngine.Object ODDAPEGFCIJ = null)
		{
			if (KLONFPGKCOH() && Application.isPlaying)
			{
				Target.gameObject.SendMessage(MethodName, ODDAPEGFCIJ, SendMessageOptions.DontRequireReceiver);
			}
		}

		public bool KLONFPGKCOH()
		{
			return Target != null && !string.IsNullOrEmpty(MethodName);
		}
	}
}
