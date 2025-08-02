using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.CasualTools.Dialogs;
using DG.Tweening;
using TMPro;
using UnityEngine;
using caravan.protobuf.messages;

namespace Assets.Scripts.Dialogs
{
	public class HighScoresPanel : MonoBehaviour
	{
		private List<HighscoreFriendDisplay> KOANMLPAEKI;

		private float BMGKCLNINID;

		private int EADEMDIHGHE;

		private readonly float EDEONNLKCDF = 7f;

		private float MAECNCPPIJB;

		private float FILIJBIDLFM;

		private bool APIHIJECANO;

		private bool EPJMHPHNHCL;

		private bool AFNNGCHAEIP;

		public GameObject ConnectFacebookButton;

		public GameObject FriendDisplayReference;

		private ELNHKDNIEKC[] DNGDLGNJHPA;

		public TextMeshPro LoadingText;

		public ScrollController ScrollController;

		private int HCEHJCHHNFE;

		private bool GHBCLNBAIEP;

		[HideInInspector]
		public Dialog CurrentDialog;

		private bool COFBMPPDBCM;

		private bool JCAODHCHDDF;

		private bool BIELEFAPPBF;

		[CompilerGenerated]
		private static Comparison<FriendScore> EBCOMJBLIPP;

		internal void DIOELAHNLKJ(int KIGOGMKCDKN, int NBFBPNNEKMN)
		{
			GHBCLNBAIEP = true;
			HCEHJCHHNFE = NBFBPNNEKMN;
			float num = ONCMBJKLKIL.NNOBNMCLIBC * 2f * ONCMBJKLKIL.JMICAJINDLL;
			float num2 = num / 10f;
			EADEMDIHGHE = KIGOGMKCDKN;
			BMGKCLNINID = ONCMBJKLKIL.HINDAIPFFJL.y + 0.3f * num2;
			MAECNCPPIJB = ONCMBJKLKIL.HINDAIPFFJL.y - 4f;
			if (ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL > 0f)
			{
				BMGKCLNINID += ONCMBJKLKIL.GNGIGAPBFCN.HINDAIPFFJL;
				BMGKCLNINID += ((!ONCMBJKLKIL.PEFHCKMBHOM) ? 0f : (-0.04f));
			}
			base.transform.localScale = Vector3.one * num2;
			base.transform.localPosition = new Vector3(0f, MAECNCPPIJB, 0f);
			float num3 = 1.85f * num2 * 0.5f;
			ScrollController.Init(num3, num3);
			LoadingText.enabled = false;
			KOANMLPAEKI = new List<HighscoreFriendDisplay>(10);
			RefreshHighscorePanel();
		}

		public void RefreshHighscorePanel()
		{
			if (!GHBCLNBAIEP)
			{
				return;
			}
			if (LECPGNKOABP.GABGKBAKHDP.BJLBIBDKADC())
			{
				if (!JHOAHCHHBCH.CCAJIIFJPFF())
				{
					EPJMHPHNHCL = false;
					LoadingText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("NoConnection");
					LoadingText.enabled = true;
					ConnectFacebookButton.gameObject.SetActive(false);
					ScrollController.gameObject.SetActive(false);
				}
				else if (!JCAODHCHDDF)
				{
					FILIJBIDLFM = Time.realtimeSinceStartup;
					APIHIJECANO = true;
					ConnectFacebookButton.gameObject.SetActive(false);
					ScrollController.gameObject.SetActive(true);
					JCGLFEMHECF.GABGKBAKHDP.LNFNDHKCKOP(CDKNKFBHDAE);
					COFBMPPDBCM = false;
					JCAODHCHDDF = true;
				}
			}
			else
			{
				EPJMHPHNHCL = true;
				if (!COFBMPPDBCM)
				{
					ConnectFacebookButton.gameObject.SetActive(true);
					ScrollController.gameObject.SetActive(false);
					COFBMPPDBCM = true;
					JCAODHCHDDF = false;
				}
			}
		}

		public void Update()
		{
			if (DNGDLGNJHPA != null)
			{
				int num = DNGDLGNJHPA.Length;
				if (!ScrollController.IsLocked() && num > 2)
				{
					float x = ScrollController.Content.localPosition.x;
					for (int i = 0; i < num; i++)
					{
						float num2 = x - EDEONNLKCDF;
						float num3 = x + EDEONNLKCDF;
						ELNHKDNIEKC eLNHKDNIEKC = DNGDLGNJHPA[i];
						float num4 = 0f - eLNHKDNIEKC.NANPFCCINPF;
						if (num4 > num2 && num4 < num3)
						{
							if (!eLNHKDNIEKC.LCNFELDFBAG)
							{
								eLNHKDNIEKC.LCNFELDFBAG = true;
								eLNHKDNIEKC.PBMCMFKDAGE = KBCMLCLFMLN();
								if (eLNHKDNIEKC.PBMCMFKDAGE != null)
								{
									eLNHKDNIEKC.PBMCMFKDAGE.transform.localPosition = new Vector3(eLNHKDNIEKC.NANPFCCINPF, -0.238f, 0f);
									eLNHKDNIEKC.PBMCMFKDAGE.Init(eLNHKDNIEKC.NPLDNNNCBPA, eLNHKDNIEKC.BHIJCAOHDCM);
								}
							}
						}
						else if (eLNHKDNIEKC.LCNFELDFBAG)
						{
							eLNHKDNIEKC.LCNFELDFBAG = false;
							eLNHKDNIEKC.PBMCMFKDAGE.gameObject.SetActive(false);
						}
					}
				}
			}
			if (APIHIJECANO && Time.realtimeSinceStartup - FILIJBIDLFM > 2f)
			{
				LoadingText.enabled = true;
				LoadingText.FCJBBPHFNPJ = NKILHODNBDE.GHBGCADFLFB("LoadingFriends");
				APIHIJECANO = false;
			}
		}

		private void CDKNKFBHDAE(KNAKIANHFJN[] LAKOAECNNCO)
		{
			if (BIELEFAPPBF)
			{
				return;
			}
			if (LAKOAECNNCO == null || LAKOAECNNCO.Length == 0)
			{
				BKHNDHCGFPO(null);
				return;
			}
			List<FriendScore> list = AGLOLLABINO.GABGKBAKHDP.FEACIPKPDDF(EADEMDIHGHE);
			if (list == null)
			{
				IFGILMEDMPL(LAKOAECNNCO);
			}
			else
			{
				BKHNDHCGFPO(list);
			}
		}

		private void IFGILMEDMPL(KNAKIANHFJN[] LAKOAECNNCO)
		{
			ScrollController.gameObject.SetActive(false);
			KNNEHLJJIJN item = new KNNEHLJJIJN(EADEMDIHGHE, LAKOAECNNCO, ELMMBDDOEMP);
			KIHMBFDKLJM.GABGKBAKHDP.IINKCBOCHBG(new List<IKDMCJPBBIH> { item });
		}

		public void OnDestroy()
		{
			BIELEFAPPBF = true;
		}

		private void ELMMBDDOEMP(bool EEKJMDHEJCK)
		{
			if (BIELEFAPPBF)
			{
				return;
			}
			try
			{
				ScrollController.gameObject.SetActive(true);
				List<FriendScore> eMAHLNKGLMC = AGLOLLABINO.GABGKBAKHDP.FEACIPKPDDF(EADEMDIHGHE);
				BKHNDHCGFPO(eMAHLNKGLMC);
			}
			catch (Exception ex)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.HighScoresPanel, "ON SCORES RECEIVED EXCEPTION {0} \n{1}", ex.Message, ex.StackTrace);
			}
		}

		private HighscoreFriendDisplay KBCMLCLFMLN()
		{
			if (KOANMLPAEKI == null)
			{
				return null;
			}
			for (int i = 0; i < KOANMLPAEKI.Count; i++)
			{
				if (!KOANMLPAEKI[i].gameObject.activeInHierarchy)
				{
					KOANMLPAEKI[i].gameObject.SetActive(true);
					return KOANMLPAEKI[i];
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(FriendDisplayReference, Vector3.zero, Quaternion.identity);
			if (gameObject == null)
			{
				return null;
			}
			gameObject.transform.SetParent(ScrollController.Content.transform);
			gameObject.transform.localScale = Vector3.one * 1.36f;
			HighscoreFriendDisplay component = gameObject.GetComponent<HighscoreFriendDisplay>();
			if (component != null)
			{
				KOANMLPAEKI.Add(component);
			}
			return component;
		}

		private void BKHNDHCGFPO(List<FriendScore> EMAHLNKGLMC)
		{
			APIHIJECANO = false;
			LoadingText.enabled = false;
			List<FriendScore> list = new List<FriendScore>();
			if (EMAHLNKGLMC != null)
			{
				list.AddRange(EMAHLNKGLMC);
			}
			NIGFCEFLHML nIGFCEFLHML = MADFPPJCOIM.GABGKBAKHDP.ACDBBJACJOE(EADEMDIHGHE);
			int dJADMBLKBKJ = nIGFCEFLHML.DJADMBLKBKJ;
			int num = list.Count;
			if (num == 0 && dJADMBLKBKJ == 0)
			{
				ScrollController.DAMJJFCIHBA();
				return;
			}
			if (dJADMBLKBKJ > 0)
			{
				FriendScore friendScore = new FriendScore();
				friendScore.facebookId = LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA;
				friendScore.score = dJADMBLKBKJ;
				FriendScore item = friendScore;
				list.Add(item);
				num++;
			}
			list.Sort((FriendScore MNIMEAMHNMI, FriendScore BCIHLCMFAEK) => (MNIMEAMHNMI.score <= BCIHLCMFAEK.score) ? 1 : (-1));
			float num2 = 0f;
			float num3 = 0f;
			DNGDLGNJHPA = new ELNHKDNIEKC[num];
			for (int i = 0; i < num; i++)
			{
				GBFAPADEBEC.PFGLLCEKCGI(PBIIDJOKNEK.HighScoresPanel, "FbId:{0} Score:{1}", list[i].facebookId, list[i].score);
				num3 = (float)i * 1.85f;
				FriendScore friendScore2 = list[i];
				if (friendScore2.facebookId == LECPGNKOABP.GABGKBAKHDP.EHNKLBBAKCA)
				{
					num2 = num3;
				}
				ELNHKDNIEKC eLNHKDNIEKC = new ELNHKDNIEKC(null, friendScore2, i + 1, num3);
				if (num < 6)
				{
					eLNHKDNIEKC.LCNFELDFBAG = true;
					eLNHKDNIEKC.PBMCMFKDAGE = KBCMLCLFMLN();
					if (eLNHKDNIEKC.PBMCMFKDAGE != null)
					{
						eLNHKDNIEKC.PBMCMFKDAGE.transform.localPosition = new Vector3(num3, -0.238f, 0f);
						eLNHKDNIEKC.PBMCMFKDAGE.Init(friendScore2, i + 1);
					}
				}
				DNGDLGNJHPA[i] = eLNHKDNIEKC;
			}
			if (num < 6)
			{
				Vector3 localPosition = ScrollController.Content.localPosition;
				localPosition.x = (float)(-(num - 1)) * 1.85f * 0.5f;
				ScrollController.Content.localPosition = localPosition;
				ScrollController.DAMJJFCIHBA();
			}
			else
			{
				float x = base.gameObject.transform.localScale.x;
				ScrollController.SetContentSize((num3 + 1.85f) * x);
				ScrollController.SetPos(0f - num2);
				ScrollController.JBOFOOHGDGC();
			}
			EPJMHPHNHCL = true;
			if (AFNNGCHAEIP && base.transform.position.y < BMGKCLNINID)
			{
				ABOFKOHLOGC();
			}
		}

		internal void CPPHECFAEAD()
		{
			base.transform.DOMoveY(MAECNCPPIJB, 0.3f);
		}

		internal void ABOFKOHLOGC()
		{
			AFNNGCHAEIP = true;
			if (EPJMHPHNHCL)
			{
				base.transform.DOMoveY(BMGKCLNINID, 0.3f);
			}
		}

		public void ConnectButtonClicked()
		{
			KAKOONJCENE lINOJBKHEOP = KAKOONJCENE.LoginInOk;
			string mJIOMBCHMNO = "levelcompleted_leaderboard";
			switch (HCEHJCHHNFE)
			{
			case -1:
				lINOJBKHEOP = KAKOONJCENE.NoSceneLoad;
				break;
			case 0:
				mJIOMBCHMNO = "prelevel_leaderboard";
				lINOJBKHEOP = KAKOONJCENE.LoginInOk;
				break;
			case 1:
				lINOJBKHEOP = KAKOONJCENE.NoSceneLoad;
				break;
			}
			CurrentDialog.PlayDialogOutAnimation();
			IIMOEAOONKA.GABGKBAKHDP.KCLJAABIMED(mJIOMBCHMNO, lINOJBKHEOP, DFKHDHEEOMK);
		}

		private void DFKHDHEEOMK(bool EEKJMDHEJCK)
		{
			if (CurrentDialog != null)
			{
				CurrentDialog.HideSelf();
			}
		}

		[CompilerGenerated]
		private static int PGLJOGLBNEM(FriendScore MNIMEAMHNMI, FriendScore BCIHLCMFAEK)
		{
			return (MNIMEAMHNMI.score <= BCIHLCMFAEK.score) ? 1 : (-1);
		}
	}
}
