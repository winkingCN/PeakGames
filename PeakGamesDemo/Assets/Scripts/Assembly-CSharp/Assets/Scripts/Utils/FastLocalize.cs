using TMPro;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class FastLocalize : MonoBehaviour
	{
		public TextMeshPro TextToBeTranslated;

		public string Term;

		public void Awake()
		{
			if (TextToBeTranslated != null)
			{
				TextToBeTranslated.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB(Term);
			}
		}
	}
}
