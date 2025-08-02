using Assets.Scripts.CasualTools.Dialogs;
using Dialogs;
using TMPro;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

namespace ToonSocial.ui.joined
{
	public class TeamEntry : VerticalScrollEntry
	{
		public TextMeshPro TeamName;

		public TextMeshPro MemberCount;

		public TextMeshPro ButtonText;

		public bool isClosedTeam;

		public EventBasedSpriteButton Button;

		private SocialHelper PFFCACADPKB;

		private BGMENKMNLCH LLLIEGDGGBJ;

		private int NHBDFJFCIGM;

		public SpriteRenderer BadgeRenderer;

		public int OADDPGNIINO { get; set; }

		public BGMENKMNLCH MMDABIBEGEO
		{
			get
			{
				return LLLIEGDGGBJ;
			}
		}

		public void OnSelect()
		{
			if (JHOAHCHHBCH.CCAJIIFJPFF())
			{
				TeamInfoJoinDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialTeamInfoJoinDialog, false).GetComponent<TeamInfoJoinDialog>();
				component.SetReferral(NHBDFJFCIGM);
				component.ShowTeamInfoFromParent(OADDPGNIINO, PFFCACADPKB, null, this);
			}
		}

		public void Prepare(BGMENKMNLCH IBGOMPLHAFP, SocialHelper JANPCBNIGFG, int AFGFJNOIBKD)
		{
			LLLIEGDGGBJ = IBGOMPLHAFP;
			PFFCACADPKB = JANPCBNIGFG;
			NHBDFJFCIGM = AFGFJNOIBKD;
			TeamName.FCJBBPHFNPJ = IBGOMPLHAFP.PNGPLGHKFDI;
			MemberCount.FCJBBPHFNPJ = IBGOMPLHAFP.GMCGMPEEHJP + "/" + 50;
			OADDPGNIINO = (int)IBGOMPLHAFP.EEFMIHDPJPG;
			BadgeRenderer.sprite = JANPCBNIGFG.BadgesDictionary.GetBadge(IBGOMPLHAFP.FGPGOGEKDAM);
			isClosedTeam = false;
			UpdateButtonStyle();
		}

		public void UpdateButtonStyle()
		{
			if (MKINMKEMBPL.GABGKBAKHDP.HEANMKDLPGF(PHGCFPNJLEI.HMHDPEOJPNJ(OADDPGNIINO)))
			{
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Pending");
				Button.DisableButton();
			}
			else
			{
				ButtonText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("Join");
				Button.EnableButton();
			}
		}

		public override void SetContent<T>(T HOMONAAFMFH)
		{
			FKPMKEKODPC fKPMKEKODPC = HOMONAAFMFH as FKPMKEKODPC;
			Prepare(fKPMKEKODPC.ENGNFGGKODK, fKPMKEKODPC.IPCAELIMIBN, fKPMKEKODPC.DEIDLKIBDOB);
		}

		public int getReferal()
		{
			return NHBDFJFCIGM;
		}
	}
}
