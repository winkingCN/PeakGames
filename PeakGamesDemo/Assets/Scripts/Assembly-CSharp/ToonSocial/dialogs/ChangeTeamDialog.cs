using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using TMPro;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;
using caravan.protobuf.messages;

namespace ToonSocial.dialogs
{
	public class ChangeTeamDialog : SimpleDialog
	{
		public TextMeshPro CurrentTeamName;

		public TextMeshPro NewTeamName;

		public GameObject WarningContainer;

		public GameObject LoadingIcon;

		public GameObject[] Buttons;

		public Transform LeaveText;

		public Transform Seperator;

		public Transform CurrentTeam;

		public Transform NewTeam;

		public Transform ButtonContainer;

		public Transform CurrentBadgeTransform;

		public Transform NewBadgeTransform;

		public SpriteRenderer OldBadgeSprite;

		public SpriteRenderer NewBadgeSprite;

		public SpriteRenderer[] BackgroundSprites;

		public static ChangeTeamDialog ActiveOne;

		private bool CHPLICIPAHD;

		private bool LGJODHCKGFI;

		private int NHBDFJFCIGM;

		private int KKMIEDBFCOB;

		private long FOIKAEEFKKE;

		private TeamEntry JGHMIDDEHOG;

		private SocialHelper KCMNBMGCKKI;

		public override void DialogCreated()
		{
			base.DialogCreated();
			ActiveOne = this;
			KCKDNJOMPJH kCKDNJOMPJH = DGOMNDMPMBG.GABGKBAKHDP.FABKMFCBELE;
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() >= 21 && kCKDNJOMPJH != null && kCKDNJOMPJH.AEPLIGFCGIF == 2)
			{
				OPJDNNLKKGH();
			}
		}

		public void Prepare(SocialHelper JANPCBNIGFG, int AFGFJNOIBKD, TeamInfo JBOJDNHIICH, TeamEntry DFCOHHJIAHH)
		{
			KCMNBMGCKKI = JANPCBNIGFG;
			NHBDFJFCIGM = AFGFJNOIBKD;
			KKMIEDBFCOB = JBOJDNHIICH.id;
			JGHMIDDEHOG = DFCOHHJIAHH;
			FOIKAEEFKKE = LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO;
			CurrentTeamName.FCJBBPHFNPJ = LECPGNKOABP.GABGKBAKHDP.EFHEIFMEJCN;
			NewTeamName.FCJBBPHFNPJ = JBOJDNHIICH.name;
			Sprite sprite = KCMNBMGCKKI.CurrentJoinedContainer.MyTeamTab.TeamBadge.sprite;
			if (sprite != null)
			{
				OldBadgeSprite.sprite = sprite;
			}
			Sprite badge = KCMNBMGCKKI.BadgesDictionary.GetBadge(JBOJDNHIICH.badge);
			if (badge != null)
			{
				NewBadgeSprite.sprite = badge;
			}
			Vector3 localPosition = CurrentBadgeTransform.localPosition;
			localPosition.x = HJBCCCHBKNB(CurrentTeamName) / -2f - 0.06f;
			CurrentBadgeTransform.localPosition = localPosition;
			localPosition = NewBadgeTransform.localPosition;
			localPosition.x = HJBCCCHBKNB(NewTeamName) / -2f - 0.06f;
			NewBadgeTransform.localPosition = localPosition;
		}

		private float HJBCCCHBKNB(TextMeshPro KBINGMPHHOG)
		{
			float width = KBINGMPHHOG.GPPKOGCLKPL.rect.width;
			return Mathf.Min(KBINGMPHHOG.GetPreferredValues().x, width);
		}

		private void OPJDNNLKKGH()
		{
			PNLEDFLLAKO(BackgroundSprites[0], 10.58f, -0.049f);
			PNLEDFLLAKO(BackgroundSprites[1], 10.58f, -0.049f);
			PNLEDFLLAKO(BackgroundSprites[2], 8.018f, -0.684f);
			PNLEDFLLAKO(BackgroundSprites[3], 8.018f, -0.684f);
			Vector3 localPosition = LeaveText.localPosition;
			localPosition.y = 1.93f;
			LeaveText.localPosition = localPosition;
			localPosition = Seperator.localPosition;
			localPosition.y = 1.07f;
			Seperator.localPosition = localPosition;
			localPosition = ButtonContainer.localPosition;
			localPosition.y = 0.24f;
			ButtonContainer.localPosition = localPosition;
			localPosition = CurrentTeam.localPosition;
			localPosition.y = 0.26f;
			CurrentTeam.localPosition = localPosition;
			localPosition = NewTeam.localPosition;
			localPosition.y = -1.31f;
			NewTeam.localPosition = localPosition;
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

		public void OnYesClick()
		{
			JBLHLNCOLHD();
			CHPLICIPAHD = true;
			LoadingIcon.SetActive(true);
			Buttons[0].SetActive(false);
			Buttons[1].SetActive(false);
			Buttons[2].SetActive(true);
			Buttons[3].SetActive(true);
			HLHELBGKKCM();
		}

		public override void OnDialogClosed()
		{
			LoadingIcon.SetActive(false);
			base.OnDialogClosed();
			ActiveOne = null;
		}

		private void HLHELBGKKCM()
		{
			KCMNBMGCKKI.RequestLeaveTeam();
		}

		private void HJPKPBPHOJM()
		{
			PHGCFPNJLEI.DCPADMOLNML = "Change";
			PHGCFPNJLEI.DEIDLKIBDOB = NHBDFJFCIGM;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChangeTeam, "Joining new team: {0}", KKMIEDBFCOB);
			KCMNBMGCKKI.JoinToTeam(KKMIEDBFCOB, JGHMIDDEHOG);
		}

		private void CILFGFIOCHL()
		{
			PHGCFPNJLEI.DCPADMOLNML = "Change";
			PHGCFPNJLEI.DEIDLKIBDOB = 6;
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChangeTeam, "Joining old team: {0}", FOIKAEEFKKE);
			KCMNBMGCKKI.JoinToTeam(FOIKAEEFKKE, null);
		}

		public void OnLeaveEnd()
		{
			HJPKPBPHOJM();
		}

		public void OnJoinEnd(bool DIDHNNMKJFE, NKILAONHNNE EEBJBOHPDDH)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChangeTeam, "Change team result: {0}", DIDHNNMKJFE);
			if (EEBJBOHPDDH != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChangeTeam, "Change team error code: {0}", EEBJBOHPDDH.KJLHFILAKOB);
				switch (EEBJBOHPDDH.KJLHFILAKOB)
				{
				case 1000:
					break;
				case 3003:
					KFGHLAKOOGK();
					break;
				case 3015:
				{
					int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
					int kOPMPMIFHNF = EEBJBOHPDDH.KOPMPMIFHNF;
					if (num < kOPMPMIFHNF)
					{
						KFGHLAKOOGK();
					}
					break;
				}
				default:
					Close();
					break;
				}
			}
			else
			{
				VerticalScrollController.UnlockAllScrolls();
				FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID();
				MapManager.Instance.CurrentContainerManager.SlideToPosition(1);
				Close();
			}
		}

		private void KFGHLAKOOGK()
		{
			if (!LGJODHCKGFI)
			{
				LGJODHCKGFI = true;
				CILFGFIOCHL();
			}
		}

		public override bool CanHandleBackButton()
		{
			return !CHPLICIPAHD;
		}

		public override bool CanCloseOnBlackPanelTouch()
		{
			return !CHPLICIPAHD;
		}
	}
}
