using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using Assets.Scripts.MapScene;
using DG.Tweening;
using NewMapScene;
using TMPro;
using ToonSocial.ui.joined;
using Ui.VerticalScroll;
using UnityEngine;

namespace ToonSocial.ui.notjoined
{
	public class SearchTeamTab : TabPage
	{
		public GameObject TeamEntryReference;

		public TMP_InputField SearchTextInputField;

		public TextMeshProUGUI SearchTextPlaceHolder;

		public TextMeshPro NoResultsWarning;

		public EventBasedSpriteButton SearchTeamButton;

		public SpriteRenderer SearchTeamBackL;

		public SpriteRenderer SearchTeamBackR;

		public OptimisedVerticalScrollController SearchResultsScrollController;

		public SocialHelper CurrentSocialHelper;

		public SpriteRenderer TabBackground;

		private const int ADPDCLEBFLI = 15;

		private Tweener HNLFEEHKHOB;

		private bool DFIKDMCPFFA;

		private Dictionary<long, TeamEntry> NGLNCAJBPGD = new Dictionary<long, TeamEntry>();

		public bool AJEGGLPFLEO
		{
			get
			{
				return DFIKDMCPFFA;
			}
		}

		public void Awake()
		{
			SearchResultsScrollController.Init();
			SearchTextPlaceHolder.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("TeamName");
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
			Vector2 size = SearchResultsScrollController.ScrollArea.size;
			size.x = HHHMOGOKFHF;
			TabBackground.size = new Vector3(HHHMOGOKFHF, 2.37f);
			float centerPanelExtend = MapManager.Instance.CurrentMapPageSizer.CenterPanelExtend;
			if (centerPanelExtend > 0f)
			{
				size.y = 10.74f + centerPanelExtend;
				SearchResultsScrollController.SetOffsets((0f - centerPanelExtend) * 0.5f, (0f - centerPanelExtend) * 0.5f);
				SearchResultsScrollController.ScrollArea.offset = new Vector2(0f, (0f - centerPanelExtend) * 0.5f);
			}
			else
			{
				SearchResultsScrollController.SetOffsets(0f, 0f);
			}
			SearchResultsScrollController.ScrollArea.size = size;
		}

		public override void Activate()
		{
			base.Activate();
			DFIKDMCPFFA = true;
			SearchResultsScrollController.ScrollToTop();
		}

		public override void Deactivate()
		{
			base.Deactivate();
			DFIKDMCPFFA = false;
		}

		public void Update()
		{
			PEJEHGMLKCC(SearchTextInputField, SearchTextPlaceHolder);
			if (FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN && SearchTextInputField.enabled)
			{
				SearchTextInputField.enabled = false;
			}
			else if (!FHAAAFAAMDO.GABGKBAKHDP.COCNAAGPOMN && !SearchTextInputField.enabled)
			{
				SearchTextInputField.enabled = true;
			}
		}

		public void ClearText()
		{
			if (HNLFEEHKHOB != null)
			{
				HNLFEEHKHOB.Kill(true);
			}
			if (NoResultsWarning.gameObject.activeSelf)
			{
				NoResultsWarning.gameObject.SetActive(false);
			}
			SearchTextInputField.FCJBBPHFNPJ = string.Empty;
			OnValueChanged();
			SearchResultsScrollController.Init();
			float num = ONCMBJKLKIL.FHAMOHDEGMK * 0.5f;
			SearchResultsScrollController.SetPoolDimensions(num, 0f - num);
			SearchResultsScrollController.RemoveAllItems();
			SearchResultsScrollController.SetContentSize(0f);
			SearchResultsScrollController.ScrollToTop();
		}

		public void OnValueChanged()
		{
			SearchTextInputField.FCJBBPHFNPJ = NFBBGJONNED(SearchTextInputField.FCJBBPHFNPJ);
			Update();
		}

		private string NFBBGJONNED(string IBBBMACIBGK)
		{
			int length = IBBBMACIBGK.Length;
			IBBBMACIBGK = HFFNPEPPBCC.OJHJEGCAPLF(IBBBMACIBGK);
			if (length != IBBBMACIBGK.Length)
			{
				MapManager.Instance.ShowErrorMessageAtPosition(NKILHODNBDE.GHBGCADFLFB("CharacterNotSupported"), Vector3.up * 1.12f);
			}
			IBBBMACIBGK = IBBBMACIBGK.TrimStart();
			if (IBBBMACIBGK.Length > 15)
			{
				IBBBMACIBGK = IBBBMACIBGK.Substring(0, 15);
			}
			return IBBBMACIBGK;
		}

		public void EnableSendButton(bool IDEOALCKAEJ)
		{
			if (!(SearchTeamButton == null) && SearchTeamButton.CanBeClicked != IDEOALCKAEJ)
			{
				SearchTeamButton.CanBeClicked = IDEOALCKAEJ;
				Color color = ((!IDEOALCKAEJ) ? new Color(0.654902f, 0.654902f, 0.654902f, 40f / 51f) : new Color(1f, 1f, 1f, 1f));
				SearchTeamBackL.color = color;
				SearchTeamBackR.color = color;
			}
		}

		public void Search()
		{
			if (HNLFEEHKHOB != null)
			{
				HNLFEEHKHOB.Kill(true);
			}
			if (NoResultsWarning.gameObject.activeSelf)
			{
				NoResultsWarning.gameObject.SetActive(false);
			}
			string text = HFFNPEPPBCC.OJHJEGCAPLF(SearchTextInputField.FCJBBPHFNPJ);
			SearchTextInputField.FCJBBPHFNPJ = text.TrimStart();
			if (SearchTextInputField.FCJBBPHFNPJ.Length < 3)
			{
				MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_ThreeCharacters"));
			}
			else if (AJEGGLPFLEO)
			{
				CurrentSocialHelper.RequestSearchTeams(SearchTextInputField.FCJBBPHFNPJ);
				EnableSendButton(false);
			}
		}

		private static void PEJEHGMLKCC(TMP_InputField FEJFOKCKKAL, TextMeshProUGUI KNNMGOHIFIG)
		{
			if (FEJFOKCKKAL.MKAKFOEBMDF && KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = false;
			}
			else if (!FEJFOKCKKAL.MKAKFOEBMDF && FEJFOKCKKAL.FCJBBPHFNPJ == string.Empty && !KNNMGOHIFIG.enabled)
			{
				KNNMGOHIFIG.enabled = true;
			}
		}

		public void CreateEntries(List<BGMENKMNLCH> FOBMKHBPFMG)
		{
			EnableSendButton(true);
			NGLNCAJBPGD.Clear();
			SearchResultsScrollController.RemoveAllItems();
			int num = ((FOBMKHBPFMG != null) ? FOBMKHBPFMG.Count : 0);
			GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.SearchTeamAction, "Search result count is: {0}", num);
			for (int i = 0; i < num; i++)
			{
				GameObject gameObject = SearchResultsScrollController.AddPrefab(new Vector3(0f, (float)(-i) * 2.07f - 1f, 0f), TeamEntryReference);
				TeamEntry component = gameObject.GetComponent<TeamEntry>();
				BGMENKMNLCH iBGOMPLHAFP = FOBMKHBPFMG[i];
				NGLNCAJBPGD[component.OADDPGNIINO] = component;
				component.Prepare(iBGOMPLHAFP, CurrentSocialHelper, 1);
			}
			SearchResultsScrollController.SetContentSize((float)num * 2.07f);
			SearchResultsScrollController.ScrollToTop();
			if (num == 0)
			{
				if (HNLFEEHKHOB != null)
				{
					HNLFEEHKHOB.Kill(true);
				}
				NoResultsWarning.gameObject.SetActive(true);
				Color color = NoResultsWarning.color;
				color.a = 0f;
				NoResultsWarning.color = color;
				HNLFEEHKHOB = NoResultsWarning.DOFade(1f, 0.8f);
				HNLFEEHKHOB.OnComplete(delegate
				{
					HNLFEEHKHOB = null;
				});
			}
		}

		public void OnResultsFetched(bool DIDHNNMKJFE, List<BGMENKMNLCH> JDNJGOOBGAJ, NKILAONHNNE LMNJEENFOGB)
		{
			if (DIDHNNMKJFE)
			{
				CreateEntries(JDNJGOOBGAJ);
			}
		}

		public void ShowError()
		{
			EnableSendButton(true);
			MapManager.Instance.ShowErrorMessage(NKILHODNBDE.GHBGCADFLFB("Error_TryAgain"));
		}

		public void InformReject(long EMNOJOHFMEH)
		{
			TeamEntry value;
			if (NGLNCAJBPGD.TryGetValue(EMNOJOHFMEH, out value))
			{
				value.UpdateButtonStyle();
			}
		}

		[CompilerGenerated]
		private void OCCKPIAACCD()
		{
			HNLFEEHKHOB = null;
		}
	}
}
