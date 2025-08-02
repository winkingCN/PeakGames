using Assets.Scripts.Dialogs;
using TMPro;
using UnityEngine;

namespace ToonSocial.dialogs
{
	public class KickUserDialog : SimpleDialog
	{
		private long HNDDIFIANKG;

		private SocialHelper KCMNBMGCKKI;

		public TextMeshPro KickMessage;

		public Transform ButtonContainer;

		public GameObject WarningContainer;

		public SpriteRenderer[] BackgroundSprites;

		public override void DialogCreated()
		{
			base.DialogCreated();
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 21 && kCKDNJOMPJH != null && kCKDNJOMPJH.AEPLIGFCGIF == 2)
			{
				OPJDNNLKKGH();
			}
		}

		public void Kick()
		{
			JBLHLNCOLHD();
			KCMNBMGCKKI.CurrentSession.NMGBGAGMOGI.FHMAKHMJFKF(HNDDIFIANKG);
			Close();
		}

		public void Prepare(long BPKJLGJDFKG, string OIHJPHFHBKI, SocialHelper JANPCBNIGFG)
		{
			HNDDIFIANKG = BPKJLGJDFKG;
			KCMNBMGCKKI = JANPCBNIGFG;
			KickMessage.FCJBBPHFNPJ = string.Format(NKILHODNBDE.GHBGCADFLFB("KickMemberQuestion"), OIHJPHFHBKI);
		}

		private void OPJDNNLKKGH()
		{
			PNLEDFLLAKO(BackgroundSprites[1], 7.497f, 1.491f);
			PNLEDFLLAKO(BackgroundSprites[0], 7.497f, 1.491f);
			PNLEDFLLAKO(BackgroundSprites[2], 5.174f, 0.95f);
			PNLEDFLLAKO(BackgroundSprites[3], 5.174f, 0.95f);
			Vector3 localPosition = KickMessage.ANLKLKAINEO.localPosition;
			localPosition.y = 1.58f;
			KickMessage.ANLKLKAINEO.localPosition = localPosition;
			KickMessage.KMADLHHGAIH = 6.3f;
			localPosition = ButtonContainer.localPosition;
			localPosition.y = -0.48f;
			ButtonContainer.localPosition = localPosition;
			WarningContainer.SetActive(true);
		}

		private void PNLEDFLLAKO(SpriteRenderer CGGMEBGANNC, float KDLBBNBELBB, float HBKDNOHDOFG)
		{
			Vector2 size = CGGMEBGANNC.size;
			size.y = KDLBBNBELBB;
			CGGMEBGANNC.size = size;
			Vector3 localPosition = CGGMEBGANNC.transform.localPosition;
			localPosition.y = HBKDNOHDOFG;
			CGGMEBGANNC.transform.localPosition = localPosition;
		}
	}
}
