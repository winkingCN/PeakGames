using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using TMPro;
using ToonSocial;
using ToonSocial.dialogs;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;
using caravan.protobuf.messages;

namespace Dialogs
{
	public class TeamInfoJoinDialog : SimpleDialog
	{
		private enum NIKKEHHHODP
		{
			SocialTeamInfo = 0,
			LeaderBoardTeamInfo = 1
		}

		public GameObject LoadingIndicator;

		public SpriteRenderer BadgeSpriteRenderer;

		public TextMeshPro TeamNameText;

		public TextMeshPro TeamDescriptionText;

		public TextMeshPro MemberCountText;

		public TextMeshPro TeamScoreText;

		public TextMeshPro WeeklyHelpsText;

		public TextMeshPro RequiredLevelText;

		public TextMeshPro TeamTypeText;

		public Transform JoinButtonTransform;

		public EventBasedSpriteButton JoinButton;

		public GameObject TeamEntryPrefab;

		public VerticalScrollController TeamEntryScrollController;

		public SpriteRenderer BackgroundLeft;

		public SpriteRenderer BackgroundRight;

		public Transform MaskBottom;

		private SocialHelper PFFCACADPKB;

		private bool CNICJCOANPI;

		private long KKMIEDBFCOB;

		private TeamEntry JGHMIDDEHOG;

		private int DFBAMHAKIFK = -1;

		private bool CMANHKMJIEN;

		private bool LIEDJJLONPO;

		private bool DACLCOKJCJL;

		private static TeamInfoJoinDialog CNDLKPAFCLB;

		private TeamInfo PCMDCNOEHJA;

		private int NHBDFJFCIGM;

		private global::FHOJBJMMNOD<BMHDDEMBAEM, FriendEntry> JKANNLPGLPJ;

		private float JNFMOMPFIGG;

		private NIKKEHHHODP MDFEABCFMEJ;

		[CompilerGenerated]
		private static Func<TeamMemberInfo, int> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Func<TeamMemberInfo, int> DNBOPLHGMHA;

		[CompilerGenerated]
		private static Func<TeamMemberInfo, int> JFHCKLHBBDI;

		[CompilerGenerated]
		private static Func<TeamMemberInfo, int> NOGHOEBDKAH;

		[CompilerGenerated]
		private static Func<TeamMemberInfo, int> OLIGILDNADD;

		public void Start()
		{
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				float num = 1.7787265f * ONCMBJKLKIL.EMFKAPJMDCC;
				float num2 = (ONCMBJKLKIL.FHAMOHDEGMK - num) * 0.3f;
				Vector2 size = new Vector2(BackgroundLeft.size.x, 14.92428f + num2);
				Vector2 size2 = new Vector2(BackgroundLeft.size.x, 14.92428f + num2);
				MaskBottom.localPosition = new Vector3(0f, -7.92f - num2, 0f);
				BackgroundLeft.size = size;
				BackgroundRight.size = size2;
				BackgroundLeft.transform.localPosition = new Vector3(BackgroundLeft.transform.localPosition.x, 0.5178f - num2 * 0.5f, 0f);
				BackgroundRight.transform.localPosition = new Vector3(BackgroundRight.transform.localPosition.x, 0.5178f - num2 * 0.5f, 0f);
				Vector2 size3 = TeamEntryScrollController.ScrollArea.size;
				size3.y = 7f + num2;
				TeamEntryScrollController.ScrollArea.size = size3;
				Vector2 offset = TeamEntryScrollController.ScrollArea.offset;
				offset.y -= num2 * 0.5f;
				TeamEntryScrollController.ScrollArea.offset = offset;
				JNFMOMPFIGG = num2 * 0.5f;
			}
		}

		public void SetReferral(int AFGFJNOIBKD)
		{
			NHBDFJFCIGM = AFGFJNOIBKD;
		}

		public void SetSelectedTeamTab(int DFNMHHJKNKH)
		{
			DFBAMHAKIFK = DFNMHHJKNKH;
		}

		public void OnJoinClick()
		{
			Vector3 position = JoinButtonTransform.transform.position;
			position.y += 2f;
			if (!JHOAHCHHBCH.CCAJIIFJPFF())
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_Connection"), position);
				return;
			}
			if (MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() < 20)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_PassLevel"), position);
				return;
			}
			if (PCMDCNOEHJA != null && PCMDCNOEHJA.count >= 50)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_TeamFull"), position);
				return;
			}
			if (PCMDCNOEHJA != null && PCMDCNOEHJA.id == LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_SameTeam"), position);
				return;
			}
			int num = MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1;
			if (PCMDCNOEHJA != null && PCMDCNOEHJA.level > num)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_LowLevel"), position);
			}
			else if (PFFCACADPKB.CurrentSession != null && PFFCACADPKB.CurrentSession.COPDAKACHFM != null)
			{
				if (PCMDCNOEHJA != null && !PCMDCNOEHJA.isClosed && PCMDCNOEHJA.id != LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO)
				{
					DACLCOKJCJL = true;
					Close();
				}
				else
				{
					MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("Error_AlreadyInTeam"), position);
				}
			}
			else
			{
				LIEDJJLONPO = true;
				Close();
			}
		}

		public bool IsClosed()
		{
			return CNICJCOANPI;
		}

		public void ShowTeamInfoFromParent(int EMNOJOHFMEH, SocialHelper BHCIBOMDAIE, GetTeamInfoResponseMessage OEFCOJLNCKP = null, TeamEntry DFCOHHJIAHH = null)
		{
			MDFEABCFMEJ = NIKKEHHHODP.LeaderBoardTeamInfo;
			PFFCACADPKB = BHCIBOMDAIE;
			JGHMIDDEHOG = DFCOHHJIAHH;
			JoinButton.CanBeClicked = false;
			TeamScoreText.FCJBBPHFNPJ = string.Empty;
			if (OEFCOJLNCKP != null)
			{
				LoadingIndicator.transform.localPosition = new Vector3(0f, -3.58f, 0f);
				JOHHLPIIGIA();
				OGLIBCLBEDG(OEFCOJLNCKP.teamInfo);
				StartCoroutine(FPMONOPFFNC(OEFCOJLNCKP));
			}
			else
			{
				JOHHLPIIGIA();
				FELPKBNOHJK();
				KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH>
				{
					new AKHDMHCPFPJ(EMNOJOHFMEH, NLJLAEJNMOH)
				});
			}
		}

		private void NLJLAEJNMOH(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			if (CMANHKMJIEN)
			{
				MFLHLPOOBCB(OMJOIIOONMO);
			}
			else
			{
				StartCoroutine(KEEDHIBDCDO(OMJOIIOONMO));
			}
		}

		private IEnumerator KEEDHIBDCDO(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			while (!CMANHKMJIEN)
			{
				yield return null;
			}
			MFLHLPOOBCB(OMJOIIOONMO);
		}

		private IEnumerator FPMONOPFFNC(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			yield return new WaitForSeconds(0.42f);
			MFLHLPOOBCB(OMJOIIOONMO);
		}

		private void FELPKBNOHJK()
		{
			BadgeSpriteRenderer.sprite = null;
			TeamNameText.FCJBBPHFNPJ = string.Empty;
			TeamDescriptionText.FCJBBPHFNPJ = string.Empty;
			MemberCountText.FCJBBPHFNPJ = string.Empty;
			WeeklyHelpsText.FCJBBPHFNPJ = string.Empty;
			RequiredLevelText.FCJBBPHFNPJ = string.Empty;
			TeamTypeText.FCJBBPHFNPJ = string.Empty;
		}

		private void OGLIBCLBEDG(TeamInfo GCLINOAJKIH)
		{
			if (GCLINOAJKIH == null)
			{
				FELPKBNOHJK();
				return;
			}
			TeamNameText.FCJBBPHFNPJ = GCLINOAJKIH.name;
			TeamDescriptionText.FCJBBPHFNPJ = GCLINOAJKIH.description;
			MemberCountText.FCJBBPHFNPJ = GCLINOAJKIH.count + "/50";
			WeeklyHelpsText.FCJBBPHFNPJ = GCLINOAJKIH.helpCount.ToString();
			RequiredLevelText.FCJBBPHFNPJ = GCLINOAJKIH.level.ToString();
			TeamTypeText.FCJBBPHFNPJ = ((!GCLINOAJKIH.isClosed) ? NKILHODNBDE.GHBGCADFLFB("OpenNoun") : NKILHODNBDE.GHBGCADFLFB("Closed"));
			BadgeSpriteRenderer.sprite = PFFCACADPKB.BadgesDictionary.GetBadge(GCLINOAJKIH.badge);
		}

		private void MFLHLPOOBCB(GetTeamInfoResponseMessage OMJOIIOONMO)
		{
			if (CNICJCOANPI)
			{
				return;
			}
			if (OMJOIIOONMO == null)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TeamInfo"));
				Close();
			}
			PCMDCNOEHJA = OMJOIIOONMO.teamInfo;
			KKMIEDBFCOB = PCMDCNOEHJA.id;
			PCCOFJDCDNJ();
			JoinButton.CanBeClicked = true;
			OGLIBCLBEDG(PCMDCNOEHJA);
			int count = OMJOIIOONMO.teamMembers.Count;
			int num = OIAJPMNJGLK.HOGCELOOGEP();
			if (num > PCMDCNOEHJA.helpWeek)
			{
				WeeklyHelpsText.FCJBBPHFNPJ = "0";
			}
			IOrderedEnumerable<TeamMemberInfo> orderedEnumerable = from IBBBMACIBGK in OMJOIIOONMO.teamMembers
				orderby IBBBMACIBGK.maxLevelReached + IBBBMACIBGK.clScore descending, IBBBMACIBGK.maxLevelReached descending, IBBBMACIBGK.clScore descending, IBBBMACIBGK.helpWeek descending, IBBBMACIBGK.helpCount descending
				select IBBBMACIBGK;
			int num2 = 0;
			int num3 = 0;
			List<BMHDDEMBAEM> list = new List<BMHDDEMBAEM>();
			foreach (TeamMemberInfo item2 in orderedEnumerable)
			{
				BMHDDEMBAEM bMHDDEMBAEM = new BMHDDEMBAEM();
				bMHDDEMBAEM.OGHDEOIFKFP = false;
				bMHDDEMBAEM.IPCAELIMIBN = PFFCACADPKB;
				bMHDDEMBAEM.KFBCFDALGBB = item2.helpCount;
				bMHDDEMBAEM.KEMNAAPNAPA = item2.helpWeek;
				bMHDDEMBAEM.MNPEKJAAFHD = item2.Id == (int)LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
				bMHDDEMBAEM.AILNPFFLELI = OMJOIIOONMO.teamInfo.manager == item2.Id;
				bMHDDEMBAEM.EALJKKBHDHK = item2.nick;
				bMHDDEMBAEM.CALJBGILMOL = item2.maxLevelReached;
				bMHDDEMBAEM.KCAHGIBBHKJ = num3 + 1;
				bMHDDEMBAEM.GDMECFECCOM = item2.Id;
				bMHDDEMBAEM.GGBEMNJNAEE = item2.clScore;
				BMHDDEMBAEM item = bMHDDEMBAEM;
				list.Add(item);
				num2 += item2.maxLevelReached + item2.clScore;
				num3++;
			}
			if (JKANNLPGLPJ == null)
			{
				JKANNLPGLPJ = new global::FHOJBJMMNOD<BMHDDEMBAEM, FriendEntry>(TeamEntryScrollController, TeamEntryPrefab.GetComponent<FriendEntry>(), 15, 0.85f);
				JKANNLPGLPJ.FEHBHKPHBFC(10, 1.4f, 0.8f);
				TeamEntryScrollController.Init();
				TeamEntryScrollController.SetOffsets(0f - JNFMOMPFIGG, 0f - JNFMOMPFIGG);
			}
			JKANNLPGLPJ.BBOMMEKKAEB(list);
			TeamEntryScrollController.SetContentSize((float)count * 1.4f + 0.2f);
			TeamEntryScrollController.ScrollToTop();
			TeamEntryScrollController.JBOFOOHGDGC();
			int num4 = LJFKNENDNCO((int)KKMIEDBFCOB);
			if (HLFNMNPLJCP.GABGKBAKHDP.CDIPPLFJFEF(PCMDCNOEHJA.id, num2))
			{
				int num5 = LJFKNENDNCO((int)KKMIEDBFCOB);
				if (num5 > -1)
				{
					int kFAFMNLHGCF = num5 - num4;
					MapManager.Instance.CurrentLeaderboardPageController.CurrentTeamLeaderboardTabPage.UpdateLeaderboardScrollWithOrder(kFAFMNLHGCF);
				}
				else
				{
					MapManager.Instance.CurrentLeaderboardPageController.CurrentTeamLeaderboardTabPage.UpdateLeaderboardScroll(true);
				}
			}
			TeamScoreText.FCJBBPHFNPJ = num2.ToString();
		}

		private int LJFKNENDNCO(int EMNOJOHFMEH)
		{
			if (DFBAMHAKIFK == -1)
			{
				return -1;
			}
			List<FMHKCJGDPEB> list = HLFNMNPLJCP.GABGKBAKHDP.BBINNBKCDIH(DFBAMHAKIFK + 1);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				if (list[i].OADDPGNIINO.Equals(EMNOJOHFMEH))
				{
					return i;
				}
			}
			return -1;
		}

		private void JOHHLPIIGIA()
		{
			LoadingIndicator.SetActive(true);
			JoinButton.CanBeClicked = false;
		}

		private void PCCOFJDCDNJ()
		{
			LoadingIndicator.SetActive(false);
			JoinButton.CanBeClicked = true;
		}

		public override void OnDialogClosed()
		{
			CNICJCOANPI = true;
			base.OnDialogClosed();
			StopAllCoroutines();
			CNDLKPAFCLB = null;
			if (DACLCOKJCJL)
			{
				ChangeTeamDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialChangeTeamDialog, false).GetComponent<ChangeTeamDialog>();
				component.Prepare(PFFCACADPKB, NHBDFJFCIGM, PCMDCNOEHJA, JGHMIDDEHOG);
			}
			else if (LIEDJJLONPO)
			{
				if (MDFEABCFMEJ == NIKKEHHHODP.LeaderBoardTeamInfo)
				{
					VerticalScrollController.UnlockAllScrolls();
					FHAAAFAAMDO.GABGKBAKHDP.FPGFIAKIIID();
					MapManager.Instance.CurrentContainerManager.SlideToPosition(1);
				}
				SocialCreateUserDialog.UserCreationType = 0;
				PHGCFPNJLEI.DCPADMOLNML = "Join";
				PHGCFPNJLEI.DEIDLKIBDOB = NHBDFJFCIGM;
				PFFCACADPKB.JoinToTeam(KKMIEDBFCOB, JGHMIDDEHOG);
			}
		}

		protected override void BLELAMHLLNN()
		{
			base.BLELAMHLLNN();
			CMANHKMJIEN = true;
		}

		public override void DialogCreated()
		{
			base.DialogCreated();
			CNDLKPAFCLB = this;
		}

		public static void CloseActiveOne()
		{
			if (CNDLKPAFCLB != null)
			{
				CNDLKPAFCLB.Close();
			}
		}

		[CompilerGenerated]
		private static int NNGBLNNAEBK(TeamMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.maxLevelReached + IBBBMACIBGK.clScore;
		}

		[CompilerGenerated]
		private static int LENBMCJEPKI(TeamMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.maxLevelReached;
		}

		[CompilerGenerated]
		private static int HDLFEHGPLMF(TeamMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.clScore;
		}

		[CompilerGenerated]
		private static int MOMMIGAEPFJ(TeamMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.helpWeek;
		}

		[CompilerGenerated]
		private static int EOFCCCPDJBA(TeamMemberInfo IBBBMACIBGK)
		{
			return IBBBMACIBGK.helpCount;
		}
	}
}
