using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class ChatEntry : MonoBehaviour
	{
		public TextMeshPro Sender;

		public TextMeshPro Message;

		public string OriginalText;

		public float Height = 2f;

		protected SocialHelper IPCAELIMIBN;

		public EKPAJFBBAJC CurrentChatMessage;

		[CompilerGenerated]
		private static MatchEvaluator EBCOMJBLIPP;

		public virtual float GetHeight()
		{
			return Height;
		}

		public virtual void Prepare(EKPAJFBBAJC KINKOCNMOMJ, SocialHelper JANPCBNIGFG)
		{
			IPCAELIMIBN = JANPCBNIGFG;
			if (KINKOCNMOMJ != null && !(Message == null))
			{
				if (Sender != null)
				{
					Sender.FCJBBPHFNPJ = KINKOCNMOMJ.KNMOIMNECKE;
				}
				Message.HAGIKDIIIGD = 17;
				string text = (OriginalText = ILAMPCAFGIF.PJIBGAKHHFI(KINKOCNMOMJ.HKCNCCIAMEL));
				Message.SetText(text);
				CurrentChatMessage = KINKOCNMOMJ;
			}
		}

		private string HJIHCAFPDLF(string FCJBBPHFNPJ)
		{
			return Regex.Replace(FCJBBPHFNPJ, "\\\\U(?<Value>[a-zA-Z0-9]{8})", (Match CEKMAJAHNAG) => char.ConvertFromUtf32(int.Parse(CEKMAJAHNAG.Groups["Value"].Value, NumberStyles.HexNumber)));
		}

		[CompilerGenerated]
		private static string AJFCEKJECCD(Match CEKMAJAHNAG)
		{
			return char.ConvertFromUtf32(int.Parse(CEKMAJAHNAG.Groups["Value"].Value, NumberStyles.HexNumber));
		}
	}
}
