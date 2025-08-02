using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Dialogs;
using Assets.Scripts.MapScene;
using DG.Tweening;
using NewMapScene;
using TMPro;
using UnityEngine;

namespace ToonSocial.ui.joined
{
	public class ChatTab : TabPage
	{
		[CompilerGenerated]
		private sealed class NFIAKFPKKJC
		{
			internal EKPAJFBBAJC NOBNPDKGOLD;

			internal bool AGFNGEFDHLA(EKPAJFBBAJC AMFCENFNAJJ)
			{
				return AMFCENFNAJJ.EEFMIHDPJPG == NOBNPDKGOLD.OPKJNOHCIHC;
			}
		}

		[CompilerGenerated]
		private sealed class LPHKGGOFPBE
		{
			internal EKPAJFBBAJC NOBNPDKGOLD;

			internal bool AGFNGEFDHLA(EKPAJFBBAJC AMFCENFNAJJ)
			{
				return AMFCENFNAJJ.EEFMIHDPJPG == NOBNPDKGOLD.OPKJNOHCIHC;
			}

			internal bool KDACLOKGNAM(EKPAJFBBAJC AMFCENFNAJJ)
			{
				return AMFCENFNAJJ.EEFMIHDPJPG == NOBNPDKGOLD.EEFMIHDPJPG;
			}
		}

		public GameObject OtherFriendBubblePrefab;

		public GameObject MineBubblePrefab;

		public GameObject LifeRequestPrefab;

		public GameObject ChatSystemMessagePrefab;

		public GameObject RequestToJoinPrefab;

		public GameObject LeftTeamPrefab;

		public GameObject JoinedTeamPrefab;

		public GameObject UserIsKickedPrefab;

		public ChatScrollController CurrentScrollController;

		public SocialHelper CurrentSocialHelper;

		public GameObject AskLifeActiveButton;

		public GameObject AskLifePassiveButton;

		public GameObject NoticeMark;

		public TextMeshPro AskLifeTimeLeftText;

		public Transform ClockHand;

		public SpriteRenderer TeamBadge;

		public AskLifeNotificationIcon CurrentAskLifeNotificationIcon;

		public ChatHelpNotificationIcon CurrentChatHelpNotificationIcon;

		public SpriteRenderer TabBackground;

		public TouchScreenKeyboard KeyBoard;

		public Transform BottomContent;

		private bool NMIMBBIBDBH;

		private string BDCEBCLLNNG;

		private string OPLJPFGEOLI = "BadWordWarning";

		private string NKMDDPHIJJC = "ChatDisabledInfoMessage";

		private List<EKPAJFBBAJC> FAEDKBGMLJM = new List<EKPAJFBBAJC>();

		private readonly Dictionary<long, RequestToJoinEntry> HBEEKNCAFJO = new Dictionary<long, RequestToJoinEntry>();

		private readonly Dictionary<string, ChatEntry> KPENHELEJGI = new Dictionary<string, ChatEntry>();

		private readonly Dictionary<long, ChatEntry> AKBGNOPIMEC = new Dictionary<long, ChatEntry>();

		private readonly Dictionary<long, PONCCEHNOOM> HBMBJJBFLOJ = new Dictionary<long, PONCCEHNOOM>();

		private LLCJMMBBLEH COLJLBIFNGN;

		private int CGKJDFPADMD;

		public override void Prepare()
		{
			CurrentScrollController.Init();
			CurrentScrollController.SetOffsets(0f, 0f);
			OtherFriendBubblePrefab.FLFDKMOOIFL(10);
			MineBubblePrefab.FLFDKMOOIFL(10);
			LifeRequestPrefab.FLFDKMOOIFL(10);
			ChatSystemMessagePrefab.FLFDKMOOIFL(5);
			RequestToJoinPrefab.FLFDKMOOIFL(5);
			LeftTeamPrefab.FLFDKMOOIFL(3);
			JoinedTeamPrefab.FLFDKMOOIFL(3);
			UserIsKickedPrefab.FLFDKMOOIFL(3);
			UpdateSocialNoticeMark();
		}

		private void AOJNCIHALBD(float HHHMOGOKFHF)
		{
			Vector2 size = CurrentScrollController.TouchArea.size;
			size.x = HHHMOGOKFHF;
			float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
			if (centerPanelExtend > 0f)
			{
				Vector3 localPosition = BottomContent.localPosition;
				localPosition.y -= centerPanelExtend;
				BottomContent.localPosition = localPosition;
				Vector2 size2 = CurrentScrollController.ScrollArea.size;
				CurrentScrollController.ScrollArea.size = new Vector2(size2.x, 9.57f + centerPanelExtend);
				size.y = 11.59f + centerPanelExtend;
				CurrentScrollController.TouchArea.offset = new Vector2(0f, -0.78f - centerPanelExtend * 0.5f);
				CurrentScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
			}
			CurrentScrollController.TouchArea.size = size;
			TabBackground.size = new Vector3(HHHMOGOKFHF, 1.8f);
			if (ONCMBJKLKIL.KLEKJMEOPEH)
			{
				CurrentScrollController.SetVisiblePos(6.23f + centerPanelExtend, -6.7f - centerPanelExtend);
			}
			else
			{
				CurrentScrollController.SetVisiblePos(6.23f, -6.7f);
			}
			CurrentScrollController.UpdateScroll();
			CurrentScrollController.ScrollToBottom();
		}

		private void Awake()
		{
			BDCEBCLLNNG = MDGKDGMGGCL.GABGKBAKHDP.PHOCMCOHANN();
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

		private void OnApplicationPause(bool APMMLLCMAKI)
		{
			if (!APMMLLCMAKI)
			{
				CurrentSocialHelper.CurrentSession.LOMBPFAIGKF();
			}
		}

		public void OpenChatKeyboard()
		{
			if (!MDGKDGMGGCL.GABGKBAKHDP.APAAJANEIOD())
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB(NKMDDPHIJJC));
			}
			else if (KeyBoard == null)
			{
				KeyBoard = TouchScreenKeyboard.Open(string.Empty, TouchScreenKeyboardType.Default, false, false, false);
				TouchScreenKeyboard.hideInput = false;
				StartCoroutine(LBKOBAAABHD());
			}
		}

		private IEnumerator LBKOBAAABHD()
		{
			string empty = string.Empty;
			while (!KeyBoard.done)
			{
				yield return null;
			}
			empty = KeyBoard.text;
			if (KeyBoard.status != TouchScreenKeyboard.Status.Canceled && KeyBoard.status != TouchScreenKeyboard.Status.LostFocus && empty.Length > 0)
			{
				if (IBKHFKAANJP.INPPGINLBFC || IBKHFKAANJP.DGGDDILJFBJ().OJEHDCCGHNC(empty, BDCEBCLLNNG))
				{
					CurrentSocialHelper.SendChatMessage(empty);
				}
				else
				{
					KeyBoard.text = string.Empty;
					MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB(OPLJPFGEOLI));
				}
			}
			KeyBoard = null;
		}

		public void ResetMessages()
		{
			FAEDKBGMLJM.Clear();
		}

		public void AddMessage(EKPAJFBBAJC NOBNPDKGOLD, bool EDIKMPKOEGL = false, bool GCBBIKFOCFC = true)
		{
			bool flag = MDGKDGMGGCL.GABGKBAKHDP.APAAJANEIOD();
			GameObject gameObject = null;
			if (GCBBIKFOCFC)
			{
				FAEDKBGMLJM.Add(NOBNPDKGOLD);
			}
			switch (NOBNPDKGOLD.ENBPGGCIADN)
			{
			case ABAPNBACABK.HelpAsked:
				gameObject = LifeRequestPrefab;
				break;
			case ABAPNBACABK.HelpedToUser:
			{
				ChatEntry value;
				if (KPENHELEJGI.TryGetValue(NOBNPDKGOLD.OPKJNOHCIHC, out value))
				{
					((HelpEntry)value).UpdateHelp(NOBNPDKGOLD, CurrentSocialHelper);
					try
					{
						EKPAJFBBAJC eKPAJFBBAJC = FAEDKBGMLJM.Find((EKPAJFBBAJC AMFCENFNAJJ) => AMFCENFNAJJ.EEFMIHDPJPG == NOBNPDKGOLD.OPKJNOHCIHC);
						eKPAJFBBAJC.DLDMKKEICMA = NOBNPDKGOLD.DLDMKKEICMA;
					}
					catch (Exception)
					{
					}
					FAEDKBGMLJM.Remove(NOBNPDKGOLD);
					UpdateHelpNotification();
					return;
				}
				gameObject = LifeRequestPrefab;
				break;
			}
			case ABAPNBACABK.UserMessage:
				if (flag)
				{
					gameObject = ((NOBNPDKGOLD.OCHADBCJEDP != LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM) ? OtherFriendBubblePrefab : MineBubblePrefab);
				}
				break;
			case ABAPNBACABK.Disconnected:
			case ABAPNBACABK.Connected:
				return;
			case ABAPNBACABK.LeftRoom:
				PJPDNILAFKB(NOBNPDKGOLD);
				gameObject = LeftTeamPrefab;
				break;
			case ABAPNBACABK.UserIsKicked:
				PJPDNILAFKB(NOBNPDKGOLD);
				gameObject = UserIsKickedPrefab;
				break;
			case ABAPNBACABK.JoinRoom:
			case ABAPNBACABK.AcceptedToTeam:
				gameObject = JoinedTeamPrefab;
				break;
			default:
				if (flag)
				{
					gameObject = ChatSystemMessagePrefab;
				}
				break;
			}
			if (NOBNPDKGOLD.ENBPGGCIADN == ABAPNBACABK.UserMessage)
			{
				string hKCNCCIAMEL = NOBNPDKGOLD.HKCNCCIAMEL;
				if (hKCNCCIAMEL != null && hKCNCCIAMEL.Length > 512)
				{
					NOBNPDKGOLD.HKCNCCIAMEL = hKCNCCIAMEL.Substring(0, 512);
				}
			}
			if (gameObject == null)
			{
				return;
			}
			ChatEntry component = gameObject.JOBDHIPIMAG().GetComponent<ChatEntry>();
			component.Prepare(NOBNPDKGOLD, CurrentSocialHelper);
			if (NOBNPDKGOLD.ENBPGGCIADN == ABAPNBACABK.HelpAsked)
			{
				KPENHELEJGI[NOBNPDKGOLD.EEFMIHDPJPG] = component;
			}
			if (NOBNPDKGOLD.ENBPGGCIADN == ABAPNBACABK.HelpAsked || NOBNPDKGOLD.ENBPGGCIADN == ABAPNBACABK.HelpedToUser)
			{
				((HelpEntry)component).LifeRequest = NOBNPDKGOLD.DLDMKKEICMA;
				ChatEntry value2;
				if (AKBGNOPIMEC.TryGetValue(NOBNPDKGOLD.DLDMKKEICMA.OCHADBCJEDP, out value2))
				{
					long num = NOBNPDKGOLD.DLDMKKEICMA.OEDKBPGDOAP();
					long num2 = ((HelpEntry)value2).LifeRequest.OEDKBPGDOAP();
					if (num >= num2)
					{
						if (value2.CurrentChatMessage != null)
						{
							FAEDKBGMLJM.Remove(value2.CurrentChatMessage);
						}
						CurrentScrollController.RemoveContent(value2);
					}
				}
				AKBGNOPIMEC[NOBNPDKGOLD.DLDMKKEICMA.OCHADBCJEDP] = component;
				UpdateHelpNotification();
			}
			CurrentScrollController.AddContent(component, EDIKMPKOEGL);
			if (NOBNPDKGOLD.OCHADBCJEDP == LECPGNKOABP.GABGKBAKHDP.GDMECFECCOM)
			{
				ScrollToBottom();
			}
		}

		public void RemoveEntry(ChatEntry GBKPDDDJOFO, EKPAJFBBAJC NOBNPDKGOLD)
		{
			if (!string.IsNullOrEmpty(NOBNPDKGOLD.OPKJNOHCIHC))
			{
				FAEDKBGMLJM.RemoveAll((EKPAJFBBAJC AMFCENFNAJJ) => AMFCENFNAJJ.EEFMIHDPJPG == NOBNPDKGOLD.OPKJNOHCIHC);
			}
			else
			{
				FAEDKBGMLJM.RemoveAll((EKPAJFBBAJC AMFCENFNAJJ) => AMFCENFNAJJ.EEFMIHDPJPG == NOBNPDKGOLD.EEFMIHDPJPG);
			}
			CurrentScrollController.RemoveContent(GBKPDDDJOFO);
		}

		public void RefreshChatMessages()
		{
			if (FAEDKBGMLJM.Count == 0)
			{
				return;
			}
			ClearAll(false);
			for (int i = 0; i < FAEDKBGMLJM.Count; i++)
			{
				EKPAJFBBAJC eKPAJFBBAJC = FAEDKBGMLJM[i];
				if (eKPAJFBBAJC != null)
				{
					AddMessage(eKPAJFBBAJC, true, false);
				}
			}
			foreach (KeyValuePair<long, PONCCEHNOOM> item in HBMBJJBFLOJ)
			{
				AddJoinRequest(item.Value, false);
			}
			CurrentScrollController.ScrollToBottom();
		}

		public List<string> GetSameMessages(EKPAJFBBAJC NOBNPDKGOLD)
		{
			List<string> list = new List<string>();
			list.Add(NOBNPDKGOLD.EEFMIHDPJPG);
			List<string> list2 = list;
			string hKCNCCIAMEL = NOBNPDKGOLD.HKCNCCIAMEL;
			int i = 0;
			for (int count = FAEDKBGMLJM.Count; i < count; i++)
			{
				string hKCNCCIAMEL2 = FAEDKBGMLJM[i].HKCNCCIAMEL;
				if (hKCNCCIAMEL2 != null && hKCNCCIAMEL2.Equals(hKCNCCIAMEL) && FAEDKBGMLJM[i].OCHADBCJEDP == NOBNPDKGOLD.OCHADBCJEDP)
				{
					list2.Add(FAEDKBGMLJM[i].EEFMIHDPJPG);
				}
			}
			return list2;
		}

		public void ScrollToBottom()
		{
			CurrentScrollController.ScrollToBottom();
		}

		public void AddJoinRequest(PONCCEHNOOM FCCCBKMDAOM, bool DHGDDCECLND = true)
		{
			if (HBEEKNCAFJO.ContainsKey(FCCCBKMDAOM.EEFMIHDPJPG))
			{
				GBFAPADEBEC.LCNJJMBLOHE(PBIIDJOKNEK.ChatTab, "Two join request should not exists from same user!");
				return;
			}
			RequestToJoinEntry component = UnityEngine.Object.Instantiate(RequestToJoinPrefab).GetComponent<RequestToJoinEntry>();
			component.Prepare(null, CurrentSocialHelper);
			component.Sender.FCJBBPHFNPJ = FCCCBKMDAOM.EALJKKBHDHK;
			component.FromUserId = FCCCBKMDAOM.EEFMIHDPJPG;
			HBEEKNCAFJO.Add(FCCCBKMDAOM.EEFMIHDPJPG, component);
			if (!HBMBJJBFLOJ.ContainsKey(FCCCBKMDAOM.EEFMIHDPJPG))
			{
				HBMBJJBFLOJ.Add(FCCCBKMDAOM.EEFMIHDPJPG, FCCCBKMDAOM);
			}
			CurrentScrollController.AddContent(component, !DHGDDCECLND);
		}

		public void RemoveRequest(long FOJFJJANLJN)
		{
			RequestToJoinEntry value;
			if (HBEEKNCAFJO.TryGetValue(FOJFJJANLJN, out value) && !(value == null))
			{
				HBEEKNCAFJO.Remove(FOJFJJANLJN);
				if (HBMBJJBFLOJ.ContainsKey(FOJFJJANLJN))
				{
					HBMBJJBFLOJ.Remove(FOJFJJANLJN);
				}
				CurrentScrollController.RemoveContent(value);
			}
		}

		private void PJPDNILAFKB(EKPAJFBBAJC NOBNPDKGOLD)
		{
			ChatEntry value;
			if (AKBGNOPIMEC.TryGetValue(NOBNPDKGOLD.AENEHCAFNMP.EEFMIHDPJPG, out value))
			{
				if (FAEDKBGMLJM.Contains(NOBNPDKGOLD))
				{
					FAEDKBGMLJM.Remove(NOBNPDKGOLD);
				}
				CurrentScrollController.RemoveContent(value);
			}
			UpdateHelpNotification();
		}

		public void AddJoinRequests(List<PONCCEHNOOM> MIPIMDLEMDN)
		{
			if (MIPIMDLEMDN != null)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChatTab, " Requests waiting: {0}", MIPIMDLEMDN.Count);
				for (int i = 0; i < MIPIMDLEMDN.Count; i++)
				{
					PONCCEHNOOM fCCCBKMDAOM = MIPIMDLEMDN[i];
					AddJoinRequest(fCCCBKMDAOM);
				}
			}
		}

		public void ClearAll(bool NBLODELPGHL = true)
		{
			if (NBLODELPGHL)
			{
				ResetMessages();
				HBMBJJBFLOJ.Clear();
			}
			KPENHELEJGI.Clear();
			AKBGNOPIMEC.Clear();
			HBEEKNCAFJO.Clear();
			CurrentScrollController.RemoveAllItems();
			UpdateHelpNotification();
		}

		public override void Deactivate()
		{
			base.Deactivate();
			if (KeyBoard != null)
			{
				KeyBoard.active = false;
				KeyBoard = null;
			}
			StopAllCoroutines();
		}

		public override void Activate()
		{
			base.Activate();
			CurrentScrollController.ScrollToBottom();
		}

		public void AskForLife()
		{
			int num = CAGBGIHKHEJ.GABGKBAKHDP.ELEKFHDLKJJ();
			if (num == 10)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("InformInboxMaxLimit"));
				return;
			}
			if (num > 10)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("InformInboxMoreThanMaxLimit"));
				return;
			}
			AskLifeActiveButton.SetActive(false);
			AskLifePassiveButton.SetActive(true);
			AskLifeTimeLeftText.FCJBBPHFNPJ = string.Empty;
			long num2 = FIBJIOBINHL.CFBJBKEPGAN();
			long num3 = num2 * 1000;
			SetAskLifeTime(num3, num3 + 14400000);
			GFHPEDILAJG.GABGKBAKHDP.DAPBGBIBHPD(num2 + 14400);
			CurrentAskLifeNotificationIcon.UpdateCount(0);
			CurrentSocialHelper.CurrentSession.NMGBGAGMOGI.LKPMIAFIDJP();
		}

		public void UpdateHelpNotification()
		{
			if (CurrentSocialHelper.CurrentSession == null || !CurrentSocialHelper.CurrentSession.PLNDKBKHDHA || !CurrentSocialHelper.CurrentSession.NNEADDLACCA || CurrentSocialHelper.CurrentSession.ADCMNJCINBO == null || CurrentSocialHelper.CurrentSession.COPDAKACHFM == null)
			{
				CurrentChatHelpNotificationIcon.UpdateCount(0);
				CurrentChatHelpNotificationIcon.Hide();
				return;
			}
			int num = 0;
			foreach (KeyValuePair<long, ChatEntry> item in AKBGNOPIMEC)
			{
				if (!(item.Value == null) && item.Value is HelpEntry)
				{
					HelpEntry helpEntry = (HelpEntry)item.Value;
					if (helpEntry.PCPIBNDIHMA)
					{
						num++;
					}
				}
			}
			CurrentChatHelpNotificationIcon.UpdateCount(num);
			if (CGKJDFPADMD > 0 && num > 0)
			{
				CurrentChatHelpNotificationIcon.Show();
			}
			else
			{
				CurrentChatHelpNotificationIcon.Hide();
			}
		}

		public IEnumerator UpdateTimeLeft()
		{
			while (true)
			{
				yield return MCJHHDACJBG.KNLADMIBAAD;
				CGKJDFPADMD--;
				if (CGKJDFPADMD <= 0)
				{
					break;
				}
				string text = GJEIMLMEHIN.JDIMBPFKOBB(CGKJDFPADMD);
				AskLifeTimeLeftText.FCJBBPHFNPJ = text;
				ClockHand.DORotate(new Vector3(0f, 0f, (float)(CGKJDFPADMD % 4) * 90f), 0.2f).SetEase(Ease.OutBack);
			}
			AskLifeActiveButton.SetActive(true);
			AskLifePassiveButton.SetActive(false);
			CurrentAskLifeNotificationIcon.UpdateCount(1);
			CurrentChatHelpNotificationIcon.Hide();
		}

		public void SetAskLifeTime(long CPFBGPBEDAI, long NOEOHGEEDBA)
		{
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChatTab, "Set Ask Life Time: ServerTime:{0} EndTime:{1}", CPFBGPBEDAI, NOEOHGEEDBA);
			if (COLJLBIFNGN != null)
			{
				COLJLBIFNGN.BPPFBMCJOAH();
			}
			long num = (NOEOHGEEDBA - CPFBGPBEDAI) / 1000;
			if (num > 0)
			{
				CGKJDFPADMD = (int)num;
				string text = GJEIMLMEHIN.JDIMBPFKOBB(CGKJDFPADMD);
				AskLifeTimeLeftText.FCJBBPHFNPJ = text;
				AskLifeActiveButton.SetActive(false);
				AskLifePassiveButton.SetActive(true);
				COLJLBIFNGN = new LLCJMMBBLEH(UpdateTimeLeft());
				CurrentAskLifeNotificationIcon.UpdateCount(0);
				UpdateHelpNotification();
				long num2 = DateTime.Now.GMEBBNOHJFJ() + CGKJDFPADMD;
				GFHPEDILAJG.GABGKBAKHDP.DAPBGBIBHPD((int)num2);
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.ChatTab, "Set AskLife End Time:{0} seconds from now.", CGKJDFPADMD);
			}
			else
			{
				AskLifeActiveButton.SetActive(true);
				AskLifePassiveButton.SetActive(false);
				CurrentAskLifeNotificationIcon.UpdateCount(1);
				CurrentChatHelpNotificationIcon.Hide();
			}
		}

		public void ShowAskLifeWaitWarning()
		{
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_Wait"));
		}

		public void UpdateSocialNoticeMark()
		{
			bool shouldShowSocialNoticeMark = SocialHelper.CIAKNBCNMBM;
			if (NoticeMark.activeSelf != shouldShowSocialNoticeMark)
			{
				NoticeMark.SetActive(shouldShowSocialNoticeMark);
			}
		}
	}
}
