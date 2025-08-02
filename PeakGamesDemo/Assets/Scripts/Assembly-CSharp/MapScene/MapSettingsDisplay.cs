using System.Collections;
using UnityEngine;

namespace MapScene
{
	public class MapSettingsDisplay : MonoBehaviour
	{
		public GameObject NotificationIndicator;

		private void Awake()
		{
			KMBNIBGIHGH kMBNIBGIHGH = KMBNIBGIHGH.GABGKBAKHDP;
			if (kMBNIBGIHGH.ACGKOEHCHHJ)
			{
				KMBNIBGIHGH.GABGKBAKHDP.AMGPDMNGBLO();
				KMBNIBGIHGH.GABGKBAKHDP.OMIKDFPHGBA();
			}
		}

		private void Start()
		{
			StartCoroutine(MNGLDBCMFOK());
		}

		public void ActivateNotificationIndicator(bool PPFADGKGEHO)
		{
			NotificationIndicator.SetActive(PPFADGKGEHO);
		}

		private IEnumerator MNGLDBCMFOK()
		{
			if (MCJHHDACJBG.MCPELNPBPIF)
			{
				yield return new WaitForSeconds(2f);
			}
			else
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			AHPBINLMNAM();
		}

		private void AHPBINLMNAM()
		{
			ActivateNotificationIndicator(KMBNIBGIHGH.GABGKBAKHDP.IOBIDNGDPIN > 0);
			KMBNIBGIHGH.GABGKBAKHDP.AHPBINLMNAM();
		}
	}
}
