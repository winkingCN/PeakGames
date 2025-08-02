using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.MapScene;
using DG.Tweening;
using DataHelpers;
using TMPro;
using UnityEngine;
using Utils;

namespace MapScene
{
	public class CLRankDisplay : MonoBehaviour, CCGJIPEFOEL
	{
		private const string EKECLBKINCH = "#";

		public TextMeshPro Rank;

		public TextMeshPro TimeLeft;

		public Transform ClockHand;

		private long MNGFOOGIKKO;

		private void JIMBAPGACIJ(bool JFFNJGIGIGA)
		{
			if (base.gameObject.activeSelf)
			{
				IDFPAFEJPPH iDFPAFEJPPH = IDFPAFEJPPH.GABGKBAKHDP;
				UpdateRank(iDFPAFEJPPH.OHAPPDGAKNG);
				if (JFFNJGIGIGA)
				{
					MNGFOOGIKKO = iDFPAFEJPPH.AEBACBBGHKI;
					IOPCENJILNF();
				}
				else
				{
					TimeLeft.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
				}
			}
		}

		public void UpdateRank(int JEAAHAFHDEG)
		{
			Rank.FCJBBPHFNPJ = "#" + JEAAHAFHDEG;
		}

		public void OnClick()
		{
			if (JHOAHCHHBCH.CCAJIIFJPFF())
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.CLLeaderboardDialog, false);
			}
			else
			{
				FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.NoConnectionDialog, false);
			}
		}

		private void IOPCENJILNF()
		{
			if (MNGFOOGIKKO <= 0)
			{
				GMOMEPNHJGA();
				return;
			}
			TimerHelper.GABGKBAKHDP.RegisterTimer(this);
			DPOOABPAMFO();
		}

		public void DecreaseTimeLeft()
		{
			MNGFOOGIKKO--;
			DPOOABPAMFO();
		}

		private void GMOMEPNHJGA()
		{
			StartCoroutine(OIKNJMPAMCA());
		}

		private void DPOOABPAMFO()
		{
			if (MNGFOOGIKKO > 0)
			{
				TimeLeft.FCJBBPHFNPJ = GJEIMLMEHIN.JDIMBPFKOBB((int)MNGFOOGIKKO, true);
				ClockHand.DORotate(new Vector3(0f, 0f, (float)(MNGFOOGIKKO % 4) * 90f), 0.2f).SetEase(Ease.OutBack);
			}
			else
			{
				TimerHelper.GABGKBAKHDP.DeregisterTimer(this);
				TimeLeft.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("CL_Finished");
				GMOMEPNHJGA();
			}
		}

		private static IEnumerator OIKNJMPAMCA()
		{
			yield return MCJHHDACJBG.KNLADMIBAAD;
			while (MapManager.Instance.CurrentNewMapAnimationController.LPIEKIDOGNI)
			{
				yield return MCJHHDACJBG.CHFOIGLAMPN;
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChampionsLeague, "CLRank Display > CheckStatusCommand Called");
			IKDMCJPBBIH item = IDFPAFEJPPH.GABGKBAKHDP.CGOOBAHCDDK();
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}

		public void UpdateTimeLeft()
		{
			if (MNGFOOGIKKO > 0)
			{
				MNGFOOGIKKO = IDFPAFEJPPH.GABGKBAKHDP.AEBACBBGHKI;
			}
		}

		public void Activate(bool HJDKIFFPCBE, bool JFFNJGIGIGA)
		{
			base.gameObject.SetActive(HJDKIFFPCBE);
			JIMBAPGACIJ(JFFNJGIGIGA);
		}
	}
}
