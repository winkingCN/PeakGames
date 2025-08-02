using System.Collections;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using TMPro;
using ToonSocial;
using ToonSocial.dialogs;
using UnityEngine;
using Utils;

namespace Dialogs
{
	public class TeamInfoDialog : SimpleDialog
	{
		public GameObject Content;

		public SpriteRenderer BadgeSpriteRenderer;

		public TextMeshPro TeamNameText;

		public TextMeshPro TeamDescriptionText;

		public TextMeshPro MemberCountText;

		public TextMeshPro TeamScoreText;

		public TextMeshPro WeeklyHelpsText;

		public TextMeshPro RequiredLevelText;

		public TextMeshPro TeamTypeText;

		public GameObject EditButtonContainer;

		private SocialHelper PFFCACADPKB;

		private bool PEGGPKPKMFH;

		private bool LAGKFHPFICO;

		public override void OnDialogClosed()
		{
			base.OnDialogClosed();
			if (PEGGPKPKMFH)
			{
				LeaveTeamDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialLeaveTeamDialog, false).GetComponent<LeaveTeamDialog>();
				component.Prepare(PFFCACADPKB);
			}
			else if (LAGKFHPFICO)
			{
				TeamEditDialog component2 = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.TeamEditDialog, false).GetComponent<TeamEditDialog>();
				component2.Prepare(PFFCACADPKB);
			}
		}

		public void Prepare(DKBEJLGEAOA AFMJOLPBLKA, SocialHelper BHCIBOMDAIE)
		{
			PFFCACADPKB = BHCIBOMDAIE;
			if (PFFCACADPKB == null || AFMJOLPBLKA == null)
			{
				TeamNameText.FCJBBPHFNPJ = string.Empty;
				TeamDescriptionText.FCJBBPHFNPJ = string.Empty;
				MemberCountText.FCJBBPHFNPJ = string.Empty;
				WeeklyHelpsText.FCJBBPHFNPJ = string.Empty;
				RequiredLevelText.FCJBBPHFNPJ = string.Empty;
				TeamTypeText.FCJBBPHFNPJ = string.Empty;
				TeamScoreText.FCJBBPHFNPJ = string.Empty;
				EditButtonContainer.SetActive(false);
				StartCoroutine(PFNHIACPLFM());
				return;
			}
			BadgeSpriteRenderer.sprite = BHCIBOMDAIE.BadgesDictionary.GetBadge(AFMJOLPBLKA.FGPGOGEKDAM);
			TeamNameText.FCJBBPHFNPJ = AFMJOLPBLKA.PNGPLGHKFDI;
			TeamDescriptionText.FCJBBPHFNPJ = ILAMPCAFGIF.PJIBGAKHHFI(AFMJOLPBLKA.MMONLGJNACB);
			MemberCountText.FCJBBPHFNPJ = AFMJOLPBLKA.GMCGMPEEHJP + "/50";
			RequiredLevelText.FCJBBPHFNPJ = AFMJOLPBLKA.KOPMPMIFHNF.ToString();
			TeamTypeText.FCJBBPHFNPJ = ((!AFMJOLPBLKA.IHLIGFJLDLJ) ? NKILHODNBDE.GHBGCADFLFB("OpenNoun") : NKILHODNBDE.GHBGCADFLFB("Closed"));
			int num = 0;
			foreach (AKGIJAMHMNA value in AFMJOLPBLKA.HOINIMJNGFK.Values)
			{
				num += (int)value.CALJBGILMOL + value.GGBEMNJNAEE;
			}
			TeamScoreText.FCJBBPHFNPJ = num.ToString();
			if (HLFNMNPLJCP.GABGKBAKHDP.KDNCPBJFMBD((int)AFMJOLPBLKA.EEFMIHDPJPG, num))
			{
				MapManager.Instance.CurrentLeaderboardPageController.CurrentTeamLeaderboardTabPage.UpdateLeaderboardScroll(true);
			}
			EditButtonContainer.SetActive(AFMJOLPBLKA.AFPDGDAEENM == LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM);
			WeeklyHelpsText.FCJBBPHFNPJ = AFMJOLPBLKA.AKNLLPAHFOK.ToString();
			int num2 = OIAJPMNJGLK.HOGCELOOGEP();
			if (num2 > AFMJOLPBLKA.KEMNAAPNAPA)
			{
				WeeklyHelpsText.FCJBBPHFNPJ = "0";
			}
		}

		private IEnumerator PFNHIACPLFM()
		{
			while (PFFCACADPKB == null || PFFCACADPKB.CurrentSession.COPDAKACHFM == null)
			{
				yield return MCJHHDACJBG.CNDGGNLKOOC;
			}
			Prepare(PFFCACADPKB.CurrentSession.COPDAKACHFM, PFFCACADPKB);
		}

		public void OnLeaveClick()
		{
			PEGGPKPKMFH = true;
			Close();
		}

		public void OnEditClick()
		{
			LAGKFHPFICO = true;
			Close();
		}

		private void OnDestroy()
		{
			StopAllCoroutines();
		}
	}
}
