using TMPro;
using UnityEngine;

namespace Dialogs
{
	public class RewardText : MonoBehaviour
	{
		public TextMeshPro[] TextFields;

		public void SetRewardAmount(int NNIDKMJGAJO, bool GLDONINJAOK = false)
		{
			base.gameObject.SetActive(true);
			string text = NNIDKMJGAJO.ToString();
			if (GLDONINJAOK)
			{
				text = NNIDKMJGAJO.ToString("# ###");
			}
			int i = 0;
			for (int num = TextFields.Length; i < num; i++)
			{
				TextFields[i].FCJBBPHFNPJ = text;
			}
		}

		public void Activate(bool EDDNOJDPMCF)
		{
			base.gameObject.SetActive(EDDNOJDPMCF);
		}
	}
}
