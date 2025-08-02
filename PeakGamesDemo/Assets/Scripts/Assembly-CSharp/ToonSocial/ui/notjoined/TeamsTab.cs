using System.Collections.Generic;
using Assets.Scripts.MapScene;
using NewMapScene;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;

namespace ToonSocial.ui.notjoined
{
	public class TeamsTab : TabPage
	{
		public GameObject TeamEntryReference;

		public VerticalScrollController TeamsScrollController;

		public SocialHelper CurrentSocialHelper;

		public SpriteRenderer TabBackground;

		private global::FHOJBJMMNOD<FKPMKEKODPC, TeamEntry> KBLCJMBCPNG;

		private bool DFIKDMCPFFA;

		public void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!APMMLLCMAKI && DFIKDMCPFFA)
			{
				Activate();
			}
		}

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
			Vector2 size = TeamsScrollController.ScrollArea.size;
			size.x = HHHMOGOKFHF;
			float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
			if (centerPanelExtend > 0f)
			{
				size.y = 10.95f + centerPanelExtend;
				TeamsScrollController.ScrollArea.offset = new Vector2(0f, (0f - centerPanelExtend) * 0.5f);
				TeamsScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
			}
			else
			{
				TeamsScrollController.SetOffsets(0f, 0f);
			}
			TeamsScrollController.ScrollArea.size = size;
			TabBackground.size = new Vector3(HHHMOGOKFHF, 1.8f);
		}

		public override void Activate()
		{
			base.Activate();
			DFIKDMCPFFA = true;
			if (CurrentSocialHelper != null)
			{
				CurrentSocialHelper.FetchSuggestedTeams();
				TeamsScrollController.ScrollToTop();
			}
		}

		public override void Deactivate()
		{
			base.Deactivate();
			DFIKDMCPFFA = false;
			StopAllCoroutines();
		}

		public void CreateEntries(List<BGMENKMNLCH> FOBMKHBPFMG)
		{
			int num = ((FOBMKHBPFMG != null) ? FOBMKHBPFMG.Count : 0);
			List<FKPMKEKODPC> list = new List<FKPMKEKODPC>();
			for (int i = 0; i < FOBMKHBPFMG.Count; i++)
			{
				list.Add(new FKPMKEKODPC(FOBMKHBPFMG[i], CurrentSocialHelper, 0));
			}
			CGCCKDELCAH();
			KBLCJMBCPNG.BBOMMEKKAEB(list);
			TeamsScrollController.SetContentSize((float)num * 2f);
			TeamsScrollController.ScrollToTop();
		}

		private void CGCCKDELCAH()
		{
			if (KBLCJMBCPNG == null)
			{
				TeamsScrollController.Init();
				KBLCJMBCPNG = new global::FHOJBJMMNOD<FKPMKEKODPC, TeamEntry>(TeamsScrollController, TeamEntryReference.GetComponent<TeamEntry>(), 15);
				KBLCJMBCPNG.FEHBHKPHBFC(10, 2f, 1f);
			}
		}
	}
}
