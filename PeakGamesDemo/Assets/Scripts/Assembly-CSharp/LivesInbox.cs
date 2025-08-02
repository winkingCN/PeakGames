using System.Collections.Generic;
using Assets.Scripts.MapScene;
using DAO.Entity;
using NewMapScene;
using ToonSocial;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;

public class LivesInbox : MonoBehaviour
{
	public GameObject LifeEntryReference;

	public VerticalScrollController LivesScrollController;

	public SocialHelper CurrentSocialHelper;

	public LivesPageController CurrentPageController;

	public GameObject NoLivesContainer;

	private global::FHOJBJMMNOD<HMBOJCADBKN, LifeEntry> JKANNLPGLPJ;

	public void Awake()
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
		HCCCLKBJHBH();
		float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
		Vector2 size = LivesScrollController.ScrollArea.size;
		size.x = HHHMOGOKFHF;
		if (centerPanelExtend > 0f)
		{
			size.y = 12.47f + centerPanelExtend;
			LivesScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
			Vector2 offset = LivesScrollController.ScrollArea.offset;
			offset.y -= centerPanelExtend * 0.5f;
			LivesScrollController.ScrollArea.offset = offset;
		}
		else
		{
			size.y = 12.47f;
			LivesScrollController.SetOffsets(0f, 0f);
		}
		LivesScrollController.ScrollArea.size = size;
		UpdateScrollContent();
	}

	public void AddSocialLife(string IOCMOCCFALN, string DLALMJPFFMK, long DIKEGACKFFH)
	{
		if (CAGBGIHKHEJ.GABGKBAKHDP.CPDDAPIICDO(IOCMOCCFALN, DLALMJPFFMK, DIKEGACKFFH))
		{
			CurrentPageController.UpdateInboxCount();
			UpdateScrollContent();
		}
	}

	public void OnAskLifeClick()
	{
		EIPCLBONPLC currentSession = CurrentSocialHelper.CurrentSession;
		if (currentSession != null && currentSession.NNEADDLACCA && currentSession.PLNDKBKHDHA)
		{
			if (currentSession.COPDAKACHFM == null)
			{
				CurrentSocialHelper.CurrentNotJoinedContainer.SelectTab(0);
			}
			else
			{
				CurrentSocialHelper.CurrentJoinedContainer.SelectTab(0);
			}
		}
		MapManager.Instance.CurrentContainerManager.SlideToPosition(1);
	}

	public void UpdateScrollContent(bool NDAILICIEEB = false)
	{
		float y = LivesScrollController.Content.transform.localPosition.y;
		List<InboxEntity> list = CAGBGIHKHEJ.GABGKBAKHDP.LGGAKAHPGFE();
		if (list == null || list.Count < 1)
		{
			if (!NoLivesContainer.activeSelf)
			{
				NoLivesContainer.SetActive(true);
			}
			LivesScrollController.DAMJJFCIHBA();
			if (JKANNLPGLPJ != null)
			{
				JKANNLPGLPJ.FPGFIAKIIID();
			}
			return;
		}
		if (NoLivesContainer.activeSelf)
		{
			NoLivesContainer.SetActive(false);
		}
		int count = list.Count;
		List<HMBOJCADBKN> list2 = new List<HMBOJCADBKN>();
		foreach (InboxEntity item in list)
		{
			list2.Add(new HMBOJCADBKN(item.From, item.AIAEHPLOFGB(), this, item.Type));
		}
		HCCCLKBJHBH();
		JKANNLPGLPJ.BBOMMEKKAEB(list2);
		LivesScrollController.SetContentSize((float)count * 2.08f + 0.2f);
		if (NDAILICIEEB)
		{
			LivesScrollController.SetLocalPos(y);
		}
		else
		{
			LivesScrollController.ScrollToTop();
		}
	}

	private void HCCCLKBJHBH()
	{
		if (JKANNLPGLPJ == null)
		{
			LivesScrollController.Init();
			JKANNLPGLPJ = new global::FHOJBJMMNOD<HMBOJCADBKN, LifeEntry>(LivesScrollController, LifeEntryReference.GetComponent<LifeEntry>(), 15);
			JKANNLPGLPJ.FEHBHKPHBFC(12, 2.08f, 1.29f);
		}
	}

	public bool CanGetLife()
	{
		return PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI < 5;
	}

	public void GetLife(int? BDKFNEDHAOJ)
	{
		if (!BDKFNEDHAOJ.HasValue)
		{
			return;
		}
		int dLDHNNCGIPI = PJPPADHKGHN.GABGKBAKHDP.PMBGCACJIHD().DLDHNNCGIPI;
		if (dLDHNNCGIPI < 5)
		{
			InboxEntity inboxEntity = CAGBGIHKHEJ.GABGKBAKHDP.IBDDFALOHOC(BDKFNEDHAOJ.Value);
			PJPPADHKGHN.GABGKBAKHDP.CJNFILFKEAC();
			PJPPADHKGHN.GABGKBAKHDP.EFFMBBAJLCF++;
			CurrentPageController.UpdateInboxCount();
			UpdateScrollContent(true);
			string dGFPCOODPCB = null;
			if (GFHPEDILAJG.GABGKBAKHDP.ODMCGBLJFKM)
			{
				dGFPCOODPCB = LECPGNKOABP.GABGKBAKHDP.OADDPGNIINO.ToString();
			}
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.Inbox, "Life used from inbox. {0}", CAGBGIHKHEJ.GABGKBAKHDP);
			AFJPGLHKOID.CPIGOAGGLBM("LifeUse", MADFPPJCOIM.GABGKBAKHDP.NAJIPFBGLLC() + 1, dLDHNNCGIPI, LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM.ToString(), dGFPCOODPCB, inboxEntity.MessageId);
		}
		if (CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ() == 0)
		{
			CurrentPageController.Show();
		}
	}
}
