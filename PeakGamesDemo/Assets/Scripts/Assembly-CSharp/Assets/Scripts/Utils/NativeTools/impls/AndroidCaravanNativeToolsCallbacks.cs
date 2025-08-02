using System;
using UnityEngine;

namespace Assets.Scripts.Utils.NativeTools.impls
{
	public class AndroidCaravanNativeToolsCallbacks : MonoBehaviour
	{
		public Action<string> OnRead;

		public void OnBackupRestore(string MBBPBGHKLJM)
		{
			OnRead(MBBPBGHKLJM);
		}

		public void OnAcceptConsentPopup(string OEFCOJLNCKP)
		{
			FJPHLKFHDOG.JODHDOKPPCN();
		}

		public void OnTapConsentPopup(string OEFCOJLNCKP)
		{
			FJPHLKFHDOG.MDDJLEGCJFO();
		}
	}
}
