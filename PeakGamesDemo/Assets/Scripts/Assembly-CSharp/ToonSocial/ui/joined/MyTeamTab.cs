using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Assets.Scripts.MapScene;
using Dialogs;
using NewMapScene;
using Ui.VerticalScroll;
using UnityEngine;
using Utils;

namespace ToonSocial.ui.joined
{
	public class MyTeamTab : TabPage
	{
		public GameObject FriendEntryPrefab;

		public VerticalScrollController MembersScrollController;

		public SocialHelper CurrentSocialHelper;

		public SpriteRenderer TeamBadge;

		private bool DFIKDMCPFFA;

		private global::FHOJBJMMNOD<BMHDDEMBAEM, FriendEntry> JKANNLPGLPJ;

		[HideInInspector]
		public KickButton ActiveKickButton;

		private float JLKONGJKGKJ;

		[CompilerGenerated]
		private static Func<AKGIJAMHMNA, long> EBCOMJBLIPP;

		[CompilerGenerated]
		private static Func<AKGIJAMHMNA, long> DNBOPLHGMHA;

		[CompilerGenerated]
		private static Func<AKGIJAMHMNA, int> JFHCKLHBBDI;

		[CompilerGenerated]
		private static Func<AKGIJAMHMNA, long> NOGHOEBDKAH;

		[CompilerGenerated]
		private static Func<AKGIJAMHMNA, long> OLIGILDNADD;

		public void Start()
		{
			MapPageSizer currentMapPageSizer = MapManager.Instance.CurrentMapPageSizer;
			if (currentMapPageSizer.CurrentWidth > 0f)
			{
				AOJNCIHALBD(currentMapPageSizer.CurrentWidth);
			}
			else
			{
				currentMapPageSizer.PBNPBHCHODE += AOJNCIHALBD;
			}
		}

		private void AOJNCIHALBD(float HHHMOGOKFHF)
		{
			CGCCKDELCAH();
			Vector2 size = MembersScrollController.ScrollArea.size;
			size.x = HHHMOGOKFHF;
			float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
			if (centerPanelExtend > 0f)
			{
				size.y = 11.5f + centerPanelExtend;
				MembersScrollController.ScrollArea.offset = new Vector2(0f, (0f - centerPanelExtend) * 0.5f);
				MembersScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
			}
			else
			{
				MembersScrollController.SetOffsets(0f, 0f);
			}
			MembersScrollController.ScrollArea.size = size;
			MembersScrollController.SetContentSize(JLKONGJKGKJ);
		}

		public override void Activate()
		{
			DFIKDMCPFFA = true;
			base.Activate();
			MembersScrollController.ScrollToTop();
			if (!(CurrentSocialHelper == null))
			{
				DKBEJLGEAOA dKBEJLGEAOA = CurrentSocialHelper.CurrentSession.COPDAKACHFM;
				if (dKBEJLGEAOA != null && dKBEJLGEAOA.PDHFJLNGDOL != 0 && dKBEJLGEAOA.PDHFJLNGDOL != Time.frameCount)
				{
					UpdateTeamMembers();
				}
			}
		}

		public override void Deactivate()
		{
			DFIKDMCPFFA = false;
			if (ActiveKickButton != null && ActiveKickButton.IsActive())
			{
				ActiveKickButton.Hide();
			}
			base.Deactivate();
		}

		public void UpdateTeamMembers()
		{
			if (CurrentSocialHelper == null)
			{
				return;
			}
			DKBEJLGEAOA dKBEJLGEAOA = CurrentSocialHelper.CurrentSession.COPDAKACHFM;
			List<BMHDDEMBAEM> list = new List<BMHDDEMBAEM>();
			if (dKBEJLGEAOA == null)
			{
				return;
			}
			List<AKGIJAMHMNA> source = new List<AKGIJAMHMNA>(dKBEJLGEAOA.HOINIMJNGFK.Values);
			IOrderedEnumerable<AKGIJAMHMNA> orderedEnumerable = from IBBBMACIBGK in source
				orderby IBBBMACIBGK.CALJBGILMOL + IBBBMACIBGK.GGBEMNJNAEE descending, IBBBMACIBGK.CALJBGILMOL descending, IBBBMACIBGK.GGBEMNJNAEE descending, IBBBMACIBGK.KEMNAAPNAPA descending, IBBBMACIBGK.KFBCFDALGBB descending
				select IBBBMACIBGK;
			bool flag = CurrentSocialHelper.CurrentSession.COPDAKACHFM.AFPDGDAEENM == LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM;
			long eEFMIHDPJPG = CurrentSocialHelper.CurrentSession.ADCMNJCINBO.EEFMIHDPJPG;
			int num = 0;
			foreach (AKGIJAMHMNA item in orderedEnumerable)
			{
				bool flag2 = dKBEJLGEAOA.AFPDGDAEENM == item.EEFMIHDPJPG;
				BMHDDEMBAEM bMHDDEMBAEM = new BMHDDEMBAEM();
				bMHDDEMBAEM.OGHDEOIFKFP = !flag2 && flag;
				bMHDDEMBAEM.IPCAELIMIBN = CurrentSocialHelper;
				bMHDDEMBAEM.OFBCGOMNPFA = this;
				bMHDDEMBAEM.KFBCFDALGBB = (int)item.KFBCFDALGBB;
				bMHDDEMBAEM.KEMNAAPNAPA = (int)item.KEMNAAPNAPA;
				bMHDDEMBAEM.MNPEKJAAFHD = false;
				bMHDDEMBAEM.AILNPFFLELI = flag2;
				bMHDDEMBAEM.EALJKKBHDHK = item.EALJKKBHDHK;
				bMHDDEMBAEM.CALJBGILMOL = (int)item.CALJBGILMOL;
				bMHDDEMBAEM.KCAHGIBBHKJ = num + 1;
				bMHDDEMBAEM.GDMECFECCOM = (int)item.EEFMIHDPJPG;
				bMHDDEMBAEM.GGBEMNJNAEE = item.GGBEMNJNAEE;
				BMHDDEMBAEM bMHDDEMBAEM2 = bMHDDEMBAEM;
				if (eEFMIHDPJPG.Equals(item.EEFMIHDPJPG))
				{
					bMHDDEMBAEM2.MNPEKJAAFHD = true;
					CurrentSocialHelper.CurrentSession.ADCMNJCINBO.GGBEMNJNAEE = item.GGBEMNJNAEE;
					int num2 = OIAJPMNJGLK.HOGCELOOGEP();
					if (num2 > bMHDDEMBAEM2.KEMNAAPNAPA)
					{
						bMHDDEMBAEM2.KFBCFDALGBB = 0;
					}
				}
				list.Add(bMHDDEMBAEM2);
				num++;
			}
			CGCCKDELCAH();
			JLKONGJKGKJ = (float)num * 1.65f + 1f;
			JKANNLPGLPJ.BBOMMEKKAEB(list);
			MembersScrollController.SetContentSize(JLKONGJKGKJ);
			MembersScrollController.ScrollToTop();
		}

		private void CGCCKDELCAH()
		{
			if (JKANNLPGLPJ == null)
			{
				JKANNLPGLPJ = new global::FHOJBJMMNOD<BMHDDEMBAEM, FriendEntry>(MembersScrollController, FriendEntryPrefab.GetComponent<FriendEntry>(), 15);
				JKANNLPGLPJ.FEHBHKPHBFC(15, 1.65f, 1f);
				MembersScrollController.Init();
			}
		}

		public void ShowTeamInfo()
		{
			TeamInfoDialog component = FHAAAFAAMDO.GABGKBAKHDP.EOBDANKMCBK(DialogLibrary.GABGKBAKHDP.SocialTeamInfoDialog, false).GetComponent<TeamInfoDialog>();
			component.Prepare(CurrentSocialHelper.CurrentSession.COPDAKACHFM, CurrentSocialHelper);
		}

		public void UpdateIfActive()
		{
			if (DFIKDMCPFFA)
			{
				UpdateTeamMembers();
			}
		}

		[CompilerGenerated]
		private static long FIPDLBNGNOG(AKGIJAMHMNA IBBBMACIBGK)
		{
			return IBBBMACIBGK.CALJBGILMOL + IBBBMACIBGK.GGBEMNJNAEE;
		}

		[CompilerGenerated]
		private static long LIEIFGBMNLO(AKGIJAMHMNA IBBBMACIBGK)
		{
			return IBBBMACIBGK.CALJBGILMOL;
		}

		[CompilerGenerated]
		private static int LNECEDIFKDF(AKGIJAMHMNA IBBBMACIBGK)
		{
			return IBBBMACIBGK.GGBEMNJNAEE;
		}

		[CompilerGenerated]
		private static long MPBAAPMLLEK(AKGIJAMHMNA IBBBMACIBGK)
		{
			return IBBBMACIBGK.KEMNAAPNAPA;
		}

		[CompilerGenerated]
		private static long BOECALPNKGE(AKGIJAMHMNA IBBBMACIBGK)
		{
			return IBBBMACIBGK.KFBCFDALGBB;
		}
	}
}
